using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Transmisor
{
    internal class Ventana
    {
        public Ventana(int tamanioPaquete, int timeoutPaquete, int cantidadRanuras, string ip, int puerto)
        {
            this.tamanioPaquete = tamanioPaquete;
            this.timeoutPaquete = timeoutPaquete;

            numeroPaquete = 1;

            indiceDatos = 0;

            indiceRanura = 0;
            ranurasUsadas = 0;

            envioCompleto = false;

            ranuras = new Ranura[cantidadRanuras];

            //udpClient.ReceiveTimeout = timeoutPaquete;
            udpClient = new UdpClient(ip, puerto);
            udpClient.Client.ReceiveTimeout = timeoutPaquete;
        }

        private UdpClient udpClient = null; // new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        private int tamanioPaquete;
        private int timeoutPaquete;
        private int numeroPaquete;

        private int indiceDatos;

        private int indiceRanura;
        private int ranurasUsadas;

        private Ranura[] ranuras { get; set; }

        private byte[] datos { get; set; } = null;

        public void GenerarDatos(int cantidadDatos)
        {
            datos = new byte[cantidadDatos];

            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = (byte)65;
            }
        }

        public void EnviarDatos()
        {
            Console.WriteLine("Primeros paquetes");

            while (indiceDatos < datos.Length)
            {
                /*
                if (indiceRanura == ranuras.Length)
                {
                    //revisar que ranuras dio timeout

                    for (int indiceRanuraUsada = 0; indiceRanuraUsada < ranuras.Length; indiceRanuraUsada++)
                    {
                        Ranura ranuraUsada = ranuras[indiceRanuraUsada];

                        if (ranuraUsada.Timeout && ranuraUsada.Intentos <= 10)
                        {
                            Console.WriteLine("Ranura #: {0} - Paquete #: {1} -> reenvio de datos", indiceRanura, ranuraUsada.Paquete.NumeroPaquete);

                            ranuraUsada.EnviarDatos();

                            indiceDatos = ranuraUsada.Paquete.IndiceDatos + ranuraUsada.Paquete.Datos.Length;
                            indiceRanura = indiceRanuraUsada + 1;
                        }
                        else if (ranuraUsada.Intentos > 10)
                        {
                            throw new Exception("Cantidad máxima de intentos alcanzada");
                        }
                    }

                    if (indiceRanura < ranuras.Length)
                    {
                        for (int indiceRanuraUsada = indiceRanura; indiceRanuraUsada < ranuras.Length; indiceRanuraUsada++)
                        {
                            ranuras[indiceRanura] = null;
                        }
                    }
                    else
                        indiceRanura = 0;
                }
                */

                if (ranuras[indiceRanura] == null)
                {
                    //primeros paquetes

                    Paquete paquete = new Paquete(tamanioPaquete);
                    paquete.NumeroPaquete = numeroPaquete;
                    paquete.IndiceDatos = indiceDatos;

                    Array.Copy(datos, indiceDatos, paquete.Datos, 0, tamanioPaquete);

                    ranurasUsadas++;

                    Ranura ranura = new Ranura(udpClient, timeoutPaquete);
                    ranura.Paquete = paquete;
                    ranuras[indiceRanura] = ranura;

                    Console.WriteLine("Ranura #: {0}", indiceRanura);

                    ranura.EnviarDatos();

                    indiceDatos = indiceDatos + tamanioPaquete;
                    numeroPaquete++;
                    indiceRanura++;
                }
                else
                {
                    //que pasó con los paquetes anteriores?

                    //me fijo si alguna de los últimas ranura tiene ACK

                    #region Estado de paquetes anteriores (retrocedemos hasta encontrar algún ACK)

                    bool ackRecibido = false;
                    int indiceUltimaRanuraAck = 0;

                    for (int indiceRanuraUsada = ranurasUsadas - 1; indiceRanuraUsada >= 0; indiceRanuraUsada--)
                    {
                        Ranura ranuraUsada = ranuras[indiceRanuraUsada];

                        if (!ranuraUsada.Timeout && ranuraUsada.AckRecibido)
                        {
                            ackRecibido = true;
                            indiceUltimaRanuraAck = indiceRanuraUsada;

                            indiceDatos = ranuraUsada.Paquete.IndiceDatos + ranuraUsada.Paquete.Datos.Length;
                            indiceRanura = indiceRanuraUsada + 1;

                            break;
                        }
                    }

                    if (ackRecibido)
                    {
                        for (int indiceRanuraUsada = 0; indiceRanuraUsada <= indiceUltimaRanuraAck; indiceRanuraUsada++)
                            ranuras[indiceRanuraUsada] = null;

                        if (indiceRanura >= ranurasUsadas)
                            indiceRanura = 0;
                    }

                    #endregion

                    for (int indiceRanuraUsada = 0; indiceRanuraUsada < ranurasUsadas; indiceRanuraUsada++)
                    {
                        Ranura ranuraUsada = ranuras[indiceRanuraUsada];

                        if (ranuraUsada != null)
                        {
                            if (ranuraUsada.Timeout && ranuraUsada.Intentos <= 10)
                            {
                                Console.WriteLine("Ranura #: {0} - Paquete #: {1} -> reenvio de datos", indiceRanura, ranuraUsada.Paquete.NumeroPaquete);

                                ranuraUsada.EnviarDatos();
                            }
                            else if (ranuraUsada.Intentos > 10)
                            {
                                throw new Exception("Cantidad máxima de intentos alcanzada");
                            }
                        }
                        else
                        {
                            //avanzamos

                            int bytesRestantes = tamanioPaquete;

                            if (indiceDatos + tamanioPaquete > datos.Length)
                                bytesRestantes = datos.Length - indiceDatos;

                            Paquete paquete = new Paquete(bytesRestantes);
                            paquete.NumeroPaquete = numeroPaquete;
                            paquete.IndiceDatos = indiceDatos;

                            Array.Copy(datos, indiceDatos, paquete.Datos, 0, bytesRestantes);

                            Ranura ranura = new Ranura(udpClient, timeoutPaquete);
                            ranura.Paquete = paquete;
                            ranuras[indiceRanura] = ranura;

                            Console.WriteLine("Ranura #: {0}", indiceRanura);

                            ranura.EnviarDatos();

                            indiceDatos = indiceDatos + tamanioPaquete;
                            numeroPaquete++;
                            indiceRanura++;

                        }
                    }


                }

                if (indiceRanura >= ranurasUsadas)
                    indiceRanura = 0;

            }

            //interesa ver el último paquete!

            Console.WriteLine("Revisión de último paquete");

            while (!envioCompleto)
            {
                Ranura ranuraUsada = ranuras[ranurasUsadas - 1];

                if (!ranuraUsada.AckRecibido)
                {
                    if (ranuraUsada.Timeout && ranuraUsada.Intentos <= 10)
                    {
                        Console.WriteLine("Ranura #: {0} - Paquete #: {1} -> reenvio de datos", ranurasUsadas - 1, ranuraUsada.Paquete.NumeroPaquete);

                        ranuraUsada.EnviarDatos();
                    }
                    else if (ranuraUsada.Intentos > 10)
                    {
                        throw new Exception("Cantidad máxima de intentos alcanzada");
                    }
                }
                else
                    envioCompleto = true;
            }


        }

        private bool envioCompleto = false;

        public bool EnvioCompleto { get { return envioCompleto; } }
    }
}
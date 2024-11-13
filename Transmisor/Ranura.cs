using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Transmisor
{
    internal class Ranura
    {
        private UdpClient udpClient;

        private int intentos;
        private int timeoutPaquete;

        public int Intentos { get { return intentos; } }

        public Ranura(UdpClient udpClient, int timeoutPaquete)
        {
            this.udpClient = udpClient;
            this.timeoutPaquete = timeoutPaquete;

            intentos = 0;
        }

        public Paquete Paquete { get; set; }

        private DateTime inicioTransmision;

        private bool timeout = false;

        public bool Timeout { get { return timeout; } }

        private bool ackRecibido = false;

        public bool AckRecibido { get { return ackRecibido; } }

        public void EnviarDatos()
        {
            intentos++;
            timeout = false;
            inicioTransmision = DateTime.Now;

            Console.WriteLine("\tPaquete #: {0} - Indice datos: {1} - Tamaño paquete: {2} ", Paquete.NumeroPaquete, Paquete.IndiceDatos, Paquete.Datos.Length);

            //Thread.Sleep(1000);

            byte[] datos = new byte[4 + Paquete.Datos.Length];

            datos[0] = (byte)(Paquete.NumeroPaquete >> 24);
            datos[1] = (byte)(Paquete.NumeroPaquete >> 16);
            datos[2] = (byte)(Paquete.NumeroPaquete >> 8);
            datos[3] = (byte)(Paquete.NumeroPaquete);

            Array.Copy(Paquete.Datos, 0, datos, 4, Paquete.Datos.Length);

            //ENVIAR DATOS!

            udpClient.Send(datos, datos.Length);

            IPEndPoint ep = null;

            try
            {
                datos = udpClient.Receive(ref ep);

                if (datos.Length != 0)
                {
                    ackRecibido = true;
                }
                else
                    timeout = true;
            }
            catch (Exception ex)
            {
                timeout = true;
            }
        }
    }
}
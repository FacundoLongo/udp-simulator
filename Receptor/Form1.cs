using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receptor
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient = null;

        private Thread threadRecibir = null;
        private bool ejecutando = false;

        private delegate void DataReceivedDelegate(int numeroPaquete, int tamanioPaquete);
        private delegate void BytesReceivedDelegate(int totalBytesRecibidos, int totalBytesDatos);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarCantidades();
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;

            udpClient = new UdpClient((int)nudPuerto.Value);
            //udpClient.Client.Blocking = false;

            groupBox1.Enabled = false;
            btnRecibir.Enabled = false;

            ejecutando = true;

            threadRecibir = new Thread(Recibir);
            threadRecibir.Start();
        }

        private int totalCantidadPaquetes = 0;
        private int totalBytesRecibidos = 0;
        private int totalBytesDatos = 0;

        private void Recibir()
        {
            IPEndPoint ep = null;

            try
            {
                while (ejecutando)
                {
                    //if (udpClient.Available != 0)
                    //{
                    byte[] receivedData = udpClient.Receive(ref ep);

                    if (receivedData != null)
                    {
                        if (receivedData.Length > 4)
                        {
                            totalCantidadPaquetes++;
                            totalBytesRecibidos += receivedData.Length;
                            totalBytesDatos += receivedData.Length - 4;

                            int numeroPaquete = (int)receivedData[0] << 24;
                            numeroPaquete += (int)receivedData[1] << 16;
                            numeroPaquete += (int)receivedData[2] << 8;
                            numeroPaquete += (int)receivedData[3];

                            textBox1.Invoke(new DataReceivedDelegate(DataReceived), numeroPaquete, receivedData.Length - 4);
                            //lbTotalBytesRecibidos.Invoke(new BytesReceivedDelegate(BytesReceived), totalBytesRecibidos, totalBytesDatos);

                            byte[] sendData = new byte[1];
                            sendData[0] = (byte)1;

                            udpClient.Send(sendData, sendData.Length, ep);
                        }
                    }
                    //}
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DataReceived(int numeroPaquete, int tamanioPaquete)
        {
            textBox1.Text += String.Format("Paquete #: {0} - Tamaño paquete: {1} bytes\r\n", numeroPaquete, tamanioPaquete);

            ActualizarCantidades();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ejecutando = false;

            udpClient.Close();

            udpClient.Dispose();

            groupBox1.Enabled = true;
            btnRecibir.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            totalCantidadPaquetes = 0;
            totalBytesRecibidos = 0;
            totalBytesDatos = 0;

            textBox1.Text = String.Empty;

            ActualizarCantidades();
        }

        private void ActualizarCantidades()
        {
            lbCantidadPaquetes.Text = String.Format("{0}", totalCantidadPaquetes);
            lbTotalBytesRecibidos.Text = String.Format("{0} Bytes", totalBytesRecibidos);
            lbTotalBytesDatos.Text = String.Format("{0} Bytes", totalBytesDatos);

            lbTotalBytesHeaders.Text = String.Format("{0} Bytes", totalBytesRecibidos - totalBytesDatos);
        }
    }
}
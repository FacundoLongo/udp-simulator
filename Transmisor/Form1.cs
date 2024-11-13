using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transmisor
{
    public partial class Form1 : Form
    {
        private Ventana Ventana = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nudTamanioDatos.Value = 20;
            //nudTamanioPaquete.Value = 10;
            //nudCantidadRanuras.Value = 1;

            CalcularPaquetes();
        }

        private void nudTamanioDatos_ValueChanged(object sender, EventArgs e)
        {
            CalcularPaquetes();
        }

        private void nudTamanioPaquete_ValueChanged(object sender, EventArgs e)
        {
            CalcularPaquetes();
        }

        private void CalcularPaquetes()
        {

            int tamanioDatos = (int)nudTamanioDatos.Value;
            int tamanioPaquete = (int)nudTamanioPaquete.Value;
            int cantidadPaquetes = tamanioDatos / tamanioPaquete;

            if (cantidadPaquetes < (float)tamanioDatos / (float)tamanioPaquete)
                cantidadPaquetes++;

            lbCantidadPaquetes.Text = cantidadPaquetes.ToString();
            lbTamanioExtraHeaders.Text = String.Format("{0} Bytes", (cantidadPaquetes * 4).ToString());

        }

        private void btnTransmitir_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;

            string ip = string.Format("{0:N0}.{1:N0}.{2:N0}.{3:N0}", nudIP1.Value, nudIP2.Value, nudIP3.Value, nudIP4.Value);

            Ventana = new Ventana((int)nudTamanioPaquete.Value, (int)nudTimeoutPaquete.Value, (int)nudCantidadRanuras.Value, ip, (int)nudPuerto.Value);

            Ventana.GenerarDatos((int)nudTamanioDatos.Value);

            Ventana.EnviarDatos();

            while (!Ventana.EnvioCompleto)
            {
                Thread.Sleep(500);
            }

            groupBox1.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
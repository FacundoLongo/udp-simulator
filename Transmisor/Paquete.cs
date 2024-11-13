using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transmisor
{
    internal class Paquete
    {
        public Paquete(int tamanioPaquete)
        {
            Datos = new byte[tamanioPaquete];
        }

        public int NumeroPaquete { get; set; }

        public byte[] Datos { get; set; }

        public int IndiceDatos { get; set; } = 0;
    }
}
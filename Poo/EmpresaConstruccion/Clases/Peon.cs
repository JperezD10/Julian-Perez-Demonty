using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Peon : PuestoTrabajo
    {
        private int horaTrabajada = 0;
        private float extraPorHora = 450f;
        public Peon()
        {
            NombrePuesto = "Peon";
            SueldoFijo = 12000;
        }
        public override float obtenerSueldo()
        {
            float total = SueldoFijo;
            total += (horaTrabajada * extraPorHora);
            return total;
        }
    }
}

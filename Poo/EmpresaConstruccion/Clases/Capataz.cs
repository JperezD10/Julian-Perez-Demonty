using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public class Capataz : PuestoTrabajo
    {
        private float extraPorPeon = 3500f;
        private int cantPeones = 0;
        
        public Capataz()
        {
            NombrePuesto = "Capataz";
            SueldoFijo = 12000f;
        }
      

        public float ExtraPorPeon
        {
            get
            {
                return extraPorPeon;
            }

            set
            {
                extraPorPeon = value;
            }
        }

        public int CantPeones
        {
            get
            {
                return cantPeones;
            }

            set
            {
                cantPeones = value;
            }
        }

        public override float obtenerSueldo()
        {
            float total = SueldoFijo;
            total += (cantPeones * extraPorPeon);
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class PuestoTrabajo
    {
        private float sueldoFijo;
        private string nombrePuesto;
        public abstract float obtenerSueldo();
        


        public float SueldoFijo
        {
            get
            {
                return sueldoFijo;
            }

            set
            {
                sueldoFijo = value;
            }
        }

        public string NombrePuesto
        {
            get
            {
                return nombrePuesto;
            }

            set
            {
                nombrePuesto = value;
            }
        }
    }
}

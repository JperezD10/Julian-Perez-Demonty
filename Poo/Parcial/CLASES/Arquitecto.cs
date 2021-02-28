using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
   public class Arquitecto
    {
        private int CantidadDeProyectos;

        public int _CantidadDeProyectos
        {
            get { return CantidadDeProyectos; }
            set { CantidadDeProyectos = value; }
        }

        private float Sueldo;

        public float _Sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }

        public float CalcularSueldo()
        {
            return Sueldo = 12000 + (1000 * CantidadDeProyectos);
        }
    }
}

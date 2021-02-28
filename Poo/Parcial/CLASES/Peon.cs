using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Peon
    {
        private float Sueldo;

        public float _Sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }

        private int HorasTrabajadas;

        public int _HorasTrabajadas
        {
            get { return HorasTrabajadas; }
            set { HorasTrabajadas = value; }
        }

        public float CalcularSueldo()
        {
          return  Sueldo = 12000 + (200 * HorasTrabajadas);
        }
    }
}

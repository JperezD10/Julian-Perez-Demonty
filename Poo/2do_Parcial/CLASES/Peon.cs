using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Peon
    {
        private float _Sueldo;

        public float Sueldo
        {
            get { return _Sueldo; }
            set { _Sueldo = value; }
        }

        private int _HorasTrabajadas;

        public int HorasTrabajadas
        {
            get { return _HorasTrabajadas; }
            set { _HorasTrabajadas = value; }
        }
        public void CalcularSueldo()
        {
            Sueldo = 12000 + (450 * _HorasTrabajadas);
        }
    }

 }


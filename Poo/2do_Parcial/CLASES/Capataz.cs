using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Capataz
    {
        private float _Sueldo;

        public float Sueldo
        {
            get { return _Sueldo; }
            set { _Sueldo = value; }
        }
        private int _PeonesACargo;

        public int PeonesACargo
        {
            get { return _PeonesACargo; }
            set { _PeonesACargo = value; }
        }

        public void CalcularSueldo()
        {
            Sueldo = 12000 + (3500 * _PeonesACargo);
        }

    }
}

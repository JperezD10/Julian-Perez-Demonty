using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Capataz
    {
        private float Sueldo;

        public float _Sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
        private int PeonesACargo;

        public int _PeonesACargo
        {
            get { return PeonesACargo; }
            set { PeonesACargo = value; }
        }
        public float CalcularSueldo()
        {
            return Sueldo = 12000 + (450 * PeonesACargo);
        }
    }
}

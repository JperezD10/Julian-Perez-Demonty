using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Arquitecto
    {

        private float _Sueldo;

        public float Sueldo
        {
            get { return _Sueldo; }
            set { _Sueldo = value; }
        }
        private int _CantidadDeProyectos;

        public int CantidadDeProyectos
        {
            get { return _CantidadDeProyectos; }
            set { _CantidadDeProyectos = value; }
        }

        public void CalcularSueldo()
        {
            if (_CantidadDeProyectos >= 5)
            {
                Sueldo = 15000 + (10000 * _CantidadDeProyectos) + 12000;
            }
            else
            {
                Sueldo = 15000 + (10000 * _CantidadDeProyectos);
            }
        }

    }
}

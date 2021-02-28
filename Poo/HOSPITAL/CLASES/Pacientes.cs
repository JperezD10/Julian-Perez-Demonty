using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Pacientes
    {

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private int _Dni;

        public int Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        public Pacientes(string _Nombre, string _Apellido, int _Dni)
        {
            this._Nombre = _Nombre;
            this._Apellido = _Apellido;
            this._Dni = _Dni;
        }

    }
}

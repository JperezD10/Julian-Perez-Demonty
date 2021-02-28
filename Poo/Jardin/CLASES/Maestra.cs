using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Maestra
    {
        static public int NroLegajo=1;

        private int _Legajo;

        public int Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }


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

        private int _Sueldo;

        public int Sueldo
        {
            get { return _Sueldo; }
            set { _Sueldo = value; }
        }

        private bool _Recibidas;

        public bool Recibidas
        {
            get { return _Recibidas; }
            set { _Recibidas = value; }
        }

        void CalcularSueldo(bool _Recibidas)
        {
            if (_Recibidas == true)
            {
              _Sueldo = 30000;
            }
            else
            {
              _Sueldo = 15000;
            }
        }

        public Maestra(string _Nombre, string _Apellido,bool _Recibidas)
        {
            _Sueldo = 3000;
            NroLegajo++;
            this._Nombre = _Nombre;
            this._Apellido = _Apellido;
            this._Recibidas = _Recibidas;
            CalcularSueldo(_Recibidas);
        }


        
    }
}

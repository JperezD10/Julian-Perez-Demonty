using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Asignaciones
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

        private string _NombreEspecialdidad;

        public string NombreEspecialdidad
        {
            get { return _NombreEspecialdidad; }
            set { _NombreEspecialdidad = value; }
        }

        private double _Costo;

        public double Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }


        public Asignaciones(string _Nombre,string _Apellido,string _NombreEspecialdidad,double _Costo)
        {
            this._Nombre = _Nombre;
            this._Apellido = _Apellido;
            this._NombreEspecialdidad = _NombreEspecialdidad;
            this._Costo = _Costo;
        }

    }
}

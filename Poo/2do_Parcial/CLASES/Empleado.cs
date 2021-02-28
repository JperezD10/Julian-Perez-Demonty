using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
   public class Empleado:IComparable<Empleado>
    {
        public static int IDEmpleados=1;

        private int _IDEmpleado;

        public int IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
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
            get { return _Apellido;; }
            set { _Apellido = value; }
        }

        private int _Edad;

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

        private string _PuestoDeTrabajo;

        public string PuestoDeTrabajo
        {
            get { return _PuestoDeTrabajo; }
            set { _PuestoDeTrabajo = value; }
        }

        private float _Sueldo;

        public float Sueldo
        {
            get { return _Sueldo; }
            set { _Sueldo = value; }
        }


        public Empleado(string _Nombre,string _Apellido, int _Edad,string _PuestoDeTrabajo,float _Sueldo)
        {
            this._Nombre = _Nombre;
            this._Apellido = _Apellido;
            this._Edad = _Edad;
            this._PuestoDeTrabajo = _PuestoDeTrabajo;
            this._IDEmpleado = IDEmpleados;
            this._Sueldo = _Sueldo;
            IDEmpleados++;

        }

        public int CompareTo(Empleado Empleado)
        {
            return this.Apellido.CompareTo(Empleado.Apellido);
        }
    }
}

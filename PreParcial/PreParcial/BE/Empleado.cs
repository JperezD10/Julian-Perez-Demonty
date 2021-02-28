using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Empleado
    {
        private String CodigoEmpleado;

        public String _CodigoEmpleado
        {
            get { return CodigoEmpleado; }
            set { CodigoEmpleado = value; }
        }

        private String Nombre;

        public String _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private String Apellido;

        public String _Apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        private int Edad;

        public int _Edad
        {
            get { return Edad; }
            set { Edad = value; }
        }
        private String Sexo;

        public String _Sexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        private String Direccion;

        public String _Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        private String Puesto;

        public String _Puesto
        {
            get { return Puesto; }
            set { Puesto = value; }
        }

    }
}

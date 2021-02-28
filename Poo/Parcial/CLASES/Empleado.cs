using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Empleado:IComparable<Empleado>
    {
        private string Nombre;

        public string _Nombre
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
        private string Puesto;

        public string _Puesto
        {
            get { return Puesto; }
            set { Puesto = value; }
        }
        private float Sueldo;

        public float _Sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }

        public Empleado(string Nombre,string Apellido, int Edad,string Puesto, float Sueldo)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Puesto = Puesto;
            this.Sueldo = Sueldo;
        }

        public int CompareTo(Empleado Empleado)
        {
            return this.Apellido.CompareTo(Empleado.Apellido);
        }
    }
}

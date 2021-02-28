using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    public class PERSONAS
    {

        private string Nombre;

        public string NOMBRE
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Apellido;

        public string APELLIDO
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        private int Edad;

        public int EDAD
        {
            get { return Edad; }
            set { Edad = value; }
        }

        private int Dni;

        public int DNI
        {
            get { return Dni; }
            set { Dni = value; }
        }

        private int Nacimiento;

        public int NACIMIENTO
        {
            get { return Nacimiento; }
            set { Nacimiento = value; }
        }


        public PERSONAS(string Nombre,string Apellido,int Dni,int Edad,int Nacimiento)
        {

            this.Nombre = Nombre;

            this.Apellido = Apellido;

            this.Dni = Dni;

            this.Edad = Edad;

            this.Nacimiento = Nacimiento;

        }

    }
}

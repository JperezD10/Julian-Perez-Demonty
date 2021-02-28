using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    public class pasaporte
    {
       
        public pasaporte(string nombre, string apellido, int edad,  int valorfinal)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            valorFinal = valorfinal;
        }
        private string nombre;

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string APELLIDO
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private int edad;

        public int EDAD
        {
            get { return edad; }
            set { edad = value; }
        }
        private int valorbase;

        public int VALORBASE
        {
            get { return valorbase; }
            set { valorbase = value; }
        }

        private int valorFinal;

        public int VALORFINAL
        {
            get { return valorFinal; }
            set { valorFinal = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empleado : IComparable<Empleado>
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int edad;
        private PuestoTrabajo puesto;

        public delegate void obtener(PuestoTrabajo puestoTrabaj);
        public obtener obtenerPuesto;

        public Empleado(int legajo,string nombre, string apellido,int edad,PuestoTrabajo puesto)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.puesto = puesto;
        }
        public void consultarPuesto()
        {
            if(obtenerPuesto != null)
            {
                this.obtenerPuesto(puesto);
            }
           
        }
     

       


        public int Legajo
        {
            get
            {
                return legajo;
            }

            set
            {
                legajo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public PuestoTrabajo Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public int CompareTo(Empleado other)
        {
            if(this.apellido.CompareTo(other.apellido) == 0)
            {
                return this.nombre.CompareTo(other.nombre);
            }

            return this.apellido.CompareTo(other.apellido);


        }

        public override string ToString()
        {
            return legajo + "-" + apellido + ", " + nombre + " (" + edad + " años)";
        }
    }
}

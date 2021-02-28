using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_con_herencia
{
    public abstract class Empleado:IComparable<Empleado>
    {
        public static int IDEmpleado = 1;
        private int ID;

        public int _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        private string Nombre;

        public string _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Apellido;

        public string _Apellido
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
       

        public Empleado(string Nombre,string Apellido,int Edad, string Puesto)
        {
            this.ID = IDEmpleado;
            IDEmpleado++;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Puesto = Puesto;
            
        }
        public virtual float CalcularSueldo(int Variable)
        {
           if (Puesto == "Peon")
            {
                return Sueldo = 12000 + (450 * Variable);
            }
           else if (Puesto == "Capataz")
            {
                return Sueldo = 12000 + (1000 * Variable);
            }
            else
            {
                if (Variable > 5)
                {
                    return Sueldo=15000 + ((Variable * 1500) + 10000);
                }
                else
                {
                    return Sueldo = 12000 + ((Variable * 1500));
                }
            }
        }

        public int CompareTo(Empleado E)
        {
            return this.Nombre.CompareTo(E.Nombre);
        }
    }
}

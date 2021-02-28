using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_con_herencia
{
    public class Capataz : Empleado
    {
        public int Cargo;
        public Capataz(string Nombre, string Apellido, int Edad, string Puesto, int Cargo) : base(Nombre, Apellido, Edad, Puesto)
        {
            base._Nombre = Nombre;
            base._Apellido = Apellido;
            base._Edad = Edad;
            base._Puesto = Puesto;
            this.Cargo = Cargo;
            
        }
        
    }
}

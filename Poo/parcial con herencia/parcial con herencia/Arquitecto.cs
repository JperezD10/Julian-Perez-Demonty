using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_con_herencia
{
    public class Arquitecto : Empleado
    {
        public int proyectos;
        public Arquitecto(string Nombre, string Apellido, int Edad, string Puesto, int Proyectos) : base(Nombre, Apellido, Edad, Puesto)
        {
            base._Nombre = Nombre;
            base._Apellido = Apellido;
            base._Edad = Edad;
            base._Puesto = Puesto;
            this.proyectos = Proyectos;
        }
    }
}

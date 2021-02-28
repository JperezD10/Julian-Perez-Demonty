using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Empleado
    {
        private int id_Empleado;
        private int dni;
        private String nombre;
        private String apellido;
        private int id_Ciudad;
        private int id_CategoriaEmpleado;
        private String direccion;
        private DateTime fechaNacimiento;
        private DateTime fechaContratacion;

        public int Id_Empleado { get => id_Empleado; set => id_Empleado = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id_Ciudad { get => id_Ciudad; set => id_Ciudad = value; }
        public int Id_CategoriaEmpleado { get => id_CategoriaEmpleado; set => id_CategoriaEmpleado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaContratacion { get => fechaContratacion; set => fechaContratacion = value; }
    }
}

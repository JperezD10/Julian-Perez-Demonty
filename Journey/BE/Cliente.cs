using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        private int id_Cliente;
        private int dni;
        private String nombre;
        private String apellido;
        private DateTime fechaNacimiento;
        private int id_Ciudad;
        private String direccion;
        private int telefono;
        private String email;
        private int id_logCliente;
        private String user;
        private string password;

        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Id_Ciudad { get => id_Ciudad; set => id_Ciudad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public int id_LogCliente { get => id_logCliente; set => id_logCliente = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
    }
}

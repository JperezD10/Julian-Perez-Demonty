using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuarios
    {
        private string NombreUsuario;

        public string _NombreUsuario
        {
            get { return NombreUsuario; }
            set { NombreUsuario = value; }
        }
        private string Contraseña;

        public string _Constraseña
        {
            get { return Contraseña; }
            set { Contraseña = value; }
        }

        private int IDReferente;

        public int _IdReferente
        {
            get { return IDReferente; }
            set { IDReferente = value; }
        }


    }
}

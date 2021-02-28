using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario_BLL
    {
        DAL.Usuario mapper = new DAL.Usuario();

        //public bool validar(BE.Usuarios us)
        //{
        //    return mapper.Ingresar(us);
        //}
        public string Registrar(BE.Usuarios us)
        {
            return mapper.Registrar(us);
        }
        public bool iniciarSesion(BE.Usuarios us)
        {
            return mapper.IniciarSesion(us);
        }
        public int IDreferente(BE.Usuarios us)
        {
            return mapper.IDUsuarioReferente(us);
        }
    }
}

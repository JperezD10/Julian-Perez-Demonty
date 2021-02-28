using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class Usuario
    {
        DAL.Acceso acceso = new Acceso();

        public bool IniciarSesion(BE.Usuarios us)
        {
            bool respuesta= false;
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@nombreusuario", us._NombreUsuario);
            parametros[1] = new SqlParameter("@contraseña", us._Constraseña);
            DataTable tabla = acceso.Leer("iniciarSesion",parametros);
                foreach (DataRow registro in tabla.Rows)
                {
                    respuesta = true;
                }
            return respuesta;
        }

        public int IDUsuarioReferente(BE.Usuarios us)
        {
            int id = 0;
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@nombreusuario",us._NombreUsuario);
            DataTable tabla = acceso.Leer("ObtenerIDUsuario", parametros);
            foreach(DataRow Registro in tabla.Rows)
            {
                id = int.Parse(Registro["IDReferente"].ToString());
            }
            return id;
        }
      public string Registrar(BE.Usuarios us)
        { 
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@nombreUsuario", us._NombreUsuario);
            parametros[1] = new SqlParameter("@Contraseña", us._Constraseña);
            parametros[2] = new SqlParameter("@IDReferente", us._IdReferente);
            return acceso.Escribir("RegistrarUsuario", parametros);
        }
    }
}

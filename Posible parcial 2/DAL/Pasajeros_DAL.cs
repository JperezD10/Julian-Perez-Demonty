using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Pasajeros_DAL
    {
        Acceso acceso = new Acceso();
        public string Agregar(BE.Pasajeros pas)
        {

            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@ID", pas._IDPasajero);
            parametro[1] = new SqlParameter("@nombre", pas._Nombre);
            parametro[2] = new SqlParameter("@apellido", pas._Apellido);
            parametro[3] = new SqlParameter("@direccion", pas._Direccion );

            return acceso.Escribir("IngresarPasajero", parametro);
        }

        public string Eliminar(BE.Pasajeros pas)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@ID", pas._IDPasajero);
            return acceso.Escribir("EliminarPasajero", parametros);
        }

        public string Editar(BE.Pasajeros pas)
        {
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@ID", pas._IDPasajero);
            parametro[1] = new SqlParameter("@nombre", pas._Nombre);
            parametro[2] = new SqlParameter("@apellido", pas._Apellido);
            parametro[3] = new SqlParameter("@direccion", pas._Direccion);
            return acceso.Escribir("ModificarPasajero", parametro);
        }
        public List<BE.Pasajeros> Listar()
        {
            List<BE.Pasajeros> ls = new List<BE.Pasajeros>();
            DataTable tabla = acceso.Leer("listarpasajeros", null);

            foreach (DataRow Registro in tabla.Rows)
            {
                BE.Pasajeros pas = new BE.Pasajeros();
                pas._IDPasajero = int.Parse(Registro["IDPasajero"].ToString());
                pas._Nombre = Registro["Nombre"].ToString();
                pas._Apellido = Registro["Apellido"].ToString();
                pas._Direccion = Registro["Direccion"].ToString();

                ls.Add(pas);
            }
            return ls;
        }
    }
}

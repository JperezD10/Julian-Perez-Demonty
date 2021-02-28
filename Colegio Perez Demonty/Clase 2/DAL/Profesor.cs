using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class Profesor
    {
        Acceso acceso = new Acceso();
        public string Agregar(BE.Profesor profe)
        {

            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@id", profe._IDProfesor);
            parametro[1] = new SqlParameter("@Nombre", profe._NombreProfesor);

            return acceso.Escribir("AgregarProfesor", parametro);
        }
        public string Eliminar(BE.Profesor profe)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", profe._IDProfesor);
            return acceso.Escribir("EliminarProfesor", parametros);
        }
        public string Editar(BE.Profesor profe)
        {
            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@id", profe._IDProfesor);
            parametro[1] = new SqlParameter("@Nombre", profe._NombreProfesor);
            return acceso.Escribir("ModificarProfesor", parametro);
        }
        public List<BE.Profesor> Listar()
        {
            List<BE.Profesor> ls = new List<BE.Profesor>();

            DataTable tabla = acceso.Leer("ListarProfesor", null);

            foreach (DataRow Registro in tabla.Rows)
            {
                BE.Profesor profe = new BE.Profesor();
                profe._IDProfesor = int.Parse(Registro["IDProfesor"].ToString());
                profe._NombreProfesor = Registro["NombreProfesor"].ToString();
                ls.Add(profe);
            }
            return ls;
        }
    }
}

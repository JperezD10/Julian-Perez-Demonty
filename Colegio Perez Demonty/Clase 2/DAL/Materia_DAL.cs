using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Materia_DAL
    {
        Acceso acceso = new Acceso();
        public string Agregar(BE.Materia mat)
        {

            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@id", mat._IDMateria);
            parametro[1] = new SqlParameter("@Nombre", mat._NombreMateria);

            return acceso.Escribir("AgregarMateria", parametro);
        }
        public string Eliminar(BE.Materia mat)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", mat._IDMateria);
            return acceso.Escribir("EliminarMateria", parametros);
        }
        public string Editar(BE.Materia mat)
        {
            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@id", mat._IDMateria);
            parametro[1] = new SqlParameter("@Nombre", mat._NombreMateria);
            return acceso.Escribir("ModificarMateria", parametro);
        }
        public List<BE.Materia> Listar()
        {
            List<BE.Materia> ls = new List<BE.Materia>();

            DataTable tabla = acceso.Leer("ListarMateria", null);

            foreach (DataRow Registro in tabla.Rows)
            {
                BE.Materia mat = new BE.Materia();
                mat._IDMateria  = int.Parse(Registro["IDMateria"].ToString());
                mat._NombreMateria = Registro["NombreMateria"].ToString();
                ls.Add(mat);
            }
            return ls;
        }
    }
}

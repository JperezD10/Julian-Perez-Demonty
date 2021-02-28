using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Alumno
    {
        Acceso acceso = new Acceso();
        public string Agregar(BE.ALUMNO alum)
        {
            
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@Leg", alum._Id);
            parametro[1] = new SqlParameter("@Nom", alum._Nombre);
            parametro[2] = new SqlParameter("@Ape", alum._Apellido);
            parametro[3] = new SqlParameter("@edad", alum._Edad);

            return acceso.Escribir("agregarAlumno", parametro);
        }
        public string Eliminar(BE.ALUMNO Alum)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@Leg", Alum._Id);
            return acceso.Escribir("eliminarAlumno", parametros);
        }
        public string Editar(BE.ALUMNO Alum)
        {
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@Leg", Alum._Id);
            parametro[1] = new SqlParameter("@Nom", Alum._Nombre);
            parametro[2] = new SqlParameter("@Ape", Alum._Apellido);
            parametro[3] = new SqlParameter("@edad", Alum._Edad);
            return acceso.Escribir("modificarAlumno", parametro);
        }
        public List<BE.ALUMNO> Listar()
        {
            List<BE.ALUMNO> ls = new List<BE.ALUMNO>();

            DataTable tabla = acceso.Leer("ListarALUMNO", null);

            foreach (DataRow Registro in tabla.Rows)
            {
                BE.ALUMNO Alumno = new BE.ALUMNO();
                Alumno._Id = int.Parse(Registro["IDAlumno"].ToString());
                Alumno._Nombre = Registro["Nombre"].ToString();
                Alumno._Apellido = Registro["Apellido"].ToString();
                Alumno._Edad = int.Parse(Registro["Edad"].ToString());

                ls.Add(Alumno);
            }
            return ls;
        }
        
        public int CalcularPromedioEdad(BE.ALUMNO Alum)
        {
            int fa=0;
            DataTable tabla = acceso.Leer("PromedioEdad", null);
            foreach(DataRow Registro in tabla.Rows)
            {
                fa = int.Parse(Registro["PromEdad"].ToString());
            }
            return fa;
        }
        public int CalcularEdadMaxima(BE.ALUMNO Alum)
        {
            int fa = 0;
            DataTable tabla = acceso.Leer("MaxEdad", null);
            foreach (DataRow Registro in tabla.Rows)
            {
                fa = int.Parse(Registro["MaxEdad"].ToString());
            }
            return fa;
        }
        public int CalcularEdadMinima(BE.ALUMNO Alum)
        {
            int fa = 0;
            DataTable tabla = acceso.Leer("MinEdad", null);
            foreach (DataRow Registro in tabla.Rows)
            {
                fa = int.Parse(Registro["MinEdad"].ToString());
            }
            return fa;
        }
    }
}

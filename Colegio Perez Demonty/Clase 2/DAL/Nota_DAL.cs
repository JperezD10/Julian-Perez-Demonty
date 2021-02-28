using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Nota_DAL
    {
        Acceso acceso = new Acceso();

        public string AgregarNota(BE.Nota nota)
        {
            SqlParameter[] parametro = new SqlParameter[5];
            parametro[0] = new SqlParameter("@idn", nota._IDNota);
            parametro[1] = new SqlParameter("@ida", nota._IDAlumno);
            parametro[2] = new SqlParameter("@idm", nota._IDMateria);
            parametro[3] = new SqlParameter("@idi", nota._Intancia);
            parametro[4] = new SqlParameter("@nota", nota._NotaNumerica);
            return acceso.Escribir("AgregarNotas", parametro);
        }

        public List<BE.Nota> ListarNotas(int idmateria)
        {
            List<BE.Nota> ls = new List<BE.Nota>();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@idmateria", idmateria);
            DataTable tabla = acceso.Leer("VerNotasMateria", parametro);
            foreach(DataRow registro in tabla.Rows)
            {
                BE.Nota notas = new BE.Nota();
                notas._IDNota = int.Parse(registro["IDNota"].ToString());
                notas._IDAlumno= int.Parse(registro["IDAlumno"].ToString());
                notas._IDMateria = int.Parse(registro["IDMateria"].ToString());
                notas._Intancia = int.Parse(registro["IDInstancia"].ToString()); ;
                notas._NotaNumerica= int.Parse(registro["Nota"].ToString());
                ls.Add(notas);
            }
            return ls;
        }
        public string DesaprobadosPrimerParcial()
        {
            DataSet DS = new DataSet();
            SqlConnection CN = new SqlConnection();
            CN.ConnectionString = @"Data Source=MSI;Initial Catalog=FACULTAD;Integrated Security=True";
            CN.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select * from Nota where IDInstancia= 1 and Nota<4", CN);
            DA.Fill(DS, "Desaprobados primer parcial");
            CN.Close();
            DS.WriteXml("D:\\DPP.txt");
            return "";
        }
        public string DesaprobadosSegundoParcial()
        {
            DataSet DS = new DataSet();
            SqlConnection CN = new SqlConnection();
            CN.ConnectionString = @"Data Source=MSI;Initial Catalog=FACULTAD;Integrated Security=True";
            CN.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select * from Nota where IDInstancia= 2 and Nota<4", CN);
            DA.Fill(DS, "Desaprobados Segundo Parcial");
            CN.Close();
            DS.WriteXml("D:\\DSP.txt");
            return "";
        }
        public string DesaprobadosTP()
        {
            DataSet DS = new DataSet();
            SqlConnection CN = new SqlConnection();
            CN.ConnectionString = @"Data Source=MSI;Initial Catalog=FACULTAD;Integrated Security=True";
            CN.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select * from Nota where IDInstancia= 3 and Nota<4", CN);
            DA.Fill(DS, "Desaprobados tp");
            CN.Close();
            DS.WriteXml("D:\\DTP.txt");
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Profesor_Materia_DAL
    {
        Acceso acceso = new Acceso();
        public string Agregar(BE.Profesor_Materia pm)
        {
            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@idp", pm._IDProfesor);
            parametro[1] = new SqlParameter("@idm", pm._IDMateria);

            return acceso.Escribir("CrearProfeMateria", parametro);
        }
    }
}

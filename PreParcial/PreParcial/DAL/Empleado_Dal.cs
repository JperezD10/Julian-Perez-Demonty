using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Empleado_Dal
    {
        Acceso acceso = new Acceso();


        public String Agregar(BE.Empleado Emp)
        {
            SqlParameter[] parametro = new SqlParameter[7];
            parametro[0] = new SqlParameter("@id_empleado",Emp._CodigoEmpleado);
            parametro[1] = new SqlParameter("@nombre", Emp._Nombre);
            parametro[2] = new SqlParameter("@apellido", Emp._Apellido);
            parametro[3] = new SqlParameter("@edad", Emp._Edad);
            parametro[4] = new SqlParameter("@sexo", Emp._Sexo);
            parametro[5] = new SqlParameter("@direccion", Emp._Direccion);
            parametro[6] = new SqlParameter("@puesto", Emp._Puesto);
            return acceso.Escribir("agregarEmpleado",parametro,CommandType.StoredProcedure);
        }
        public String Modificar(BE.Empleado Emp)
        {
            SqlParameter[] parametro = new SqlParameter[6];
            parametro[0] = new SqlParameter("@nombre", Emp._Nombre);
            parametro[1] = new SqlParameter("@apellido", Emp._Apellido);
            parametro[2] = new SqlParameter("@edad", Emp._Edad);
            parametro[3] = new SqlParameter("@sexo", Emp._Sexo);
            parametro[4] = new SqlParameter("@direccion", Emp._Direccion);
            parametro[5] = new SqlParameter("@puesto", Emp._Puesto);
            return acceso.Escribir("modificarEmpleado",parametro, CommandType.StoredProcedure);
        }
        public String Eliminar(BE.Empleado Emp)
        {
            string query = "delete from Alumno where CodigoEmpleado="+Emp._CodigoEmpleado+"";
            return acceso.Escribir(query,null,CommandType.Text);
        }
    }
}

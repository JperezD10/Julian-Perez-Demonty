using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class Empleado_BLL
    {
        DAL.Empleado_Dal mapper = new DAL.Empleado_Dal();

        public String Agregar(BE.Empleado emp)
        {
            return mapper.Agregar(emp);
        }
        public String Eliminar(BE.Empleado emp)
        {
            return mapper.Eliminar(emp);
        }
        public String Modificar(BE.Empleado emp)
        {
            return mapper.Modificar(emp);
        }
    }
}

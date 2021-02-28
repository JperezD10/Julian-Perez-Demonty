using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Sucursal_BLL
    {
        DAL.Sucursal_Dal mapper = new DAL.Sucursal_Dal();
        public string Agregar(BE.Sucursal s)
        {
            return mapper.Agregar(s);
        }
    }
}

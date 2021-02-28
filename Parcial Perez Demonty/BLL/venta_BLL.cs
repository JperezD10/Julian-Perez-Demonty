using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class venta_BLL
    {
        DAL.Venta_DAL mapper = new DAL.Venta_DAL();
        public string Agregar(BE.Venta v)
        {
            return mapper.AgregarVenta(v);
        }

    }
}

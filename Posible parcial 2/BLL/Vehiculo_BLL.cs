using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vehiculo_BLL
    {
        DAL.Vehiculo_DAL mapper = new DAL.Vehiculo_DAL();
        public List<BE.Vehiculos> Listar()
        {
            List<BE.Vehiculos> veh = mapper.Listar();
            return veh;
        }
    }
}

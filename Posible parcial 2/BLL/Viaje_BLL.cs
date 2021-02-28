using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Viaje_BLL
    {
        DAL.Viaje_DAL mapper = new DAL.Viaje_DAL();
        DAL.Acceso XML = new DAL.Acceso();
        public string Agregar(BE.Viaje viaje)
        {
            return mapper.Agregar(viaje);
        }
        public string Generar()
        {
            return XML.GenerarXML();
        }
        public int CantViajes(BE.Viaje v)
        {
            return mapper.ContarViajes(v);
        }
    }
}

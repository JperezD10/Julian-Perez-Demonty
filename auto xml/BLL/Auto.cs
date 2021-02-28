using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Auto
    {
        DAL.AutoDAL mapper = new DAL.AutoDAL();
        DAL.Acceso XML = new DAL.Acceso();
        public string Agregar(BE.Auto auto)
        {
            return mapper.Agregar(auto);
        }   

        public string Generar()
        {
                return XML.GenerarXML();   
        }
    }
}

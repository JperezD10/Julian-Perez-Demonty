using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Seguridad_BLL
    {
        DAL.Seguridat mapper = new DAL.Seguridat();
        public string generarHASH(string contraseña)
        {
            return mapper.generarSHA256(contraseña);
        }
    }
}

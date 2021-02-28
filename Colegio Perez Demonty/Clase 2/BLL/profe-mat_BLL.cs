using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class profe_mat_BLL
    {
        DAL.Profesor_Materia_DAL mapper = new DAL.Profesor_Materia_DAL();

        public string Agregar(BE.Profesor_Materia pm)
        {
            return mapper.Agregar(pm);
        }
    }
}

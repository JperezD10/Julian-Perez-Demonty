using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Profesor_BLL
    {
        DAL.Profesor mapper = new DAL.Profesor();

        public String Agregar(BE.Profesor profe)
        {
            return mapper.Agregar(profe);

        }
        public string Eliminar(BE.Profesor profe)
        {
            return mapper.Eliminar(profe);
        }
        public string Modificar(BE.Profesor profe)
        {
            return mapper.Editar(profe);
        }
        public List<BE.Profesor> Listar()
        {
            List<BE.Profesor> profe = mapper.Listar();
            return profe;
        }
    }
}

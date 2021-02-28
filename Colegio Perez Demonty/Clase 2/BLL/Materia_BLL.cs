using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Materia_BLL
    {
        DAL.Materia_DAL mapper = new DAL.Materia_DAL();
        public String Agregar(BE.Materia mat)
        {
            return mapper.Agregar(mat);

        }
        public string Eliminar(BE.Materia mat)
        {
            return mapper.Eliminar(mat);
        }
        public string Modificar(BE.Materia mat)
        {
            return mapper.Editar(mat);
        }
        public List<BE.Materia> Listar()
        {
            List<BE.Materia> mat = mapper.Listar();
            return mat;
        }
    }
}

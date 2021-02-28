using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Nota_BLL
    {
        DAL.Nota_DAL mapper = new DAL.Nota_DAL();
        public string AgregarNota(BE.Nota notas)
        {
            return mapper.AgregarNota(notas);
        }
        public List<BE.Nota> Listar(int idmateria)
        {
            List<BE.Nota> notas = mapper.ListarNotas(idmateria);
            return notas;
        }

        public string DesaprobadorPrimerParcial()
        {
            return mapper.DesaprobadosPrimerParcial();
        }
        public string DesaprobadosSegundoParcial()
        {
            return mapper.DesaprobadosSegundoParcial();
        }
        public string DesaprobadosTP()
        {
            return mapper.DesaprobadosTP();
        }
    }
}

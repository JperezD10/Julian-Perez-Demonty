using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Alumno
    {
        DAL.Alumno mapper = new DAL.Alumno();

        public String Agregar(BE.ALUMNO Alum)
        {
            return mapper.Agregar(Alum);
            
        }

        public List<BE.ALUMNO> Listar()
        {
            List<BE.ALUMNO> Alumnos = mapper.Listar();
            return Alumnos;
        }
        public string Eliminar(BE.ALUMNO Alum)
        {
            return mapper.Eliminar(Alum);

        }
        public string Editar(BE.ALUMNO Alum)
        {
            return mapper.Editar(Alum);
        }
        public int PromedioEdad(BE.ALUMNO Alum)
        {
            
            int resultado = mapper.CalcularPromedioEdad(Alum);
            return resultado;
            
        }
        public int EdadMaxima(BE.ALUMNO Alum)
        {
            int Maxima = mapper.CalcularEdadMaxima(Alum);
            return Maxima;
        }
        public int EdadMinima(BE.ALUMNO Alum)
        {
            int Minima = mapper.CalcularEdadMinima(Alum);
            return Minima;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Especialidades
    {

        public List<Estudios> Estudio = new List<Estudios>();

        public static double GananciaTotal;

        private string _NombreEspecialdidad;

        public string NombreEspecialdidad
        {
            get { return _NombreEspecialdidad; }
            set { _NombreEspecialdidad = value; }
        }

        public Especialidades(string _NombreEspecialdidad)
        {
            this._NombreEspecialdidad = _NombreEspecialdidad;

        }

        public void CalcularTotal()
        {
            GananciaTotal = 0;
            foreach(Estudios E in Estudio)
            {
                GananciaTotal = GananciaTotal + E.CostoDeEstudio;

            }


        }

    }
}

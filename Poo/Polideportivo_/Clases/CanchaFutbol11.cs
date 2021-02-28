using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CanchaFutbol11:Cancha
    {
        private string opcional2Text;
        private bool[] opcional2Estado = { false, false, false };

        public string Opcional2Text
        {
            get
            {
                return opcional2Text;
            }

            set
            {
                opcional2Text = value;
            }
        }

        public bool[] Opcional2Estado
        {
            get
            {
                return opcional2Estado;
            }

            set
            {
                opcional2Estado = value;
            }
        }

        public CanchaFutbol11()
        {
            Nombre = "Cancha de Fútobl 11";
            Valor = 800;
            Opcional1Text = "Añadir un arbitro";
            Opcional2Text = "Añadir un arbitro  y dos jueces de linea";
        }


    }
}

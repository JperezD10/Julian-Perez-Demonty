using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CanchaTenis:Cancha
    {
        private Juez[] jueces = new Juez[3];

       public CanchaTenis()
        {
            Nombre = "Cancha de tenis";
            Valor = 200;
            Opcional1Text = "Añadir un arbitro";
            
        }
    }
}

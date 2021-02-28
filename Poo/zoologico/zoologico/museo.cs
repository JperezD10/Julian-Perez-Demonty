using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
   public class museo
    {
        public List<animal> listaAnimales = new List<animal>();
        public int entrada = 1;
        public int valorbase = 50;
        public void agregarAnimales(animal animal)
        {
            listaAnimales.Add(animal);
        }
    }
}

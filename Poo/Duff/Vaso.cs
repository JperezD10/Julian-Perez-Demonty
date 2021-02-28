using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duff
{
    class Vaso
    {
        string nombreVaso;
        float capacidadTotal;

        public Vaso(String nombre, float capacidad)
        {
            nombreVaso = nombre;
            capacidadTotal = capacidad;
        }
        public string getNombre()
        {
            return nombreVaso;
        }
        public float getCapacidad()
        {
            return capacidadTotal;
        }
    }
}

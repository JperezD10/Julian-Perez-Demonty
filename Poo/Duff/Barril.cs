using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duff
{
    class Barril
    {
        public float capacidadTotal;
        public Cerveza cerveza;
        public float capacidadRestante;
        public float litrosServidos  = 0;

        

        public Barril(float capacidadTotal,Cerveza cerveza)
        {
            capacidadRestante= this.capacidadTotal = capacidadTotal;
            this.cerveza = cerveza;
        }
        public void servirLitros(float litros)
        {
            litrosServidos += litros;
        }
    }
}

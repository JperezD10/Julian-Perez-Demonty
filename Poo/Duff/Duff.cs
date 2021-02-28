using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duff
{
    class Duff
    {
        public List<Barril> barriles = new List<Barril>();

        public Cerveza[] cervezas = new Cerveza[3];

        public Vaso[] vasos = new Vaso[3];

        public float total = 0;

        private void crearCerverzas()
        {
            cervezas[0] = new Cerveza("Rubia Nacional", 50);
            cervezas[1] = new Cerveza("Negra Nacional", 58);
            cervezas[2] = new Cerveza("Rubia Importada", 65);
        }
        private void crearVasos()
        {
            vasos[0] = new Vaso("Chopp", 0.75f);
            vasos[1] = new Vaso("Pinta", 0.5f);
            vasos[2] = new Vaso("Jarra", 3);
        }
        public Duff()
        {
            crearCerverzas();
            crearVasos();
        }


        public void addBarril(Barril barril)
        {
            barriles.Add(barril);
        }
        public void comprar(float importe)
        {
            total += importe;
        }
        public float getTotal()
        {
            return total;
        }

        public string getMasVendio()
        {
            float mayorVendido = 0;
            int nroBarril = 0;
            for (int j = 0; j < barriles.Count; j++)
            {
                if (barriles[j].litrosServidos > mayorVendido)
                    {
                        mayorVendido = barriles[j].litrosServidos;
                        nroBarril = j+1;
                    }
            }
            return nroBarril + " con un total de " + mayorVendido + " litros";
        }
    }
}

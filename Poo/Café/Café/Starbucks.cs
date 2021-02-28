using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Café
{
    public class Starbucks
    {
        public int contador = 0;
        public MaquinaCafe[] Maquina = new MaquinaCafe[6];

        public float totalNegocio()
        {
            float total=0;
            foreach(var maq in Maquina)
            {
                if(maq != null)
                {
                    total += maq._Total;
                }
            }
            return total;
        }

        public float totalPorMaquina(int tipoMaquina)
        {
            float total = 0;
            for(int i = 0; i<6; i++)
            {
                if(Maquina[i] != null && (i+1) == tipoMaquina)
                {
                    total += Maquina[i]._Total;
                }
            }
            return total;      
        }
    }
}

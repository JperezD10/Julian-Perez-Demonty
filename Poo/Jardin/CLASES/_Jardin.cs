using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class _Jardin
    {


        public List<Salas> Salitas = new List<Salas>();
        Lactarios Lactario = new Lactarios();
        Deambuladores Deambolador = new Deambuladores();
        Deambuladores_II DeambuladorII = new Deambuladores_II();
        Sala_de_2 SalaDe2 = new Sala_de_2();
        Sala_de_3 SalaDe3 = new Sala_de_3();

        double GananciasMensuales;

        public _Jardin()
        {
            Salitas.Add(Lactario);
            Salitas.Add(Deambolador);
            Salitas.Add(DeambuladorII);
            Salitas.Add(SalaDe2);
            Salitas.Add(SalaDe3);
        }

        public int CalcularSalon(int edad)
        {
            if (edad <= 9)
            {
                return 0;
            }
            else if (edad > 9 && edad <= 16)
            {
                return 1;
            }
            else if (edad > 16 && edad <= 24)
            {
                return 2;
            }
            else if (edad == 24)
            {
                return 3;
            }
            else
            {
                return 4;
            }


        }

        public double GananciaMensual()
        {
            int i=0;
            GananciasMensuales = 0;

          foreach (Inscripcion I in Salitas[i].Inscriptos)
            {
                GananciasMensuales = GananciasMensuales + I.Cuota;
                i++;
            }

            return GananciasMensuales;

        }

    }
}

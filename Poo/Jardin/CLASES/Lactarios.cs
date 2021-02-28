using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Lactarios:Salas
    {
        public Lactarios()
        {
            Nombre = "Lactarios";
            EdadRequeridad = "De 0 a 9 meses";
            Cupo = 12;
            CupoMaestras = 2;
        }
    }
}

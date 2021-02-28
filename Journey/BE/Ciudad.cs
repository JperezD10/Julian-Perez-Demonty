using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ciudad
    {
        private int id_Ciudad;
        private String nombre;
        private int id_Pais;

        public int Id_Ciudad { get => id_Ciudad; set => id_Ciudad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_Pais { get => id_Pais; set => id_Pais = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pais
    {
        private int id_Pais;
        private String nombre;

        public int Id_Pais { get => id_Pais; set => id_Pais = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}

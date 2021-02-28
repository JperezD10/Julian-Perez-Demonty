using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duff
{
    class Cerveza
    {
        string nombre;
        float precio;

        public Cerveza(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public string getNombre()
        {
            return nombre;
        }
        public float getPrecio()
        {
            return precio;
        }
    }
}

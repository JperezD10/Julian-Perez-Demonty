using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto_BLL
    {
        DAL.Producto_Dal mapper = new DAL.Producto_Dal();

        public List<BE.Producto> listar()
        {
            List<BE.Producto> productos = mapper.listar();
            return productos;
        }
        public List<BE.Producto> Mayores()
        {
            List<BE.Producto> productos = mapper.listarMayores();
            return productos;
        }

        public string Agregar(BE.Producto p)
        {
            return mapper.Agregar(p);
        }
        public string Modificar(BE.Producto p)
        {
            return mapper.Modificar(p);
        }
        public string Eliminar(BE.Producto p)
        {
            return mapper.Eliminar(p);
        }
    }
}

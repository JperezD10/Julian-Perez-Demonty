using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Producto_Dal
    {
        Acceso acceso = new Acceso();

        public String Agregar(BE.Producto p)
        {
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@ID",p._IDProducto);
            parametro[1] = new SqlParameter("@desc", p._Descripcion);
            parametro[2] = new SqlParameter("@stock", p._Stock);
            parametro[3] = new SqlParameter("@precio", p._PrecioU);
            return acceso.Escribir("AltaProducto",parametro);
        }
        public string Modificar(BE.Producto p)
        {
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@ID", p._IDProducto);
            parametro[1] = new SqlParameter("@desc", p._Descripcion);
            parametro[2] = new SqlParameter("@stock", p._Stock);
            parametro[3] = new SqlParameter("@precio", p._PrecioU);
            return acceso.Escribir("ModificarProducto",parametro);
        }
        public string Eliminar(BE.Producto p)
        {
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@ID", p._IDProducto);
            return acceso.Escribir("EliminarProducto",parametro);
        }
        public List<BE.Producto> listar()
        {
            List<BE.Producto> ls = new List<BE.Producto>();
            DataTable tabla = acceso.Leer("listarProductos", null);
            foreach(DataRow Registro in tabla.Rows)
            {
                BE.Producto Producto = new BE.Producto();
                Producto._IDProducto = int.Parse(Registro["IDProducto"].ToString());
                Producto._Descripcion = Registro["Descripcion"].ToString();
                Producto._Stock= int.Parse(Registro["Stock"].ToString());
                Producto._PrecioU= int.Parse(Registro["PrecioUnit"].ToString());
                ls.Add(Producto);
            }
            return ls;
        }
        public List<BE.Producto> listarMayores()
        {
            List<BE.Producto> ls = new List<BE.Producto>();
            DataTable tabla = acceso.Leer("Mayores", null);
            foreach (DataRow Registro in tabla.Rows)
            {
                BE.Producto Producto = new BE.Producto();
                Producto._IDProducto = int.Parse(Registro["IDProducto"].ToString());
                Producto._Descripcion = Registro["Descripcion"].ToString();
                Producto._Stock = int.Parse(Registro["Stock"].ToString());
                Producto._PrecioU = int.Parse(Registro["PrecioUnit"].ToString());
                ls.Add(Producto);
            }
            return ls;
        }
    }
}

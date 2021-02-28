using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Factura_DAL
    {
        Acceso acceso = new Acceso();

        public String generarFactura(BE.Factura factura)
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("id_factura", factura.Id_factura);
            sqlParameters[1] = new SqlParameter("id_cliente", factura.Id_cliente);
            sqlParameters[2] = new SqlParameter("id_tipoFactura", factura.Id_tipofactura);
            DateTime fechaRealizacion = DateTime.Parse(factura.FechaRealizacion);
            DateTime horaRealizacion = DateTime.Parse(factura.HoraRealizacion);
            sqlParameters[3] = new SqlParameter("fechaRealizacion", fechaRealizacion);
            sqlParameters[4] = new SqlParameter("horaRealizacion", horaRealizacion);
            sqlParameters[5] = new SqlParameter("precio", factura.Precio);
            return acceso.writeData("generarFactura", sqlParameters);
        }

        public String generarFacturaVuelo(BE.FacturaVuelo facturaVuelo)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("id_facturaVuelo", facturaVuelo.Id_facturavuelo);
            sqlParameters[1] = new SqlParameter("id_tipoFactura", facturaVuelo.Id_tipofactura);
            sqlParameters[2] = new SqlParameter("id_factura", facturaVuelo.Id_factura);
            sqlParameters[3] = new SqlParameter("id_vuelo", facturaVuelo.Id_vuelo);
            sqlParameters[4] = new SqlParameter("cantidadVuelos", facturaVuelo.CantidadVuelos);
            return acceso.writeData("generarFacturaVuelo", sqlParameters);
        }

        public String generarFacturaHotel(BE.FacturaHotel facturaHotel)
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id_facturahotel", facturaHotel.Id_facturahotel);
            sqlParameters[1] = new SqlParameter("@id_factura", facturaHotel.Id_factura);
            sqlParameters[2] = new SqlParameter("@id_tipofactura", facturaHotel.Id_tipofactura);
            sqlParameters[3] = new SqlParameter("@id_hotel", facturaHotel.Id_hotel);
            sqlParameters[4] = new SqlParameter("@checkin", facturaHotel.Checkin);
            sqlParameters[5] = new SqlParameter("@checkout", facturaHotel.Checkout);
            return acceso.writeData("generarFacturaHotel", sqlParameters);
        }

        public String generarFacturaPaquete(BE.FacturaPaquete facturaPaquete)
        {
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@id_facturapaquete", facturaPaquete.Id_facturapaquete);
            sqlParameters[1] = new SqlParameter("@id_factura", facturaPaquete.Id_factura);
            sqlParameters[2] = new SqlParameter("@id_tipofactura", facturaPaquete.Id_tipofactura);
            sqlParameters[3] = new SqlParameter("@id_paquete", facturaPaquete.Id_paquete);
            sqlParameters[4] = new SqlParameter("@checkin", facturaPaquete.Checkin);
            sqlParameters[5] = new SqlParameter("@checkout", facturaPaquete.Checkout);
            sqlParameters[6] = new SqlParameter("@cantidadmenores", facturaPaquete.Cantidadmenores);
            sqlParameters[7] = new SqlParameter("@cantidadadultos", facturaPaquete.Cantidadadultos);
            return acceso.writeData("generarFacturaPaquete", sqlParameters);
        }
        public int obtenerIDFactura(String[] datos)
        {
            int idfactura = 0;
            SqlParameter[] sqlParameters = new SqlParameter[2];
            DateTime fecha = DateTime.Parse(datos[0]);
            DateTime hora = DateTime.Parse(datos[1]);
            sqlParameters[0] = new SqlParameter("fecha", fecha);
            sqlParameters[1] = new SqlParameter("hora", hora);
            DataTable dataTable = acceso.readData("obtenerIDFactura", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                idfactura = int.Parse(dataRow["ID_Factura"].ToString());
            }
            return idfactura;
        }

        public List<BE.Factura> getFactura(int id)
        {
            List<BE.Factura> listaFacturas = new List<BE.Factura>();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_cliente", id);
            DataTable dataTable = acceso.readData("getFactura", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Factura factura = new BE.Factura();                              
                var fechaRealizacion = DateTime.Parse(dataRow["FechaRealizacion"].ToString());
                var horaRealizacion = DateTime.Parse(dataRow["HoraRealizacion"].ToString());
                factura.FechaRealizacion = fechaRealizacion.ToShortDateString();
                factura.HoraRealizacion = horaRealizacion.ToShortTimeString();
                listaFacturas.Add(factura);
            }
            return listaFacturas;
        }

        public List<BE.Factura> getFacturaDatos(int id)
        {
            List<BE.Factura> listaDatos = new List<BE.Factura>();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_factura", id);
            DataTable dataTable = acceso.readData("getFacturaDatos", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Factura factura = new BE.Factura();
                factura.Id_tipofactura = int.Parse(dataRow["ID_TipoFactura"].ToString());
                factura.Precio = float.Parse(dataRow["Precio"].ToString());
                listaDatos.Add(factura);
            }
            return listaDatos;
        }

        public DataTable getNombreTipoFactura(int id)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_tipoFactura", id);
            return acceso.readData("getNombreTipoFactura", sqlParameters);
        }
    }
}

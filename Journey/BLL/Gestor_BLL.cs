using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Gestor_BLL
    {
        DAL.PaisCiudad_DAL MapperPaisCiudad = new DAL.PaisCiudad_DAL();
        DAL.LogCliente_DAL MapperLogCliente = new DAL.LogCliente_DAL();
        DAL.Seguridad_DAL MapperSecurity = new DAL.Seguridad_DAL();
        DAL.Cliente_DAL MapperCliente = new DAL.Cliente_DAL();
        DAL.Vuelo_DAL MapperVuelo = new DAL.Vuelo_DAL();
        DAL.Factura_DAL MapperFactura = new DAL.Factura_DAL();
        DAL.Hotel_DAL MapperHotel = new DAL.Hotel_DAL();

        public List<BE.Pais> cargarPaises()
        {
            List<BE.Pais> listaPaises = MapperPaisCiudad.cargarPaises();
            return listaPaises;
        }

        public List<BE.Ciudad> cargarCiudades(int id_pais)
        {
            List<BE.Ciudad> listaCiudades = MapperPaisCiudad.cargarCiudades(id_pais);
            return listaCiudades;
        }

        public String inscribirCliente(BE.Cliente cliente)
        {
            return MapperLogCliente.inscribirCliente(cliente);
        }

        public String editarCliente(BE.Cliente cliente)
        {
            return MapperLogCliente.editarCliente(cliente);
        }

        public String generarHash(String toHash, String username)
        {
            return MapperSecurity.generarHash(toHash, username);
        }

        public string getUserPassword(string user)
        {
            return MapperSecurity.getUserPassword(user);
        }

        public String updatePassword(string hashed, string user)
        {
            return MapperSecurity.updatePassword(hashed, user);
        }
        public Boolean iniciarSesion(BE.Cliente cliente)
        {
            DataTable dataTable = MapperLogCliente.iniciarSesion(cliente);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                return true;
            }
            return false;
        }

        public Boolean comprobarUsuarioExistente(BE.Cliente cliente)
        {
            DataTable dataTable = MapperLogCliente.comprobarUsuarioExistente(cliente);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                return true;
            }
            return false;
        }

        public int getClientID(string user)
        {
            int ID=0;
            DataTable dataTable = MapperCliente.getClientID(user);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                ID = int.Parse(dataRow["ID_Cliente"].ToString());
            }
            return ID;
        }

        public List<BE.Cliente> getClientData(int id)
        {
            List<BE.Cliente> listaCliente = MapperCliente.getClientData(id);
            return listaCliente;
        }

        public List<BE.Vuelo> listarVuelos()
        {
            List<BE.Vuelo> listaVuelos = MapperVuelo.listarVuelos();
            return listaVuelos;
        }
        public String[] getClientNombrePais(int id)
        {
            String[] datos = new string[2];
            int id_pais = 0;
            DataTable dataTable = MapperCliente.getClientCiudad(id);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                datos[0] = dataRow["NombreCiudad"].ToString();
                id_pais = int.Parse(dataRow["ID_Pais"].ToString());
                
                
            }
            DataTable dataTable2 = MapperCliente.getClientPais(id_pais);
            foreach (DataRow dataRow1 in dataTable2.Rows)
            {
                datos[1] = dataRow1["Nombre"].ToString();
            }
            return datos;
        }

        public String getCiudadNombre(int ciudad)
        {
            String datos = MapperVuelo.getCiudadNombre(ciudad);                   
            return datos;
        }

        public int getCiudadID(string nombreCiudad)
        {     
            int datos = MapperVuelo.getCiudadID(nombreCiudad);
            
            return datos;
        }

        public int getVueloID(int[] datos)
        {
            int id=0;
            DataTable dataTable = MapperVuelo.getVueloID(datos);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                id = int.Parse(dataRow["ID_Vuelo"].ToString());
            }
            return id;
        }

        public List<BE.Vuelo> getVueloDatos(int id)
        {
            List<BE.Vuelo> listaVuelo = MapperVuelo.getVueloDatos(id);
            return listaVuelo;
        }

        public int getPaisID(string nombreCiudad)
        {
            int id = 0;
            DataTable dataTable = MapperVuelo.getPaisID(nombreCiudad);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                id = int.Parse(dataRow["ID_Pais"].ToString());
            }
            return id;
        }

        public String getPaisNombre(int id)
        {
            String datos = "";
            DataTable dataTable = MapperVuelo.getPaisNombre(id);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                datos = dataRow["Nombre"].ToString();
            }
            return datos;
        }

        public String generarFactura(BE.Factura factura)
        {
            return MapperFactura.generarFactura(factura);
        }

        public String generarFacturaVuelo(BE.FacturaVuelo facturaVuelo)
        {
            return MapperFactura.generarFacturaVuelo(facturaVuelo);
        }

        public int obtenerIDFactura(String[] datos)
        {     
            int id = MapperFactura.obtenerIDFactura(datos);
            return id;
        }

        public List<BE.Factura> getFacturas(string user)
        {
            int id = getClientID(user);
            List <BE.Factura> listaFactura = MapperFactura.getFactura(id);
            return listaFactura;
        }

        public List<BE.Factura> getFacturaDatos(string[] datos)
        {
            int id = obtenerIDFactura(datos);
            List<BE.Factura> listaFacturaDatos = MapperFactura.getFacturaDatos(id);
            return listaFacturaDatos;
        }

        public String getNombreTipoFactura(int id)
        {
            String nombre = "";
            DataTable dataTable = MapperFactura.getNombreTipoFactura(id);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                nombre = dataRow["Nombre"].ToString();
            }
            return nombre;
        }

        public List<BE.Hotel> listarHoteles()
        {
            List<BE.Hotel> listaHoteles = MapperHotel.listarHoteles();
            return listaHoteles;
        }
      
        /*public String encrypt(String key)
        {
            return MapperSecurity.encrypt(key);
        }
        public Boolean iniciarSesion(BE.Cliente cliente, String key)
        {
            bool ok;
            String passCliente = MapperCliente.iniciarSesion(cliente,key);
            if (passCliente.Equals(cliente.Password))
            {
                ok= true;
            }
            else
            {
                ok= false;
            }
            return ok;
        }*/

    }
}

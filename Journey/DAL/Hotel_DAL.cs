using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Hotel_DAL
    {

        Acceso acceso = new Acceso();

        public List<BE.Hotel> listarHoteles()
        {
            List<BE.Hotel> listaHoteles = new List<BE.Hotel>();
            DataTable dataTable = acceso.readData("listarHoteles", null);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Hotel hotel = new BE.Hotel();
                hotel.Id_Hotel = int.Parse(dataRow["ID_Hotel"].ToString());
                hotel.Nombre = dataRow["Nombre"].ToString();
                hotel.Telefono = int.Parse(dataRow["Telefono"].ToString());
                hotel.Id_Ciudad = int.Parse(dataRow["ID_Ciudad"].ToString());
                hotel.Id_CategoriaHotel = int.Parse(dataRow["ID_CategoriaHotel"].ToString());
                hotel.Direccion = dataRow["Direccion"].ToString();
                hotel.Precio = int.Parse(dataRow["Precio"].ToString());
                listaHoteles.Add(hotel);
            }
            return listaHoteles;
        }    

        public List<BE.Hotel> getHotelDatos(string hotel)
        {
            List<BE.Hotel> listaHotel = new List<BE.Hotel>();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Nombre", hotel);
            DataTable dataTable = acceso.readData("getHotelDatos", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Hotel hotel1 = new BE.Hotel();
                hotel1.Telefono = int.Parse(dataRow["Telefono"].ToString());
                hotel1.Id_Ciudad = int.Parse(dataRow["ID_Ciudad"].ToString());
                hotel1.Id_CategoriaHotel = int.Parse(dataRow["ID_CategoriaHotel"].ToString());
                hotel1.Direccion = dataRow["Direccion"].ToString();
                hotel1.Precio = int.Parse(dataRow["Precio"].ToString());
                listaHotel.Add(hotel1);
            }
            return listaHotel;
        }
        
        public int getIDHotel(string hotel)
        {
            int id = 0;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Nombre", hotel);
            DataTable dataTable = acceso.readData("getIDHotel", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                id = int.Parse(dataRow["ID_Hotel"].ToString());

            }
            return id;
        }

        public String getHotelNombre(int id)
        {
            string nombre = "";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DataTable dataTable = acceso.readData("getHotelNombre", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                nombre = dataRow["Nombre"].ToString();
            }
            return nombre;
        }
    }
}

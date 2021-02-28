using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Vehiculo_DAL
    {
        Acceso acceso = new Acceso();
        public List<BE.Vehiculos> Listar()
        {
            List<BE.Vehiculos> ls = new List<BE.Vehiculos>();
            DataTable tabla = acceso.Leer("listarvehiculo", null);

            foreach (DataRow Registro in tabla.Rows)
            {
                BE.Vehiculos veh = new BE.Vehiculos();
                veh._IDVehiculo = int.Parse(Registro["IDvehiculo"].ToString());
                veh._Marca = Registro["Marca"].ToString();
                veh._Modelo = Registro["Modelo"].ToString();
                veh._Patente = Registro["Patente"].ToString();

                ls.Add(veh);
            }
            return ls;
        }
    }
}

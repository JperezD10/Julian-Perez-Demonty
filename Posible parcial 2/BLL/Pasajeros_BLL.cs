using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pasajeros_BLL
    {
        DAL.Pasajeros_DAL pasajeros = new DAL.Pasajeros_DAL();

        public string Agregar(BE.Pasajeros pas)
        {
            return pasajeros.Agregar(pas);
        }
        public string modificar(BE.Pasajeros pas)
        {
            return pasajeros.Editar(pas);
        }
        public List<BE.Pasajeros> Listar()
        {
            List<BE.Pasajeros> pas = pasajeros.Listar();
            return pas;
        }
        public string Eliminar(BE.Pasajeros pas)
        {
            return pasajeros.Eliminar(pas);
        }
    }
}

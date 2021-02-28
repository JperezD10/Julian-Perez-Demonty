using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    public class RESERVAS
    {

        private int NroHabitacion;

        public int NROHABITACION
        {
            get { return NroHabitacion; }
            set { NroHabitacion = value; }
        }

        private string NombreDelPropietario;

        public string NOMBREDELPROPIETARIO
        {
            get { return NombreDelPropietario; }
            set { NombreDelPropietario = value; }
        }

        private bool EstadoReserva;

        public bool ESTADORESERVA
        {
            get { return EstadoReserva; }
            set { EstadoReserva = value; }
        }

        public RESERVAS(int NroHabitacion,string NombreDelPropietario)
        {

            this.NroHabitacion = NroHabitacion;

            this.NombreDelPropietario = NombreDelPropietario;

        }


    }
}

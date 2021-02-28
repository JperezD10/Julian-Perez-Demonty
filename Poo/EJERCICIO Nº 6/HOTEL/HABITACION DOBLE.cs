using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    public class HABITACION_DOBLE:HABITACION
    {

        private string TipoCama= "Cama De Dos Plazas";
        public string TIPOCAMA
        {
            get { return TipoCama; }
            set { TipoCama = value; }
        }

         public HABITACION_DOBLE() : base()
        {

            PRECIO = 350;

            NROHABITACION = HABITACION.numeroHabitacion;

            ESTADOHABITACION = false;

        }

    }
}

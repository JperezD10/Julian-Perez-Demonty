using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    public class HABITACION_SIMPLE:HABITACION
    {
        

        private string TipoCama= "Cama De Una Plaza";

        public string TIPOCAMA
        {
            get { return TipoCama; }
            set { TipoCama = value; }
        }

        public HABITACION_SIMPLE() : base()
        {

            PRECIO = 200;

            NROHABITACION = HABITACION.numeroHabitacion;

            ESTADOHABITACION = false;

        }

    




    }
}

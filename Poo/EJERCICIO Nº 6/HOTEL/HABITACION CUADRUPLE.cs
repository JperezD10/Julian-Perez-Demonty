using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    public class HABITACION_CUADRUPLE:HABITACION
    {


        private string TipoCama1= "Cama Matrimonial";

        public string TIPOCAMA1
        {
            get { return TipoCama1; }
            set { TipoCama1 = value; }
        }

        private string TipoCama2 = "Cama-Cucheta";
        public string TIPOCAMA2
        {
            get { return TipoCama2; }
            set { TipoCama2 = value; }
        }

        public HABITACION_CUADRUPLE() : base()
        {

            PRECIO = 700;

            NROHABITACION = HABITACION.numeroHabitacion;

            ESTADOHABITACION = false;

        }
   

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    public class HABITACION_TRIPLE:HABITACION
    {

        private string TipoCama1= "Cama Matrimonial Plus";

        public string TIPOCAMA1
        {
            get { return TipoCama1; }
            set { TipoCama1 = value; }
        }

        private string TipoCama2= "Cama Extra";
         
        public string TIPOCAMA2
        {
            get { return TipoCama2; }
            set { TipoCama2 = value; }
        }


        public HABITACION_TRIPLE() : base()
        {

            PRECIO = 550;

            NROHABITACION = HABITACION.numeroHabitacion;

            ESTADOHABITACION = false;


            
        }


    }
}

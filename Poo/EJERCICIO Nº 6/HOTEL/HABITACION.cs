using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    public abstract class HABITACION
    {
        public static int numeroHabitacion = 0;

        private int nroHabitacion;

        public int NROHABITACION 
        {
            get { return nroHabitacion; }
            set { nroHabitacion = value; }
        }
        

        private int Precio;
      
        public int PRECIO
        {
            get { return Precio; }
            set { Precio = value; }
        }

        private bool EstadoHabitacion;

        public bool ESTADOHABITACION
        {
            get { return EstadoHabitacion; }
            set { EstadoHabitacion = value; }
        }

        public HABITACION()
        {

            numeroHabitacion++;

            nroHabitacion = numeroHabitacion;


        }

    }
}

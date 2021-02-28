using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    public class Hotel
    {
        HABITACION_SIMPLE HABSIMPLE;
        HABITACION_DOBLE HABDOBLE;
        HABITACION_TRIPLE HABTRIPLE;
        HABITACION_CUADRUPLE HABCUADRUPLE;
           
        
        public List<HABITACION> Habitaciones = new List<HABITACION>();

        public List<PERSONAS> Personas = new List<PERSONAS>();

        public List<RESERVAS> Reservas = new List<RESERVAS>();

        public Hotel()
        {

            CrearHabitaciones();
               
        }

        private void CrearHabitaciones()
        {

            HABSIMPLE = new HABITACION_SIMPLE();          
            HABDOBLE = new HABITACION_DOBLE();
            HABTRIPLE = new HABITACION_TRIPLE();
            HABCUADRUPLE = new HABITACION_CUADRUPLE();

            /*
            Habitaciones.Add(HABSIMPLE);
            Habitaciones.Add(HABDOBLE);
            Habitaciones.Add(HABTRIPLE);
            */
        }

        public void LlenarHabitaciones(int Numero)
        {            

            switch (Numero)
            {
                case 0:
                    Habitaciones.Add(HABSIMPLE);
                    break;
                case 1:
                    Habitaciones.Add(HABDOBLE);
                    break;
                case 2:
                    Habitaciones.Add(HABTRIPLE);
                    break;
                case 3:
                    Habitaciones.Add(HABCUADRUPLE);
                    break;

            }
          
        
         }

        public void LlenarPeronas(PERSONAS persona)
        {

            Personas.Add(persona);

        }

        public void LLenarReservas(RESERVAS Reserva)
        {

               Reservas.Add(Reserva);
                     
              

        }

        public void CancelarReserva(int i)
        {

            Reservas.RemoveAt(i);

        }

        }


       }
         

   

    
   


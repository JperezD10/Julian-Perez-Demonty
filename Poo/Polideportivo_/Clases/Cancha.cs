using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Cancha
    {

        private string nombre;
        private float valor;
        private float recaudacion;
        private int cantidadVecesAlquilada;
        private string opcional1Text;
        private bool[] opcional1Estado = { false, false, false };
        private string[] turnosText = { "Mañana","Tarde","Noche"};
        private bool[] turnosEstados = { false, false, false };
        

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public float Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public float Recaudacion
        {
            get
            {
                return recaudacion;
            }

            set
            {
                recaudacion = value;
            }
        }

        public int CantidadVecesAlquilada
        {
            get
            {
                return cantidadVecesAlquilada;
            }

            set
            {
                cantidadVecesAlquilada = value;
            }
        }

        public string Opcional1Text
        {
            get
            {
                return opcional1Text;
            }

            set
            {
                opcional1Text = value;
            }
        }

      

        public string[] TurnosText
        {
            get
            {
                return turnosText;
            }

            set
            {
                turnosText = value;
            }
        }

        public bool[] TurnosEstados
        {
            get
            {
                return turnosEstados;
            }

            set
            {
                turnosEstados = value;
            }
        }

        public bool[] Opcional1Estado
        {
            get
            {
                return opcional1Estado;
            }

            set
            {
                opcional1Estado = value;
            }
        }
    }
}

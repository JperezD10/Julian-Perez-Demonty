using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Juez
    {
        public static int Numero = 1;
        private int nroLegajo;
        private string nombre;
        private string apellido;
        private int cantDirigidos = 0;
        private float totalRecaudado = 0;
        private bool[] turnos = new bool[3];

        public Juez(String nomb, String apellid)
        {
            nroLegajo = Juez.Numero;
            nombre = nomb;
            apellido = apellid;
            turnos[0] = turnos[1] = turnos[2] = false;
            Juez.Numero++;
        }


        public int NroLegajo
        {
            get
            {
                return nroLegajo;
            }

            set
            {
                nroLegajo = value;
            }
        }

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

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public int CantDirigidos
        {
            get
            {
                return cantDirigidos;
            }

            set
            {
                cantDirigidos = value;
            }
        }

        public float TotalRecaudado
        {
            get
            {
                return totalRecaudado;
            }

            set
            {
                totalRecaudado = value;
            }
        }

        public bool[] Turnos
        {
            get
            {
                return turnos;
            }

            set
            {
                turnos = value;
            }
        }
    }
}

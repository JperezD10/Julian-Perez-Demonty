using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arquitecto : PuestoTrabajo
    {
        private float sueldoInicial = 15000f;
        private float extraPorProyecto = 10000f;
        private int cantProyectos = 0;


        public Arquitecto()
        {
            NombrePuesto = "Arquitecto";
            SueldoFijo = 12000f;

        }
        public override float obtenerSueldo()
        {
            float total = sueldoInicial;
            total += (extraPorProyecto * cantProyectos);
            if(cantProyectos > 5)
            {
                total += SueldoFijo;
            }
            return total;
        }


        public float SueldoInicial
        {
            get
            {
                return sueldoInicial;
            }

            set
            {
                sueldoInicial = value;
            }
        }

        public float ExtraPorProyecto
        {
            get
            {
                return extraPorProyecto;
            }

            set
            {
                extraPorProyecto = value;
            }
        }

        public int CantProyectos
        {
            get
            {
                return cantProyectos;
            }

            set
            {
                cantProyectos = value;
            }
        }

        

    }
}

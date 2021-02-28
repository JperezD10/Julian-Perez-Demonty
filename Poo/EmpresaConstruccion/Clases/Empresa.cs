using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empresa
    {

        public List<Empleado> empleados = new List<Empleado>();
        private float totalRecaudado = 0;
        private int cantEmpCapataz = 0;
        private int cantEmpPeon = 0;
        private int cantEmpArq = 0;
      
        public float getTotalRecaudado()
        {
            return totalRecaudado;
        }

        public string getCategoriaMayorEmpleados()
        {
            string mensaje = "La categoria con más empleados es ";
            string categoriaMayor = "";
            updateCantEmpleadosCapataz();
            categoriaMayor = cantEmpCapataz > cantEmpPeon ? (cantEmpCapataz > cantEmpArq ? "Capataz" : "Arquitecto") : (cantEmpPeon > cantEmpArq ? "Peon" : "Arquitecto");

            return mensaje + categoriaMayor;
        }
        public void updateCantEmpleadosCapataz() {
            cantEmpCapataz = 0;
            cantEmpPeon = 0;
            cantEmpArq = 0;

            foreach(Empleado single in empleados)
            {
                if(single.Puesto is Capataz)
                {
                    cantEmpCapataz++;
                }else if(single.Puesto is Peon)
                {
                    cantEmpPeon++;
                }else if(single.Puesto is Arquitecto)
                {
                    cantEmpArq++;
                }
            }
            
        }
        public float getRecaudacionTotal()
        {
            totalRecaudado = 0;
            totalRecaudado += getRecaudacionArquitecto() + getRecaudacionCapataz() + getRecaudacionPeon();
            return totalRecaudado;
        }

        public List<Empleado> getFiltroArq45()
        {
            List<Empleado> lista = new List<Empleado>();
            foreach(Empleado single in empleados)
            {
                if(single.Edad > 45 && single.Puesto is Arquitecto)
                {
                    lista.Add(single);
                }
            }

            return lista;
        }
      
        public float getRecaudacionCapataz()
        {
            float recaudado = 0;
            foreach(Empleado single in empleados)
            {
                if(single.Puesto is Capataz)
                {
                    recaudado += ((Capataz)single.Puesto).obtenerSueldo();
                }
            }
            return recaudado;
        }
        public float getRecaudacionPeon()
        {
            float recaudado = 0;
            foreach (Empleado single in empleados)
            {
                if (single.Puesto is Peon)
                {
                    recaudado += ((Peon)single.Puesto).obtenerSueldo();
                }
            }
            return recaudado;

        }
        public float getRecaudacionArquitecto()
        {
            float recaudado = 0;
            foreach (Empleado single in empleados)
            {
                if (single.Puesto is Arquitecto)
                {
                    recaudado += ((Arquitecto)single.Puesto).obtenerSueldo();
                }
            }
            return recaudado;
        }

    }
}

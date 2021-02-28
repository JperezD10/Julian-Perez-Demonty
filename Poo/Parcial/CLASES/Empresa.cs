using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Empresa
    {
        public delegate void Creado(string mensaje);
        public delegate void NoCreado(string mensaje);
        public event Creado Creados;
        public event NoCreado NoCreados;
        public List<Empleado> Empleados = new List<Empleado>();
       public int CantPeon = 0, CantCapataz = 0, CantArquitecto = 0;
        public float SueldoCapataz = 0, SueldoPeon = 0, SueldoArquitecto = 0;
        public string MayorCantEmpleados;
        public void evento(int numero)
        {
            if (numero == 1)
            {
                this.Creados("Creados correctamente");
            }
            else
            {
                this.NoCreados("Menor De Edad");
            }
        }
        public void CalcularEmpleados()
        {
            foreach(Empleado E in Empleados)
            {
                if (E._Puesto == "Peon")
                {
                    SueldoPeon += E._Sueldo;
                    CantPeon++;
                }
                else if (E._Puesto == "Capataz")
                {
                    SueldoCapataz += E._Sueldo;
                    CantCapataz++;
                }
                else
                {
                    SueldoArquitecto += E._Sueldo;
                    CantArquitecto++;
                }
            }
            if(CantPeon>CantCapataz && CantPeon> CantArquitecto)
            {
                MayorCantEmpleados = "Peon";
            }
            else if (CantCapataz>CantPeon && CantCapataz > CantArquitecto)
            {
                MayorCantEmpleados = "Capataz";
            }
            else
            {
                MayorCantEmpleados = "Arquitecto";
            }
        }
    }
}

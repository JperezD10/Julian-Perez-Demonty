using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Empresa
    {
        public delegate void Creado(string Mensaje);
        public delegate void NoCreado(string Mensaje);

        public event Creado Creados;
        public event NoCreado NoCreados;

        
        public string MayorCantDeEmpleados;
        public int CantCapataz = 0, CantPeon = 0, CantArquitecto = 0;
        public float SueldoCapataz = 0, SueldoPeon = 0, SueldoArquitecto = 0;
        public float RecaudacionTotal;
        
        public List<Empleado> Empleados = new List<Empleado>();


        public void CalcualarRecaudacionTotal()
        {
            foreach(Empleado E in Empleados)
            {
                RecaudacionTotal = RecaudacionTotal + E.Sueldo;
            }            
        }

        public void CalcularMayorCantEmpleados()
        {
            CantArquitecto = CantCapataz = CantPeon = 0;
            foreach (Empleado E in Empleados)
            {
                if (E.PuestoDeTrabajo == "Capataz")
                {
                    SueldoCapataz = SueldoCapataz + E.Sueldo;
                    CantCapataz++;
                }
                else if(E.PuestoDeTrabajo == "Peon")
                {
                    SueldoPeon = SueldoPeon + E.Sueldo;
                    CantPeon++;
                }
                else
                {
                    SueldoArquitecto = SueldoArquitecto + E.Sueldo;
                    CantArquitecto++;
                }
            }
            if(CantCapataz>CantPeon && CantCapataz > CantArquitecto)
            {
                MayorCantDeEmpleados = "Capataz";
                
            }
            else if (CantPeon > CantCapataz && CantPeon > CantArquitecto)
            {
                MayorCantDeEmpleados = "Peon";
            }
            else
            {
                MayorCantDeEmpleados = "Arquitecto";
            }
        }

        public void Evento(int Num)
        {

            if (Num == 1)
            {
                this.Creados("Creado Correctamente...");
            }
            else
            {
                this.NoCreados("Error Debe ser mayor de 18...");
            }
        }
    }
}

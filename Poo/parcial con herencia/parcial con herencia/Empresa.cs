using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_con_herencia
{
   public class Empresa
    {
        public List<Empleado> Empleados = new List<Empleado>();
        public int CantPeon = 0, CantCapataz = 0, CantArquitecto = 0;
        public float SueldoPeon = 0, SueldoCapataz = 0, Sueldoarquitecto = 0, SueldoTotalEmpresa = 0;
        public delegate void NoCreados(string mensaje);
        public event NoCreados NoCreado;
        public void evento()
        {
            this.NoCreado("Menor de edad");
        }
        public void CalcularSueldo()
        {
            foreach(Empleado e in Empleados)
            {
                if (e._Puesto == "Peon")
                {
                    CantPeon++;
                    SueldoPeon += e._Sueldo;
                }
                else if (e._Puesto == "Capataz")
                {
                    CantCapataz++;
                    SueldoCapataz += e._Sueldo;
                }
                else
                {
                    CantArquitecto++;
                    Sueldoarquitecto += e._Sueldo;
                }
                SueldoTotalEmpresa += e._Sueldo;
            }
        }
    }
}

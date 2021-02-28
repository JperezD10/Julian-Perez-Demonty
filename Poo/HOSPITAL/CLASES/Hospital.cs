using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Hospital
    {
        public List<Especialidades> Especialidad = new List<Especialidades>();

        public List<Medicos> Medico = new List<Medicos>();

        public List<Asignaciones> AsignarMedico = new List<Asignaciones>();

        public List<Pacientes> Paciente = new List<Pacientes>();

        public void LlenarListaEspecialidad(Especialidades E)
        {
            Especialidad.Add(E);
        }

        public void LlenarListaMedico(Medicos E)
        {
            Medico.Add(E);
        }

        public void LlenarListaAsignarMedico(Asignaciones E)
        {
            AsignarMedico.Add(E);
        }

        public void LlenarListaPaciente(Pacientes E)
        {
            Paciente.Add(E);
        }


    }
}

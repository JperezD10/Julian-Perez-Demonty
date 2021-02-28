using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public abstract class Salas
    {
        public List<Maestra> Maestras = new List<Maestra>();
        public List<Inscripcion> Inscriptos = new List<Inscripcion>();

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


        private string _EdadRequerida;

        public string EdadRequeridad
        {
            get { return _EdadRequerida; }
            set { _EdadRequerida = value; }
        }

        private int _CantAlumnos;

        public int CantAlumnos
        {
            get { return _CantAlumnos; }
            set { _CantAlumnos = value; }
        }

        private int _Cupo;

        public int Cupo
        {
            get { return _Cupo; }
            set { _Cupo = value; }
        }

        private int _CupoMaestras;

        public int CupoMaestras
        {
            get { return _CupoMaestras; }
            set { _CupoMaestras = value; }
        }


        private int _CantMaestras;

        public int CantMaestras
        {
            get { return _CantMaestras; }
            set { _CantMaestras = value; }
        }



    }
}

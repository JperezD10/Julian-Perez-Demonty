using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nota
    {
        private int IDNota;

        public int _IDNota
        {
            get { return IDNota; }
            set { IDNota = value; }
        }
        private int IDAlumno;

        public int _IDAlumno
        {
            get { return IDAlumno; }
            set { IDAlumno = value; }
        }

        private int IDMateria;

        public int _IDMateria
        {
            get { return IDMateria; }
            set { IDMateria = value; }
        }
        private int Instancia;

        public int _Intancia
        {
            get { return Instancia; }
            set { Instancia = value; }
        }

        private int NotaNumerica;

        public int _NotaNumerica
        {
            get { return NotaNumerica; }
            set { NotaNumerica = value; }
        }

    }
}

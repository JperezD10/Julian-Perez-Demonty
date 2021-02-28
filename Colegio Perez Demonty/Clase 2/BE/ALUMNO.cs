using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ALUMNO
    {
        private int Id;

        public int _Id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string Nombre;

        public string _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Apellido;

        public string _Apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private int Edad;

        public int _Edad
        {
            get { return Edad; }
            set { Edad = value; }
        }


    }
}

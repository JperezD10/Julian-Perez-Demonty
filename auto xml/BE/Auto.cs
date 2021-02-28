using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Auto
    {
        private String Modelo;

        public String _Modelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }

        private String Patente;

        public String _Patente
        {
            get { return Patente; }
            set { Patente = value; }
        }
        private string Estado;

        public string _Estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

    }
}

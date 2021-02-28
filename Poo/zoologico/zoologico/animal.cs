using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    public class animal
    {
        public animal(string nombre,string habitat,string alimentacion,int existencia)
        {
            this.nombre = nombre;
            this.habitat = habitat;
            this.alimentacion = alimentacion;
            this.existencia = existencia;
        }
        private string nombre;

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string habitat;

        public string HABITAT
        {
            get { return habitat; }
            set { habitat = value; }
        }
        private string alimentacion;

        public string ALIMENTACION
        {
            get { return alimentacion; }
            set { alimentacion = value; }
        }
        private int existencia;

        public int EXISTENCIA
        {
            get { return existencia; }
            set { existencia = value; }
        }
        private string patas;

        public string PATAS
        {
            get { return patas; }
            set { patas = value; }
        }
        private Boolean exoesqueleto;

        public Boolean EXOESQUELETO
        {
            get { return exoesqueleto; }
            set { exoesqueleto = value; }
        }
        private int velocidad;

        public int VELOCIDAD
        {
            get { return velocidad; }
            set { velocidad = value; }
        }
        private int distanciaVision;

        public int DISTANCIAVISION
        {
            get { return distanciaVision; }
            set { distanciaVision = value; }
        }


    }
}

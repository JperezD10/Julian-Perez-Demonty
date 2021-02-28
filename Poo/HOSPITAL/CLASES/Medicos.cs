using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Medicos
    {
        
        
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private int _Dni;

        public int Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        private double _CantEspecializaciones;

        public double CantEspecializaciones
        {
            get { return _CantEspecializaciones; }
            set { _CantEspecializaciones = value; }
        }

        private double _Costo;

        public double Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }

        public void CalcularCosto()
        {
            double Resultado = (_Costo * _CantEspecializaciones * 0.15) + _Costo;
            _Costo = Resultado;
        }
        
        public Medicos(string _Nombre,string _Apellido,int _Dni)
        {
            this._Nombre = _Nombre;
            this._Apellido = _Apellido;
            this._Dni = _Dni;
            _Costo = 30000;
        }



    }
}

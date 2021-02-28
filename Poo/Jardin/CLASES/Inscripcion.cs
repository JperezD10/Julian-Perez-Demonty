using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Inscripcion : IComparable<Inscripcion>
    {

        public delegate void SalonLleno(string Mensaje);
        public delegate void SalonDisponible(string Mensaje, int Capacidad);

        public event SalonLleno Lleno;
        public event SalonDisponible Disponible;

        public static int NumeroInscripcion;

        private int _NroInscripcion;

        public int NroInscripcion
        {
            get { return _NroInscripcion; }
            set { _NroInscripcion = value; }
        }

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

        private int _Edad;

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }


        private string _Turno;

        public string Turno
        {
            get { return _Turno; }
            set { _Turno = value; }
        }

        private double _Cuota;

        public double Cuota
        {
            get { return _Cuota; }
            set { _Cuota = value; }
        }


        private bool _Comedor;

        public bool Comedor
        {
            get { return _Comedor; }
            set { _Comedor = value; }
        }

        private bool _Hermanos;

        public bool Hermanos
        {
            get { return _Hermanos; }
            set { _Hermanos = value; }
        }

        void CaluclarCuota(bool _Comedor, string _Turno,bool _Hermanos)
        {

            if (_Hermanos == true)
            {
                if(_Turno == "Doble Jornada")
                {
                      if(_Comedor == true)
                               {
                                    _Cuota = 13800;
                                }
                                else
                                {
                                    _Cuota = 12000;

                                }
                }
                else
                {
                        if (_Comedor == true)
                        {
                            _Cuota = 7800;
                        }
                        else
                        {
                            _Cuota = 6000;

                        }
                }

            }
            else
            {
               {
                    if (_Turno == "Doble Jornada")
                    {
                        if (_Comedor == true)
                        {
                            _Cuota = 23000;
                        }
                        else
                        {
                            _Cuota = 20000;

                        }
                    }
                    else
                    {
                        if (_Comedor == true)
                        {
                            _Cuota = 13000;
                        }
                        else
                        {
                            _Cuota = 10000;

                        }

                    }

                }

            }
        }

        public void Evento(int Num)
        {

            if (Num == 1)
            {
                this.Disponible("Asignado Correctamente, Numero de inscripcion:  ",NroInscripcion);
            }
            else
            {
                this.Lleno("Salon Lleno...");
            }

        }

        public int CompareTo(Inscripcion Inscripciones)
        {
            return this._Apellido.CompareTo(Inscripciones._Apellido);
        }

        public Inscripcion(string _Nombre, string _Apellido,int _Edad, string _Turno, bool _Comedor,bool _Hermanos)
        {
            this._Nombre = _Nombre;
            this._Apellido = _Apellido;
            this._Edad = _Edad;
            this._Turno = _Turno;
            this._Comedor = _Comedor;
            this._Hermanos = _Hermanos;
            CaluclarCuota(_Comedor, _Turno, _Hermanos);
            NumeroInscripcion++;
            _NroInscripcion = NumeroInscripcion;



        }


    }
}

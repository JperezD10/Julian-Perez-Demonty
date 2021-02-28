using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Estudios : IComparable<Estudios>
    {
        public delegate void FaltaFirmaMedico(string Firma);
        public delegate void FirmaCorrecta(string FirmaOk);

        public event FaltaFirmaMedico FaltaFirma;
        public event FirmaCorrecta FirmaOk;

        public static int Numero=1;

        public static int i;
        private int _Nro;

        public int Nro
        {
            get { return _Nro; }
            set { _Nro = value; }
        }

        private string _NombrePaciente;

        public string NombrePaciente
        {
            get { return _NombrePaciente; }
            set { _NombrePaciente = value; }
        }

        private string _ApellidoPaciente;

        public string ApellidoPaciente
        {
            get { return _ApellidoPaciente; }
            set { _ApellidoPaciente = value; }
        }

        private string _Especialidad;

        public string Especialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value; }
        }

        private string _NombreMedico;

        public string NombreMedico
        {
            get { return _NombreMedico; }
            set { _NombreMedico = value; }
        }


        private double _CostoDeEstudio;

        public double CostoDeEstudio
        {
            get { return _CostoDeEstudio; }
            set { _CostoDeEstudio = value; }
        }

        private string _Receta;

        public string Receta
        {
            get { return _Receta; }
            set { _Receta = value; }
        }

        private bool _FirmaDelMedico;

        public bool FirmaDelMedico
        {
            get { return _FirmaDelMedico; }
            set { _FirmaDelMedico = value; }
        }

        private int _Fecha;

        public int Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public Estudios(string _NombrePaciente, string _ApellidoPaciente,string _Especialidad,string _NombreMedico, string _Receta, bool _FirmaDelMedico, double _CostoDeEstudio, int _Fecha)
        {
            this._NombrePaciente = _NombrePaciente;
            this._ApellidoPaciente = _ApellidoPaciente;
            this._Especialidad = _Especialidad;
            this._NombreMedico = _NombreMedico;
            this._Nro = Numero;
            this._Receta = _Receta;
            this._FirmaDelMedico = _FirmaDelMedico;
            this._CostoDeEstudio = _CostoDeEstudio;
            this._Fecha = _Fecha;
            Numero++;

        }



        public int CompareTo(Estudios estudio)
        {
            if (i == 0)
            {
                return this._Fecha.CompareTo(estudio._Fecha);
            }
            else
            {
                return this._NombrePaciente.CompareTo(estudio._NombrePaciente);
            }

            
        }

        public void Evento(int Num)
        {
            if (Num==0)
            {
                this.FaltaFirma("Falta Firma Del Doc..");

            }
            else
            {
                this.FirmaOk("Estudio Generado...");
            }

        }

    }
}

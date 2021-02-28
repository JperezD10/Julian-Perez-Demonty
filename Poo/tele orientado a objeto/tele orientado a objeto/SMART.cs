using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tele_orientado_a_objeto
{
    public class SMART
    {
        private bool estado;

        public bool ESTADO
        {
            get { return estado; }
            set { estado = value; }
        }

        private int canal;
        public int CANAL
        {
            get { return canal; }
            set { canal = value; }
        }
        private int volumen;

        public int VOLUMEN
        {
            get { return volumen; }
            set { volumen = value; }
        }
        private string url;

        public string URL
        {
            get { return url; }
            set { url = value; }
        }
        public bool encendido()
        {
            if (ESTADO==true)
            {
                return ESTADO= false;
            }
            else
            {
                return ESTADO = true;
            }
        }
        public bool CambioCanal;
        public void Canal()
        {
            if (CambioCanal == true)
            {
                if (CANAL == 99)
                {
                    CANAL = 1;
                }
                else
                {
                    CANAL++;
                }
            }
            else
            {
                if (CANAL == 1)
                {
                    CANAL = 99;
                }
                else
                {
                    CANAL--;
                }
            }
        }
        public bool CambiarVolumen;
        public void Volumen()
        {
            if (CambiarVolumen == true )
            {
                VOLUMEN++;
            }
            else
            {
                VOLUMEN--;
            }
        }
        public void Smart()
        {

        }
    }
}

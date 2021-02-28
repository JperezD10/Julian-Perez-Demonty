using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tele2
{
    class TELE
    {
       

        private bool estado=false;

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

        private int marca;

        public int MARCA
        {
            get { return marca; }
            set { marca = value; }
        }

        private int url;

        public int URL
        {
            get { return url; }
            set { url = value; }
        }

        public bool encendido()
        {
            if (ESTADO == true)
            {
                return ESTADO = false;
            }
            else 
            {
                return ESTADO = true;
            }
            
        }

        public bool canalmasomenos; 

        public void canales()
        {
            if (canalmasomenos == true)
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

        public bool Volmasomenos;

        public void Volumen()
        {
            if (Volmasomenos == true)
            {
                if (VOLUMEN == 99)
                {
                    VOLUMEN = 1;

                }
                else
                {
                    VOLUMEN++;
                }
            }
            else
            {
                if (VOLUMEN == 1)
                {
                    VOLUMEN = 99;

                }
                else
                {
                    VOLUMEN--;
                }
            }
        }

        public string url_()
        {
            return "https://www.netflix.com/ar/";
        }

        public string Marcaa()
        {
            return "toshiba";
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SubPRocesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void delEstampar();

        void EstamparHorario()
        {
            if (label2.InvokeRequired)
            {

                label2.Invoke(new delEstampar(EstamparHorario));
            }
            else
            {
                label2.Text = DateTime.Now.ToString();
            }

        }


        void Tarea()
        {
            for (long n = 0; n < 10; n++)
            {
                Thread.Sleep(1000);
            }

            EstamparHorario();
        }
        Thread hilo;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            hilo = new Thread(new ThreadStart(Tarea));
            hilo.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hilo.Abort();
        }
    }
}

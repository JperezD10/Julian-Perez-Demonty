using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semaforo
{
    
    public partial class Form1 : Form
    {
        int caso, servicio = 0, prenderauto = 0, servicioauto = 0;
        int prender=0, prenderservicio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            pictureBox2.Image = semaforo.Properties.Resources.apagado;
            pictureBox3.Image = semaforo.Properties.Resources.apagado;
        }

        private void btencender_Click(object sender, EventArgs e)
        {
            
            switch (prender)
            {
                case 0:
                    timer1.Start();
                    btencender.Text = "apagar";
                    prender = 1;
                    break;
                case 1:
                    timer1.Stop();
                    btencender.Text = "encender";
                    prender = 0;
                    pictureBox2.Image = semaforo.Properties.Resources.apagado;
                    pictureBox3.Image = semaforo.Properties.Resources.apagado;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                switch (caso)
                {
                case 0:
                    pictureBox2.Image = semaforo.Properties.Resources.rojo;
                    pictureBox3.Image = semaforo.Properties.Resources.verde;
                    timer1.Interval = 3000;
                    caso = 1;
                    break;
                case 1:
                    pictureBox2.Image = semaforo.Properties.Resources.amarillo;
                    pictureBox3.Image = semaforo.Properties.Resources.amarillo;
                    timer1.Interval = 2000;
                    caso = 2;
                    break;
                case 2:
                    pictureBox2.Image = semaforo.Properties.Resources.verde;
                    pictureBox3.Image = semaforo.Properties.Resources.rojo;
                    timer1.Interval = 3000;
                    caso = 3;
                    break;
                case 3:
                    pictureBox2.Image = semaforo.Properties.Resources.amarillo;
                    pictureBox3.Image = semaforo.Properties.Resources.amarillo;
                    caso = 0;
                    timer1.Interval = 2000;
                    break;
                    

                }
        }

        private void rbautomatico_CheckedChanged(object sender, EventArgs e)
        {
                btencender.Enabled = false;
                btservicio.Enabled = false;
                timer3.Start();
            
        }

        private void rbmanual_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = semaforo.Properties.Resources.apagado;
            pictureBox3.Image = semaforo.Properties.Resources.apagado;
            btencender.Enabled = true;
            btservicio.Enabled = true;
            timer3.Stop();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            switch (servicio)
            {
                case 0:
                    pictureBox2.Image = semaforo.Properties.Resources.amarillo;
                    pictureBox3.Image = semaforo.Properties.Resources.amarillo;
                    timer2.Interval = 3000;
                    servicio = 1;
                    break;
                case 1:
                    pictureBox2.Image = semaforo.Properties.Resources.apagado;
                    pictureBox3.Image = semaforo.Properties.Resources.apagado;
                    timer2.Interval = 3000;
                    servicio = 0;
                    break;
            }
        }

        private void btservicio_Click_1(object sender, EventArgs e)
        {
            switch (prenderservicio)
            {
                case 0:
                    timer1.Stop();
                    timer2.Start();
                    btservicio.Text = "volver a servicio";
                    prenderservicio = 1;
                    break;
                case 1:
                    timer1.Start();
                    timer2.Stop();
                    btservicio.Text = "fuera de servicio";
                    prenderservicio = 0;
                    pictureBox2.Image = semaforo.Properties.Resources.apagado;
                    pictureBox3.Image = semaforo.Properties.Resources.apagado;
                    break;
            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour <= 23)
            {
                
                switch (prenderauto)
                {
                    case 0:
                        pictureBox2.Image = semaforo.Properties.Resources.rojo;
                        pictureBox3.Image = semaforo.Properties.Resources.verde;
                        timer3.Interval = 3000;
                        prenderauto = 1;
                        break;
                    case 1:
                        pictureBox2.Image = semaforo.Properties.Resources.amarillo;
                        pictureBox3.Image = semaforo.Properties.Resources.amarillo;
                        timer3.Interval = 3000;
                        prenderauto = 2;
                        break;
                    case 2:
                        pictureBox2.Image = semaforo.Properties.Resources.verde;
                        pictureBox3.Image = semaforo.Properties.Resources.rojo;
                        timer3.Interval = 3000;
                        prenderauto = 3;
                        break;
                    case 3:
                        pictureBox2.Image = semaforo.Properties.Resources.amarillo;
                        pictureBox3.Image = semaforo.Properties.Resources.amarillo;
                        timer3.Interval = 3000;
                        prenderauto = 0;
                        break;
                }
            }
            if (DateTime.Now.Hour >= 1 && DateTime.Now.Hour <= 4)
            {
                switch (servicioauto)
                {
                    case 0:
                        pictureBox2.Image = semaforo.Properties.Resources.amarillo;
                        pictureBox3.Image = semaforo.Properties.Resources.amarillo;
                        timer3.Interval = 3000;
                        servicioauto = 1;
                        break;
                    case 1:
                        pictureBox2.Image = semaforo.Properties.Resources.apagado;
                        pictureBox3.Image = semaforo.Properties.Resources.apagado;
                        timer3.Interval = 3000;
                        servicioauto = 0;
                        break;
                }
            }
        }        
        }
    }


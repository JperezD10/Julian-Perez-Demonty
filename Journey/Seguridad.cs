using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journey
{
    public partial class Seguridad : Form
    {
        private int xClick;
        private int yClick;
        WindowsAnimation windowsAnimation = new WindowsAnimation();
        BLL.Gestor_BLL gestor = new BLL.Gestor_BLL();
        public Seguridad()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left += (e.X - xClick); this.Top += (e.Y - yClick); }
        }
        private void Seguridad_Load(object sender, EventArgs e)
        {
            windowsAnimation.animacionAbrir(this.Handle, 350);            
            foreach (Control control in this.Controls)
            {
                if (control is CU.RegisterControl)
                {
                    ((CU.RegisterControl)control).setReadOnly();
                }

            }
            regUsuario.Texto = Properties.Settings.Default.nombreUsuario;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            windowsAnimation.animacionCerrar(this.Handle, 350);
            menu.Show();
            this.Close();
        }

        private void Seguridad_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void BtnEditarPassActual_Click(object sender, EventArgs e)
        {
            regPassActual.setReadOnlyFalse();
        }

        private void BtnPassNuevo_Click(object sender, EventArgs e)
        {
            regPassNuevo.setReadOnlyFalse();
        }

        private void BtnRepetirPass_Click(object sender, EventArgs e)
        {
            regPassRepetir.setReadOnlyFalse();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            changePass();
        }

        private void changePass()
        {
            bool ok = true;
            foreach (Control control in this.Controls)
            {
                if (control is CU.RegisterControl)
                {
                    ok = ((CU.RegisterControl)control).validarData() && ok;
                }
            }
            if (ok)
            {
                try
                {
                    if (comprobarPassActual().Equals(true))
                    {

                        if (comprobarPassNuevo().Equals(true))
                        {
                            gestor.updatePassword(gestor.generarHash(regPassRepetir.Texto, Properties.Settings.Default.nombreUsuario)
                            , Properties.Settings.Default.nombreUsuario);
                        }
                        else
                        {
                            MessageBox.Show("Se ha ingresado el password a repetir erroneo.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El password actual no es correcto.");
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios.");
            }
        }

        private bool comprobarPassActual()
        {
            string hashed = gestor.getUserPassword(Properties.Settings.Default.nombreUsuario);
            string compare = gestor.generarHash(regPassActual.Texto, Properties.Settings.Default.nombreUsuario);
            if (compare.Equals(hashed))
            {
                return true;
            }
            return false;
        }

        private bool comprobarPassNuevo()
        {
            if (regPassRepetir.Texto.Equals(regPassNuevo.Texto))
            { 
                return true;
            }
            return false;
        }
    }
}

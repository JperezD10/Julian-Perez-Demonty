using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_2
{
    public partial class LogIn : Form
    {
       
        public LogIn()
        {
            InitializeComponent();
           
        }
        BLL.Usuario_BLL gestor = new BLL.Usuario_BLL();

        private void btEntrar_Click(object sender, EventArgs e)
        {
            login();
        }
        
        void limpiar()
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
        }
        BLL.Seguridad_BLL seguridad = new BLL.Seguridad_BLL();
        void login()
        {
            BE.Usuarios user = new BE.Usuarios();
            user._NombreUsuario = txtUsuario.Text;
            user._Constraseña = seguridad.generarHASH(txtContraseña.Text);
            if (gestor.iniciarSesion(user) == true)
            {
                MessageBox.Show("ingreso correctamente","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                user._IdReferente = gestor.IDreferente(user);

                    if (user._IdReferente == 1)
                    {
                        frmAdministrativo ad = new frmAdministrativo(this);
                        ad.Show();
                        this.Hide();
                    }
                    else if (user._IdReferente == 2)
                    {
                        PonerNotas p = new PonerNotas(this);
                        p.Show();
                        this.Hide();

                    }
                    else
                    {
                    VerNotas a = new VerNotas(this);
                    a.Show();
                    this.Hide();
                    }
                txtUsuario.Clear();
                txtContraseña.Clear();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                limpiar();
                txtUsuario.Focus();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void lblNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse r = new Registrarse(this);
            r.ShowDialog();
        }
    }
}

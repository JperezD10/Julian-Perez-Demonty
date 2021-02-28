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
    public partial class Registrarse : Form
    {
        LogIn l;
        public Registrarse(LogIn l)
        {
            InitializeComponent();
            this.l = l;
        }
        BLL.Usuario_BLL usuario = new BLL.Usuario_BLL();
        BLL.Seguridad_BLL seguridad = new BLL.Seguridad_BLL();
        private void Registrarse_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Usuarios temp = new BE.Usuarios();
                temp._NombreUsuario = txtNombre.Text;
                temp._Constraseña = seguridad.generarHASH(txtCotnraseña.Text);
                if (comboBox1.SelectedIndex == 0)
                {
                    temp._IdReferente = 1;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    temp._IdReferente = 2;
                }
                else
                {
                    temp._IdReferente = 3;
                }
                usuario.Registrar(temp);
                MessageBox.Show("Usuario creado con exito","Realizacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("El nombre de usuario ya existe", "Nombre incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

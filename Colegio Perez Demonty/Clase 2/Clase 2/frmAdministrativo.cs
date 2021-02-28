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
    public partial class frmAdministrativo : Form
    {
        LogIn L;
        public frmAdministrativo(LogIn L)
        {
            InitializeComponent();
            this.L = L;
        }

        private void frmAdministrativo_Load(object sender, EventArgs e)
        {
            cmbEfectuar.SelectedIndex = 0;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            L.Show();
        }

        private void btEfectuar_Click(object sender, EventArgs e)
        {
            if (cmbEfectuar.SelectedIndex == 0)
            {
                GestionarAlumnos ga = new GestionarAlumnos(this);
                ga.Show();
                this.Hide();
            }
            else if (cmbEfectuar.SelectedIndex == 1)
            {
                GestionarMateria materias = new GestionarMateria(this);
                materias.Show();
                this.Hide();
            }
            else if (cmbEfectuar.SelectedIndex == 2)
            {
                AdministrarProfesor profes = new AdministrarProfesor(this);
                profes.Show();
                this.Hide();
            }
            else
            {
                AsignarProfeMaterias apm = new AsignarProfeMaterias(this);
                apm.Show();
                this.Hide();
            }
        }
    }
}

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
    public partial class AsignarProfeMaterias : Form
    {
        frmAdministrativo a;
        public AsignarProfeMaterias(frmAdministrativo a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void grillaProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           BE.Profesor temp = (BE.Profesor)grillaProfesor.Rows[e.RowIndex].DataBoundItem;
            txtIDProfesor.Text = temp._IDProfesor.ToString();
        }

        private void GrillaMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Materia temp = (BE.Materia)GrillaMateria.Rows[e.RowIndex].DataBoundItem;
            txtIDMateria.Text = temp._IDMateria.ToString();
        }
        BLL.Profesor_BLL gestorProfe = new BLL.Profesor_BLL();
        BLL.Materia_BLL gestorMateria = new BLL.Materia_BLL();
        private void btAsignar_Click(object sender, EventArgs e)
        {
            if (txtIDMateria.Text=="" || txtIDProfesor.Text == "")
            {
                MessageBox.Show("Faltan Completar Campos");
            }
            else
            {
                BE.Profesor_Materia temp = new BE.Profesor_Materia();
                BLL.profe_mat_BLL gestor = new BLL.profe_mat_BLL();
                temp._IDMateria = int.Parse(txtIDMateria.Text);
                temp._IDProfesor = int.Parse(txtIDProfesor.Text);
                try
                {
                    gestor.Agregar(temp);
                    MessageBox.Show("Asignado");
                    txtIDProfesor.Clear();
                    txtIDMateria.Clear();
                }
                catch
                {

                }
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            a.Show();
        }

        private void AsignarProfeMaterias_Load(object sender, EventArgs e)
        {
            GrillaMateria.DataSource = null;
            grillaProfesor.DataSource = null;
            grillaProfesor.DataSource = gestorProfe.Listar();
            GrillaMateria.DataSource = gestorMateria.Listar();
        }
    }
}

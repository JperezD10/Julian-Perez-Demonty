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
    public partial class GestionarMateria : Form
    {
        frmAdministrativo a;
        public GestionarMateria(frmAdministrativo a)
        {
            InitializeComponent();
            this.a = a;
        }
        BE.Materia temp;
        BLL.Materia_BLL gestor = new BLL.Materia_BLL();
        private void GestionarMateria_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btAgregarMateria_Click(object sender, EventArgs e)
        {
            bool ok = true;

            foreach (Control ctr in this.Controls)
            {
                if (ctr is ControlUsuario)
                {
                    ok = ((ControlUsuario)ctr).Validar() && ok;

                }

            }
            if (ok)
            {
                temp = new BE.Materia();
                temp._IDMateria = 0;
                temp._NombreMateria = controlNombreMateria.Texto;
                try
                {
                    gestor.Agregar(temp);
                    MessageBox.Show("Materia Agregada");
                    txtIDMateria.Clear();
                    controlNombreMateria.Texto = "";
                }
                catch
                {

                }
                temp = null;
                ActualizarGrilla();
            }
        }

        private void btModificarMateria_Click(object sender, EventArgs e)
        {
            if (txtIDMateria.Text == "")
            {
                MessageBox.Show("Debe elegir la materia a modificar");
            }
            else
            {
                bool ok = true;

                foreach (Control ctr in this.Controls)
                {
                    if (ctr is ControlUsuario)
                    {
                        ok = ((ControlUsuario)ctr).Validar() && ok;

                    }

                }
                if (ok)
                {
                    temp = new BE.Materia();
                    temp._IDMateria = int.Parse(txtIDMateria.Text);
                    temp._NombreMateria = controlNombreMateria.Texto;
                    try
                    {
                        gestor.Modificar(temp);
                        MessageBox.Show("Materia Modificada");
                        txtIDMateria.Clear();
                        controlNombreMateria.Texto = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ActualizarGrilla();
                }
            }
            
        }

        private void btELiminarMateria_Click(object sender, EventArgs e)
        {
            if (txtIDMateria.Text == "")
            {
                MessageBox.Show("Debe elegir la materia a Eliminar");
            }
            else
            {
                bool ok = true;

                foreach (Control ctr in this.Controls)
                {
                    if (ctr is ControlUsuario)
                    {
                        ok = ((ControlUsuario)ctr).Validar() && ok;

                    }

                }
                if (ok)
                {
                    temp = new BE.Materia();
                    temp._IDMateria = int.Parse(txtIDMateria.Text);
                    try
                    {
                        gestor.Eliminar(temp);
                        MessageBox.Show("Materia Eliminada");
                        txtIDMateria.Clear();
                        controlNombreMateria.Texto = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ActualizarGrilla();
                }
            }
            
        }
        void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.Listar();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            a.Show();
        }
        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            temp = (BE.Materia)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtIDMateria.Text = temp._IDMateria.ToString();
            controlNombreMateria.Texto = temp._NombreMateria;
        }

        private void txtIDMateria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

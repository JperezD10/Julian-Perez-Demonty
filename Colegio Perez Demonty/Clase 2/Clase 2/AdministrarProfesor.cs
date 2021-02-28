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
    public partial class AdministrarProfesor : Form
    {
        frmAdministrativo a;
        public AdministrarProfesor(frmAdministrativo a)
        {
            InitializeComponent();
            this.a = a;
        }
        BE.Profesor temp;
        BLL.Profesor_BLL gestor = new BLL.Profesor_BLL();
        private void btAgregarProfe_Click(object sender, EventArgs e)
        {
            if(controlNombreProfe.Texto == "")
            {
                MessageBox.Show("Faltan Completar Campos");
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
                    temp = new BE.Profesor();
                    temp._IDProfesor = 0;
                    temp._NombreProfesor = controlNombreProfe.Texto;
                    try
                    {
                        gestor.Agregar(temp);
                        MessageBox.Show("Profesor Agregado");
                        txtIDProfesor.Clear();
                        controlNombreProfe.Texto = "";
                    }
                    catch
                    {

                    }
                    temp = null;
                }
            }
            
            ActualizarGrilla();
        }

        private void btChauProfe_Click(object sender, EventArgs e)
        {
            if (txtIDProfesor.Text == "" || controlNombreProfe.Texto == "")
            {
                MessageBox.Show("Faltan Completar Campos");
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
                    temp = new BE.Profesor();
                    temp._IDProfesor = int.Parse(txtIDProfesor.Text);
                    try
                    {
                        gestor.Eliminar(temp);
                        MessageBox.Show("profesor Eliminado");
                        txtIDProfesor.Clear();
                        controlNombreProfe.Texto = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ActualizarGrilla();
                }
            }
            
        }

        private void btModificarProfe_Click(object sender, EventArgs e)
        {
            if (txtIDProfesor.Text == "" || controlNombreProfe.Texto == "")
            {
                MessageBox.Show("Faltan Completar Campos");
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
                    temp = new BE.Profesor();
                    temp._IDProfesor = int.Parse(txtIDProfesor.Text);
                    temp._NombreProfesor = controlNombreProfe.Texto;
                    try
                    {
                        gestor.Modificar(temp);
                        MessageBox.Show("Profesor Modificado");
                        txtIDProfesor.Clear();
                        controlNombreProfe.Texto = "";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = (BE.Profesor)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtIDProfesor.Text = temp._IDProfesor.ToString();
            controlNombreProfe.Texto = temp._NombreProfesor;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            a.Show();
        }

        private void AdministrarProfesor_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

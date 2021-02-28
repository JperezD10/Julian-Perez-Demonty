using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Clase_2
{
    public partial class GestionarAlumnos : Form
    {
        frmAdministrativo a;
        public GestionarAlumnos(frmAdministrativo a)
        {
            InitializeComponent();
            this.a = a;
        }
        BE.ALUMNO temp;
        BLL.Alumno gestor = new BLL.Alumno();
        void Enlazar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            MostrarEdades();
        }

      
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if(controlNumericoEdad.Texto=="" || controlUsuarioNombre.Texto=="" || controlUsuarioApellido.Texto == "")
            {
                MessageBox.Show("Faltan completar campos");
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
                    temp = new BE.ALUMNO();

                    temp._Id = 0;
                    temp._Nombre = controlUsuarioNombre.Texto;
                    temp._Apellido = controlUsuarioApellido.Texto;
                    temp._Edad = int.Parse(controlNumericoEdad.Texto);
                    try
                    {
                        gestor.Agregar(temp);
                        MessageBox.Show("Agregado correctamente");
                        controlUsuarioApellido.Texto = controlNumericoEdad.Texto = controlUsuarioNombre.Texto = "";
                    }
                    catch (Exception)
                    {

                    }
                    temp = null;
                }
            }
            
            ActualizarGrilla();
            MostrarEdades();
        }
       
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDALumno.Text == "")
            {
                MessageBox.Show("Debe elegir el alumno a eliminar");
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
                    temp = new BE.ALUMNO();
                    temp._Id = int.Parse(txtIDALumno.Text);

                    try
                    {
                        gestor.Eliminar(temp);
                        MessageBox.Show("Eliminado correctamente");
                        txtIDALumno.Text = controlUsuarioApellido.Texto = controlNumericoEdad.Texto = controlUsuarioNombre.Texto = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
           
            ActualizarGrilla();
            MostrarEdades();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (controlNumericoEdad.Texto == "" || controlUsuarioNombre.Texto == "" || controlUsuarioApellido.Texto == "")
            {
                MessageBox.Show("Faltan completar campos");
            }
            else if (txtIDALumno.Text == "")
            {
                MessageBox.Show("Debe elegir el ID del Alumno a modificar");
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
                    temp = new BE.ALUMNO();
                    temp._Id = int.Parse(txtIDALumno.Text);
                    temp._Nombre = controlUsuarioNombre.Texto;
                    temp._Apellido = controlUsuarioApellido.Texto;
                    temp._Edad = int.Parse(controlNumericoEdad.Texto);
                    try
                    {
                        gestor.Editar(temp);
                        MessageBox.Show("Modificado correctamente");
                        txtIDALumno.Text = controlUsuarioApellido.Texto = controlNumericoEdad.Texto = controlUsuarioNombre.Texto = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            
            ActualizarGrilla();
            MostrarEdades();

        }
        void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.Listar();
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            temp = (BE.ALUMNO)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtIDALumno.Text = temp._Id.ToString();
            controlUsuarioNombre.Texto = temp._Nombre;
            controlUsuarioApellido.Texto = temp._Apellido;
            controlNumericoEdad.Texto = temp._Edad.ToString();
        }
        void MostrarEdades()
        {
            int promEdad = gestor.PromedioEdad(temp);
            int Maxima = gestor.EdadMaxima(temp);
            int Minima = gestor.EdadMinima(temp);
            lblPromedio.Text = promEdad.ToString();
            lblMaxima.Text = Maxima.ToString();
            lblMinimo.Text = Minima.ToString();
        }
        private void controlNumericoLegajo_Load(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            a.Show();
        }
    }
}

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
    public partial class PonerNotas : Form
    {
        LogIn l;
        public PonerNotas(LogIn l)
        {
            InitializeComponent();
            this.l = l;
        }
        BLL.Alumno gestorAlumno = new BLL.Alumno();
        BLL.Materia_BLL gestorMateria = new BLL.Materia_BLL();
        private void PonerNotas_Load(object sender, EventArgs e)
        {
            cmbInstancia.SelectedIndex = 0;
            GrillaAlumno.DataSource = null;
            GrillaMateria.DataSource = null;
            GrillaMateria.DataSource = gestorMateria.Listar();
            GrillaAlumno.DataSource = gestorAlumno.Listar();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Close();
        }

        private void GrillaAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.ALUMNO temp = (BE.ALUMNO)GrillaAlumno.Rows[e.RowIndex].DataBoundItem;
            txtIDAlumno.Text = temp._Id.ToString();
        }

        private void GrillaMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Materia temp = (BE.Materia)GrillaMateria.Rows[e.RowIndex].DataBoundItem;
            txtIDMateria.Text = temp._IDMateria.ToString();
        }
        BLL.Nota_BLL gestor = new BLL.Nota_BLL();
        private void button1_Click(object sender, EventArgs e)
        {
            int instancia;
            if (cmbInstancia.SelectedIndex == 0)
            {
                instancia = 1;
            }
            else if (cmbInstancia.SelectedIndex == 1)
            {
                instancia = 2;
            }
            else
            {
                instancia = 3;
            }
            if(txtIDAlumno.Text=="" || txtIDMateria.Text=="" || controlNumericoNotas.Texto =="")
            {
                MessageBox.Show("Faltan Completar Campos");
            }
            else
            {
                if (int.Parse(controlNumericoNotas.Texto) <= 1 || int.Parse(controlNumericoNotas.Texto) > 10)
                {
                    MessageBox.Show("Solo notas de 1 a 10");
                    controlNumericoNotas.Texto = "";
                }
                else
                {
                    BE.Nota temp = new BE.Nota();
                    temp._IDNota = 0;
                    temp._IDAlumno = int.Parse(txtIDAlumno.Text);
                    temp._IDMateria = int.Parse(txtIDMateria.Text);
                    temp._Intancia = instancia;
                    temp._NotaNumerica = int.Parse(controlNumericoNotas.Texto);
                    try
                    {
                        gestor.AgregarNota(temp);
                        MessageBox.Show("Nota Agregada");
                        gestor.DesaprobadorPrimerParcial();
                        gestor.DesaprobadosSegundoParcial();
                        gestor.DesaprobadosTP();
                        txtIDAlumno.Clear();
                        txtIDMateria.Clear();
                        controlNumericoNotas.Texto = "";
                    }
                    catch
                    {
                        MessageBox.Show("error");
                    }
                }
               
            }
            
        }
    }
}

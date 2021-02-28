using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;

namespace Jardin
{
    public partial class Imprimir_Boleta : Form
    {
        Form1 Contexto;
        public Imprimir_Boleta(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }

        private void Imprimir_Boleta_Load(object sender, EventArgs e)
        {

        }

        private void CmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbSalon.SelectedIndex)
            {

                case 0:
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[0].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[0].Inscriptos;


                    }
                    break;
                case 1:                   
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[1].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[1].Inscriptos;


                    }
                    break;
                case 2:
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[2].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[2].Inscriptos;


                    }
                    break;
                case 3:
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[3].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[3].Inscriptos;


                    }
                    break;
                case 4:
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[4].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[4].Inscriptos;


                    }
                    break;
                default:
                    break;

            }
        }

        Inscripcion Alumno;

        private void dataGridViewInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno = (Inscripcion)dataGridViewInscripciones.Rows[e.RowIndex].DataBoundItem;
            LblNombre.Text = Alumno.Nombre;
            LblApellido.Text = Alumno.Apellido;
            LblCurso.Text = CmbSalon.Text;
            LblEdad.Text = Alumno.Edad.ToString() + "Meses";
            LblTotal.Text = Alumno.Cuota.ToString();
            LblTurno.Text = Alumno.Turno;
            LblTotal2.Text = Alumno.Cuota.ToString();

        }
    }
}

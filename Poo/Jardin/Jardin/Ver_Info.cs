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
    public partial class Ver_Info : Form
    {
        Form1 Contexto;
        public Ver_Info(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }
        
        private void Ver_Info_Load(object sender, EventArgs e)
        {
            DgVSalas.DataSource = Contexto.Jardines.Salitas;
            LblGnanciaTotal.Text = Contexto.Jardines.GananciaMensual().ToString();
        }

        private void CmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbSalon.SelectedIndex)
            {

                case 0:
                    DatagrivewMaestras.DataSource = null;
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Maestra S in Contexto.Jardines.Salitas[0].Maestras)
                    {

                        DatagrivewMaestras.DataSource = Contexto.Jardines.Salitas[0].Maestras;


                    }
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[0].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[0].Inscriptos;


                    }
                    break;
                case 1:
                    DatagrivewMaestras.DataSource = null;
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Maestra S in Contexto.Jardines.Salitas[1].Maestras)
                    {

                        DatagrivewMaestras.DataSource = Contexto.Jardines.Salitas[1].Maestras;


                    }
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[1].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[1].Inscriptos;


                    }
                    break;
                case 2:
                    DatagrivewMaestras.DataSource = null;
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Maestra S in Contexto.Jardines.Salitas[2].Maestras)
                    {

                        DatagrivewMaestras.DataSource = Contexto.Jardines.Salitas[2].Maestras;


                    }
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[2].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[2].Inscriptos;


                    }
                    break;
                case 3:
                    DatagrivewMaestras.DataSource = null;
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Maestra S in Contexto.Jardines.Salitas[3].Maestras)
                    {

                        DatagrivewMaestras.DataSource = Contexto.Jardines.Salitas[3].Maestras;


                    }
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[3].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[3].Inscriptos;


                    }
                    break;
                case 4:
                    DatagrivewMaestras.DataSource = null;
                    dataGridViewInscripciones.DataSource = null;
                    foreach (Maestra S in Contexto.Jardines.Salitas[4].Maestras)
                    {

                        DatagrivewMaestras.DataSource = Contexto.Jardines.Salitas[4].Maestras;


                    }
                    foreach (Inscripcion S in Contexto.Jardines.Salitas[4].Inscriptos)
                    {

                        dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[4].Inscriptos;


                    }
                    break;
                default:
                    break;

            }



        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewInscripciones.SelectedRows.Count > 0)
            {
                Contexto.Jardines.Salitas[CmbSalon.SelectedIndex].Inscriptos.RemoveAt(this.dataGridViewInscripciones.SelectedRows[0].Index);
            }
            Contexto.Jardines.Salitas[CmbSalon.SelectedIndex].CantAlumnos--;
            dataGridViewInscripciones.DataSource = null;
            foreach (Inscripcion S in Contexto.Jardines.Salitas[CmbSalon.SelectedIndex].Inscriptos)
            {

                dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[CmbSalon.SelectedIndex].Inscriptos;


            }
            DgVSalas.DataSource = null;
            DgVSalas.DataSource = Contexto.Jardines.Salitas;
        }

        private void BtnOrdenarApellido_Click(object sender, EventArgs e)
        {
            Contexto.Jardines.Salitas[CmbSalon.SelectedIndex].Inscriptos.Sort();
            dataGridViewInscripciones.DataSource = null;
            foreach (Inscripcion S in Contexto.Jardines.Salitas[CmbSalon.SelectedIndex].Inscriptos)
            {

                dataGridViewInscripciones.DataSource = Contexto.Jardines.Salitas[CmbSalon.SelectedIndex].Inscriptos;


            }
        }
    }
}

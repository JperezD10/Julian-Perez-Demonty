using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public List<Persona> Personas = new List<Persona>();

        private void button1_Click(object sender, EventArgs e) //agregar
        { 
            Persona p = new Persona();
            bool v = false;
            p.Legajo = int.Parse(txtLegajo.Text);
            p.Nombre = txtNombre.Text;
            foreach(Persona pers in Personas)
            {
                v = pers.Legajo.Equals(p.Legajo);
            }
            if (!v)
            {
                Personas.Add(p);
            }
            else
            {
                MessageBox.Show("ya existe");
            }
            resetGrilla();
           
          
        }

        private void button1_Click_1(object sender, EventArgs e) //modificar
        {
            if (this.Grilla.SelectedRows.Count > 0)
            {
                Personas.ElementAt(this.Grilla.SelectedRows[0].Index).Nombre = txtNombre.Text;
            }
            resetGrilla();


        }

        private void resetGrilla()
        {
            Grilla.DataSource = null;
            Grilla.DataSource = Personas;
            txtLegajo.Text = txtNombre.Text = "";
        }
        private void Grilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

       
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (this.Grilla.SelectedRows.Count > 0)
            {
               Personas.RemoveAt( this.Grilla.SelectedRows[0].Index);
            }
            resetGrilla();

        }
        Persona per;
        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Grilla.SelectedRows.Count > 0)
            {
                per = (Persona)Grilla.Rows[e.RowIndex].DataBoundItem;
                txtLegajo.Text = per.Legajo.ToString();
                txtNombre.Text = per.Nombre;
            }
        }
    }
}

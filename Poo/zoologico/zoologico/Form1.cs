using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoologico
{
    public partial class Form1 : Form
    {
        museo zoologico= new museo();
        sector sector;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sector = new acuatico("acuatico");
            sector = new terrestre("terrestre");
            sector = new aire("aire");
            cmbAlimentacion.Items.Add("carnivoro");
            cmbAlimentacion.Items.Add("herbivoro");
            cmbAlimentacion.Items.Add("omnivoro");
            cmbHabitat.Items.Add("acuatico");
            cmbHabitat.Items.Add("aire");
            cmbHabitat.Items.Add("terrestre");
            cmbHabitat.Enabled = cmbAlimentacion.Enabled = cbbipedo.Enabled = cbcuadrupedo.Enabled
                = cbexoesqueleto.Enabled=nudDistancia.Enabled= nudVelocidad.Enabled=lblDistancia.Enabled=lblVelocidad.Enabled = false;
            txtNombreAnimal.Select();
        }

        private void txtNombreAnimal_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreAnimal != null) cmbHabitat.Enabled = cmbAlimentacion.Enabled = true;
        }

        private void cmbHabitat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHabitat.SelectedItem.Equals("terrestre"))
            {
                cbbipedo.Enabled = cbcuadrupedo.Enabled = cbexoesqueleto.Enabled = true;
                nudDistancia.Enabled = nudVelocidad.Enabled = lblDistancia.Enabled = lblVelocidad.Enabled = false;
            }
            else if (cmbHabitat.SelectedItem.Equals("aire"))
            {
                cbbipedo.Enabled = cbcuadrupedo.Enabled = cbexoesqueleto.Enabled = false;
                nudDistancia.Enabled = nudVelocidad.Enabled = lblDistancia.Enabled = lblVelocidad.Enabled = true;
            }
            else
            {
                cbbipedo.Enabled = cbcuadrupedo.Enabled = cbexoesqueleto.Enabled = false;
                nudDistancia.Enabled = nudVelocidad.Enabled = lblDistancia.Enabled = lblVelocidad.Enabled = false;
            }
                
        }

        private void btCargarAnimal_Click(object sender, EventArgs e)
        {
            animal animal= new animal(txtNombreAnimal.Text, cmbHabitat.SelectedItem.ToString(), cmbAlimentacion.SelectedItem.ToString(), int.Parse(nudExistencia.ToString()));
            if (txtNombreAnimal.Text!= null && cmbAlimentacion.SelectedItem!= null && cmbHabitat.SelectedItem!= null && nudExistencia.Value>0 )
            {
                if (cmbHabitat.SelectedItem.Equals("terrestre"))
                {
                    if (cbbipedo.Checked) animal.PATAS = cbbipedo.Text;
                    else if (cbcuadrupedo.Checked) animal.PATAS = cbcuadrupedo.Text;
                    else animal.PATAS = "sin patas";
                    if (cbexoesqueleto.Checked) animal.EXOESQUELETO = true;
                    else animal.EXOESQUELETO = false;
                }
                else if (cmbHabitat.SelectedItem.Equals("aire"))
                {
                    animal.DISTANCIAVISION = int.Parse(nudDistancia.ToString());
                    animal.VELOCIDAD = int.Parse(nudVelocidad.ToString());
                }
              zoologico.agregarAnimales(animal);
            }
            else
            {
                MessageBox.Show("faltan datos");
            }
        }

        private void cbbipedo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbipedo.Checked) cbcuadrupedo.Enabled = false;
            else cbcuadrupedo.Enabled = true;
        }

        private void cbcuadrupedo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcuadrupedo.Checked) cbbipedo.Enabled = false;
            else cbbipedo.Enabled = true;
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarEntrada ventana = new ComprarEntrada(zoologico,this);
            ventana.Show();
            this.Hide();
        }
    }
}

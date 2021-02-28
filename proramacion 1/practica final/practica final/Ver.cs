using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace practica_final
{
    public partial class Ver : Form
    {
        public Ver()
        {
            InitializeComponent();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int promtotal = 0, cantpersonas = 0, promfinal = 0, Promedio = 0;

        void Listar()
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final/Alumnos.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            listViewProg.Items.Clear();
            listViewSist.Items.Clear();
            listViewRedes.Items.Clear();
            String[] vectorRegistro;
            string registro, legajo="", edad, nombre="", sexo, curso, parcial1, parcial2, tp, promedio;
            while (SR.Peek() != -1)
            {
                registro = SR.ReadLine();
                vectorRegistro = registro.Split(';');
                legajo = vectorRegistro[0];
                nombre = vectorRegistro[1];
                edad = vectorRegistro[2];
                sexo = vectorRegistro[3];
                curso = vectorRegistro[4];
                parcial1 = vectorRegistro[5];
                parcial2 = vectorRegistro[6];
                tp = vectorRegistro[7];
                promedio = vectorRegistro[8];
                cantpersonas++;
                promtotal = promtotal + int.Parse(promedio);
                promfinal = promtotal / cantpersonas;
                ListViewItem listItem = new ListViewItem(legajo);
                listItem.SubItems.Add(nombre);
                listItem.SubItems.Add(edad);
                listItem.SubItems.Add(sexo);
                listItem.SubItems.Add(curso);
                listItem.SubItems.Add(parcial1);
                listItem.SubItems.Add(parcial2);
                listItem.SubItems.Add(tp);
                listItem.SubItems.Add(promedio);
                if (curso == "Programacion")
                {
                    
                    listViewProg.Items.Add(listItem);
                }
                else if (curso == "Sistemas")
                {
                    listViewSist.Items.Add(listItem);
                }
                else if(curso=="Redes")
                {
                    listViewRedes.Items.Add(listItem);
                }
            }
            SR.Close();
            FS.Close();
        }

        private void Ver_Load(object sender, EventArgs e)
        {
            Listar();
            lblCantidad.Text = cantpersonas.ToString();
            lblPromedio.Text = promfinal.ToString();
        }

        private void listViewProg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProg.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewProg.SelectedItems[0];

                txtLegajo.Text = listItem.Text;
                txtNombre.Text = listItem.SubItems[1].Text;
                txtEdad.Text = listItem.SubItems[2].Text;
                cmbSexo.Text = listItem.SubItems[3].Text;
                cmbCurso.Text = listItem.SubItems[4].Text;
                txtParcial1.Text = listItem.SubItems[5].Text;
                txtParcial2.Text = listItem.SubItems[6].Text;
                txtTp.Text = listItem.SubItems[7].Text;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (listViewProg.SelectedItems.Count > 0)
            {
                listViewProg.SelectedItems[0].SubItems[0].Text = txtLegajo.Text;
                listViewProg.SelectedItems[0].SubItems[1].Text = txtNombre.Text;
                listViewProg.SelectedItems[0].SubItems[2].Text = txtEdad.Text;
                listViewProg.SelectedItems[0].SubItems[3].Text = cmbSexo.Text;
                listViewProg.SelectedItems[0].SubItems[4].Text = cmbCurso.Text;
                listViewProg.SelectedItems[0].SubItems[5].Text = txtParcial1.Text;
                listViewProg.SelectedItems[0].SubItems[6].Text = txtParcial2.Text;
                listViewProg.SelectedItems[0].SubItems[7].Text = txtTp.Text;
                listViewProg.SelectedItems[0].SubItems[8].Text = Promedio.ToString();
                FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final/Alumnos.txt", FileMode.Open);
                StreamWriter SW = new StreamWriter(FS);
                string reg;
                Promedio = (int.Parse(txtParcial1.Text) + int.Parse(txtParcial2.Text) + int.Parse(txtTp.Text)) / 3;
                foreach (ListViewItem Listitem in listViewProg.Items)
                {
                    reg = Listitem.SubItems[0].Text + ";" + Listitem.SubItems[1].Text + ";" + Listitem.SubItems[2].Text + ";" + Listitem.SubItems[3].Text + ";"
                        + Listitem.SubItems[4].Text + ";" + Listitem.SubItems[5].Text + ";" + Listitem.SubItems[6].Text + ";" + Listitem.SubItems[7].Text +
                         ";" + Promedio;
                    SW.WriteLine(reg);
                }
                
                SW.Close();
                FS.Close();
            }
            else if (listViewSist.SelectedItems.Count > 0)
            { listViewSist.SelectedItems[0].SubItems[0].Text = txtNombre.Text;
            listViewSist.SelectedItems[0].SubItems[1].Text = txtNombre.Text;
            listViewSist.SelectedItems[0].SubItems[2].Text = txtEdad.Text;
            listViewSist.SelectedItems[0].SubItems[3].Text = cmbSexo.Text;
            listViewSist.SelectedItems[0].SubItems[4].Text = cmbCurso.Text;
            listViewSist.SelectedItems[0].SubItems[5].Text = txtParcial1.Text;
            listViewSist.SelectedItems[0].SubItems[6].Text = txtParcial2.Text;
            listViewSist.SelectedItems[0].SubItems[7].Text = txtTp.Text;
            listViewSist.SelectedItems[0].SubItems[8].Text = Promedio.ToString();
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final/Alumnos.txt", FileMode.Open);
            StreamWriter SW = new StreamWriter(FS);
            string reg;
                Promedio = (int.Parse(txtParcial1.Text) + int.Parse(txtParcial2.Text) + int.Parse(txtTp.Text)) / 3;
                foreach (ListViewItem Listitem in listViewSist.Items)
            {
                reg = Listitem.SubItems[0].Text + ";" + Listitem.SubItems[1].Text + ";" + Listitem.SubItems[2].Text + ";" + Listitem.SubItems[3].Text + ";"
                    + Listitem.SubItems[4].Text + ";" + Listitem.SubItems[5].Text + ";" + Listitem.SubItems[6].Text + ";" + Listitem.SubItems[7].Text +
                     ";" + Promedio;
                SW.WriteLine(reg);
                }
                
                SW.Close();
            FS.Close();
        }
        else if (listViewRedes.SelectedItems.Count > 0)
            {
                listViewRedes.SelectedItems[0].SubItems[0].Text = txtLegajo.Text;
                listViewRedes.SelectedItems[0].SubItems[1].Text = txtNombre.Text;
                listViewRedes.SelectedItems[0].SubItems[2].Text = txtEdad.Text;
                listViewRedes.SelectedItems[0].SubItems[3].Text = cmbSexo.Text;
                listViewRedes.SelectedItems[0].SubItems[4].Text = cmbCurso.Text;
                listViewRedes.SelectedItems[0].SubItems[5].Text = txtParcial1.Text;
                listViewRedes.SelectedItems[0].SubItems[6].Text = txtParcial2.Text;
                listViewRedes.SelectedItems[0].SubItems[7].Text = txtTp.Text;
                listViewRedes.SelectedItems[0].SubItems[8].Text = Promedio.ToString();
                FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final/Alumnos.txt", FileMode.Open);
                StreamWriter SW = new StreamWriter(FS);
                string reg;
                Promedio = (int.Parse(txtParcial1.Text) + int.Parse(txtParcial2.Text) + int.Parse(txtTp.Text)) / 3;
                foreach (ListViewItem Listitem in listViewRedes.Items)
                {
                    reg = Listitem.SubItems[0].Text + ";" + Listitem.SubItems[1].Text + ";" + Listitem.SubItems[2].Text + ";" + Listitem.SubItems[3].Text + ";"
                        + Listitem.SubItems[4].Text + ";" + Listitem.SubItems[5].Text + ";" + Listitem.SubItems[6].Text + ";" + Listitem.SubItems[7].Text +
                         ";" + Promedio;
                    SW.WriteLine(reg);
                    
                }
                
                SW.Close();
                FS.Close();
            }   
              
            Listar();
            lblPromedio.Text = promfinal.ToString();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final/Alumnos.txt", FileMode.Open);
                StreamWriter SW = new StreamWriter(FS);
            if (listViewProg.SelectedItems.Count > 0)
            {
                foreach (ListViewItem Listitem in listViewProg.SelectedItems)
                {
                    Listitem.Remove();
                }
                txtLegajo.Text = txtNombre.Text = txtEdad.Text = cmbSexo.Text = cmbCurso.Text = txtParcial1.Text = txtParcial2.Text = txtTp.Text = "";
                
                string reg;
                foreach (ListViewItem Listitem in listViewProg.Items)
                {
                    reg = Listitem.SubItems[0].Text + ";" + Listitem.SubItems[1].Text + ";" + Listitem.SubItems[2].Text + ";" + Listitem.SubItems[3].Text + ";"
                        + Listitem.SubItems[4].Text + ";" + Listitem.SubItems[5].Text + ";" + Listitem.SubItems[6].Text + ";" + Listitem.SubItems[7].Text +
                         ";" + Listitem.SubItems[8].Text;
                    SW.WriteLine(reg);
                }
                
            }
            else if (listViewSist.SelectedItems.Count > 0)
            {
                foreach (ListViewItem Listitem in listViewSist.SelectedItems)
                {
                    Listitem.Remove();
                }
                txtLegajo.Text = txtNombre.Text = txtEdad.Text = cmbSexo.Text = cmbCurso.Text = txtParcial1.Text = txtParcial2.Text = txtTp.Text = "";
                string reg;
                foreach (ListViewItem Listitem in listViewSist.Items)
                {
                    reg = Listitem.SubItems[0].Text + ";" + Listitem.SubItems[1].Text + ";" + Listitem.SubItems[2].Text + ";" + Listitem.SubItems[3].Text + ";"
                        + Listitem.SubItems[4].Text + ";" + Listitem.SubItems[5].Text + ";" + Listitem.SubItems[6].Text + ";" + Listitem.SubItems[7].Text +
                         ";" + Listitem.SubItems[8].Text;
                    SW.WriteLine(reg);
                }
              
            }
            else if (listViewRedes.SelectedItems.Count > 0)
            {
                foreach (ListViewItem Listitem in listViewRedes.SelectedItems)
                {
                    Listitem.Remove();
                }
                txtLegajo.Text = txtNombre.Text = txtEdad.Text = cmbSexo.Text = cmbCurso.Text = txtParcial1.Text = txtParcial2.Text = txtTp.Text = "";
                string reg;
                foreach (ListViewItem Listitem in listViewSist.Items)
                {
                    reg = Listitem.SubItems[0].Text + ";" + Listitem.SubItems[1].Text + ";" + Listitem.SubItems[2].Text + ";" + Listitem.SubItems[3].Text + ";"
                        + Listitem.SubItems[4].Text + ";" + Listitem.SubItems[5].Text + ";" + Listitem.SubItems[6].Text + ";" + Listitem.SubItems[7].Text +
                         ";" + Listitem.SubItems[8].Text;
                    SW.WriteLine(reg);
                }

            }
                SW.Close();
                FS.Close();
            Listar();
            cantpersonas--;
        }

        private void listViewSist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSist.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewSist.SelectedItems[0];

                txtLegajo.Text = listItem.Text;
                txtNombre.Text = listItem.SubItems[1].Text;
                txtEdad.Text = listItem.SubItems[2].Text;
                cmbSexo.Text = listItem.SubItems[3].Text;
                cmbCurso.Text = listItem.SubItems[4].Text;
                txtParcial1.Text = listItem.SubItems[5].Text;
                txtParcial2.Text = listItem.SubItems[6].Text;
                txtTp.Text = listItem.SubItems[7].Text;
            }
        }

        private void listViewRedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRedes.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewRedes.SelectedItems[0];

                txtLegajo.Text = listItem.Text;
                txtNombre.Text = listItem.SubItems[1].Text;
                txtEdad.Text = listItem.SubItems[2].Text;
                cmbSexo.Text = listItem.SubItems[3].Text;
                cmbCurso.Text = listItem.SubItems[4].Text;
                txtParcial1.Text = listItem.SubItems[5].Text;
                txtParcial2.Text = listItem.SubItems[6].Text;
                txtTp.Text = listItem.SubItems[7].Text;
            }
        }
    }
}

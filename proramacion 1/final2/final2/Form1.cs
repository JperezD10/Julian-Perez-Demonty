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

namespace final2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final2/Alumnos2.txt", FileMode.Append);
            FS.Close();
            cmbCurso.SelectedIndex = cmbSexo.SelectedIndex = 0;
            listar();
            CantidadxMateria();
            lblCantidad.Text = cantpersonas.ToString();
            lblPromedio.Text = promediofinal.ToString();
        }
        int cantProg = 0, cantSis = 0, cantRed = 0, Promedio, promediototal = 0, promediofinal = 0, cantpersonas = 0;
        void listar()
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final2/Alumnos2.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            listView1.Items.Clear();
            String[] vectorRegistro;
            string registro, legajo, nombre, sexo, curso, parcial1, parcial2, tp, promedio;
            while (SR.Peek() != -1)
            {
                registro = SR.ReadLine();
                vectorRegistro = registro.Split(';');
                legajo = vectorRegistro[0];
                nombre = vectorRegistro[1];
                sexo = vectorRegistro[2];
                curso = vectorRegistro[3];
                parcial1 = vectorRegistro[4];
                parcial2 = vectorRegistro[5];
                tp = vectorRegistro[6];
                promedio = vectorRegistro[7];
                cantpersonas++;
                promediototal = promediototal + int.Parse(promedio);
                promediofinal = promediototal / cantpersonas;
                ListViewItem LS = new ListViewItem(legajo);
                LS.SubItems.Add(nombre);
                LS.SubItems.Add(sexo);
                LS.SubItems.Add(curso);
                LS.SubItems.Add(parcial1);
                LS.SubItems.Add(parcial2);
                LS.SubItems.Add(tp);
                LS.SubItems.Add(promedio);
                listView1.Items.Add(LS);
            }
            SR.Close();
            FS.Close();
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            Boolean Existir;
            Existir = Comprobar(txtLegajo.Text);
            if (Existir == true)
            {
                MessageBox.Show("El Legajo ya existe......");
            }
            else
            {
                if (cmbCurso.Text == "Programacion 1")
                {
                    if (cantProg <= 5)
                    {
                        CantidadxMateria();
                        agregarfinal();
                    }
                    else
                    {
                        MessageBox.Show("Cupos Llenos..");
                    }
                }
                else if (cmbCurso.Text == "Sistemas")
                {
                    if (cantSis < 6)
                    {
                        CantidadxMateria();
                        agregarfinal();
                    }
                    else
                    {
                        MessageBox.Show("Cupos Llenos..");
                    }
                }
                else
                {
                    if (cantRed < 6)
                    {
                        CantidadxMateria();
                        agregarfinal();
                    }
                    else
                    {
                        MessageBox.Show("Cupos Llenos..");
                    }
                }
                listar();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem LS = listView1.SelectedItems[0];
                txtLegajo.Text = LS.Text;
                txtNombre.Text = LS.SubItems[1].Text;
                cmbSexo.Text = LS.SubItems[2].Text;
                cmbCurso.Text = LS.SubItems[3].Text;
                txtParcial1.Text = LS.SubItems[4].Text;
                txtParcial2.Text = LS.SubItems[5].Text;
                txtTp.Text = LS.SubItems[6].Text;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtLegajo.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtNombre.Text;
                listView1.SelectedItems[0].SubItems[2].Text = cmbSexo.Text;
                listView1.SelectedItems[0].SubItems[3].Text = cmbCurso.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txtParcial1.Text;
                listView1.SelectedItems[0].SubItems[5].Text = txtParcial2.Text;
                listView1.SelectedItems[0].SubItems[6].Text = txtTp.Text;
                listView1.SelectedItems[0].SubItems[7].Text = Promedio.ToString();
                FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final2/Alumnos2.txt", FileMode.Create);
                StreamWriter SW = new StreamWriter(FS);
                string reg;
                Promedio = (int.Parse(txtParcial1.Text) + int.Parse(txtParcial2.Text) + int.Parse(txtTp.Text)) / 3;
                foreach (ListViewItem Listitem in listView1.Items)
                {
                    reg = Listitem.SubItems[0].Text + ";" + Listitem.SubItems[1].Text + ";" + Listitem.SubItems[2].Text + ";" + Listitem.SubItems[3].Text + ";"
                        + Listitem.SubItems[4].Text + ";" + Listitem.SubItems[5].Text + ";" + Listitem.SubItems[6].Text + ";" + Promedio;
                    SW.WriteLine(reg);
                }
                SW.Close();
                FS.Close();
            }
            listar();
            lblPromedio.Text = promediofinal.ToString();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem LS in listView1.SelectedItems)
            {
                LS.Remove();
            }
            txtNombre.Text = txtLegajo.Text = cmbCurso.Text = cmbSexo.Text = txtParcial1.Text = txtParcial2.Text = txtTp.Text = "";
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final2/Alumnos2.txt", FileMode.Create);
            StreamWriter SW = new StreamWriter(FS);
            string reg;
            foreach (ListViewItem LS in listView1.Items)
            {
                reg = LS.SubItems[0].Text + ";" + LS.SubItems[1].Text + ";" + LS.SubItems[2].Text + ";" + LS.SubItems[3].Text + ";"
                        + LS.SubItems[4].Text + ";" + LS.SubItems[5].Text + ";" + LS.SubItems[6].Text + ";" + Promedio;
                SW.WriteLine(reg);
            }
            SW.Close();
            FS.Close();
            listar();
            cantpersonas--;
        }

        private Boolean Comprobar(string Leg)
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final2/Alumnos2.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            string[] VectLegajo;
            string Registro, Legajo = "";
            while (SR.Peek() != -1)
            {
                Registro = SR.ReadLine();
                VectLegajo = Registro.Split(';');
                Legajo = VectLegajo[0];

            }
            if (Legajo == Leg)
            {
                SR.Close();
                FS.Close();
                return true;
            }
            else
            {
                SR.Close();
                FS.Close();
                return false;
            }
        }

        void CantidadxMateria()
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final2/Alumnos2.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            String[] vectorRegistro;
            string registro, legajo, nombre, sexo, curso, parcial1, parcial2, tp, promedio;
            while (SR.Peek() != -1)
            {
                registro = SR.ReadLine();
                vectorRegistro = registro.Split(';');
                legajo = vectorRegistro[0];
                nombre = vectorRegistro[1];
                sexo = vectorRegistro[2];
                curso = vectorRegistro[3];
                parcial1 = vectorRegistro[4];
                parcial2 = vectorRegistro[5];
                tp = vectorRegistro[6];
                promedio = vectorRegistro[7];

                if (curso == "Programacion 1")
                {
                    cantProg++;
                }
                else if (curso == "Sistemas")
                {
                    cantSis++;
                }
                else
                {
                    cantRed++;
                }

            }
            SR.Close();
            FS.Close();

        }
        void agregarfinal()
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final2/Alumnos2.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            Promedio = (int.Parse(txtParcial1.Text) + int.Parse(txtParcial2.Text) + int.Parse(txtTp.Text)) / 3;
            SW.WriteLine(txtLegajo.Text + ";" + txtNombre.Text + ";" + cmbSexo.SelectedItem + ";" + cmbCurso.SelectedItem + ";"
                + txtParcial1.Text + ";" + txtParcial2.Text + ";" + txtTp.Text + ";" + Promedio);
            MessageBox.Show("se cargo el wacho");
            SW.Close();
            FS.Close();

        }

    }
}

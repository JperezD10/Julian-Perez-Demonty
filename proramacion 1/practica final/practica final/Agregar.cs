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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            cmbCurso.SelectedIndex = cmbSexo.SelectedIndex = 0;
            CantidadxMateria();
        }
        private Boolean CompLegajo(string Existe)
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final/Alumnos.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            string[] VectLegajo;
            string Registro, Legajo = "";
            while (SR.Peek() != -1)
            {
                Registro = SR.ReadLine();
                VectLegajo = Registro.Split(';');
                Legajo = VectLegajo[0];

            }
            if (Legajo == Existe)
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
        int CantProg = 0, CantSist = 0, CantRedes = 0;
        int promedio;
        void CantidadxMateria()
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final/Alumnos.txt", FileMode.OpenOrCreate);
            StreamReader SR = new StreamReader(FS);
            String[] vectorRegistro;
            string registro, legajo, edad, nombre, sexo, curso, parcial1, parcial2, tp, promedio;
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

                if (curso == "Programacion 1")
                {
                    CantProg++;
                }
                else if (curso == "Sistemas")
                {
                    CantSist++;
                }
                else
                {
                    CantRedes++;
                }

            }
            SR.Close();
            FS.Close();

        }
        void agregarfinal()
        {
            FileStream FS = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/final/Alumnos.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            promedio = (int.Parse(txtParcial1.Text) + int.Parse(txtParcial2.Text) + int.Parse(txtTp.Text)) / 3;
            SW.WriteLine(txtLegajo.Text + ";" + txtNombre.Text + ";" + txtEdad.Text + ";" + cmbSexo.SelectedItem + ";" + cmbCurso.SelectedItem + ";"
                + txtParcial1.Text + ";" + txtParcial2.Text + ";" + txtTp.Text + ";" + promedio.ToString());
            MessageBox.Show("se cargo el wacho");
            SW.Close();
            FS.Close();
            
        }
        
        private void btcargar_Click(object sender, EventArgs e)
        {
            Boolean Existir;
            Existir = CompLegajo(txtLegajo.Text);
            if (Existir == true)
            {
                MessageBox.Show("El Legajo ya existe......");
            }
            else
            {
                if (cmbCurso.Text == "Programacion 1")
                {
                    if (CantProg <= 5)
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
                    if (CantSist <= 5)
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
                    if (CantRedes <= 5)
                    {
                        CantidadxMateria();
                        agregarfinal();
                    }
                    else
                    {
                        MessageBox.Show("Cupos Llenos..");
                    }
                }
            }
        }
    }
}

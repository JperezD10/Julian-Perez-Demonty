using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instituto
{
    public partial class frmResumen : Form
    {
        frmMenu contexto;
        public frmResumen(frmMenu contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Curso 1");
            listBox1.Items.Add("Curso 2");
            listBox1.Items.Add("Curso 3");
            listBox1.Items.Add("Curso 4");
            listBox1.Items.Add("Curso 5");
            listBox1.Items.Add("Curso 6");
            listBox1.Items.Add("Curso 7");
            listBox1.Items.Add("Total Recaudado");
            listBox1.Items.Add("Porcentaje de Beca");
            listBox1.Items.Add("Promedios");
            txtResumen.ScrollBars = ScrollBars.Vertical;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            contexto.Show();
        }

        

        private void porcentajeBecaCompleta()
        {
            if (contexto.valorBecaCompleta == 0)
            {
                contexto.porcentajeBC = 0;
            }
            else
            {
                contexto.porcentajeBC = ((contexto.valorBecaCompleta * 100) / contexto.totalRecaudado);
            }                     
        }

        private void porcentajeBecaMedia()
        {
            if (contexto.valorBecaMedia == 0)
            {
                contexto.porcentajeBM = 0;
            }
            else
            {
                contexto.porcentajeBM = ((contexto.valorBecaMedia * 100) / contexto.totalRecaudado);
            }       
        }

        private void porcentajeBecaRegular()
        {
            if (contexto.valorBecaRegular == 0)
            {
                contexto.porcentajeBR = 0;
            }
            else
            {
                contexto.porcentajeBR = ((contexto.valorBecaRegular * 100) / contexto.totalRecaudado);
            }
        }
        
        private void promedioEdad()
        {
            if (contexto.totalEdad == 0)
            {
                contexto.valorPromedioEdad = 0;
            }
            else
            {
                contexto.valorPromedioEdad = (contexto.totalEdad / (contexto.i));
            }
        }

        private void promedioEdadC1()
        {
            if (contexto.cantEdadC1 == 0)
            {
                contexto.valorPromedioEdadC1 = 0;
            }
            else
            {
                contexto.valorPromedioEdadC1 = (contexto.totalEdad / (contexto.cantEdadC1));
            }
        }

        private void promedioEdadC2()
        {
            if (contexto.cantEdadC2 == 0)
            {
                contexto.valorPromedioEdadC2 = 0;
            }
            else
            {
                contexto.valorPromedioEdadC2 = (contexto.totalEdad / (contexto.cantEdadC2));
            }
        }

        private void promedioEdadC3()
        {
            if (contexto.cantEdadC3 == 0)
            {
                contexto.valorPromedioEdadC3 = 0;
            }
            else
            {
                contexto.valorPromedioEdadC3 = (contexto.totalEdad / (contexto.cantEdadC3));
            }
        }

        private void promedioEdadC4()
        {
            if (contexto.cantEdadC4 == 0)
            {
                contexto.valorPromedioEdadC4 = 0;
            }
            else
            {
                contexto.valorPromedioEdadC4 = (contexto.totalEdad / (contexto.cantEdadC4));
            }
        }

        private void promedioEdadC5()
        {
            if (contexto.cantEdadC5 == 0)
            {
                contexto.valorPromedioEdadC5 = 0;
            }
            else
            {
                contexto.valorPromedioEdadC5 = (contexto.totalEdad / (contexto.cantEdadC5));
            }
        }

        private void promedioEdadC6()
        {
            if (contexto.cantEdadC6== 0)
            {
                contexto.valorPromedioEdadC6= 0;
            }
            else
            {
                contexto.valorPromedioEdadC6= (contexto.totalEdad / (contexto.cantEdadC6));
            }
        }

        private void promedioEdadC7()
        {
            if (contexto.cantEdadC7 == 0)
            {
                contexto.valorPromedioEdadC7 = 0;
            }
            else
            {
                contexto.valorPromedioEdadC7 = (contexto.totalEdad / (contexto.cantEdadC7));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResumen.Clear();
            switch (listBox1.SelectedIndex) //posicion de listbox.
            {
                case 0:
                    promedioEdadC1();
                    txtPreResumen.Text = ("Disponibilidad del curso: " + contexto.cantidadAlumnosC1.ToString() + "/20" + Environment.NewLine+
                        "Total del curso 1: $" +contexto.totalC1.ToString() + Environment.NewLine+"Cantidad de mujeres: " +contexto.cantMujeresC1.ToString()+Environment.NewLine+
                        "Promedio de edad: "+contexto.valorPromedioEdadC1);
                    for (int j = 0; j < 20; j++)
                    {
                        if(contexto.curso1[j] != 0)
                        {
                            txtResumen.Text += ("Legajo: " + contexto.legajoAlumno[j] + Environment.NewLine+"Nombre: " + contexto.nombreAlumno[j] + Environment.NewLine+"Edad: " +
                                contexto.edadAlumno[j] + Environment.NewLine+"Sexo: " + contexto.sexoAlumno[j] + Environment.NewLine + "----------------------" + Environment.NewLine);
                        }
                        
                    }
                    break;
                case 1:
                    promedioEdadC2();
                    txtPreResumen.Text = ("Disponibilidad del curso: " + contexto.cantidadAlumnosC2.ToString() + "/20" + Environment.NewLine+
                        "Total del curso 2: $" + contexto.totalC2.ToString() + Environment.NewLine+"Cantidad de mujeres: " + contexto.cantMujeresC2.ToString() + Environment.NewLine +
                        "Promedio de edad: " + contexto.valorPromedioEdadC2);
                    for (int j = 0; j < 20; j++)
                    {
                        if (contexto.curso2[j] != 0)
                        {
                            txtResumen.Text += ("Legajo: " + contexto.legajoAlumno[j] + Environment.NewLine+"Nombre: " + contexto.nombreAlumno[j] + Environment.NewLine+"Edad: " +
                                contexto.edadAlumno[j] + Environment.NewLine+"Sexo: " + contexto.sexoAlumno[j] + Environment.NewLine + "----------------------" + Environment.NewLine);
                        }

                    }
                    break;
                case 2:
                    promedioEdadC3();
                    txtPreResumen.Text = ("Disponibilidad del curso: " + contexto.cantidadAlumnosC3.ToString() + "/20" + Environment.NewLine+
                        "Total del curso 3: $" + contexto.totalC3.ToString() + Environment.NewLine+"Cantidad de mujeres: " + contexto.cantMujeresC3.ToString() + Environment.NewLine +
                        "Promedio de edad: " + contexto.valorPromedioEdadC3);
                    for (int j = 0; j < 20; j++)
                    {
                        if (contexto.curso3[j] != 0)
                        {
                            txtResumen.Text += ("Legajo: " + contexto.legajoAlumno[j] + Environment.NewLine+"Nombre: " + contexto.nombreAlumno[j] + Environment.NewLine+"Edad: " +
                                contexto.edadAlumno[j] + Environment.NewLine+"Sexo: " + contexto.sexoAlumno[j] + Environment.NewLine + "----------------------" + Environment.NewLine);
                        }

                    }
                    break;
                case 3:
                    promedioEdadC4();
                    txtPreResumen.Text = ("Disponibilidad del curso: " + contexto.cantidadAlumnosC4.ToString() + "/20" + Environment.NewLine+
                        "Total del curso 4: $" + contexto.totalC4.ToString() + Environment.NewLine+"Cantidad de mujeres: " + contexto.cantMujeresC4.ToString() + Environment.NewLine +
                        "Promedio de edad: " + contexto.valorPromedioEdadC4);
                    for (int j = 0; j < 20; j++)
                    {
                        if (contexto.curso4[j] != 0)
                        {
                            txtResumen.Text += ("Legajo: " + contexto.legajoAlumno[j] + Environment.NewLine+"Nombre: " + contexto.nombreAlumno[j] + Environment.NewLine+"Edad: " +
                                contexto.edadAlumno[j] + Environment.NewLine+"Sexo: " + contexto.sexoAlumno[j] + Environment.NewLine + "----------------------" + Environment.NewLine);
                        }

                    }
                    break;
                case 4:
                    promedioEdadC5();
                    txtPreResumen.Text = ("Disponibilidad del curso: " + contexto.cantidadAlumnosC5.ToString() + "/20" + Environment.NewLine+
                        "Total del curso 5: $" + contexto.totalC5.ToString() + Environment.NewLine+"Cantidad de mujeres: " + contexto.cantMujeresC5.ToString() + Environment.NewLine +
                        "Promedio de edad: " + contexto.valorPromedioEdadC5);
                    for (int j = 0; j < 20; j++)
                    {
                        if (contexto.curso5[j] != 0)
                        {
                            txtResumen.Text += ("Legajo: " + contexto.legajoAlumno[j] + Environment.NewLine+"Nombre: " + contexto.nombreAlumno[j] + Environment.NewLine+
                                "Edad: " +
                                contexto.edadAlumno[j] + Environment.NewLine+"Sexo: " + contexto.sexoAlumno[j] + Environment.NewLine + "----------------------" + Environment.NewLine);
                        }

                    }
                    break;
                case 5:
                    promedioEdadC6();
                    txtPreResumen.Text = ("Disponibilidad del curso: " + contexto.cantidadAlumnosC6.ToString() + "/20" + Environment.NewLine+
                        "Total del curso 6: $" + contexto.totalC6.ToString() + Environment.NewLine+"Cantidad de mujeres: " + contexto.cantMujeresC6.ToString() + Environment.NewLine +
                        "Promedio de edad: " + contexto.valorPromedioEdadC6);
                    for (int j = 0; j < 20; j++)
                    {
                        if (contexto.curso6[j] != 0)
                        {
                            txtResumen.Text += ("Legajo: " + contexto.legajoAlumno[j] + Environment.NewLine+"Nombre: " + contexto.nombreAlumno[j] + Environment.NewLine+"Edad: " +
                                contexto.edadAlumno[j] + Environment.NewLine+"Sexo: " + contexto.sexoAlumno[j] + Environment.NewLine + "----------------------" + Environment.NewLine);
                        }

                    }
                    break;
                case 6:
                    promedioEdadC7();
                    txtPreResumen.Text = ("Disponibilidad del curso: " + contexto.cantidadAlumnosC7.ToString() + "/20" +Environment.NewLine+
                        "Total del curso 7: $" + contexto.totalC7.ToString() + Environment.NewLine+"Cantidad de mujeres: " + contexto.cantMujeresC7.ToString() + Environment.NewLine +
                        "Promedio de edad: " + contexto.valorPromedioEdadC7);
                    for (int j = 0; j < 20; j++)
                    {
                        if (contexto.curso7[j] != 0)
                        {
                            txtResumen.Text += ("Legajo: " + contexto.legajoAlumno[j] + Environment.NewLine+"Nombre: " + contexto.nombreAlumno[j] + Environment.NewLine+
                                "Edad: " +
                                contexto.edadAlumno[j] + Environment.NewLine+"Sexo: " + contexto.sexoAlumno[j]+Environment.NewLine+"----------------------"+Environment.NewLine);
                        }

                    }
                    break;
                case 7: txtPreResumen.Text =("Total recaudado: $" + contexto.totalRecaudado.ToString()); break;
                case 8:
                    porcentajeBecaCompleta();
                    porcentajeBecaMedia();
                    porcentajeBecaRegular();
                    txtPreResumen.Text = ("El porcentaje de las becas son:\n" + Environment.NewLine + "Beca completa: %" + contexto.porcentajeBC)+Environment.NewLine+
                        ("Beca media: %"+contexto.porcentajeBM)+Environment.NewLine+("Beca regular: %"+contexto.porcentajeBR)+Environment.NewLine; break;
                case 9:
                    promedioEdad();
                    txtPreResumen.Text = ("El promedio de la edad es: " + contexto.valorPromedioEdad);
                     break;
            }
        }
    }
}

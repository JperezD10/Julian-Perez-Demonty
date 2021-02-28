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

namespace _2do_Parcial
{
    public partial class Crear_Empleado : Form
    {
        Form1 Contexto;
        public Crear_Empleado(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }


        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (int.Parse(numericUpDownEdad.Text) >= 18)
            {
            float Sueldo=0;
            
             if(CmbPuestoTrabajo.SelectedIndex == 0)
                {
                    Contexto.Capataz.PeonesACargo = int.Parse(numericUpDownPeones.Text);
                    Contexto.Capataz.CalcularSueldo();
                    Sueldo = Contexto.Capataz.Sueldo;
                }       
             else if (CmbPuestoTrabajo.SelectedIndex == 1)
                {
                    Contexto.Peon.HorasTrabajadas = int.Parse(numericUpDownPeones.Text);
                    Contexto.Peon.CalcularSueldo();
                    Sueldo = Contexto.Peon.Sueldo;
                }
                else
                {
                    Contexto.Arquitecto.CantidadDeProyectos = int.Parse(numericUpDownPeones.Text);
                    Contexto.Arquitecto.CalcularSueldo();                    
                    Sueldo = Contexto.Arquitecto.Sueldo;
                }

            Contexto.Empleado = new Empleado(TxtNombre.Text,TxtApellido.Text,int.Parse(numericUpDownEdad.Text),CmbPuestoTrabajo.Text,Sueldo);
            Contexto.Empresa.Empleados.Add(Contexto.Empleado);
            LblID.Text = Empleado.IDEmpleados.ToString();
            Contexto.Empresa.CalcularMayorCantEmpleados();
            Contexto.Empresa.Creados += Creado;
            Contexto.Empresa.Evento(1);
            }
            else
            {
            Contexto.Empresa.NoCreados += NoCreado;
            Contexto.Empresa.Evento(2);
            }

        }

        void NoCreado(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }
        void Creado(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

        private void Crear_Empleado_Load(object sender, EventArgs e)
        {
            LblID.Text = Empleado.IDEmpleados.ToString();
            numericUpDownEdad.Maximum = 75;
            numericUpDownEdad.Minimum = 1;
        }

        private void CmbPuestoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPuestoTrabajo.SelectedIndex ==0)
            {
                LblPeones.Visible = true;
                numericUpDownPeones.Visible = true;
                lblTrabajo.Visible = false;
                numericUpDownTrabajo.Visible = false;
                LblProyectos.Visible = false;
                numericUpDownProyectos.Visible = false;
            }
            else if(CmbPuestoTrabajo.SelectedIndex == 1)
            {
                lblTrabajo.Visible = true;
                numericUpDownTrabajo.Visible = true;
                LblPeones.Visible = false;
                numericUpDownPeones.Visible = false;
                LblProyectos.Visible = false;
                numericUpDownProyectos.Visible = false;
            }
            else
            {
                LblProyectos.Visible = true;
                numericUpDownProyectos.Visible = true;
                LblPeones.Visible = false;
                numericUpDownPeones.Visible = false;
                lblTrabajo.Visible = false;
                numericUpDownTrabajo.Visible = false;
            }
        }
    }
}

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
                    
            LblMayorTrabajo.Text = Contexto.Empresa.MayorCantDeEmpleados;
            dataGridViewEmpleados.DataSource = Contexto.Empresa.Empleados;
            LblCantCapataz.Text = Contexto.Empresa.CantCapataz.ToString();
            LblCantPeon.Text = Contexto.Empresa.CantPeon.ToString();
            LblCantArquitecto.Text = Contexto.Empresa.CantArquitecto.ToString();
            LlenarCmbEmpleadosMayores();
            LblSueldoCapataz.Text = Contexto.Empresa.SueldoCapataz.ToString();
            LblSueldoPeon.Text = Contexto.Empresa.SueldoPeon.ToString();
            LblSueldoArquitecto.Text = Contexto.Empresa.SueldoArquitecto.ToString();

        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            Contexto.Empresa.Empleados.Sort();
            dataGridViewEmpleados.DataSource = Contexto.Empresa.Empleados;
        }

        void LlenarCmbEmpleadosMayores()
        {
            int i = 0;

            foreach (Empleado E in Contexto.Empresa.Empleados)
            {
                if (E.PuestoDeTrabajo == "Arquitecto" && E.Edad > 45)
                {          
                 CmbEmpleados.Items.Add(Contexto.Empresa.Empleados[i].Nombre + " " + Contexto.Empresa.Empleados[i].Apellido);
                }
                i++;
            }
        }
        private void CmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}

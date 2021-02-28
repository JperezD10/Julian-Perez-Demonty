using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection CN = new SqlConnection();
        SqlCommand CM = new SqlCommand();

        void Conectar()
        {
            CN.ConnectionString = @"Data Source =.\SQL_UAI; Initial Catalog = Facultad; Integrated Security = True";
            CN.Open();
        }

        void Desconectar()
        {
            CN.Close();
            CN.Dispose();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            Conectar();
            textBox1.BackColor = Color.Green;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Desconectar();
            textBox1.BackColor = Color.Red;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conectar();

            CM.Connection = CN;
            CM.CommandType = CommandType.Text;
            CM.CommandText = "Insert into Alumno values("+int.Parse(txtLegajo.Text)+",'"+txtNombre.Text+"','"+txtApellido.Text+"',"+int.Parse(txtEdad.Text)+")";
            CM.ExecuteNonQuery();



            Desconectar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Conectar();
            CM.Connection = CN;
            CM.CommandType = CommandType.Text;
            CM.CommandText = "Update Alumno set Nombre = '" + txtNombre.Text + "',Apellido='" + txtApellido.Text + "',Edad=" + int.Parse(txtEdad.Text) + "where Legajo="+int.Parse(txtLegajo.Text);
            CM.ExecuteNonQuery();
            Desconectar();


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Conectar();
            CM.Connection = CN;
            CM.CommandType = CommandType.Text;
            CM.CommandText = "Delete from Alumno where Legajo=" + int.Parse(txtLegajo.Text);
            CM.ExecuteNonQuery();
            Desconectar();
            
        }

        void Ver()
        {
            List<Alumno> ListaAlumnos = new List<Alumno>();
            Conectar();
            CM.Connection = CN;
            CM.CommandType = CommandType.Text;
            CM.CommandText = "Select * from Alumno";
            SqlDataReader lector = CM.ExecuteReader();
            while (lector.Read())
            {
                Alumno al = new Alumno();
                al.Legajo = int.Parse(lector["Legajo"].ToString());
                al.Nombre = lector["Nombre"].ToString();
                al.Apellido = lector["Apellido"].ToString();
                al.Edad = int.Parse(lector["Edad"].ToString());
                ListaAlumnos.Add(al);

            }
            lector.Close();
            Desconectar();
            grilla.DataSource = null;
            grilla.DataSource = ListaAlumnos;
        
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Ver();
        }

        Alumno temporal;
        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temporal = (Alumno)grilla.Rows[e.RowIndex].DataBoundItem;
            txtLegajo.Text = temporal.Legajo.ToString();
            txtNombre.Text = temporal.Nombre;
            txtApellido.Text = temporal.Apellido;
            txtEdad.Text = temporal.Edad.ToString();
            
        }
    }



}

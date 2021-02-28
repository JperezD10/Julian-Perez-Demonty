using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Posible_parcial_2
{
    public partial class Pasajeros : Form
    {
        Form1 f;
        public Pasajeros(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }
        BE.Pasajeros temp;
        BLL.Pasajeros_BLL gestor = new BLL.Pasajeros_BLL();
        private void Pasajeros_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        void limpiartxt()
        {
            txtApellido.Clear();
            txtDireccion.Clear();
            txtID.Clear();
            txtNombre.Clear();
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            temp = new BE.Pasajeros();
            string patron = @"\d{1,5}";
            Regex miregex = new Regex(patron);
            MatchCollection match = miregex.Matches(txtDireccion.Text);
            if (match.Count > 0)
            {
                //using (Parcial2LUGEntities2 db = new Parcial2LUGEntities2())
                //{
                //    Pasajero p = new Pasajero();
                //    p.Nombre = txtNombre.Text;
                //    p.Apellido = txtApellido.Text;
                //    p.Direccion = txtDireccion.Text;
                //    db.Pasajero.Add(p);
                //    db.SaveChanges();
                //}
               
                temp._IDPasajero = 0;
                temp._Nombre = txtNombre.Text;
                temp._Apellido = txtApellido.Text;
                temp._Direccion = txtDireccion.Text;
                try
                {
                    gestor.Agregar(temp);
                    MessageBox.Show("pasajero agrega3");

                }
                catch
                {
                    MessageBox.Show("error al cargar");
                }
                listar();
                limpiartxt();
            }
            else
            {
                MessageBox.Show("La direccion debe estar escrita con hasta 5 numeros","Direccion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                limpiartxt();
            }

            
            
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            using(Parcial2LUGEntities2 db= new Parcial2LUGEntities2())
            {
                Pasajero p = db.Pasajero.Find(int.Parse(txtID.Text)); //este pasajero hace referencia al del entity, no al de BE
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                p.Direccion = txtDireccion.Text;
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            //temp = new BE.Pasajeros();
            //temp._IDPasajero = int.Parse(txtID.Text);
            //temp._Nombre = txtNombre.Text;
            //temp._Apellido = txtApellido.Text;
            //temp._Direccion = txtDireccion.Text;
            try
            {
                //gestor.modificar(temp);
                MessageBox.Show("pasajero modifica3");
                listar();
            }
            catch
            {
                MessageBox.Show("error");
            }
           
            limpiartxt();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = (BE.Pasajeros)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtID.Text = temp._IDPasajero.ToString();
            txtNombre.Text = temp._Nombre;
            txtApellido.Text = temp._Apellido;
            txtDireccion.Text = temp._Direccion;
        }
        void listar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.Listar();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            using (Parcial2LUGEntities2 db = new Parcial2LUGEntities2())
            {
                Pasajero p = db.Pasajero.Find(int.Parse(txtID.Text));
                db.Pasajero.Remove(p);
                db.SaveChanges();
            }
            //    temp = new BE.Pasajeros();
            //temp._IDPasajero = int.Parse(txtID.Text);
            try
            {
                //gestor.Eliminar(temp);
                MessageBox.Show("pasajero elimina3");
            }
            catch
            {
                MessageBox.Show("error");
            }
            limpiartxt();
            listar();
        }
    }
}

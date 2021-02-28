using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_2
{
    public partial class VerNotas : Form
    {
        LogIn a;
        public VerNotas(LogIn a)
        {
            InitializeComponent();
            this.a = a;
        }
        BLL.Materia_BLL gestorMateria = new BLL.Materia_BLL();
        private void VerNotas_Load(object sender, EventArgs e)
        {
            GrillaMateria.DataSource = null;
            GrillaMateria.DataSource = gestorMateria.Listar();
        }

        private void btvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Ver notas de materia
        {
            if (txtIDMateria.Text == "")
            {
                MessageBox.Show("Debe Elegir La materia de la cual quiere las notas");
            }
            else
            {
                BLL.Nota_BLL GestorNotas = new BLL.Nota_BLL();
                try
                {
                    GrillaNotas.DataSource = null;
                    GrillaNotas.DataSource=GestorNotas.Listar(int.Parse(txtIDMateria.Text));
                    txtIDMateria.Clear();
                    
                }
                catch
                {

                }
                
            }
            
        }

        private void GrillaMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Materia temp = (BE.Materia)GrillaMateria.Rows[e.RowIndex].DataBoundItem;
            txtIDMateria.Text = temp._IDMateria.ToString();
        }
    }
}

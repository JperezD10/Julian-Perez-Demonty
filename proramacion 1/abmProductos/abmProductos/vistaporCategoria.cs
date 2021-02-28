using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace abmProductos
{
    public partial class vistaporCategoria : Form
    {
        public vistaporCategoria()
        {
            InitializeComponent();
        }
        private ArrayList categoriaList = new ArrayList();

        private void vistaporCategoria_Load(object sender, EventArgs e)
        {
            actualizarCategorias();
            try
            {
                comboCategoria.SelectedIndex = 0;
                buscarPorCategoria(comboCategoria.Text);
            }
            catch
            {
                MessageBox.Show("No hay productos cargados");
            }
        }

        void actualizarCategorias()
        {
            categoriaList.Clear();
            FileStream FS = new FileStream("C:/producto/producto.txt", FileMode.OpenOrCreate);
            StreamReader Sr = new StreamReader(FS);
            string[] VectorRegistro;
            string Registro;
            string codProducto, desc, stock, preciou, preciov, categoria;
            

            while (Sr.Peek() != -1)
            {

                Registro = Sr.ReadLine();
                VectorRegistro = Registro.Split(';');

                categoria = VectorRegistro[5];
                
                if (!comboCategoria.Items.Contains(categoria))
                {
                    comboCategoria.Items.Add(categoria);
                }
                
            }
           
            Sr.Close();
            FS.Close();
        }
        void buscarPorCategoria(String buscarCategoria)
        {
            listView1.Items.Clear();
            FileStream FS = new FileStream("C:/producto/producto.txt", FileMode.OpenOrCreate);
            StreamReader Sr = new StreamReader(FS);
            string[] VectorRegistro;
            string Registro;
            string codProducto, desc, stock, preciou, preciov, categoria;


            while (Sr.Peek() != -1)
            {

                Registro = Sr.ReadLine();
                VectorRegistro = Registro.Split(';');

                codProducto = VectorRegistro[0];

                desc = VectorRegistro[1];
                stock = VectorRegistro[2];
                preciou = VectorRegistro[3];
                preciov = VectorRegistro[4];
                categoria = VectorRegistro[5];

                if (buscarCategoria.Equals(categoria))
                {
                    ListViewItem Ls = new ListViewItem(codProducto);
                    Ls.SubItems.Add(desc);
                    Ls.SubItems.Add(stock);
                    Ls.SubItems.Add(preciou);
                    Ls.SubItems.Add(preciov);
                    Ls.SubItems.Add(categoria);
                    listView1.Items.Add(Ls);
                }

            }


            Sr.Close();
            FS.Close();
        }

        private void vistaporCategoria_MouseHover(object sender, EventArgs e)
        {
            buscarPorCategoria(comboCategoria.Text);
        }

        private void comboCategoria_Enter(object sender, EventArgs e)
        {
            actualizarCategorias();
        }
    }
}

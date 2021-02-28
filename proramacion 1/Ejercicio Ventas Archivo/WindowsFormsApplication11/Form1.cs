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

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean comprobacionLista()
        {
            foreach(ListViewItem listItem in listView1.Items)
            {
                if(listItem.SubItems[0].Text != "")
                {
                    return true;
                }
            }
            return false;
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe;
            existe = comprobacionLista();
            if (existe == true)
            {
                Logincs ventana = new Logincs();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay productos cargados en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }
        private Boolean comprobarCod(string CodArt)
        {
            FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStreamer);
            String[] vectorVenta;
            string codProducto = "", registro;
            while (streamReader.Peek() != -1)
            {
                registro = streamReader.ReadLine();
                vectorVenta = registro.Split(';');
                codProducto = vectorVenta[0];
                if (codProducto == CodArt)
                {
                    streamReader.Close();
                    fileStreamer.Close();
                    return true;
                }
            }
            streamReader.Close();
            fileStreamer.Close();
            return false;
        }

        private void Listar()
        {
            FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStreamer);
            listView1.Items.Clear();
            String[] vectorVenta;
            string registro, codProducto, descripcion, stock, precioU, precioV, categoria;
            while(streamReader.Peek() != -1)
             {
                registro = streamReader.ReadLine();
                vectorVenta = registro.Split(';');
                codProducto = vectorVenta[0];
                descripcion = vectorVenta[1];
                stock = vectorVenta[2];
                if (stock == 0.ToString())
                {
                    stock = "Agotado";
                }
                precioU = vectorVenta[3];
                precioV = vectorVenta[4];
                categoria = vectorVenta[5];
                ListViewItem listItem = new ListViewItem(codProducto);
                listItem.SubItems.Add(descripcion);
                listItem.SubItems.Add(stock);
                listItem.SubItems.Add(precioU);
                listItem.SubItems.Add(precioV);
                listItem.SubItems.Add(categoria);
                listView1.Items.Add(listItem);
             }
            streamReader.Close();
            fileStreamer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Append);
            fileStreamer.Close();
            listView1.Scrollable = true;
            Listar();
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            Boolean existe;
            existe = comprobarCod(txtCodProducto.Text);
            if (existe)
            {
                MessageBox.Show("El codigo de producto existe.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                FileStream fileStreamer1 = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Append);
                StreamWriter streamWriter1 = new StreamWriter(fileStreamer1);
                streamWriter1.WriteLine(txtCodProducto.Text + ";" + txtDescripcion.Text + ";" + txtStock.Text + ";" +
                    txtPrecioUnit.Text + ";" + txtPrecioVenta.Text + ";" + txtCategoria.Text);
                txtCategoria.Text = txtCodProducto.Text = txtDescripcion.Text = txtPrecioUnit.Text = txtPrecioVenta.Text = txtStock.Text = "";
                streamWriter1.Close();
                fileStreamer1.Close();
                Listar();
            }

        }
        private void fileStreamer()
        {
            FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStreamer);
            String reg;
            foreach (ListViewItem listItem in listView1.Items)
            {
                reg = listItem.SubItems[0].Text + ";" + listItem.SubItems[1].Text + ";" +
                    listItem.SubItems[2].Text + ";" + listItem.SubItems[3].Text + ";" +
                    listItem.SubItems[4].Text + ";" + listItem.SubItems[5].Text;
                streamWriter.WriteLine(reg);
            }
            streamWriter.Close();
            fileStreamer.Close();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem listItem in listView1.SelectedItems)
            {
                listItem.Remove();
            }
            txtCategoria.Text = txtCodProducto.Text = txtDescripcion.Text = txtPrecioUnit.Text = txtPrecioVenta.Text = txtStock.Text = "";
            fileStreamer();        
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[1].Text = txtDescripcion.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtStock.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtPrecioUnit.Text;
            listView1.SelectedItems[0].SubItems[4].Text = txtPrecioVenta.Text;
            listView1.SelectedItems[0].SubItems[5].Text = txtCategoria.Text;
            fileStreamer();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                
                ListViewItem listItem = listView1.SelectedItems[0];
                txtCodProducto.Text = listItem.SubItems[0].Text;
                txtDescripcion.Text = listItem.SubItems[1].Text;
                txtStock.Text = listItem.SubItems[2].Text;
                txtPrecioUnit.Text = listItem.SubItems[3].Text;
                txtPrecioVenta.Text = listItem.SubItems[4].Text;
                txtCategoria.Text = listItem.SubItems[5].Text;
            }
            
        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPrecioUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

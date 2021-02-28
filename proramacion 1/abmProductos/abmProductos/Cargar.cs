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
using System.Media;
namespace abmProductos
{
    public partial class Cargar : Form
    {
        public Cargar()
        {
            InitializeComponent();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listView1.SelectedItems[0];

                txtCod.Text = listItem.Text;
                txtDesc.Text = listItem.SubItems[1].Text;
                txtStock.Text = listItem.SubItems[2].Text;
                txtPUnitario.Text = listItem.SubItems[3].Text;
                txtPVenta.Text = listItem.SubItems[4].Text;
                txtCategoria.Text = listItem.SubItems[5].Text;


            }
        }

        void Listar()
        {
            FileStream FS = new FileStream("C:/producto/producto.txt", FileMode.OpenOrCreate);
            StreamReader Sr = new StreamReader(FS);
            listView1.Items.Clear();//Por sino me duplica los datos
            string[] VectorRegistro;
            string Registro;
            string cod, desc, stock, preciou, preciov, categoria;

            while (Sr.Peek() != -1)
            {

                Registro = Sr.ReadLine();
                VectorRegistro = Registro.Split(';');
                cod = VectorRegistro[0];
                desc = VectorRegistro[1];
                stock = VectorRegistro[2];
                preciou = VectorRegistro[3];
                preciov = VectorRegistro[4];
                categoria = VectorRegistro[5];

                ListViewItem Ls = new ListViewItem(cod);
                Ls.SubItems.Add(desc);
                Ls.SubItems.Add(stock);
                Ls.SubItems.Add(preciou);
                Ls.SubItems.Add(preciov);
                Ls.SubItems.Add(categoria);
                listView1.Items.Add(Ls);

            }

            Sr.Close();
            FS.Close();
        }

        private bool comprobarExistencia(String codigoComparar)
        {
            FileStream fileStreamer = new FileStream("C:/producto/producto.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStreamer);
            string[] VectorRegistro;
            string Registro;

            try
            {
                while (streamReader.Peek() != 1)
                {
                    Registro = streamReader.ReadLine();
                    VectorRegistro = Registro.Split(';');
                    if (codigoComparar == VectorRegistro[0])
                    {
                        streamReader.Close();
                        fileStreamer.Close();
                        return true;
                    }
                }
            }
            catch { }
            streamReader.Close();
            fileStreamer.Close();
            return false;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!comprobarExistencia(txtCod.Text))
            {
                txtCod.BackColor = Color.White;
                txtCod.ForeColor = Color.Black;
                FileStream fileStreamer = new FileStream("C:/producto/producto.txt", FileMode.Append);
                StreamWriter streamWriter = new StreamWriter(fileStreamer);
                string Reg; //Ceo una variable de tipo STRING para poder escribir
                Reg = txtCod.Text + ";" + txtDesc.Text + ";" + txtStock.Text + ";" + txtPUnitario.Text + ";" + txtPVenta.Text + ";" + txtCategoria.Text;
                streamWriter.WriteLine(Reg);//Igualo al stream WRITER a la variable reg
                streamWriter.Close();//Primero el que lee despues el archivo, Cierro el stream writer
                fileStreamer.Close();//Cierro el archivo filestream

                Listar();

            }
            else
            {
                txtCod.Select();
                txtCod.BackColor = Color.Red;
                txtCod.ForeColor = Color.White;
                txtCod.Focus();
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Codigo Existente");


            }
        }

        private void Cargar_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Listar();
        }

        private void txtCod_Leave(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                lista.Remove();
            }
            txtCod.Text = txtDesc.Text = txtPUnitario.Text = txtPVenta.Text = txtStock.Text = txtCategoria.Text = "";
            FileStream fileStream = new FileStream("C:/producto/producto.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            String reg;
            foreach (ListViewItem lista in listView1.Items) // cada item lo transforma en una variable llamada lista
            {

                reg = lista.SubItems[0].Text + ";" + lista.SubItems[1].Text + ";" + lista.SubItems[2].Text + ";" + lista.SubItems[3].Text + ";" + lista.SubItems[4].Text + ";" + lista.SubItems[5].Text;
                streamWriter.WriteLine(reg);

            }
            streamWriter.Close();
            fileStream.Close();
            Listar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try { 
            listView1.SelectedItems[0].SubItems[1].Text = txtDesc.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtStock.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtPUnitario.Text;
            listView1.SelectedItems[0].SubItems[4].Text = txtPVenta.Text;
            listView1.SelectedItems[0].SubItems[5].Text = txtCategoria.Text;
            FileStream fileStreamer = new FileStream("C:/producto/producto.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStreamer);
            String reg;
            foreach (ListViewItem lista in listView1.Items)
            {

                reg = lista.SubItems[0].Text + ";" + lista.SubItems[1].Text + ";" + lista.SubItems[2].Text + ";" + lista.SubItems[3].Text + ";" + lista.SubItems[4].Text + ";" + lista.SubItems[5].Text;
                streamWriter.WriteLine(reg);

            }
            streamWriter.Close();
            fileStreamer.Close();
            }
            catch
            {
                MessageBox.Show("Seleccione el item a modificar");
            }


        }

        private void listView1_MouseHover(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Listar();
        }
    }
}
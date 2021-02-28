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
    public partial class Venta : Form
    {
        Logincs context;
        public Venta(Logincs context)
        {          
            InitializeComponent();
            this.context = context;
        }

        public int numeroVenta = 1,importeTotal=0;
        public int valorProducto = 0,stockProducto=0;
        public Int32[] stock = { };

        private void Venta_Load(object sender, EventArgs e)
        {
            listView1.Scrollable = true;
            lblNombreCliente.Text = context.nombreCliente;
            lblNumeroVenta.Text = numeroVenta.ToString();
            timer1.Start();
            timer2.Start();
            FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStreamer);
            String[] vectorVenta;
            string registro, codProducto, descripcion, stock, precioU, precioV, categoria;
            while(streamReader.Peek() != -1)
            {
                registro = streamReader.ReadLine();
                vectorVenta = registro.Split(';');
                codProducto = vectorVenta[0];
                descripcion = vectorVenta[1];
                stock = vectorVenta[2];
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {       
            numeroVenta++;                  
            importeTotal += valorProducto * stockProducto;
            lblImporteTotal.Text += "$"+importeTotal;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockProducto = int.Parse(listView1.SelectedItems[0].SubItems[2].Text);
            valorProducto = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
            for (int i = 0; i < stockProducto; i++)
            {
                stock[i] = i+1;
                cmbStock.Items.Add(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

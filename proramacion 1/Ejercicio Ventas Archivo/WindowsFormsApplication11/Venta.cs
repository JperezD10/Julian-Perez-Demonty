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

        public int numeroVenta = 0,importeTotalFinal=0,importeTotalTotal=0,importeSeleccionado=0,promedioVenta=0;
        public int valorProducto = 0,stockProducto=0,stockSeleccionado=0;

        private void cargarCategoria()
        {
            FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStreamer);
            String[] vectorCategoria;
            string categoria,registro;        
            while(streamReader.Peek()!= -1)
            {
                registro = streamReader.ReadLine();
                vectorCategoria = registro.Split(';');
                categoria = vectorCategoria[5];
                if (!cmbCategoria.Items.Contains(categoria))
                {
                    cmbCategoria.Items.Add(categoria);
                }
            }
            streamReader.Close();
            fileStreamer.Close();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            cmbStock.Enabled = false;
            listView1.Scrollable = true;
            lblNombreCliente.Text = context.nombreCliente;    
            timer1.Start();
            timer2.Start();
            cargarCategoria();
            FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Open);
            FileStream fileStreamer1 = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/VentasDatos.txt", FileMode.OpenOrCreate);
            StreamReader streamReader1 = new StreamReader(fileStreamer1);
            StreamReader streamReader = new StreamReader(fileStreamer);
            String[] vectorVenta, vectorVentaDatos;
            Boolean elementos = false;
            string registro,registroDatos, codProducto, descripcion, stock, precioU, precioV, categoria, numVenta="", importeFinal="";
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
            while(streamReader1.Peek() != -1)
            {
                registroDatos = streamReader1.ReadLine();
                vectorVentaDatos = registroDatos.Split(';');
                numVenta = vectorVentaDatos[0];
                importeFinal = vectorVentaDatos[1];
                elementos = true;
            }
            if (elementos == true)
            {
                numeroVenta = Int32.Parse(numVenta);
                importeTotalTotal = Int32.Parse(importeFinal);
            }
            else
            {
                numeroVenta = 0;
                importeTotalTotal = 0;
            }
            txtNumVenta.Text = numVenta;
            txtImporteTotal.Text = importeFinal;
            txtPrecioSeleccionado.Text = importeSeleccionado.ToString();
            streamReader1.Close();
            fileStreamer1.Close();
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

        private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockSeleccionado = int.Parse(cmbStock.Text);
            txtPrecioSeleccionado.Text = (valorProducto * stockSeleccionado).ToString();
        }

        private void buscarCategoria(string categoriaBuscar)
        {
            
            FileStream fileStreamer1 = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Open);
            StreamReader streamReader1 = new StreamReader(fileStreamer1);
            String[] vectorCategoria;
            string registro, codProducto, descripcion, stock, precioU, precioV, categoria1;
            while(streamReader1.Peek()!= -1)
            {
                registro = streamReader1.ReadLine();
                vectorCategoria = registro.Split(';');
                codProducto = vectorCategoria[0];
                descripcion = vectorCategoria[1];
                stock = vectorCategoria[2];
                precioU = vectorCategoria[3];
                precioV = vectorCategoria[4];
                categoria1 = vectorCategoria[5];
                if (categoriaBuscar.Equals(categoria1))
                {
                    ListViewItem listItem = new ListViewItem(codProducto);
                    listItem.SubItems.Add(descripcion);
                    listItem.SubItems.Add(stock);
                    listItem.SubItems.Add(precioU);
                    listItem.SubItems.Add(precioV);
                    listItem.SubItems.Add(categoria1);
                    listView1.Items.Add(listItem);
                }
            }
            streamReader1.Close();
            fileStreamer1.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            buscarCategoria(cmbCategoria.Text);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            numeroVenta = 0;
            importeTotalTotal = 0;
            promedioVenta = 0;
            txtNumVenta.Text = numeroVenta.ToString();
            txtImporteTotal.Text = importeTotalTotal.ToString();
            txtPromedioVenta.Text = promedioVenta.ToString();
            FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/VentasDatos.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStreamer);
            streamWriter.WriteLine(numeroVenta + ";" + importeTotalTotal);
            streamWriter.Close();
            fileStreamer.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {

            if (cmbStock.Text != "")
            {
                txtPrecioSeleccionado.Text = 0.ToString();
                cmbStock.Enabled = false;
                listView1.SelectedItems[0].SubItems[2].Text = (stockProducto - stockSeleccionado).ToString();
                if (listView1.SelectedItems[0].SubItems[2].Text == (0.ToString()))
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "Agotado";
                }
                FileStream fileStreamer = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/Ventas.txt", FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStreamer);
                FileStream fileStreamer1 = new FileStream("C:/Users/1/Downloads/Ingeniería En Sistemas/1ro/2º Cuatrimestre/Programacion I/VentasDatos.txt", FileMode.Create);
                StreamWriter streamWriter1 = new StreamWriter(fileStreamer1);
                String reg;
                foreach (ListViewItem listItem in listView1.Items)
                {
                    reg = listItem.SubItems[0].Text + ";" + listItem.SubItems[1].Text + ";" +
                        listItem.SubItems[2].Text + ";" + listItem.SubItems[3].Text + ";" +
                        listItem.SubItems[4].Text + ";" + listItem.SubItems[5].Text;
                    streamWriter.WriteLine(reg);
                }
                numeroVenta++;
                importeTotalFinal = (valorProducto * stockSeleccionado);
                importeTotalTotal += importeTotalFinal;
                txtImporteTotal.Text = importeTotalTotal.ToString();
                txtNumVenta.Text = numeroVenta.ToString();
                try
                {
                    txtPromedioVenta.Text = (importeTotalTotal / numeroVenta).ToString();
                }
                catch (Exception)
                {

                }
                streamWriter1.WriteLine(numeroVenta + ";" + importeTotalTotal);
                cmbStock.Items.Clear();
                streamWriter1.Close();
                streamWriter.Close();
                fileStreamer1.Close();
                fileStreamer.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar datos");
            }    
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStock.Enabled = true;
            cmbStock.Items.Clear();
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].SubItems[2].Text == "Agotado")
                {
                    stockProducto = 0;
                }
                else
                {
                    stockProducto = int.Parse(listView1.SelectedItems[0].SubItems[2].Text);
                }               
                valorProducto = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                for (int i = 0; i < stockProducto; i++)
                {
                    cmbStock.Items.Add(i+1);
                }               
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

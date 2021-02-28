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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
        private ArrayList productosList = new ArrayList();
        private ArrayList preciosList = new ArrayList();
        private ArrayList stockList = new ArrayList();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String nrocliente = txtNroCliente.Text;
            if(nrocliente != "")
            {
                foreach(Control control in this.Controls)
                {
                    control.Visible = true;
                }
                txtNroCliente.Visible = false;
                btnEntrar.Visible = false;
                label7.Visible = false;
                txtCliente2.Enabled = false;
                txtCliente2.Text = nrocliente;
                txtVenta.Text = comprobarCodVenta();
                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Listar();
                agregarProductos();
            }
            else{
                
            }
        }
        private void agregarProductos()
        {
            comboProducto.Items.Clear();
            for(int i = 0;i< productosList.Count; i++)
            {
                comboProducto.Items.Add(productosList[i]);
            }
            comboProducto.SelectedIndex = 0;

        }
        

        
        private string comprobarCodVenta()
        {
            FileStream FS = new FileStream("C:/producto/venta.txt", FileMode.OpenOrCreate);
            StreamReader Sr = new StreamReader(FS);
      
            string[] VectorRegistro;
            string Registro;
            string codVenta ="";

            while (Sr.Peek() != -1)
            {

                Registro = Sr.ReadLine();
                VectorRegistro = Registro.Split(';');
                codVenta = VectorRegistro[0];
                
            }
            int numeroNuevaVenta;
            if (codVenta != ""){
                numeroNuevaVenta = (int.Parse(codVenta)+1);
            }else
            {
                numeroNuevaVenta = 1;
            }

            Sr.Close();
            FS.Close();
            return numeroNuevaVenta.ToString();

        }
        void Listar()
        {
            FileStream FS = new FileStream("C:/producto/producto.txt", FileMode.OpenOrCreate);
            StreamReader Sr = new StreamReader(FS);
            string[] VectorRegistro;
            string Registro;
            string codProducto, desc, stock, preciou, preciov, categoria;
            productosList.Clear();
            preciosList.Clear();
            stockList.Clear();
            
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

                productosList.Add(desc);
                preciosList.Add(preciov);
                stockList.Add(stock);
                          

            }


            Sr.Close();
            FS.Close();
        }


        private void Ventas_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
            txtNroCliente.Visible = true;
            btnEntrar.Visible = true;
            label7.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem Ls = new ListViewItem(comboProducto.Text);
            Ls.SubItems.Add(txtPVenta.Text);
            Ls.SubItems.Add(comboCantidad.Text);
            int precio = 0 ;
            try {
                precio = int.Parse(txtPVenta.Text) * int.Parse(comboCantidad.Text);
            }
            catch
            {
                MessageBox.Show("ASEGURESE DE SELECIONAR EL STOCK");
                
                return;
            }
            Ls.SubItems.Add(precio.ToString());
            listView1.Items.Add(Ls);

            int productoIndex = comboProducto.SelectedIndex;
            int stockADescontar = (int) comboCantidad.SelectedItem;
            txtPVenta.Text = preciosList[productoIndex].ToString();
            actualizarStockArchivo(comboProducto.Text, stockADescontar);
            Listar();
            actualizarPrecioAndStock();
            int total = int.Parse(txtTotal.Text) + precio;
            txtTotal.Text = total+"";

        }
        private void actualizarStockArchivo(string nombreProducto, int stockNuevo)
        {

            FileStream fileStreamer0 = new FileStream("C:/producto/producto.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStreamer0);
            string[] VectorRegistro;
            string Registro;
            ArrayList codProducto = new ArrayList();
            ArrayList descripcion = new ArrayList();
            ArrayList stockProducto = new ArrayList();
            ArrayList precioVenta = new ArrayList();
            ArrayList precioUnitario = new ArrayList();
            ArrayList categoria = new ArrayList();


            try { 
            while (streamReader.Peek() != 1)
                {
                    Registro = streamReader.ReadLine();
                    VectorRegistro = Registro.Split(';');
               
                    codProducto.Add(VectorRegistro[0]);
                    descripcion.Add(VectorRegistro[1]);
                if (VectorRegistro[1].Equals(nombreProducto))
                {
                    stockProducto.Add(int.Parse(VectorRegistro[2].ToString())-stockNuevo);
                }else
                {
                    stockProducto.Add(VectorRegistro[2]);
                }
                   precioUnitario.Add(VectorRegistro[3]);
                    precioVenta.Add(VectorRegistro[4]);
                    categoria.Add(VectorRegistro[5]);
                    

            }
            }
            catch { }

            streamReader.Close();
            fileStreamer0.Close();


            FileStream fileStreamer = new FileStream("C:/producto/producto.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStreamer);
            String reg;
            for (int i = 0; i < codProducto.Count; i++)
            {

                reg = codProducto[i] +";"+ descripcion[i] + ";" + stockProducto[i] + ";" + precioUnitario[i] + ";" + precioVenta[i] + ";" + categoria[i];
                streamWriter.WriteLine(reg);

            }
            streamWriter.Close();
            fileStreamer.Close();
            
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
             FileStream fileStreamer = new FileStream("C:/producto/venta.txt", FileMode.Append);
             StreamWriter streamWriter = new StreamWriter(fileStreamer);
            String reg;
            foreach (ListViewItem lista in listView1.Items)
            {

                reg = txtVenta.Text + ";" + txtCliente2.Text + ";" + lista.SubItems[0].Text + ";" + lista.SubItems[1].Text + ";" + lista.SubItems[2].Text + ";" + lista.SubItems[3].Text;
                streamWriter.WriteLine(reg);

            }
           
          
            
            streamWriter.Close();
            fileStreamer.Close();

            Listar();
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No se han agregado productos a la lista");
                return;
            }
            MessageBox.Show("Vendido Correctamente");
            this.Close();

        }
        private void actualizarPrecioAndStock()
        {
            comboCantidad.Items.Clear();
            int productoIndex = comboProducto.SelectedIndex > 0 ? comboProducto.SelectedIndex : 0;
            for (int i = 0; i < int.Parse(stockList[productoIndex].ToString()); i++)
            {
                comboCantidad.Items.Add(i + 1);
            }
            txtPVenta.Text = preciosList[productoIndex].ToString();
           
        }
        private void comboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPrecioAndStock();
        }

        private void comboProducto_Leave(object sender, EventArgs e)
        {
            Listar();
            actualizarPrecioAndStock();
            try
            {
                comboCantidad.SelectedIndex = 0;
            }
            catch
            {
                comboCantidad.Text = "";
                MessageBox.Show("No Hay Stock de este producto");
            }
        }
    }
}

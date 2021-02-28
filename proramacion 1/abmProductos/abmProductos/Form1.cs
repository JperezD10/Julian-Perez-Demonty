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

namespace abmProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float maximo = 0, minimo = 0;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Cargar ventana = new Cargar();
            ventana.MdiParent = this;
            ventana.Show();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fileStreamer = new FileStream("C:/producto/producto.txt", FileMode.Append);
            fileStreamer.Close();
            FileStream fileStreamer1 = new FileStream("C:/producto/venta.txt", FileMode.Append);
            fileStreamer1.Close();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventana = new Ventas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void visualizarPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vistaporCategoria ventana = new vistaporCategoria();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void promedioDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El promedio de las ventas es de " + promedioVentas());

        }
        private string promedioVentas()
        {
            FileStream FS = new FileStream("C:/producto/venta.txt", FileMode.OpenOrCreate);
            StreamReader Sr = new StreamReader(FS);

            string[] VectorRegistro;
            string Registro;
            string codVenta = "",codCliente,producto,precio,cantidad,subtotal;
            float promedio = 0;
            float total = 0;
            int contador = 0;
            while (Sr.Peek() != -1)
            {

                Registro = Sr.ReadLine();
                VectorRegistro = Registro.Split(';');
                codVenta = VectorRegistro[0];
                codCliente = VectorRegistro[1];
                producto = VectorRegistro[2];
                precio = VectorRegistro[3];
                cantidad = VectorRegistro[4];
                subtotal = VectorRegistro[5];
                total += float.Parse(subtotal);
                contador++;

            }
            promedio = total / contador;
          

            Sr.Close();
            FS.Close();
            return promedio.ToString("c2"); ; 

        }

        private void ventaMinimaYMaximaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            calcularMaximoyMinimo();
            MessageBox.Show("La venta Maxima es de " + maximo.ToString("c2"));
            MessageBox.Show("La venta Minima es de " + minimo.ToString("c2"));
            }
            catch
            {
                MessageBox.Show("No se han realizado ventas aun");
            }
        }

        private void calcularMaximoyMinimo()
        {
            FileStream FS = new FileStream("C:/producto/venta.txt", FileMode.OpenOrCreate);
            StreamReader Sr = new StreamReader(FS);

            string[] VectorRegistro;
            string Registro;
            string codVenta = "", codCliente, producto, precio, cantidad, subtotal;
            
            
            float[] totales = new float[100];
           
            while (Sr.Peek() != -1)
            {

                Registro = Sr.ReadLine();
                VectorRegistro = Registro.Split(';');
                codVenta = VectorRegistro[0];
                codCliente = VectorRegistro[1];
                producto = VectorRegistro[2];
                precio = VectorRegistro[3];
                cantidad = VectorRegistro[4];
                subtotal = VectorRegistro[5];
                totales[int.Parse(codVenta)] += float.Parse(subtotal);
                
            }
            minimo = totales[1];
            for(int i = 0;i < totales.Length; i++)
            {
                if(maximo < totales[i])
                {
                    maximo = totales[i];
                }
                if(minimo > totales[i] && totales[i] != 0)
                {
                    minimo = totales[i];
                }
            }
            


            Sr.Close();
            FS.Close();
            

        }
    }
}

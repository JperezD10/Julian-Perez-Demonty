using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cantDisponibles = 50;
        int vendidos = 0;
        int[] itemsArray = new int[50];
        int contTimer = 0;
        Boolean flagTimer = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar.Minimum = 0;
            progressBar.Maximum = 50;
            cargarArray();
            cargarComboBox();
            setLabelDisponible(cantDisponibles);
            setLabelVendido(vendidos);

        }
        private void cargarArray()
        {
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                itemsArray[i] = 0;
            }
            progressBar.Value = vendidos;       
        }
        private void cargarComboBox()
        {
            int i = 0;
            comboBoxItems.Items.Clear();
            for(i=0; i< 50; i++)
            {
                comboBoxItems.Items.Add(i+1);
            }
            comboBoxItems.SelectedIndex = 0;
        }
        private void resetear()
        {
            int i = 0;
            progressBar.Value = 0;
            cantDisponibles = 50;
            vendidos = 0;
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnVender.Enabled = true;
           
            resetear();
            cargarArray();
            cargarComboBox();
            setLabelDisponible(cantDisponibles);
            setLabelVendido(vendidos);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            itemsArray[comboBoxItems.SelectedIndex] = 1;            
            comboBoxItems.Items.RemoveAt(comboBoxItems.SelectedIndex);
            cantDisponibles--;
            vendidos++;
            labelTotal.Text = (int.Parse(labelTotal.Text) + int.Parse(labelValor.Text)).ToString();
            try
            {
                progressBar.Value = vendidos;
                comboBoxItems.SelectedIndex = 0;
                setLabelDisponible(cantDisponibles);
                setLabelVendido(vendidos);
            }
            catch (Exception ex)
            {
                comboBoxItems.Items.Add("PRESIONE RESET");
                comboBoxItems.SelectedIndex = 0;
                btnVender.Enabled = false;
               
            }
            setLabelDisponible(cantDisponibles);
            setLabelVendido(vendidos);
        }
        private void setLabelVendido(int vendido)
        {
            labelVendido.Text = vendido.ToString();
        }

        private void setLabelDisponible(int disp)
        {
            labelDisponible.Text = disp.ToString();
        }

        private void btnVentaporSegundo_Click(object sender, EventArgs e)
        {/*
            if (flagTimer)
            {
                flagTimer = false;
                comboBoxItems.Visible = true;
                btnVender.Visible = true;
                
                btnVentaporSegundo.Text = "Vender cada 300 milliseg";
            }
            else
            {
                flagTimer = true;
                comboBoxItems.Visible = false;
                btnVender.Visible = false;
                btnVentaporSegundo.Text = "STOP TIMER";
                

            }*/

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            /* if (itemsArray[contTimer] == 0)
             {
                 itemsArray[contTimer] = 1;
                 comboBoxItems.Items.Remove(contTimer);
                 cantDisponibles--;
                 vendidos++;
                 try
                 {
                     progressBar.Value = vendidos;
                     comboBoxItems.SelectedIndex = 0;
                     setLabelDisponible(cantDisponibles);
                     setLabelVendido(vendidos);
                 }
                 catch (Exception ex)
                 {
                     comboBoxItems.Items.Add("PRESIONE RESET");
                     comboBoxItems.SelectedIndex = 0;
                     btnVender.Enabled = false;
                     btnVentaporSegundo.Enabled = false;
                 }
                 setLabelDisponible(cantDisponibles);
                 setLabelVendido(vendidos);
                 contTimer++;
             }
             if (cantDisponibles == 0)
             {
                 contTimer = 0;
                 timer1.Stop();
                 MessageBox.Show("Todo se ha vendido, presione en Reset");
             }*/
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.Parse(comboBoxItems.SelectedItem.ToString()) >= 0 && int.Parse(comboBoxItems.SelectedItem.ToString()) <= 25)
            {
                labelValor.Text = "25";
            }
            else
            {
                labelValor.Text = "50";
            }
        }
    }
}

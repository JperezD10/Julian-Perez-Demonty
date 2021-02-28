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

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fileStreamer = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/personas.txt", FileMode.Append); //Abre Stream y con Append crea archivo si no existe.
            fileStreamer.Close(); //Cierra el stream.
            cmbSexo.SelectedIndex = 0;
            Listar();
        }
        private Boolean comprobarLegajo(string Leg) //Pasa como parametro un string que seria txtLegajo.Text.
        {
            FileStream fileStreamer = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/personas.txt", FileMode.Open); //Abre Stream y con Open abre el archivo existente.
            StreamReader streamReader = new StreamReader(fileStreamer); //Indica al StreamReader que archivo tiene que leer.
            String[] vectorRegistro;
            string registro, legajo="";
            while (!(streamReader.Peek() == -1)) //Mientras sea -1, representa el proximo caracter a leer. Si es -1 no hay para leer.
            {
                registro = streamReader.ReadLine(); //Lee la linea y la guarda en un string.
                vectorRegistro = registro.Split(';'); //Separa la linea por cada ; y lo guarda en una posicion de memoria del vector.
                legajo = vectorRegistro[0]; //Legajo va a ser la primer posicion del vector.      
            }
            if(legajo == Leg) //Si el legajo es igual a Leg (txtLegajo.Text) devuelve true.
            {
                streamReader.Close();
                fileStreamer.Close();
                return true;
            }
            else //De lo contrario false.
            {  
                streamReader.Close();
                fileStreamer.Close();
                return false;
            }
           
        }
        private void button1_Click(object sender, EventArgs e) //Agregar.
        {
            FileStream fileStreamer = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/personas.txt", FileMode.Append); //Abre Stream y con Append crea archivo si no existe.
            StreamWriter streamWriter = new StreamWriter(fileStreamer); //Indica al StreamWriter que archivo tiene que escribir.
            streamWriter.Close();
            fileStreamer.Close();
            int promedionotas;
            //Cierra los procesos.
            Boolean existe;
            existe = comprobarLegajo(txtLegajo.Text); //El Boolean "existe" toma el valor devuelto por la funcion Boolean.
            if (existe==true)
            {
                MessageBox.Show("El numero de legajo existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FileStream fileStreamer1 = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/personas.txt", FileMode.Append); 
                StreamWriter streamWriter1 = new StreamWriter(fileStreamer1);
                promedionotas = ((int.Parse(txtNota1.Text) + int.Parse(txtNota2.Text) + int.Parse(txtNota3.Text)) / 3);
                streamWriter1.WriteLine(txtLegajo.Text + ";" + txtNombre.Text + ";" + txtEdad.Text +
                                ";" + cmbSexo.SelectedItem + ";" + txtNota1.Text +";"+txtNota2.Text+";"+txtNota3.Text+";"+promedionotas.ToString()); //Escribe los datos en la linea del archivo.
                streamWriter1.Close();
                fileStreamer1.Close();
                
            }
            Listar();
        }

        void Listar()
        {
            FileStream fileStreamer = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/personas.txt", FileMode.Open); 
            StreamReader streamReader = new StreamReader(fileStreamer); 
            listView1.Items.Clear();
            String[] vectorRegistro;
            String registro, nombre, edad, legajo, sexo, nota1, nota2, nota3,promedionotas;
            //Para listBox:
            //(Codigo) string renglon;
            while (!(streamReader.Peek() == -1))
            {
                registro = streamReader.ReadLine();
                vectorRegistro = registro.Split(';');
                legajo = vectorRegistro[0];
                nombre = vectorRegistro[1];
                edad = vectorRegistro[2];
                sexo = vectorRegistro[3];
                nota1 = vectorRegistro[4];
                nota2 = vectorRegistro[5];
                nota3 = vectorRegistro[6];
                promedionotas = vectorRegistro[7];
                //A cada variable se le asigna una posicion del vector dividido por ;.
                //--------------------
                //Para listBox:
                //(Codigo) renglon = legajo + ";" + nombre + ";" + edad;
                //(Codigo) listBox1.Items.Add(renglon);
                ListViewItem LS = new ListViewItem(legajo); //Crea una instancia de listView y toma como parametro el primer item.
                LS.SubItems.Add(nombre);
                LS.SubItems.Add(edad);
                LS.SubItems.Add(sexo);
                LS.SubItems.Add(nota1);
                LS.SubItems.Add(nota2);
                LS.SubItems.Add(nota3);
                LS.SubItems.Add(promedionotas);
                //Los demas items pasan a ser subitems de la listView.
                listView1.Items.Add(LS); //Se agrega la instancia a la listView del formulario.
            }
            streamReader.Close();
            fileStreamer.Close();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //Si los items seleccionados el conteo es mayor a 0.
            {
                ListViewItem listItem = listView1.SelectedItems[0]; //La clase es igual a los items seleccionados en la posicion 0, (legajo).
                txtLegajo.Text = listItem.Text;
                txtNombre.Text = listItem.SubItems[1].Text;
                txtEdad.Text = listItem.SubItems[2].Text;
                cmbSexo.Text = listItem.SubItems[3].Text;
                txtNota1.Text = listItem.SubItems[4].Text;
                txtNota2.Text = listItem.SubItems[5].Text;
                txtNota3.Text = listItem.SubItems[6].Text;
                //Se igualan los controles al primer item y los subitems respectivamente de la instancia.
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e) //Eliminar.
        {
            foreach (ListViewItem listItem in listView1.SelectedItems) //Para cada elemento de la instancia en los items seleccionados de la listView.
            {
                listItem.Remove(); //Remueve los items seleccionados.
            }           
            txtEdad.Text = txtLegajo.Text = txtNombre.Text =txtNota1.Text=txtNota2.Text=txtNota3.Text= cmbSexo.Text = "";
            FileStream fileStream = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/personas.txt", FileMode.Create); //Abre Stream y crea un nuevo archivo.
            StreamWriter streamWriter = new StreamWriter(fileStream); 
            String reg;
            foreach (ListViewItem listItem in listView1.Items) //Para cada elemento de la instancia en los items de la listView del formulario.
            {

                reg = listItem.SubItems[0].Text + ";" + listItem.SubItems[1].Text + ";" + listItem.SubItems[2].Text + ";" +
                   listItem.SubItems[3].Text + ";" + listItem.SubItems[4] + ";" + listItem.SubItems[5] +";"+listItem.SubItems[6]+";"+ listItem.SubItems[7]; //Se iguala cada elemento de la listView del formulario con sus items(legajo) y sus subitems a la variable reg.
                streamWriter.WriteLine(reg); //Se escribe reg en el archivo.

            }           
            streamWriter.Close();
            fileStream.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Editar.
        {  int promedionotas;
            promedionotas = ((int.Parse(txtNota1.Text) + int.Parse(txtNota2.Text) + int.Parse(txtNota3.Text)) / 3);
            try
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtLegajo.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtNombre.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtEdad.Text;
                listView1.SelectedItems[0].SubItems[3].Text = cmbSexo.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txtNota1.Text;
                listView1.SelectedItems[0].SubItems[5].Text = txtNota2.Text;
                listView1.SelectedItems[0].SubItems[6].Text = txtNota3.Text;
                listView1.SelectedItems[0].SubItems[7].Text = promedionotas.ToString();
                //Indico que el elemento seleccionado con sus subitems cambia segun lo que haya en los controles del formulario.
            }
            catch(Exception)
            {

            }

            FileStream fileStream = new FileStream("C:/Users/Usuario/Desktop/UAI/1°/proramacion 1/personas.txt", FileMode.Create); 
            StreamWriter streamWriter = new StreamWriter(fileStream); 
            String reg;
            
            
            foreach (ListViewItem listItem in listView1.Items)
            {
               
                reg = listItem.SubItems[0].Text + ";" + listItem.SubItems[1].Text + ";" + listItem.SubItems[2].Text +
                    ";" + listItem.SubItems[3].Text + ";" + listItem.SubItems[4].Text + ";" + listItem.SubItems[5].Text + ";" + listItem.SubItems[6].Text + ";" + promedionotas.ToString();
                streamWriter.WriteLine(reg);

            }      
            streamWriter.Close();
            fileStream.Close();
        }
       
        
    }
}

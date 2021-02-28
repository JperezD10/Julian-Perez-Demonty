using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;// libreria importante para utilizar archivos

namespace Archivos_Prog_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        FileStream FS = new FileStream("D:/Personas.txt", FileMode.Append);
        StreamWriter SW = new StreamWriter(FS); //Usa el STREAM WRITER, ya que voy a escribir en el Archivo
        String Reg; //Creo una variable de tipo STRING para poder escrbir
            Reg = txtLegajo.Text + ";" + txtNombre.Text + ";" + txtEdad.Text;
            SW.WriteLine(Reg); //IGUALO al Stream WRITER la Variable REG, que es donde guarde  el Texto
            SW.Close(); //Cierro el Stream Writer
            FS.Close(); //Cierro el Archivo Filestream
           Listar();
         Listar2(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          Listar();
        Listar2();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FileStream FS = new FileStream("D:/Personas.txt", FileMode.Open); //Abro el Archivo "Productos"
            FileStream FSAUX = new FileStream("D:/PersonasAux.txt", FileMode.Create); //Creo un archivo Auxiliar
            StreamReader SR = new StreamReader(FS);
            StreamWriter SW = new StreamWriter(FSAUX);
            String[] vectorregistro;
            String Reg;
            String Legajo;
            while (!(SR.Peek() == -1))
            {
                Reg = SR.ReadLine();
                vectorregistro = Reg.Split(';');
                Legajo = vectorregistro[0]; 
                if (Legajo != txtLegajo.Text) //ESTE != es fundamental
                {
                    SW.WriteLine(Reg);
                }

            }
            SR.Close();
            SW.Close();
            FS.Close();
            FSAUX.Close();
            File.Delete("D:/Personas.txt");
            File.Move("D:/PersonasAux.txt", "D:/Personas.txt");
            Listar();
            Listar2();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FileStream FS = new FileStream("D:/Personas.txt", FileMode.Open); //USO FILESTREAM para ABrir el Archivo
            FileStream FSAUX = new FileStream("D:/PersonasAux.txt", FileMode.Create); //CREO UN ARCHIVO Auxiliar para Escribir
            StreamReader SR = new StreamReader(FS); //Declaro que voy a usar un StreamReader para el Archivo Original
            StreamWriter SW = new StreamWriter(FSAUX);//declaro que voy a usar un StreamWriter para el Archivo AUXILIAR "FSAUX"
            String[] vectorregistro; //Declaro Vector
            String Reg;//declaro Variable de tipo String
            String Legajo;//Declaro la variable con la que voy a revisar los codigos ingresados para modificarlo
            while (!(SR.Peek() == -1)) //Voy a leer el archivo hasta el final
            {
                Reg = SR.ReadLine(); //Igualo REG a la linea Leida
                vectorregistro = Reg.Split(';'); //Declaro que voy a separarlo en Vector por cada ";" que se use
                Legajo = vectorregistro[0]; //Igualo la variable CODIGO a la posicion 0 del Array, que es donde se guarda justamente los codigos del producto
                if (Legajo  == txtLegajo.Text) //Si COINCIDE con el codigo que yo quiero ingresar, Lo permite modificar
                {
                    Reg = txtLegajo.Text + ";" + txtNombre.Text + ";" + txtEdad.Text ; //Guarda en REG los datos de las TEXTBOX
                }
                SW.WriteLine(Reg); //ESCRIBRO EN LA LINEA QUE Leí, los datos de REG
            }
            SR.Close(); //Cierro el STREAR READER
            SW.Close(); //Cierro el Stream Writer
            FS.Close(); //Cierro el  Archivo
            FSAUX.Close(); //cierro el archivo Auxiliar
            File.Delete("D:/Personas.txt"); //Borro el archivo Original
            File.Move("D:/PersonasAUX.txt", "D:/Personas.txt");
           Listar();
           Listar2();
            
        }
        void Listar()
        {

            FileStream FS = new FileStream("D:/Personas.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            lstLista.Items.Clear();
            String[] vectorregistro;
            String registro, renglon;
            String Legajo, Nombre, Edad;
            while (!(SR.Peek() == -1))
            {
                registro = SR.ReadLine();
                vectorregistro = registro.Split(';');
                Legajo = vectorregistro[0];
                Nombre = vectorregistro[1];
                Edad = vectorregistro[2];
                renglon = Legajo + ";" + Nombre + ";" + Edad;
                lstLista.Items.Add(renglon);
            }
            SR.Close();
            FS.Close();

        }

        void Listar2()
        {

            FileStream FS = new FileStream("D:/Personas.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            String[] vectorregistro;
            String registro;
            String Legajo, Nombre, Edad;
            lstvLista.Items.Clear();
            while (!(SR.Peek() == -1))
            {
                registro = SR.ReadLine();
                vectorregistro = registro.Split(';');
                Legajo = vectorregistro[0];
                Nombre = vectorregistro[1];
                Edad = vectorregistro[2];
                
                ListViewItem Ls = new ListViewItem(Legajo);
                Ls.SubItems.Add(Nombre);
                Ls.SubItems.Add(Edad);
                lstvLista.Items.Add(Ls);

            }
            SR.Close();
            FS.Close();

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = lstLista.SelectedItem.ToString();
            String[] vector;
            vector = seleccionado.Split(';');
            txtLegajo .Text = vector[0];
            txtNombre.Text = vector[1];
            txtEdad .Text = vector[2];  
        }
        private void lstvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (lstvLista.SelectedItems.Count > 0)
            {
            ListViewItem listItem =lstvLista.SelectedItems[0];

            txtLegajo.Text = listItem.Text;
            txtNombre.Text = listItem.SubItems[1].Text;
            txtEdad.Text = listItem.SubItems[2].Text;

           }
        }
    }
}

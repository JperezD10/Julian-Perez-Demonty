using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;

namespace Jardin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public _Jardin Jardines = new _Jardin();
        public Lactarios Lactario = new Lactarios();
        public Sala_de_2 SalaDe2 = new Sala_de_2();
        public Maestra Maestras;
        public Inscripcion Inscripciones;
       

        private void BtnVerInfo_Click(object sender, EventArgs e)
        {
            Ver_Info Vi = new Ver_Info(this);
            Vi.ShowDialog();
        }

        private void BtnAgregarMaestra_Click(object sender, EventArgs e)
        {
            Asignar_Maestra Am = new Asignar_Maestra(this);
            Am.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnInscribirAlumno_Click(object sender, EventArgs e)
        {
            Inscribir_Alumno Ia = new Inscribir_Alumno(this);
            Ia.ShowDialog();
        }

        private void BtnImprBoleta_Click(object sender, EventArgs e)
        {
            Imprimir_Boleta Ib = new Imprimir_Boleta(this);
            Ib.ShowDialog();
        }
    }
}

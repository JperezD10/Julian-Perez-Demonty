using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instituto
{
    public partial class frmMenu : Form
    {
        public string[] nombreAlumno = new string[140];
        public int[] legajoAlumno = new int[140];
        public Int32[] edadAlumno = new Int32[140];
        public string[] sexoAlumno = new string[140];
        public string[] becaAlumno = new string[140];
        public Int32[] curso1 = new Int32[20];
        public Int32[] curso2 = new Int32[20];
        public Int32[] curso3 = new Int32[20];
        public Int32[] curso4 = new Int32[20];
        public Int32[] curso5 = new Int32[20];
        public Int32[] curso6 = new Int32[20];
        public Int32[] curso7 = new Int32[20];
        public int valor = 2000,cantidadAlumnosC1=20, cantidadAlumnosC2 = 20, cantidadAlumnosC3 = 20, cantidadAlumnosC4 = 20
            , cantidadAlumnosC5 = 20, cantidadAlumnosC6 = 20, cantidadAlumnosC7 = 20,totalRecaudado=0,totalC1=0,totalC2=0,totalC3=0,totalC4=0,totalC5=0,
            totalC6=0,totalC7=0,cantMujeresC1=0, cantMujeresC2 = 0, cantMujeresC3 = 0, cantMujeresC4 = 0, cantMujeresC5 = 0, cantMujeresC6 = 0, cantMujeresC7 = 0,
            valorBecaCompleta=0,valorBecaMedia=0,valorBecaRegular=0, porcentajeBC=0, porcentajeBM=0, porcentajeBR=0,totalEdad=0,valorPromedioEdad=0,
            valorPromedioEdadC1=0, valorPromedioEdadC2 = 0, valorPromedioEdadC3 = 0, valorPromedioEdadC4 = 0, valorPromedioEdadC5 = 0, valorPromedioEdadC6 = 0,
            valorPromedioEdadC7 = 0,cantEdadC1=0, cantEdadC2 = 0, cantEdadC3 = 0, cantEdadC4 = 0, cantEdadC5 = 0, cantEdadC6 = 0, cantEdadC7 = 0;

        public int i = 0;

        public frmMenu()
        {
            InitializeComponent();
            
        }

        public int xClick = 0, yClick = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left += (e.X - xClick); this.Top += (e.Y - yClick); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistro frmReg = new frmRegistro(this);
            frmReg.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            frmResumen frmRes = new frmResumen(this);
            frmRes.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

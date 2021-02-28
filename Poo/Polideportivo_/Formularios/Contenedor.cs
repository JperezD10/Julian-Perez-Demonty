using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Formularios
{
    public partial class Contenedor : Form
    {
        public List<Juez> jueces = new List<Juez>();
        public List<Cancha> canchas = new List<Cancha>();

        public Contenedor()
        {
            InitializeComponent();
        }
              
        
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MDIParent_Load(object sender, EventArgs e)
        {
            cargarCanchas();
        }

        private void cargarCanchas()
        {
            /*Cancha de Tenis
              Cancha de fútbol 5
              Cancha de fútbol 7
              Cancha de fútbol 11
             */
            canchas.Add(new CanchaTenis());
            canchas.Add(new CanchaFutbol5());
            canchas.Add(new CanchaFutbol7());
            canchas.Add(new CanchaFutbol11());
        }

        private void añadirJuezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJuez ventana = new frmJuez(this);
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void alquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlquiler ventana = new frmAlquiler(this);
            ventana.MdiParent = this;
            ventana.Show();
        }

        public void addJuez(Juez juez) {
           
          jueces.Add(juez);
           
        }

       
        public List<Juez> obtenerArbitros(int turno)
        {
            List<Juez> listaJueces = new List<Juez>();
                      
           
                try {
                foreach (Juez ju in jueces)
                {
                    if (!ju.Turnos[turno])
                    {
                        listaJueces.Add(ju);
                    }
                }
                }catch(Exception ex)
                {
                    MessageBox.Show("Debe seleccionar el turno");
                }
            
            return listaJueces;
        }
    }
}

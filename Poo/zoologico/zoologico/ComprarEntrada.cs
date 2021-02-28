using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoologico
{
    public partial class ComprarEntrada : Form
    {
        int contador = 0;
        museo museo;
        Form1 formulario;
        public ComprarEntrada(museo zoologico,Form1 form)
        {
            InitializeComponent();
            museo = zoologico;
            formulario = form;
        }

        private void ComprarEntrada_Load(object sender, EventArgs e)
        {
            lblNumeroEntrada.Text = museo.entrada.ToString();
            lblTotal.Text = 0.ToString();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            formulario.Show();
        }

        private void ComprarEntrada_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void ComprarEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario.Show();
        }
        public void calcularvalor()
        {
            comprobarChecked();
            switch (contador)
            {
                case 0: lblTotal.Text = 0.ToString(); break;
                case 1: lblTotal.Text = museo.valorbase.ToString(); break;
                case 2: lblTotal.Text = (museo.valorbase - (museo.valorbase * 0.1)).ToString(); break;
                case 3: lblTotal.Text=(museo.valorbase-(museo.valorbase * 0.3)).ToString(); break;
            }
                

        }
        void comprobarChecked()
        {
            if (cbTerrestre.Checked && cbAire.Checked && cbAcuatico.Checked)
            {
                contador = 3;
            }
            else if (cbTerrestre.Checked && cbAire.Checked && !cbAcuatico.Checked ||cbTerrestre.Checked && cbAcuatico.Checked && !cbAire.Checked
               || !cbTerrestre.Checked && cbAire.Checked && cbAcuatico.Checked)
            {
                contador = 2;
            }
            else if (cbTerrestre.Checked && !cbAire.Checked && !cbAcuatico.Checked || !cbTerrestre.Checked && cbAire.Checked && !cbAcuatico.Checked
               || !cbTerrestre.Checked && !cbAire.Checked && cbAcuatico.Checked)
            {
                contador = 1;
            }
            else
            {
                contador = 0;
            }
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            calcularvalor();
        }
    }
}

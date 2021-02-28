using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cu
{
    public partial class MiControl : UserControl
    {
        public MiControl()
        {
            InitializeComponent();
        }

        

        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        protected void SetearColor(Color unColor)
        {
            lblEtiqueta.ForeColor = unColor;
        }

        public virtual bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                ok = false;
               SetearColor( Color.Red);
            }
            else
            {
                SetearColor(Color.Black);
            }
            return ok;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

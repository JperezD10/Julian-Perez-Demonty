using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;

            foreach (Control ctr in this.Controls)
            {
                if (ctr is MiControl)
                {
                    ok = ((MiControl)ctr).Validar() && ok;

                }

            }
            if (!ok)
            {
                MessageBox.Show("Hay campos incompletos");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

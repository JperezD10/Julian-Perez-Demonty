using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_2
{
    public partial class ControlNumerico : ControlUsuario
    {
        public ControlNumerico()
        {
            InitializeComponent();
        }
        public override bool Validar()
        {

            bool ok = base.Validar();

            if (ok)
            {
                int numero;
                ok = int.TryParse(this.Texto, out numero);
                if (!ok)
                {
                    this.SetearColor(System.Drawing.Color.Orange);
                    MessageBox.Show("Solo Numeros");
                }
            }

            return ok;
        }
        private void ControlNumerico_Load(object sender, EventArgs e)
        {

        }
    }
}

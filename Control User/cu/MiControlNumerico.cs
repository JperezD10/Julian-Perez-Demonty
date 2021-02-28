using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cu
{
    public class MiControlNumerico:MiControl
    {
        public override bool Validar()
        {

            bool ok = base.Validar();

            if (ok)
            {
                int numero ;
                ok = int.TryParse(this.Texto, out numero);
                if (!ok)
                {
                    this.SetearColor(System.Drawing.Color.Green);
                }
            }

            return ok;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MiControlNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.Name = "MiControlNumerico";
            this.Load += new System.EventHandler(this.MiControlNumerico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MiControlNumerico_Load(object sender, EventArgs e)
        {

        }
    }
}

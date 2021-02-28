using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
           InitializeComponent();
            this.DoubleBuffered = true;
            
        }
       
        public string LabelRegistro { get => lblRegistro.Text; set => lblRegistro.Text = value; }
        public string Texto { get => txtRegistro.Text; set => txtRegistro.Text = value; }
        public string LabelError { get => lblError.Text; set => lblError.Text = value; }     

        public void selectText()
        {
            this.txtRegistro.Select();
        }
        public Boolean setErrorEmail()
        {
            if (!this.Texto.Contains("@"))
            {
                setLabelError();
                return false;
            }
            return true;
        }

        public void setLabelError()
        {
            lblError.Text = "*Obligatorio";
        }

        public void setLabelNormal()
        {
            lblError.Text = "";
        }
        
        public void setTextPassword()
        {
            txtRegistro.UseSystemPasswordChar = true;
        }
        public void setTextNormal()
        {
            txtRegistro.UseSystemPasswordChar = false;
        }

        public void cleanText()
        {
            txtRegistro.Clear();
        }

        public virtual bool validarData()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(this.txtRegistro.Text))
            {
                ok = false;            
                setLabelError();
            }
            else
            {
                setLabelNormal();
            }
            return ok;
        }
        private void RegisterControl_Load(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;
        }

        public void setReadOnly()
        {
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Enabled = false;

        }

        public void setReadOnlyFalse()
        {
            this.txtRegistro.ReadOnly = false;
            this.txtRegistro.Enabled = true;
        }
        private void TxtRegistro_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

    }
}

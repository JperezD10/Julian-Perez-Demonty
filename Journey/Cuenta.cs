using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journey
{
    public partial class Cuenta : Form
    {
        private int xClick;
        private int yClick;
        WindowsAnimation windowsAnimation = new WindowsAnimation();
        BLL.Gestor_BLL gestor = new BLL.Gestor_BLL();
        BE.Cliente cliente;

        public Cuenta()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left += (e.X - xClick); this.Top += (e.Y - yClick); }
        }

       

        private void CmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPais.ValueMember = "ID_Pais";
            if (cmbPais.SelectedValue != null)
            {
                cmbCiudad.DataSource = gestor.cargarCiudades(int.Parse(cmbPais.SelectedValue.ToString()));
                cmbCiudad.DisplayMember = "Nombre";
                cmbCiudad.ValueMember = "ID_Ciudad";
            }
        }

        private void Cuenta_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is CU.RegisterControl)
                {
                    ((CU.RegisterControl)control).setReadOnly();
                }
                
            }
            cargarPaises();
            getClientData();           
            pictureBox1.Select();
            windowsAnimation.animacionAbrir(this.Handle, 350);         
        }

        private void getClientData()
        {        
            List<BE.Cliente> listaCliente = gestor.getClientData(gestor.getClientID(Properties.Settings.Default.nombreUsuario));          
            foreach (BE.Cliente cliente in listaCliente)
            {
                String[] datos = gestor.getClientNombrePais(cliente.Id_Ciudad);
                registerControl1.Texto = cliente.Nombre;
                registerControl2.Texto = cliente.Apellido;
                registerControl3.Texto = cliente.Dni.ToString();
                dateTimePicker1.Value = cliente.FechaNacimiento;
                cmbCiudad.SelectedIndex = cmbCiudad.FindStringExact(datos[0]);
                cmbPais.SelectedIndex = cmbPais.FindStringExact(datos[1]);
                registerControl4.Texto = cliente.Telefono.ToString();
                registerControl5.Texto = cliente.Direccion;             
            }
        }
        private void cargarPaises()
        {
            cmbPais.DataSource = gestor.cargarPaises();
            cmbPais.DisplayMember = "Nombre";
        }

        private void Cuenta_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            windowsAnimation.animacionCerrar(this.Handle, 350);
            menu.Show();
            this.Close();
            
        }

        private void BtnEditarNombre_Click(object sender, EventArgs e)
        {          
            registerControl1.setReadOnlyFalse();
        }

        private void BtnEditarApellido_Click(object sender, EventArgs e)
        {
            registerControl2.setReadOnlyFalse();
           
        }

        private void BtnEditarDNI_Click(object sender, EventArgs e)
        {
            registerControl3.setReadOnlyFalse();
            
        }

        private void BtnEditarDireccion_Click(object sender, EventArgs e)
        {
            registerControl5.setReadOnlyFalse();
            
        }

        private void BtnEditarTelefono_Click(object sender, EventArgs e)
        {
            registerControl4.setReadOnlyFalse();
            
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            editarCliente();
        }

        private String editarCliente()
        {
            bool ok=true;
            foreach(Control control in this.Controls)
            {
                if(control is CU.RegisterControl)
                {
                    ok = ((CU.RegisterControl)control).validarData() && ok;
                }
            }
            if (ok)
            {
                try
                {
                    cliente = new BE.Cliente();
                    cliente.Id_Cliente = gestor.getClientID(Properties.Settings.Default.nombreUsuario);
                    cliente.Nombre = registerControl1.Texto;
                    cliente.Apellido = registerControl2.Texto;
                    cliente.Dni = int.Parse(registerControl3.Texto);
                    cliente.Telefono = int.Parse(registerControl4.Texto);
                    cliente.Direccion = registerControl5.Texto;
                    cliente.FechaNacimiento = dateTimePicker1.Value;
                    cliente.Id_Ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
                    gestor.editarCliente(cliente);
                    MessageBox.Show("Editado");
                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios");
            }
            return "";
        }
    }
}

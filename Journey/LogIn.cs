using System;
using System.Drawing;
using System.Windows.Forms;

namespace Journey
{
    public partial class JourneyLogIn : Form
    {
        private int xClick;
        private int yClick;

        BE.Cliente clienteTmp;
        BLL.Gestor_BLL gestor = new BLL.Gestor_BLL();
        WindowsAnimation windowsAnimation = new WindowsAnimation();

        public JourneyLogIn()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void Journey_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void Journey_Load(object sender, EventArgs e)
        {
            panelRegistrarse.Visible = false;
            registerControlP.setTextPassword();
            cbMostrarPass.Enabled = false;
            pbLogo.Select();
            windowsAnimation.animacionAbrir(this.Handle,350);           
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (panelRegistrarse.Visible.Equals(true))
            {
                animacionDeslizarCerrar();
            }
            animacionCerrar();
            Application.Exit();

        }

        private void animacionCerrar()
        {
            windowsAnimation.animacionCerrar(this.Handle,500);          
        }

        private void animacionMinimizar()
        {
            windowsAnimation.animacionMinimizar(this.Handle);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            animacionMinimizar();
            this.WindowState = FormWindowState.Minimized;
        }

        void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left += (e.X - xClick); this.Top += (e.Y - yClick); }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void PbLogo_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void TxtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario"))
            {
                setTxtUsuarioClick();
            }
            setLabelLogInNormal();
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text.Equals("Contraseña"))
            {

                setTxtPasswordClick();
            }
            setLabelLogInNormal();
        }

        private void setTxtUsuarioClick()
        {
            txtUsuario.Clear();
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Font = new Font(txtUsuario.Font, FontStyle.Regular);
        }

        private void setTxtPasswordClick()
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Regular);
            cbMostrarPass.Enabled = true;
        }

        private void setTxtUsuarioItalic()
        {
            if (txtUsuario.Text.Equals(""))
            {
                changeTxtUsuario();
            }
        }

        private void setTxtUsuarioItalicPanel()
        {
            if (!txtUsuario.Text.Equals(""))
            {
                changeTxtUsuario();
            }
        }

        private void changeTxtUsuario()
        {
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = Color.DarkGray;
            txtUsuario.Font = new Font(txtUsuario.Font, FontStyle.Italic);
        }
        private void setTxtPasswordItalicPanel()
        {
            if (!txtPassword.Text.Equals(""))
            {
                changeTxtPassword();
            }
        }
        private void setTxtPasswordItalic()
        {
            if (txtPassword.Text.Equals(""))
            {
                changeTxtPassword();
            }
        }

        private void changeTxtPassword()
        {
            txtPassword.Text = "Contraseña";
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ForeColor = Color.DarkGray;
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);
            cbMostrarPass.Checked = false;
            cbMostrarPass.Enabled = false;
        }
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            setTxtUsuarioItalic();
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            setTxtPasswordItalic();

        }

        private void CbMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbMostrarPass.Checked && !txtPassword.Text.Equals("Contraseña"))
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else if (cbMostrarPass.Checked && !txtPassword.Text.Equals("Contraseña"))
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openPanel();
        }

        void openPanel()
        {
            if (panelRegistrarse.Visible.Equals(false))
            {            
                setLabelLogInNormal();
                animacionDeslizarAbrir();
                panelRegistrarse.Visible = true;
                setTxtUsuarioItalicPanel();
                setTxtPasswordItalicPanel();
                cmbPais.DataSource = gestor.cargarPaises();
                cmbPais.DisplayMember = "Nombre";
                registerControl1.selectText();               
            }
            else
            {              
                foreach (Control control in this.panelRegistrarse.Controls)
                {
                    if (control is CU.RegisterControl)
                    {
                        ((CU.RegisterControl)control).setLabelNormal();
                    }
                }            
                animacionDeslizarCerrar();
                dateTimePicker1.Value = DateTime.Now;
                panelRegistrarse.Visible = false;
                setDataSourceNULL();
                cleanRegisterControls();
                setLabelUsuarioExistenteNormal();
            }
        }

        private void animacionDeslizarAbrir()
        {
            windowsAnimation.animacionDeslizarPanelAbrir(panelRegistrarse.Handle);
        }

        private void animacionDeslizarCerrar()
        {
            windowsAnimation.animacionDeslizarPanelCerrar(panelRegistrarse.Handle);
        }
        public void setDataSourceNULL()
        {
            cmbPais.DataSource = null;
            cmbCiudad.DataSource = null;
            cmbPais.Items.Clear();
            cmbCiudad.Items.Clear();
        }

        public void cleanRegisterControls()
        {
            foreach (Control control in this.panelRegistrarse.Controls)
            {
                if (control is CU.RegisterControl)
                {
                    ((CU.RegisterControl)control).cleanText();
                }
            }
        }

        public Boolean comprobarRegisterControls()
        {
            bool ok=true;
            foreach (Control control in this.panelRegistrarse.Controls)
            {
                if (control is CU.RegisterControl)
                {
                    if (((CU.RegisterControl)control).LabelRegistro.Equals("Email"))
                    {                      
                        ok = ((CU.RegisterControl)control).setErrorEmail();
                    }                  
                }
            }
            return ok;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            openPanel();

        }

        private void PanelRegistrarse_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            preRegistrarCliente();
        }

        private void preRegistrarCliente()
        {
            bool ok = true, usuarioExiste = true;
            foreach (Control control in this.panelRegistrarse.Controls)
            {
                if (control is CU.RegisterControl)
                {
                    ok = ((CU.RegisterControl)control).validarData() && ok;
                }
            }
            if (ok)
            {
                try
                {
                    if (comprobarRegisterControls() == true)
                    {
                        registrarCliente(usuarioExiste);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void registrarCliente(bool usuarioExiste)
        {
            clienteTmp = new BE.Cliente();
            clienteTmp.Id_Cliente = 0;
            clienteTmp.Dni = 0;
            clienteTmp.Nombre = registerControl1.Texto;
            clienteTmp.Apellido = registerControl2.Texto;
            clienteTmp.FechaNacimiento = dateTimePicker1.Value;
            clienteTmp.Id_Ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            clienteTmp.Direccion = "";
            clienteTmp.Telefono = 0;
            clienteTmp.Email = registerControl4.Texto;
            clienteTmp.id_LogCliente = 0;
            clienteTmp.User = registerControl5.Texto;
            clienteTmp.Password = gestor.generarHash(registerControlP.Texto, registerControl5.Texto);
            //clienteTmp.Password = gestor.encrypt(Properties.Settings.Default.AESKey);
            usuarioExiste = gestor.comprobarUsuarioExistente(clienteTmp);
            if (!usuarioExiste)
            {
                gestor.inscribirCliente(clienteTmp);
                setLabelUsuarioExistenteNormal();
                MessageBox.Show("El usuario ha sido registrado con éxito.", "Registro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                openPanel();
            }
            else
            {
                setLabelUsuarioExistenteError();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPais.ValueMember = "ID_Pais";
            if (cmbPais.SelectedValue != null)
            {
                cmbCiudad.DataSource = gestor.cargarCiudades(int.Parse(cmbPais.SelectedValue.ToString()));
                cmbCiudad.DisplayMember = "Nombre";
                cmbCiudad.ValueMember = "ID_Ciudad";
            }
        }

        private void CbContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbContraseña.Checked)
            {
                registerControlP.setTextPassword();
            }
            else
            {
                registerControlP.setTextNormal();
            }
        }

        private void logIn()
        {
            clienteTmp = new BE.Cliente();
            clienteTmp.User = txtUsuario.Text;
            clienteTmp.Password = gestor.generarHash(txtPassword.Text, txtUsuario.Text);
            //clienteTmp.Password = gestor.encrypt(Properties.Settings.Default.AESKey);
            //gestor.iniciarSesion(clienteTmp,Properties.Settings.Default.AESKey).Equals(true)
            if (gestor.iniciarSesion(clienteTmp))
            {
                Properties.Settings.Default.nombreUsuario = txtUsuario.Text;
                Properties.Settings.Default.Save();
                Menu mainMenu = new Menu();
                animacionCerrar();
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                setLabelLogInError();
            }
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            logIn();
        }

        private void setLabelUsuarioExistenteError()
        {
            lblUsuarioExistente.Text = "El usuario ya existe.";
            lblUsuarioExistente.Visible = true;
        }

        private void setLabelUsuarioExistenteNormal()
        {
            lblUsuarioExistente.Visible = false;
        }
        private void setLabelLogInError()
        {
            lblLogIn.Text = "*Usuario y/o contraseña incorrecto.";
            lblLogIn.Visible = true;
        }

        private void setLabelLogInNormal()
        {
            lblLogIn.Visible = false;
        }

        private void RegisterControl5_MouseClick(object sender, MouseEventArgs e)
        {
            setLabelUsuarioExistenteNormal();
        }
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario"))
            {
                setTxtUsuarioClick();
            }
        }
        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Contraseña"))
            {
                setTxtPasswordClick();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Enter))
            {
                logIn();
                e.Handled = true;
            }
        }

        private void LinkOlvidarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

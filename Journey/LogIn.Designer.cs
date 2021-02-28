namespace Journey
{
    partial class JourneyLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JourneyLogIn));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.cbMostrarPass = new System.Windows.Forms.CheckBox();
            this.linkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.panelRegistrarse = new System.Windows.Forms.Panel();
            this.registerControlP = new CU.RegisterControl();
            this.lblUsuarioExistente = new System.Windows.Forms.Label();
            this.cbContraseña = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.registerControl5 = new CU.RegisterControl();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerControl4 = new CU.RegisterControl();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.registerControl2 = new CU.RegisterControl();
            this.registerControl1 = new CU.RegisterControl();
            this.lblLogIn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            this.panelRegistrarse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Journey.Properties.Resources.LOGOFINAL2;
            this.pbLogo.Location = new System.Drawing.Point(179, 97);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(137, 131);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbLogo_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::Journey.Properties.Resources._936311;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Location = new System.Drawing.Point(427, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(17, 15);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::Journey.Properties.Resources._61155;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Location = new System.Drawing.Point(459, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 15);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.SteelBlue;
            this.panelUp.Controls.Add(this.btnMenu);
            this.panelUp.Controls.Add(this.btnCerrar);
            this.panelUp.Controls.Add(this.btnMinimizar);
            this.panelUp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(489, 66);
            this.panelUp.TabIndex = 3;
            this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::Journey.Properties.Resources.menu_icon_6;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(59, 66);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightCyan;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(131, 298);
            this.txtUsuario.MaxLength = 35;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(256, 27);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtUsuario_MouseClick);
            this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(131, 378);
            this.txtPassword.MaxLength = 35;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtPassword_MouseClick);
            this.txtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.LightCyan;
            this.pbUser.Image = global::Journey.Properties.Resources.UserLogo;
            this.pbUser.Location = new System.Drawing.Point(360, 298);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(27, 27);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 6;
            this.pbUser.TabStop = false;
            // 
            // pbLock
            // 
            this.pbLock.BackColor = System.Drawing.Color.LightCyan;
            this.pbLock.Image = global::Journey.Properties.Resources.LockPassword;
            this.pbLock.Location = new System.Drawing.Point(360, 378);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(27, 27);
            this.pbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLock.TabIndex = 7;
            this.pbLock.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(115, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(115, 411);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 1);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Location = new System.Drawing.Point(115, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 27);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightCyan;
            this.panel5.Location = new System.Drawing.Point(115, 378);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 27);
            this.panel5.TabIndex = 11;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLog.Location = new System.Drawing.Point(196, 488);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(110, 43);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "Log In";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // cbMostrarPass
            // 
            this.cbMostrarPass.AutoSize = true;
            this.cbMostrarPass.BackColor = System.Drawing.Color.Transparent;
            this.cbMostrarPass.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbMostrarPass.FlatAppearance.BorderSize = 0;
            this.cbMostrarPass.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbMostrarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMostrarPass.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrarPass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbMostrarPass.Location = new System.Drawing.Point(115, 418);
            this.cbMostrarPass.Name = "cbMostrarPass";
            this.cbMostrarPass.Size = new System.Drawing.Size(155, 23);
            this.cbMostrarPass.TabIndex = 4;
            this.cbMostrarPass.Text = "Mostrar caracteres";
            this.cbMostrarPass.UseVisualStyleBackColor = false;
            this.cbMostrarPass.CheckedChanged += new System.EventHandler(this.CbMostrarPass_CheckedChanged);
            // 
            // linkRegistrarse
            // 
            this.linkRegistrarse.AutoSize = true;
            this.linkRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.linkRegistrarse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistrarse.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkRegistrarse.Location = new System.Drawing.Point(145, 548);
            this.linkRegistrarse.Name = "linkRegistrarse";
            this.linkRegistrarse.Size = new System.Drawing.Size(214, 19);
            this.linkRegistrarse.TabIndex = 6;
            this.linkRegistrarse.TabStop = true;
            this.linkRegistrarse.Text = "¿No tiene cuenta? Registrarse";
            this.linkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // panelRegistrarse
            // 
            this.panelRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.panelRegistrarse.BackgroundImage = global::Journey.Properties.Resources._664b6af1e2428aed06246af0c6581efb;
            this.panelRegistrarse.Controls.Add(this.registerControlP);
            this.panelRegistrarse.Controls.Add(this.lblUsuarioExistente);
            this.panelRegistrarse.Controls.Add(this.cbContraseña);
            this.panelRegistrarse.Controls.Add(this.dateTimePicker1);
            this.panelRegistrarse.Controls.Add(this.label3);
            this.panelRegistrarse.Controls.Add(this.registerControl5);
            this.panelRegistrarse.Controls.Add(this.btnRegistrarse);
            this.panelRegistrarse.Controls.Add(this.label2);
            this.panelRegistrarse.Controls.Add(this.label1);
            this.panelRegistrarse.Controls.Add(this.registerControl4);
            this.panelRegistrarse.Controls.Add(this.cmbCiudad);
            this.panelRegistrarse.Controls.Add(this.cmbPais);
            this.panelRegistrarse.Controls.Add(this.registerControl2);
            this.panelRegistrarse.Controls.Add(this.registerControl1);
            this.panelRegistrarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRegistrarse.Location = new System.Drawing.Point(0, 65);
            this.panelRegistrarse.Name = "panelRegistrarse";
            this.panelRegistrarse.Size = new System.Drawing.Size(489, 667);
            this.panelRegistrarse.TabIndex = 15;
            this.panelRegistrarse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelRegistrarse_MouseMove);
            // 
            // registerControlP
            // 
            this.registerControlP.BackColor = System.Drawing.Color.Transparent;
            this.registerControlP.LabelError = "";
            this.registerControlP.LabelRegistro = "Contraseña";
            this.registerControlP.Location = new System.Drawing.Point(57, 446);
            this.registerControlP.Name = "registerControlP";
            this.registerControlP.Size = new System.Drawing.Size(419, 55);
            this.registerControlP.TabIndex = 25;
            this.registerControlP.Texto = "";
            // 
            // lblUsuarioExistente
            // 
            this.lblUsuarioExistente.AutoSize = true;
            this.lblUsuarioExistente.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuarioExistente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioExistente.ForeColor = System.Drawing.Color.Red;
            this.lblUsuarioExistente.Location = new System.Drawing.Point(101, 424);
            this.lblUsuarioExistente.Name = "lblUsuarioExistente";
            this.lblUsuarioExistente.Size = new System.Drawing.Size(52, 19);
            this.lblUsuarioExistente.TabIndex = 18;
            this.lblUsuarioExistente.Text = "label4";
            this.lblUsuarioExistente.Visible = false;
            // 
            // cbContraseña
            // 
            this.cbContraseña.AutoSize = true;
            this.cbContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContraseña.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContraseña.Location = new System.Drawing.Point(105, 502);
            this.cbContraseña.Name = "cbContraseña";
            this.cbContraseña.Size = new System.Drawing.Size(155, 23);
            this.cbContraseña.TabIndex = 26;
            this.cbContraseña.Text = "Mostrar caracteres";
            this.cbContraseña.UseVisualStyleBackColor = true;
            this.cbContraseña.CheckedChanged += new System.EventHandler(this.CbContraseña_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 197);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 23);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // registerControl5
            // 
            this.registerControl5.BackColor = System.Drawing.Color.Transparent;
            this.registerControl5.LabelError = "";
            this.registerControl5.LabelRegistro = "Usuario";
            this.registerControl5.Location = new System.Drawing.Point(57, 379);
            this.registerControl5.Name = "registerControl5";
            this.registerControl5.Size = new System.Drawing.Size(419, 55);
            this.registerControl5.TabIndex = 24;
            this.registerControl5.Texto = "";
            this.registerControl5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegisterControl5_MouseClick);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Navy;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarse.Location = new System.Drawing.Point(177, 556);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(139, 43);
            this.btnRegistrarse.TabIndex = 27;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "País";
            // 
            // registerControl4
            // 
            this.registerControl4.BackColor = System.Drawing.Color.Transparent;
            this.registerControl4.LabelError = "";
            this.registerControl4.LabelRegistro = "Email";
            this.registerControl4.Location = new System.Drawing.Point(58, 311);
            this.registerControl4.Name = "registerControl4";
            this.registerControl4.Size = new System.Drawing.Size(418, 55);
            this.registerControl4.TabIndex = 23;
            this.registerControl4.Texto = "";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.LightCyan;
            this.cmbCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(262, 263);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(140, 24);
            this.cmbCiudad.TabIndex = 22;
            // 
            // cmbPais
            // 
            this.cmbPais.BackColor = System.Drawing.Color.LightCyan;
            this.cmbPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(105, 263);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(140, 24);
            this.cmbPais.TabIndex = 21;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // registerControl2
            // 
            this.registerControl2.BackColor = System.Drawing.Color.Transparent;
            this.registerControl2.LabelError = "";
            this.registerControl2.LabelRegistro = "Apellido";
            this.registerControl2.Location = new System.Drawing.Point(57, 106);
            this.registerControl2.Name = "registerControl2";
            this.registerControl2.Size = new System.Drawing.Size(419, 55);
            this.registerControl2.TabIndex = 18;
            this.registerControl2.Texto = "";
            // 
            // registerControl1
            // 
            this.registerControl1.BackColor = System.Drawing.Color.Transparent;
            this.registerControl1.LabelError = "";
            this.registerControl1.LabelRegistro = "Nombre";
            this.registerControl1.Location = new System.Drawing.Point(58, 44);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(418, 55);
            this.registerControl1.TabIndex = 17;
            this.registerControl1.Texto = "";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogIn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.Red;
            this.lblLogIn.Location = new System.Drawing.Point(114, 446);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(52, 19);
            this.lblLogIn.TabIndex = 17;
            this.lblLogIn.Text = "label4";
            this.lblLogIn.Visible = false;
            // 
            // JourneyLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Journey.Properties.Resources.sdsdssdds1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 721);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.panelRegistrarse);
            this.Controls.Add(this.linkRegistrarse);
            this.Controls.Add(this.cbMostrarPass);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbLock);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JourneyLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Journey_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Journey_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            this.panelRegistrarse.ResumeLayout(false);
            this.panelRegistrarse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.CheckBox cbMostrarPass;
        private System.Windows.Forms.LinkLabel linkRegistrarse;
        private System.Windows.Forms.Panel panelRegistrarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CU.RegisterControl registerControl4;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbPais;
        private CU.RegisterControl registerControl2;
        private CU.RegisterControl registerControl1;
        private System.Windows.Forms.Button btnRegistrarse;
        private CU.RegisterControl registerControl5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbContraseña;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblUsuarioExistente;
        private CU.RegisterControl registerControlP;
    }
}


namespace Journey
{
    partial class Cuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuenta));
            this.registerControl1 = new CU.RegisterControl();
            this.registerControl2 = new CU.RegisterControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.registerControl3 = new CU.RegisterControl();
            this.registerControl4 = new CU.RegisterControl();
            this.registerControl5 = new CU.RegisterControl();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditarNombre = new System.Windows.Forms.Button();
            this.btnEditarApellido = new System.Windows.Forms.Button();
            this.btnEditarDNI = new System.Windows.Forms.Button();
            this.btnEditarDireccion = new System.Windows.Forms.Button();
            this.btnEditarTelefono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerControl1
            // 
            this.registerControl1.BackColor = System.Drawing.Color.Transparent;
            this.registerControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerControl1.LabelError = "";
            this.registerControl1.LabelRegistro = "Nombre";
            this.registerControl1.Location = new System.Drawing.Point(62, 88);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(330, 55);
            this.registerControl1.TabIndex = 18;
            this.registerControl1.Texto = "";
            // 
            // registerControl2
            // 
            this.registerControl2.BackColor = System.Drawing.Color.Transparent;
            this.registerControl2.LabelError = "";
            this.registerControl2.LabelRegistro = "Apellido";
            this.registerControl2.Location = new System.Drawing.Point(62, 159);
            this.registerControl2.Name = "registerControl2";
            this.registerControl2.Size = new System.Drawing.Size(316, 55);
            this.registerControl2.TabIndex = 19;
            this.registerControl2.Texto = "";
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
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 338);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 23);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "País";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.BackColor = System.Drawing.Color.LightCyan;
            this.cmbCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(275, 417);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(140, 24);
            this.cmbCiudad.TabIndex = 32;
            // 
            // cmbPais
            // 
            this.cmbPais.BackColor = System.Drawing.Color.LightCyan;
            this.cmbPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(112, 417);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(140, 24);
            this.cmbPais.TabIndex = 31;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.CmbPais_SelectedIndexChanged);
            // 
            // registerControl3
            // 
            this.registerControl3.BackColor = System.Drawing.Color.Transparent;
            this.registerControl3.LabelError = "";
            this.registerControl3.LabelRegistro = "DNI";
            this.registerControl3.Location = new System.Drawing.Point(62, 229);
            this.registerControl3.Name = "registerControl3";
            this.registerControl3.Size = new System.Drawing.Size(321, 55);
            this.registerControl3.TabIndex = 37;
            this.registerControl3.Texto = "";
            // 
            // registerControl4
            // 
            this.registerControl4.BackColor = System.Drawing.Color.Transparent;
            this.registerControl4.LabelError = "";
            this.registerControl4.LabelRegistro = "Teléfono";
            this.registerControl4.Location = new System.Drawing.Point(62, 540);
            this.registerControl4.Name = "registerControl4";
            this.registerControl4.Size = new System.Drawing.Size(321, 55);
            this.registerControl4.TabIndex = 39;
            this.registerControl4.Texto = "";
            // 
            // registerControl5
            // 
            this.registerControl5.BackColor = System.Drawing.Color.Transparent;
            this.registerControl5.LabelError = "";
            this.registerControl5.LabelRegistro = "Dirección";
            this.registerControl5.Location = new System.Drawing.Point(62, 470);
            this.registerControl5.Name = "registerControl5";
            this.registerControl5.Size = new System.Drawing.Size(316, 55);
            this.registerControl5.TabIndex = 38;
            this.registerControl5.Texto = "";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::Journey.Properties.Resources.Sin_título_2;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(44, 41);
            this.btnMenu.TabIndex = 41;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Journey.Properties.Resources.ppppp1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(56, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 13);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Location = new System.Drawing.Point(168, 633);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 43);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // btnEditarNombre
            // 
            this.btnEditarNombre.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarNombre.BackgroundImage = global::Journey.Properties.Resources.editLogo1;
            this.btnEditarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarNombre.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditarNombre.FlatAppearance.BorderSize = 0;
            this.btnEditarNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnEditarNombre.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNombre.Location = new System.Drawing.Point(367, 109);
            this.btnEditarNombre.Name = "btnEditarNombre";
            this.btnEditarNombre.Size = new System.Drawing.Size(25, 25);
            this.btnEditarNombre.TabIndex = 44;
            this.btnEditarNombre.UseVisualStyleBackColor = false;
            this.btnEditarNombre.Click += new System.EventHandler(this.BtnEditarNombre_Click);
            // 
            // btnEditarApellido
            // 
            this.btnEditarApellido.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarApellido.BackgroundImage = global::Journey.Properties.Resources.editLogo1;
            this.btnEditarApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarApellido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditarApellido.FlatAppearance.BorderSize = 0;
            this.btnEditarApellido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnEditarApellido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditarApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarApellido.Location = new System.Drawing.Point(367, 180);
            this.btnEditarApellido.Name = "btnEditarApellido";
            this.btnEditarApellido.Size = new System.Drawing.Size(25, 25);
            this.btnEditarApellido.TabIndex = 45;
            this.btnEditarApellido.UseVisualStyleBackColor = false;
            this.btnEditarApellido.Click += new System.EventHandler(this.BtnEditarApellido_Click);
            // 
            // btnEditarDNI
            // 
            this.btnEditarDNI.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarDNI.BackgroundImage = global::Journey.Properties.Resources.editLogo1;
            this.btnEditarDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarDNI.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditarDNI.FlatAppearance.BorderSize = 0;
            this.btnEditarDNI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnEditarDNI.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditarDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDNI.Location = new System.Drawing.Point(367, 250);
            this.btnEditarDNI.Name = "btnEditarDNI";
            this.btnEditarDNI.Size = new System.Drawing.Size(25, 25);
            this.btnEditarDNI.TabIndex = 46;
            this.btnEditarDNI.UseVisualStyleBackColor = false;
            this.btnEditarDNI.Click += new System.EventHandler(this.BtnEditarDNI_Click);
            // 
            // btnEditarDireccion
            // 
            this.btnEditarDireccion.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarDireccion.BackgroundImage = global::Journey.Properties.Resources.editLogo1;
            this.btnEditarDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarDireccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditarDireccion.FlatAppearance.BorderSize = 0;
            this.btnEditarDireccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnEditarDireccion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDireccion.Location = new System.Drawing.Point(367, 490);
            this.btnEditarDireccion.Name = "btnEditarDireccion";
            this.btnEditarDireccion.Size = new System.Drawing.Size(25, 25);
            this.btnEditarDireccion.TabIndex = 47;
            this.btnEditarDireccion.UseVisualStyleBackColor = false;
            this.btnEditarDireccion.Click += new System.EventHandler(this.BtnEditarDireccion_Click);
            // 
            // btnEditarTelefono
            // 
            this.btnEditarTelefono.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarTelefono.BackgroundImage = global::Journey.Properties.Resources.editLogo1;
            this.btnEditarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarTelefono.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditarTelefono.FlatAppearance.BorderSize = 0;
            this.btnEditarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnEditarTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTelefono.Location = new System.Drawing.Point(367, 560);
            this.btnEditarTelefono.Name = "btnEditarTelefono";
            this.btnEditarTelefono.Size = new System.Drawing.Size(25, 25);
            this.btnEditarTelefono.TabIndex = 48;
            this.btnEditarTelefono.UseVisualStyleBackColor = false;
            this.btnEditarTelefono.Click += new System.EventHandler(this.BtnEditarTelefono_Click);
            // 
            // Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Journey.Properties.Resources._664b6af1e2428aed06246af0c6581efb;
            this.ClientSize = new System.Drawing.Size(479, 725);
            this.Controls.Add(this.btnEditarTelefono);
            this.Controls.Add(this.btnEditarDireccion);
            this.Controls.Add(this.btnEditarDNI);
            this.Controls.Add(this.btnEditarApellido);
            this.Controls.Add(this.btnEditarNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.registerControl4);
            this.Controls.Add(this.registerControl5);
            this.Controls.Add(this.registerControl3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.registerControl2);
            this.Controls.Add(this.registerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.Cuenta_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cuenta_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CU.RegisterControl registerControl1;
        private CU.RegisterControl registerControl2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbPais;
        private CU.RegisterControl registerControl3;
        private CU.RegisterControl registerControl4;
        private CU.RegisterControl registerControl5;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardar;
        
        private System.Windows.Forms.Button btnEditarNombre;
        private System.Windows.Forms.Button btnEditarApellido;
        private System.Windows.Forms.Button btnEditarDNI;
        private System.Windows.Forms.Button btnEditarDireccion;
        private System.Windows.Forms.Button btnEditarTelefono;
    }
}
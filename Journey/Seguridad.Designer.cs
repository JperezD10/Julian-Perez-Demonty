namespace Journey
{
    partial class Seguridad
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.regPassNuevo = new CU.RegisterControl();
            this.regPassRepetir = new CU.RegisterControl();
            this.regPassActual = new CU.RegisterControl();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnEditarPassActual = new System.Windows.Forms.Button();
            this.btnPassNuevo = new System.Windows.Forms.Button();
            this.btnRepetirPass = new System.Windows.Forms.Button();
            this.regUsuario = new CU.RegisterControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Journey.Properties.Resources.ppppp1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(56, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 13);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
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
            this.btnMenu.TabIndex = 43;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // regPassNuevo
            // 
            this.regPassNuevo.BackColor = System.Drawing.Color.Transparent;
            this.regPassNuevo.LabelError = "label";
            this.regPassNuevo.LabelRegistro = "Contraseña nueva";
            this.regPassNuevo.Location = new System.Drawing.Point(61, 260);
            this.regPassNuevo.Name = "regPassNuevo";
            this.regPassNuevo.Size = new System.Drawing.Size(305, 55);
            this.regPassNuevo.TabIndex = 46;
            this.regPassNuevo.Texto = "";
            // 
            // regPassRepetir
            // 
            this.regPassRepetir.BackColor = System.Drawing.Color.Transparent;
            this.regPassRepetir.LabelError = "label";
            this.regPassRepetir.LabelRegistro = "Repetir contraseña";
            this.regPassRepetir.Location = new System.Drawing.Point(61, 343);
            this.regPassRepetir.Name = "regPassRepetir";
            this.regPassRepetir.Size = new System.Drawing.Size(305, 55);
            this.regPassRepetir.TabIndex = 47;
            this.regPassRepetir.Texto = "";
            // 
            // regPassActual
            // 
            this.regPassActual.BackColor = System.Drawing.Color.Transparent;
            this.regPassActual.LabelError = "label";
            this.regPassActual.LabelRegistro = "Contraseña actual";
            this.regPassActual.Location = new System.Drawing.Point(61, 174);
            this.regPassActual.Name = "regPassActual";
            this.regPassActual.Size = new System.Drawing.Size(305, 55);
            this.regPassActual.TabIndex = 45;
            this.regPassActual.Texto = "";
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
            this.btnRegistrarse.Location = new System.Drawing.Point(168, 440);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(139, 43);
            this.btnRegistrarse.TabIndex = 48;
            this.btnRegistrarse.Text = "Guardar";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // btnEditarPassActual
            // 
            this.btnEditarPassActual.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarPassActual.BackgroundImage = global::Journey.Properties.Resources.editLogo1;
            this.btnEditarPassActual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarPassActual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditarPassActual.FlatAppearance.BorderSize = 0;
            this.btnEditarPassActual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnEditarPassActual.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditarPassActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPassActual.Location = new System.Drawing.Point(363, 196);
            this.btnEditarPassActual.Name = "btnEditarPassActual";
            this.btnEditarPassActual.Size = new System.Drawing.Size(25, 25);
            this.btnEditarPassActual.TabIndex = 50;
            this.btnEditarPassActual.UseVisualStyleBackColor = false;
            this.btnEditarPassActual.Click += new System.EventHandler(this.BtnEditarPassActual_Click);
            // 
            // btnPassNuevo
            // 
            this.btnPassNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnPassNuevo.BackgroundImage = global::Journey.Properties.Resources.editLogo1;
            this.btnPassNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPassNuevo.FlatAppearance.BorderSize = 0;
            this.btnPassNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnPassNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPassNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassNuevo.Location = new System.Drawing.Point(363, 281);
            this.btnPassNuevo.Name = "btnPassNuevo";
            this.btnPassNuevo.Size = new System.Drawing.Size(25, 25);
            this.btnPassNuevo.TabIndex = 51;
            this.btnPassNuevo.UseVisualStyleBackColor = false;
            this.btnPassNuevo.Click += new System.EventHandler(this.BtnPassNuevo_Click);
            // 
            // btnRepetirPass
            // 
            this.btnRepetirPass.BackColor = System.Drawing.Color.Transparent;
            this.btnRepetirPass.BackgroundImage = global::Journey.Properties.Resources.editLogo1;
            this.btnRepetirPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepetirPass.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRepetirPass.FlatAppearance.BorderSize = 0;
            this.btnRepetirPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnRepetirPass.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRepetirPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepetirPass.Location = new System.Drawing.Point(363, 364);
            this.btnRepetirPass.Name = "btnRepetirPass";
            this.btnRepetirPass.Size = new System.Drawing.Size(25, 25);
            this.btnRepetirPass.TabIndex = 52;
            this.btnRepetirPass.UseVisualStyleBackColor = false;
            this.btnRepetirPass.Click += new System.EventHandler(this.BtnRepetirPass_Click);
            // 
            // regUsuario
            // 
            this.regUsuario.BackColor = System.Drawing.Color.Transparent;
            this.regUsuario.LabelError = "label";
            this.regUsuario.LabelRegistro = "Usuario";
            this.regUsuario.Location = new System.Drawing.Point(61, 91);
            this.regUsuario.Name = "regUsuario";
            this.regUsuario.Size = new System.Drawing.Size(305, 55);
            this.regUsuario.TabIndex = 49;
            this.regUsuario.Texto = "";
            // 
            // Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Journey.Properties.Resources._664b6af1e2428aed06246af0c6581efb;
            this.ClientSize = new System.Drawing.Size(479, 548);
            this.Controls.Add(this.btnRepetirPass);
            this.Controls.Add(this.btnPassNuevo);
            this.Controls.Add(this.btnEditarPassActual);
            this.Controls.Add(this.regUsuario);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.regPassRepetir);
            this.Controls.Add(this.regPassNuevo);
            this.Controls.Add(this.regPassActual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad";
            this.Load += new System.EventHandler(this.Seguridad_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Seguridad_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private CU.RegisterControl regPassNuevo;
        private CU.RegisterControl regPassRepetir;
        private CU.RegisterControl regPassActual;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnEditarPassActual;
        private System.Windows.Forms.Button btnPassNuevo;
        private System.Windows.Forms.Button btnRepetirPass;
        private CU.RegisterControl regUsuario;
    }
}
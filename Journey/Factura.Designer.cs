namespace Journey
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbFacturas = new System.Windows.Forms.ListBox();
            this.lblPrecioFactura = new System.Windows.Forms.Label();
            this.lblFechaRealizacion = new System.Windows.Forms.Label();
            this.lblHoraRealizacion = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Journey.Properties.Resources.ppppp1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(62, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 13);
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
            // lbFacturas
            // 
            this.lbFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this.lbFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFacturas.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturas.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbFacturas.FormattingEnabled = true;
            this.lbFacturas.ItemHeight = 26;
            this.lbFacturas.Location = new System.Drawing.Point(339, 55);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(263, 312);
            this.lbFacturas.TabIndex = 45;
            this.lbFacturas.SelectedIndexChanged += new System.EventHandler(this.LbFacturas_SelectedIndexChanged);
            // 
            // lblPrecioFactura
            // 
            this.lblPrecioFactura.AutoSize = true;
            this.lblPrecioFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioFactura.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecioFactura.Location = new System.Drawing.Point(110, 346);
            this.lblPrecioFactura.Name = "lblPrecioFactura";
            this.lblPrecioFactura.Size = new System.Drawing.Size(16, 19);
            this.lblPrecioFactura.TabIndex = 53;
            this.lblPrecioFactura.Text = "-";
            // 
            // lblFechaRealizacion
            // 
            this.lblFechaRealizacion.AutoSize = true;
            this.lblFechaRealizacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaRealizacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRealizacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaRealizacion.Location = new System.Drawing.Point(110, 177);
            this.lblFechaRealizacion.Name = "lblFechaRealizacion";
            this.lblFechaRealizacion.Size = new System.Drawing.Size(16, 19);
            this.lblFechaRealizacion.TabIndex = 52;
            this.lblFechaRealizacion.Text = "-";
            this.lblFechaRealizacion.Click += new System.EventHandler(this.LblFechaLlegada_Click);
            // 
            // lblHoraRealizacion
            // 
            this.lblHoraRealizacion.AutoSize = true;
            this.lblHoraRealizacion.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraRealizacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraRealizacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraRealizacion.Location = new System.Drawing.Point(110, 262);
            this.lblHoraRealizacion.Name = "lblHoraRealizacion";
            this.lblHoraRealizacion.Size = new System.Drawing.Size(16, 19);
            this.lblHoraRealizacion.TabIndex = 51;
            this.lblHoraRealizacion.Text = "-";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoFactura.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoFactura.Location = new System.Drawing.Point(110, 97);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(16, 19);
            this.lblTipoFactura.TabIndex = 50;
            this.lblTipoFactura.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(110, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Precio factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(110, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Hora de realización:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(110, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Fecha de realización:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(110, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tipo de factura:";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Journey.Properties.Resources._664b6af1e2428aed06246af0c6581efb;
            this.ClientSize = new System.Drawing.Size(649, 422);
            this.Controls.Add(this.lblPrecioFactura);
            this.Controls.Add(this.lblFechaRealizacion);
            this.Controls.Add(this.lblHoraRealizacion);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFacturas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Factura_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Factura_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ListBox lbFacturas;
        private System.Windows.Forms.Label lblPrecioFactura;
        private System.Windows.Forms.Label lblFechaRealizacion;
        private System.Windows.Forms.Label lblHoraRealizacion;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
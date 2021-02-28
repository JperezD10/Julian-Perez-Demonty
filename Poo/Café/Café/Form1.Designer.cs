namespace Café
{
    partial class Cafeteria
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
            this.lbMaquinas = new System.Windows.Forms.ListBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbArabigo = new System.Windows.Forms.RadioButton();
            this.rbRobusto = new System.Windows.Forms.RadioButton();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblPrecioxLt = new System.Windows.Forms.Label();
            this.lblTipoCafe = new System.Windows.Forms.Label();
            this.lblTotalMaquina = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoVaso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnComprarCafe = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTamañoVaso = new System.Windows.Forms.Label();
            this.txtTipoCafe = new System.Windows.Forms.TextBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaquinas
            // 
            this.lbMaquinas.FormattingEnabled = true;
            this.lbMaquinas.Location = new System.Drawing.Point(34, 205);
            this.lbMaquinas.Name = "lbMaquinas";
            this.lbMaquinas.Size = new System.Drawing.Size(120, 160);
            this.lbMaquinas.TabIndex = 0;
            this.lbMaquinas.SelectedIndexChanged += new System.EventHandler(this.lbMaquinas_SelectedIndexChanged);
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(215, 67);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(79, 20);
            this.txtCapacidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capacidad (Lt):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbArabigo
            // 
            this.rbArabigo.AutoSize = true;
            this.rbArabigo.Checked = true;
            this.rbArabigo.Location = new System.Drawing.Point(34, 49);
            this.rbArabigo.Name = "rbArabigo";
            this.rbArabigo.Size = new System.Drawing.Size(86, 17);
            this.rbArabigo.TabIndex = 3;
            this.rbArabigo.TabStop = true;
            this.rbArabigo.Text = "Café Arabigo";
            this.rbArabigo.UseVisualStyleBackColor = true;
            // 
            // rbRobusto
            // 
            this.rbRobusto.AutoSize = true;
            this.rbRobusto.Location = new System.Drawing.Point(34, 83);
            this.rbRobusto.Name = "rbRobusto";
            this.rbRobusto.Size = new System.Drawing.Size(90, 17);
            this.rbRobusto.TabIndex = 4;
            this.rbRobusto.Text = "Café Robusto";
            this.rbRobusto.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(215, 116);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(74, 36);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar Maquina";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resumenToolStripMenuItem.Text = "Resumen";
            this.resumenToolStripMenuItem.Click += new System.EventHandler(this.resumenToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "$50 x Lt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "$58 x Lt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Capacidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio x Lt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Cafe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Maquina:";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(115, 387);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(10, 13);
            this.lblCapacidad.TabIndex = 13;
            this.lblCapacidad.Text = "-";
            // 
            // lblPrecioxLt
            // 
            this.lblPrecioxLt.AutoSize = true;
            this.lblPrecioxLt.Location = new System.Drawing.Point(114, 430);
            this.lblPrecioxLt.Name = "lblPrecioxLt";
            this.lblPrecioxLt.Size = new System.Drawing.Size(10, 13);
            this.lblPrecioxLt.TabIndex = 14;
            this.lblPrecioxLt.Text = "-";
            // 
            // lblTipoCafe
            // 
            this.lblTipoCafe.AutoSize = true;
            this.lblTipoCafe.Location = new System.Drawing.Point(238, 387);
            this.lblTipoCafe.Name = "lblTipoCafe";
            this.lblTipoCafe.Size = new System.Drawing.Size(10, 13);
            this.lblTipoCafe.TabIndex = 15;
            this.lblTipoCafe.Text = "-";
            // 
            // lblTotalMaquina
            // 
            this.lblTotalMaquina.AutoSize = true;
            this.lblTotalMaquina.Location = new System.Drawing.Point(260, 431);
            this.lblTotalMaquina.Name = "lblTotalMaquina";
            this.lblTotalMaquina.Size = new System.Drawing.Size(10, 13);
            this.lblTotalMaquina.TabIndex = 16;
            this.lblTotalMaquina.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo café:";
            // 
            // cmbTipoVaso
            // 
            this.cmbTipoVaso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVaso.FormattingEnabled = true;
            this.cmbTipoVaso.Location = new System.Drawing.Point(179, 284);
            this.cmbTipoVaso.Name = "cmbTipoVaso";
            this.cmbTipoVaso.Size = new System.Drawing.Size(86, 21);
            this.cmbTipoVaso.TabIndex = 20;
            this.cmbTipoVaso.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVaso_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tipo vaso:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(21, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 10);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Café.Properties.Resources._58adf5bae612507e27bd3c40;
            this.pictureBox1.Location = new System.Drawing.Point(51, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnComprarCafe
            // 
            this.btnComprarCafe.Location = new System.Drawing.Point(314, 321);
            this.btnComprarCafe.Name = "btnComprarCafe";
            this.btnComprarCafe.Size = new System.Drawing.Size(74, 36);
            this.btnComprarCafe.TabIndex = 25;
            this.btnComprarCafe.Text = "Comprar Cafe";
            this.btnComprarCafe.UseVisualStyleBackColor = true;
            this.btnComprarCafe.Click += new System.EventHandler(this.btnComprarCafe_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tamaño Vaso:";
            // 
            // lblTamañoVaso
            // 
            this.lblTamañoVaso.AutoSize = true;
            this.lblTamañoVaso.Location = new System.Drawing.Point(222, 344);
            this.lblTamañoVaso.Name = "lblTamañoVaso";
            this.lblTamañoVaso.Size = new System.Drawing.Size(10, 13);
            this.lblTamañoVaso.TabIndex = 27;
            this.lblTamañoVaso.Text = "-";
            // 
            // txtTipoCafe
            // 
            this.txtTipoCafe.Location = new System.Drawing.Point(179, 235);
            this.txtTipoCafe.Name = "txtTipoCafe";
            this.txtTipoCafe.ReadOnly = true;
            this.txtTipoCafe.Size = new System.Drawing.Size(86, 20);
            this.txtTipoCafe.TabIndex = 28;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(314, 231);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(74, 24);
            this.btnRecargar.TabIndex = 29;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 489);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.txtTipoCafe);
            this.Controls.Add(this.lblTamañoVaso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnComprarCafe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTipoVaso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalMaquina);
            this.Controls.Add(this.lblTipoCafe);
            this.Controls.Add(this.lblPrecioxLt);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.rbRobusto);
            this.Controls.Add(this.rbArabigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.lbMaquinas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Cafeteria";
            this.Text = "Cafeteria";
            this.Load += new System.EventHandler(this.Cafeteria_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMaquinas;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbArabigo;
        private System.Windows.Forms.RadioButton rbRobusto;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblPrecioxLt;
        private System.Windows.Forms.Label lblTipoCafe;
        private System.Windows.Forms.Label lblTotalMaquina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoVaso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnComprarCafe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTamañoVaso;
        private System.Windows.Forms.TextBox txtTipoCafe;
        private System.Windows.Forms.Button btnRecargar;
    }
}


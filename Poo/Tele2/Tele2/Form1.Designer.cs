namespace Tele2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnIr = new System.Windows.Forms.Button();
            this.Txtinternet = new System.Windows.Forms.TextBox();
            this.Barra5 = new System.Windows.Forms.Label();
            this.Barra4 = new System.Windows.Forms.Label();
            this.Barra3 = new System.Windows.Forms.Label();
            this.Barra2 = new System.Windows.Forms.Label();
            this.Barra1 = new System.Windows.Forms.Label();
            this.LblVol = new System.Windows.Forms.Label();
            this.LblCanales = new System.Windows.Forms.Label();
            this.LblApagado = new System.Windows.Forms.Label();
            this.LblEncendido = new System.Windows.Forms.Label();
            this.TxtVolumen = new System.Windows.Forms.TextBox();
            this.TxtCanal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnEncendido = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnVolMenos = new System.Windows.Forms.Button();
            this.BtnVolMas = new System.Windows.Forms.Button();
            this.BtnCanMenos = new System.Windows.Forms.Button();
            this.BtnCanMas = new System.Windows.Forms.Button();
            this.BtnMarca = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(33, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(563, 309);
            this.webBrowser1.TabIndex = 47;
            this.webBrowser1.Visible = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(169, 481);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 52;
            this.BtnSalir.Text = "Salir ";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnIr
            // 
            this.BtnIr.Location = new System.Drawing.Point(279, 443);
            this.BtnIr.Name = "BtnIr";
            this.BtnIr.Size = new System.Drawing.Size(75, 23);
            this.BtnIr.TabIndex = 50;
            this.BtnIr.Text = "Ir!";
            this.BtnIr.UseVisualStyleBackColor = true;
            this.BtnIr.Click += new System.EventHandler(this.BtnIr_Click);
            // 
            // Txtinternet
            // 
            this.Txtinternet.Location = new System.Drawing.Point(70, 443);
            this.Txtinternet.Name = "Txtinternet";
            this.Txtinternet.Size = new System.Drawing.Size(190, 20);
            this.Txtinternet.TabIndex = 49;
            // 
            // Barra5
            // 
            this.Barra5.AutoSize = true;
            this.Barra5.BackColor = System.Drawing.SystemColors.WindowText;
            this.Barra5.ForeColor = System.Drawing.Color.Lime;
            this.Barra5.Location = new System.Drawing.Point(99, 322);
            this.Barra5.Name = "Barra5";
            this.Barra5.Size = new System.Drawing.Size(9, 13);
            this.Barra5.TabIndex = 44;
            this.Barra5.Text = "|";
            // 
            // Barra4
            // 
            this.Barra4.AutoSize = true;
            this.Barra4.BackColor = System.Drawing.SystemColors.WindowText;
            this.Barra4.ForeColor = System.Drawing.Color.Lime;
            this.Barra4.Location = new System.Drawing.Point(84, 322);
            this.Barra4.Name = "Barra4";
            this.Barra4.Size = new System.Drawing.Size(9, 13);
            this.Barra4.TabIndex = 43;
            this.Barra4.Text = "|";
            // 
            // Barra3
            // 
            this.Barra3.AutoSize = true;
            this.Barra3.BackColor = System.Drawing.SystemColors.WindowText;
            this.Barra3.ForeColor = System.Drawing.Color.Lime;
            this.Barra3.Location = new System.Drawing.Point(69, 322);
            this.Barra3.Name = "Barra3";
            this.Barra3.Size = new System.Drawing.Size(9, 13);
            this.Barra3.TabIndex = 42;
            this.Barra3.Text = "|";
            // 
            // Barra2
            // 
            this.Barra2.AutoSize = true;
            this.Barra2.BackColor = System.Drawing.SystemColors.WindowText;
            this.Barra2.ForeColor = System.Drawing.Color.Lime;
            this.Barra2.Location = new System.Drawing.Point(54, 322);
            this.Barra2.Name = "Barra2";
            this.Barra2.Size = new System.Drawing.Size(9, 13);
            this.Barra2.TabIndex = 41;
            this.Barra2.Text = "|";
            // 
            // Barra1
            // 
            this.Barra1.AutoSize = true;
            this.Barra1.BackColor = System.Drawing.SystemColors.WindowText;
            this.Barra1.ForeColor = System.Drawing.Color.Lime;
            this.Barra1.Location = new System.Drawing.Point(39, 322);
            this.Barra1.Name = "Barra1";
            this.Barra1.Size = new System.Drawing.Size(9, 13);
            this.Barra1.TabIndex = 40;
            this.Barra1.Text = "|";
            // 
            // LblVol
            // 
            this.LblVol.AutoSize = true;
            this.LblVol.BackColor = System.Drawing.SystemColors.WindowText;
            this.LblVol.ForeColor = System.Drawing.Color.Lime;
            this.LblVol.Location = new System.Drawing.Point(39, 301);
            this.LblVol.Name = "LblVol";
            this.LblVol.Size = new System.Drawing.Size(13, 13);
            this.LblVol.TabIndex = 39;
            this.LblVol.Text = "0";
            // 
            // LblCanales
            // 
            this.LblCanales.AutoSize = true;
            this.LblCanales.BackColor = System.Drawing.SystemColors.WindowText;
            this.LblCanales.ForeColor = System.Drawing.Color.Lime;
            this.LblCanales.Location = new System.Drawing.Point(577, 49);
            this.LblCanales.Name = "LblCanales";
            this.LblCanales.Size = new System.Drawing.Size(13, 13);
            this.LblCanales.TabIndex = 38;
            this.LblCanales.Text = "0";
            // 
            // LblApagado
            // 
            this.LblApagado.AutoSize = true;
            this.LblApagado.BackColor = System.Drawing.SystemColors.WindowText;
            this.LblApagado.ForeColor = System.Drawing.Color.Red;
            this.LblApagado.Location = new System.Drawing.Point(540, 331);
            this.LblApagado.Name = "LblApagado";
            this.LblApagado.Size = new System.Drawing.Size(50, 13);
            this.LblApagado.TabIndex = 37;
            this.LblApagado.Text = "Apagado";
            this.LblApagado.Visible = false;
            // 
            // LblEncendido
            // 
            this.LblEncendido.AutoSize = true;
            this.LblEncendido.BackColor = System.Drawing.SystemColors.WindowText;
            this.LblEncendido.ForeColor = System.Drawing.Color.Lime;
            this.LblEncendido.Location = new System.Drawing.Point(39, 49);
            this.LblEncendido.Name = "LblEncendido";
            this.LblEncendido.Size = new System.Drawing.Size(58, 13);
            this.LblEncendido.TabIndex = 36;
            this.LblEncendido.Text = "Encendido";
            this.LblEncendido.Visible = false;
            // 
            // TxtVolumen
            // 
            this.TxtVolumen.Location = new System.Drawing.Point(389, 459);
            this.TxtVolumen.Name = "TxtVolumen";
            this.TxtVolumen.Size = new System.Drawing.Size(41, 20);
            this.TxtVolumen.TabIndex = 34;
            this.TxtVolumen.Text = "0";
            // 
            // TxtCanal
            // 
            this.TxtCanal.Location = new System.Drawing.Point(389, 427);
            this.TxtCanal.Name = "TxtCanal";
            this.TxtCanal.Size = new System.Drawing.Size(41, 20);
            this.TxtCanal.TabIndex = 33;
            this.TxtCanal.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(625, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(363, 542);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // BtnEncendido
            // 
            this.BtnEncendido.Location = new System.Drawing.Point(826, 65);
            this.BtnEncendido.Name = "BtnEncendido";
            this.BtnEncendido.Size = new System.Drawing.Size(25, 28);
            this.BtnEncendido.TabIndex = 35;
            this.BtnEncendido.Text = "A";
            this.BtnEncendido.UseVisualStyleBackColor = true;
            this.BtnEncendido.Click += new System.EventHandler(this.BtnEncendido_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(808, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Netflix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnVolMenos
            // 
            this.BtnVolMenos.Location = new System.Drawing.Point(768, 352);
            this.BtnVolMenos.Name = "BtnVolMenos";
            this.BtnVolMenos.Size = new System.Drawing.Size(26, 23);
            this.BtnVolMenos.TabIndex = 32;
            this.BtnVolMenos.Text = "-";
            this.BtnVolMenos.UseVisualStyleBackColor = true;
            this.BtnVolMenos.Click += new System.EventHandler(this.BtnVolMenos_Click);
            // 
            // BtnVolMas
            // 
            this.BtnVolMas.Location = new System.Drawing.Point(768, 331);
            this.BtnVolMas.Name = "BtnVolMas";
            this.BtnVolMas.Size = new System.Drawing.Size(26, 23);
            this.BtnVolMas.TabIndex = 31;
            this.BtnVolMas.Text = "+";
            this.BtnVolMas.UseVisualStyleBackColor = true;
            this.BtnVolMas.Click += new System.EventHandler(this.BtnVolMas_Click);
            // 
            // BtnCanMenos
            // 
            this.BtnCanMenos.Location = new System.Drawing.Point(826, 352);
            this.BtnCanMenos.Name = "BtnCanMenos";
            this.BtnCanMenos.Size = new System.Drawing.Size(25, 20);
            this.BtnCanMenos.TabIndex = 30;
            this.BtnCanMenos.Text = "-";
            this.BtnCanMenos.UseVisualStyleBackColor = true;
            this.BtnCanMenos.Click += new System.EventHandler(this.BtnCanMenos_Click);
            // 
            // BtnCanMas
            // 
            this.BtnCanMas.Location = new System.Drawing.Point(826, 331);
            this.BtnCanMas.Name = "BtnCanMas";
            this.BtnCanMas.Size = new System.Drawing.Size(25, 23);
            this.BtnCanMas.TabIndex = 29;
            this.BtnCanMas.Text = "+";
            this.BtnCanMas.UseVisualStyleBackColor = true;
            this.BtnCanMas.Click += new System.EventHandler(this.BtnCanMas_Click);
            // 
            // BtnMarca
            // 
            this.BtnMarca.Location = new System.Drawing.Point(473, 456);
            this.BtnMarca.Name = "BtnMarca";
            this.BtnMarca.Size = new System.Drawing.Size(75, 23);
            this.BtnMarca.TabIndex = 54;
            this.BtnMarca.Text = "MARCA";
            this.BtnMarca.UseVisualStyleBackColor = true;
            this.BtnMarca.Click += new System.EventHandler(this.BtnMarca_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 531);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnMarca);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIr);
            this.Controls.Add(this.Txtinternet);
            this.Controls.Add(this.Barra5);
            this.Controls.Add(this.Barra4);
            this.Controls.Add(this.Barra3);
            this.Controls.Add(this.Barra2);
            this.Controls.Add(this.Barra1);
            this.Controls.Add(this.LblVol);
            this.Controls.Add(this.LblCanales);
            this.Controls.Add(this.LblApagado);
            this.Controls.Add(this.LblEncendido);
            this.Controls.Add(this.TxtVolumen);
            this.Controls.Add(this.TxtCanal);
            this.Controls.Add(this.BtnEncendido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnVolMenos);
            this.Controls.Add(this.BtnVolMas);
            this.Controls.Add(this.BtnCanMenos);
            this.Controls.Add(this.BtnCanMas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnIr;
        private System.Windows.Forms.TextBox Txtinternet;
        private System.Windows.Forms.Label Barra5;
        private System.Windows.Forms.Label Barra4;
        private System.Windows.Forms.Label Barra3;
        private System.Windows.Forms.Label Barra2;
        private System.Windows.Forms.Label Barra1;
        private System.Windows.Forms.Label LblVol;
        private System.Windows.Forms.Label LblCanales;
        private System.Windows.Forms.Label LblApagado;
        private System.Windows.Forms.Label LblEncendido;
        private System.Windows.Forms.TextBox TxtVolumen;
        private System.Windows.Forms.TextBox TxtCanal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnEncendido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnVolMenos;
        private System.Windows.Forms.Button BtnVolMas;
        private System.Windows.Forms.Button BtnCanMenos;
        private System.Windows.Forms.Button BtnCanMas;
        private System.Windows.Forms.Button BtnMarca;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace televisor
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
            this.btEncendido = new System.Windows.Forms.Button();
            this.txtcanal = new System.Windows.Forms.TextBox();
            this.txtvolumen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btscanal = new System.Windows.Forms.Button();
            this.btbcanal = new System.Windows.Forms.Button();
            this.btsvolumen = new System.Windows.Forms.Button();
            this.btbvolumen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEncendido
            // 
            this.btEncendido.Location = new System.Drawing.Point(384, 35);
            this.btEncendido.Name = "btEncendido";
            this.btEncendido.Size = new System.Drawing.Size(86, 45);
            this.btEncendido.TabIndex = 0;
            this.btEncendido.Text = "Encender";
            this.btEncendido.UseVisualStyleBackColor = true;
            this.btEncendido.Click += new System.EventHandler(this.btEncendido_Click);
            // 
            // txtcanal
            // 
            this.txtcanal.Location = new System.Drawing.Point(40, 228);
            this.txtcanal.Name = "txtcanal";
            this.txtcanal.Size = new System.Drawing.Size(56, 20);
            this.txtcanal.TabIndex = 1;
            this.txtcanal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcanal_KeyPress);
            // 
            // txtvolumen
            // 
            this.txtvolumen.Location = new System.Drawing.Point(40, 280);
            this.txtvolumen.Name = "txtvolumen";
            this.txtvolumen.Size = new System.Drawing.Size(56, 20);
            this.txtvolumen.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::televisor.Properties.Resources.Sony_kdl_46ex521_presentacionbuena1;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CANAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VOLUMEN";
            // 
            // btscanal
            // 
            this.btscanal.Location = new System.Drawing.Point(209, 226);
            this.btscanal.Name = "btscanal";
            this.btscanal.Size = new System.Drawing.Size(54, 22);
            this.btscanal.TabIndex = 4;
            this.btscanal.Text = "+";
            this.btscanal.UseVisualStyleBackColor = true;
            this.btscanal.Click += new System.EventHandler(this.btscanal_Click);
            // 
            // btbcanal
            // 
            this.btbcanal.Location = new System.Drawing.Point(278, 226);
            this.btbcanal.Name = "btbcanal";
            this.btbcanal.Size = new System.Drawing.Size(54, 22);
            this.btbcanal.TabIndex = 4;
            this.btbcanal.Text = "-";
            this.btbcanal.UseVisualStyleBackColor = true;
            this.btbcanal.Click += new System.EventHandler(this.btbcanal_Click);
            // 
            // btsvolumen
            // 
            this.btsvolumen.Location = new System.Drawing.Point(209, 274);
            this.btsvolumen.Name = "btsvolumen";
            this.btsvolumen.Size = new System.Drawing.Size(54, 22);
            this.btsvolumen.TabIndex = 4;
            this.btsvolumen.Text = "+";
            this.btsvolumen.UseVisualStyleBackColor = true;
            this.btsvolumen.Click += new System.EventHandler(this.btsvolumen_Click);
            // 
            // btbvolumen
            // 
            this.btbvolumen.Location = new System.Drawing.Point(278, 274);
            this.btbvolumen.Name = "btbvolumen";
            this.btbvolumen.Size = new System.Drawing.Size(54, 22);
            this.btbvolumen.TabIndex = 4;
            this.btbvolumen.Text = "-";
            this.btbvolumen.UseVisualStyleBackColor = true;
            this.btbvolumen.Click += new System.EventHandler(this.btbvolumen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 366);
            this.Controls.Add(this.btbvolumen);
            this.Controls.Add(this.btsvolumen);
            this.Controls.Add(this.btbcanal);
            this.Controls.Add(this.btscanal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtvolumen);
            this.Controls.Add(this.txtcanal);
            this.Controls.Add(this.btEncendido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEncendido;
        private System.Windows.Forms.TextBox txtcanal;
        private System.Windows.Forms.TextBox txtvolumen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btscanal;
        private System.Windows.Forms.Button btbcanal;
        private System.Windows.Forms.Button btsvolumen;
        private System.Windows.Forms.Button btbvolumen;
    }
}


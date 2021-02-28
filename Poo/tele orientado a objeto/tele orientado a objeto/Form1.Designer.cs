namespace tele_orientado_a_objeto
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
            this.btbvolumen = new System.Windows.Forms.Button();
            this.btsvolumen = new System.Windows.Forms.Button();
            this.btbcanal = new System.Windows.Forms.Button();
            this.btscanal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctelevisor = new System.Windows.Forms.PictureBox();
            this.txtvolumen = new System.Windows.Forms.TextBox();
            this.txtcanal = new System.Windows.Forms.TextBox();
            this.btEncendido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctelevisor)).BeginInit();
            this.SuspendLayout();
            // 
            // btbvolumen
            // 
            this.btbvolumen.Location = new System.Drawing.Point(377, 388);
            this.btbvolumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbvolumen.Name = "btbvolumen";
            this.btbvolumen.Size = new System.Drawing.Size(72, 27);
            this.btbvolumen.TabIndex = 11;
            this.btbvolumen.Text = "-";
            this.btbvolumen.UseVisualStyleBackColor = true;
            this.btbvolumen.Click += new System.EventHandler(this.btbvolumen_Click);
            // 
            // btsvolumen
            // 
            this.btsvolumen.Location = new System.Drawing.Point(285, 388);
            this.btsvolumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsvolumen.Name = "btsvolumen";
            this.btsvolumen.Size = new System.Drawing.Size(72, 27);
            this.btsvolumen.TabIndex = 12;
            this.btsvolumen.Text = "+";
            this.btsvolumen.UseVisualStyleBackColor = true;
            this.btsvolumen.Click += new System.EventHandler(this.btsvolumen_Click);
            // 
            // btbcanal
            // 
            this.btbcanal.Location = new System.Drawing.Point(377, 329);
            this.btbcanal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbcanal.Name = "btbcanal";
            this.btbcanal.Size = new System.Drawing.Size(72, 27);
            this.btbcanal.TabIndex = 13;
            this.btbcanal.Text = "-";
            this.btbcanal.UseVisualStyleBackColor = true;
            this.btbcanal.Click += new System.EventHandler(this.btbcanal_Click);
            // 
            // btscanal
            // 
            this.btscanal.Location = new System.Drawing.Point(285, 329);
            this.btscanal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btscanal.Name = "btscanal";
            this.btscanal.Size = new System.Drawing.Size(72, 27);
            this.btscanal.TabIndex = 14;
            this.btscanal.Text = "+";
            this.btscanal.UseVisualStyleBackColor = true;
            this.btscanal.Click += new System.EventHandler(this.btscanal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "VOLUMEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "CANAL";
            // 
            // pctelevisor
            // 
            this.pctelevisor.Image = global::tele_orientado_a_objeto.Properties.Resources.descarga;
            this.pctelevisor.Location = new System.Drawing.Point(48, 65);
            this.pctelevisor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctelevisor.Name = "pctelevisor";
            this.pctelevisor.Size = new System.Drawing.Size(288, 198);
            this.pctelevisor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctelevisor.TabIndex = 8;
            this.pctelevisor.TabStop = false;
            // 
            // txtvolumen
            // 
            this.txtvolumen.Location = new System.Drawing.Point(60, 395);
            this.txtvolumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvolumen.Name = "txtvolumen";
            this.txtvolumen.Size = new System.Drawing.Size(73, 22);
            this.txtvolumen.TabIndex = 6;
            // 
            // txtcanal
            // 
            this.txtcanal.Location = new System.Drawing.Point(60, 331);
            this.txtcanal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcanal.Name = "txtcanal";
            this.txtcanal.Size = new System.Drawing.Size(73, 22);
            this.txtcanal.TabIndex = 7;
            // 
            // btEncendido
            // 
            this.btEncendido.Location = new System.Drawing.Point(453, 87);
            this.btEncendido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEncendido.Name = "btEncendido";
            this.btEncendido.Size = new System.Drawing.Size(115, 55);
            this.btEncendido.TabIndex = 5;
            this.btEncendido.Text = "Encender";
            this.btEncendido.UseVisualStyleBackColor = true;
            this.btEncendido.Click += new System.EventHandler(this.btEncendido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 485);
            this.Controls.Add(this.btbvolumen);
            this.Controls.Add(this.btsvolumen);
            this.Controls.Add(this.btbcanal);
            this.Controls.Add(this.btscanal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctelevisor);
            this.Controls.Add(this.txtvolumen);
            this.Controls.Add(this.txtcanal);
            this.Controls.Add(this.btEncendido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctelevisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbvolumen;
        private System.Windows.Forms.Button btsvolumen;
        private System.Windows.Forms.Button btbcanal;
        private System.Windows.Forms.Button btscanal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctelevisor;
        private System.Windows.Forms.TextBox txtvolumen;
        private System.Windows.Forms.TextBox txtcanal;
        private System.Windows.Forms.Button btEncendido;
    }
}


namespace vectores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbasiento = new System.Windows.Forms.ComboBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btvender = new System.Windows.Forms.Button();
            this.txtvendido = new System.Windows.Forms.TextBox();
            this.txtdisponible = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASIENTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // cbasiento
            // 
            this.cbasiento.FormattingEnabled = true;
            this.cbasiento.Location = new System.Drawing.Point(143, 27);
            this.cbasiento.Margin = new System.Windows.Forms.Padding(4);
            this.cbasiento.Name = "cbasiento";
            this.cbasiento.Size = new System.Drawing.Size(160, 24);
            this.cbasiento.TabIndex = 2;
            this.cbasiento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(143, 79);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(4);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(132, 22);
            this.txtvalor.TabIndex = 3;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(143, 180);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 28);
            this.progressBar1.TabIndex = 4;
            // 
            // btvender
            // 
            this.btvender.Location = new System.Drawing.Point(143, 129);
            this.btvender.Margin = new System.Windows.Forms.Padding(4);
            this.btvender.Name = "btvender";
            this.btvender.Size = new System.Drawing.Size(100, 28);
            this.btvender.TabIndex = 5;
            this.btvender.Text = "vender";
            this.btvender.UseVisualStyleBackColor = true;
            this.btvender.Click += new System.EventHandler(this.btvender_Click);
            // 
            // txtvendido
            // 
            this.txtvendido.Location = new System.Drawing.Point(441, 30);
            this.txtvendido.Margin = new System.Windows.Forms.Padding(4);
            this.txtvendido.Name = "txtvendido";
            this.txtvendido.Size = new System.Drawing.Size(132, 22);
            this.txtvendido.TabIndex = 6;
            this.txtvendido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdisponible
            // 
            this.txtdisponible.Location = new System.Drawing.Point(441, 79);
            this.txtdisponible.Margin = new System.Windows.Forms.Padding(4);
            this.txtdisponible.Name = "txtdisponible";
            this.txtdisponible.Size = new System.Drawing.Size(132, 22);
            this.txtdisponible.TabIndex = 7;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(441, 186);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(132, 22);
            this.txtresultado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "ocupados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "disponibles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtdisponible);
            this.Controls.Add(this.txtvendido);
            this.Controls.Add(this.btvender);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.cbasiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "lab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbasiento;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btvender;
        private System.Windows.Forms.TextBox txtvendido;
        private System.Windows.Forms.TextBox txtdisponible;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


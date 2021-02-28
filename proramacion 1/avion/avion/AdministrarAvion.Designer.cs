namespace avion
{
    partial class AdministrarAvion
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbPlantaAlta = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPlantaBaja = new System.Windows.Forms.RadioButton();
            this.comboBoxAsientos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarEstado = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administracion del avión";
            // 
            // rbPlantaAlta
            // 
            this.rbPlantaAlta.AutoSize = true;
            this.rbPlantaAlta.Location = new System.Drawing.Point(16, 16);
            this.rbPlantaAlta.Name = "rbPlantaAlta";
            this.rbPlantaAlta.Size = new System.Drawing.Size(43, 17);
            this.rbPlantaAlta.TabIndex = 1;
            this.rbPlantaAlta.TabStop = true;
            this.rbPlantaAlta.Text = "Alta";
            this.rbPlantaAlta.UseVisualStyleBackColor = true;
            this.rbPlantaAlta.CheckedChanged += new System.EventHandler(this.rbPlantaAlta_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPlantaBaja);
            this.panel1.Controls.Add(this.rbPlantaAlta);
            this.panel1.Location = new System.Drawing.Point(102, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 45);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Planta: ";
            // 
            // rbPlantaBaja
            // 
            this.rbPlantaBaja.AutoSize = true;
            this.rbPlantaBaja.Location = new System.Drawing.Point(139, 16);
            this.rbPlantaBaja.Name = "rbPlantaBaja";
            this.rbPlantaBaja.Size = new System.Drawing.Size(46, 17);
            this.rbPlantaBaja.TabIndex = 2;
            this.rbPlantaBaja.TabStop = true;
            this.rbPlantaBaja.Text = "Baja";
            this.rbPlantaBaja.UseVisualStyleBackColor = true;
            this.rbPlantaBaja.CheckedChanged += new System.EventHandler(this.rbPlantaAlta_CheckedChanged);
            // 
            // comboBoxAsientos
            // 
            this.comboBoxAsientos.FormattingEnabled = true;
            this.comboBoxAsientos.Location = new System.Drawing.Point(135, 163);
            this.comboBoxAsientos.Name = "comboBoxAsientos";
            this.comboBoxAsientos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAsientos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asientos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:   $";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(114, 231);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(18, 20);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "0";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(256, 283);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(121, 43);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar Asiento";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 363);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(97, 36);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado";
            // 
            // progressBarEstado
            // 
            this.progressBarEstado.Location = new System.Drawing.Point(383, 363);
            this.progressBarEstado.Name = "progressBarEstado";
            this.progressBarEstado.Size = new System.Drawing.Size(189, 23);
            this.progressBarEstado.TabIndex = 11;
            // 
            // AdministrarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAsientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AdministrarAvion";
            this.Text = "AdministrarAvion";
            this.Load += new System.EventHandler(this.AdministrarAvion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPlantaAlta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPlantaBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAsientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarEstado;
    }
}
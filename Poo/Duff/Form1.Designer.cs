namespace Duff
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
            this.txtCapacidadBarril = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarBarril = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGenerarTipoCerveza = new System.Windows.Forms.ComboBox();
            this.cmbSeleccionarBarril = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoVaso = new System.Windows.Forms.ComboBox();
            this.lblTipoCerveza = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCapacidadBarril
            // 
            this.txtCapacidadBarril.Location = new System.Drawing.Point(135, 30);
            this.txtCapacidadBarril.Name = "txtCapacidadBarril";
            this.txtCapacidadBarril.Size = new System.Drawing.Size(117, 20);
            this.txtCapacidadBarril.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capacidad Barril:";
            // 
            // btnGenerarBarril
            // 
            this.btnGenerarBarril.Location = new System.Drawing.Point(292, 41);
            this.btnGenerarBarril.Name = "btnGenerarBarril";
            this.btnGenerarBarril.Size = new System.Drawing.Size(75, 44);
            this.btnGenerarBarril.TabIndex = 3;
            this.btnGenerarBarril.Text = "GENERAR BARRIL";
            this.btnGenerarBarril.UseVisualStyleBackColor = true;
            this.btnGenerarBarril.Click += new System.EventHandler(this.btnGenerarBarril_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo Cerveza:";
            // 
            // cmbGenerarTipoCerveza
            // 
            this.cmbGenerarTipoCerveza.FormattingEnabled = true;
            this.cmbGenerarTipoCerveza.Location = new System.Drawing.Point(135, 72);
            this.cmbGenerarTipoCerveza.Name = "cmbGenerarTipoCerveza";
            this.cmbGenerarTipoCerveza.Size = new System.Drawing.Size(117, 21);
            this.cmbGenerarTipoCerveza.TabIndex = 6;
            // 
            // cmbSeleccionarBarril
            // 
            this.cmbSeleccionarBarril.FormattingEnabled = true;
            this.cmbSeleccionarBarril.Location = new System.Drawing.Point(135, 157);
            this.cmbSeleccionarBarril.Name = "cmbSeleccionarBarril";
            this.cmbSeleccionarBarril.Size = new System.Drawing.Size(117, 21);
            this.cmbSeleccionarBarril.TabIndex = 7;
            this.cmbSeleccionarBarril.SelectionChangeCommitted += new System.EventHandler(this.cmbSeleccionarBarril_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar Barril: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seleccionar Vaso: ";
            // 
            // cmbTipoVaso
            // 
            this.cmbTipoVaso.Enabled = false;
            this.cmbTipoVaso.FormattingEnabled = true;
            this.cmbTipoVaso.Location = new System.Drawing.Point(135, 230);
            this.cmbTipoVaso.Name = "cmbTipoVaso";
            this.cmbTipoVaso.Size = new System.Drawing.Size(117, 21);
            this.cmbTipoVaso.TabIndex = 9;
            this.cmbTipoVaso.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoVaso_SelectionChangeCommitted);
            // 
            // lblTipoCerveza
            // 
            this.lblTipoCerveza.AutoSize = true;
            this.lblTipoCerveza.Location = new System.Drawing.Point(54, 202);
            this.lblTipoCerveza.Name = "lblTipoCerveza";
            this.lblTipoCerveza.Size = new System.Drawing.Size(73, 13);
            this.lblTipoCerveza.TabIndex = 11;
            this.lblTipoCerveza.Text = "Tipo Cerveza:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(84, 277);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio : ";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(106, 332);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(89, 44);
            this.btnComprar.TabIndex = 13;
            this.btnComprar.Text = "COMPRAR VASO";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "----------------------------------------------------------------------";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(401, 129);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(89, 44);
            this.btnTotal.TabIndex = 15;
            this.btnTotal.Text = "VER TOTAL";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 449);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTipoCerveza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoVaso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSeleccionarBarril);
            this.Controls.Add(this.cmbGenerarTipoCerveza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerarBarril);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCapacidadBarril);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapacidadBarril;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarBarril;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenerarTipoCerveza;
        private System.Windows.Forms.ComboBox cmbSeleccionarBarril;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoVaso;
        private System.Windows.Forms.Label lblTipoCerveza;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTotal;
    }
}


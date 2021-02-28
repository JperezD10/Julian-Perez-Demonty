namespace cu
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
            this.button1 = new System.Windows.Forms.Button();
            this.miControlNumerico1 = new cu.MiControlNumerico();
            this.miControl4 = new cu.MiControl();
            this.miControl3 = new cu.MiControl();
            this.miControl2 = new cu.MiControl();
            this.miControl1 = new cu.MiControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // miControlNumerico1
            // 
            this.miControlNumerico1.Etiqueta = "Numero";
            this.miControlNumerico1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miControlNumerico1.Location = new System.Drawing.Point(15, 211);
            this.miControlNumerico1.Margin = new System.Windows.Forms.Padding(6);
            this.miControlNumerico1.Name = "miControlNumerico1";
            this.miControlNumerico1.Size = new System.Drawing.Size(491, 51);
            this.miControlNumerico1.TabIndex = 8;
            this.miControlNumerico1.Texto = "";
            // 
            // miControl4
            // 
            this.miControl4.Etiqueta = "Telefono";
            this.miControl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miControl4.Location = new System.Drawing.Point(15, 157);
            this.miControl4.Margin = new System.Windows.Forms.Padding(6);
            this.miControl4.Name = "miControl4";
            this.miControl4.Size = new System.Drawing.Size(491, 51);
            this.miControl4.TabIndex = 4;
            this.miControl4.Texto = "";
            // 
            // miControl3
            // 
            this.miControl3.Etiqueta = "Direccion";
            this.miControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miControl3.Location = new System.Drawing.Point(15, 113);
            this.miControl3.Margin = new System.Windows.Forms.Padding(6);
            this.miControl3.Name = "miControl3";
            this.miControl3.Size = new System.Drawing.Size(491, 51);
            this.miControl3.TabIndex = 3;
            this.miControl3.Texto = "";
            // 
            // miControl2
            // 
            this.miControl2.Etiqueta = "Apellido";
            this.miControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miControl2.Location = new System.Drawing.Point(15, 67);
            this.miControl2.Margin = new System.Windows.Forms.Padding(6);
            this.miControl2.Name = "miControl2";
            this.miControl2.Size = new System.Drawing.Size(491, 51);
            this.miControl2.TabIndex = 2;
            this.miControl2.Texto = "";
            // 
            // miControl1
            // 
            this.miControl1.Etiqueta = "Nombre";
            this.miControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miControl1.Location = new System.Drawing.Point(15, 15);
            this.miControl1.Margin = new System.Windows.Forms.Padding(6);
            this.miControl1.Name = "miControl1";
            this.miControl1.Size = new System.Drawing.Size(491, 51);
            this.miControl1.TabIndex = 0;
            this.miControl1.Texto = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 345);
            this.Controls.Add(this.miControlNumerico1);
            this.Controls.Add(this.miControl4);
            this.Controls.Add(this.miControl3);
            this.Controls.Add(this.miControl2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.miControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MiControl miControl1;
        private System.Windows.Forms.Button button1;
        private MiControl miControl2;
        private MiControl miControl3;
        private MiControl miControl4;
        private MiControlNumerico miControlNumerico1;
    }
}


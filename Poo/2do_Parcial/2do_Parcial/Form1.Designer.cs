namespace _2do_Parcial
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
            this.BtnVerInfo = new System.Windows.Forms.Button();
            this.BtnCrearEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVerInfo
            // 
            this.BtnVerInfo.Location = new System.Drawing.Point(51, 38);
            this.BtnVerInfo.Name = "BtnVerInfo";
            this.BtnVerInfo.Size = new System.Drawing.Size(102, 23);
            this.BtnVerInfo.TabIndex = 0;
            this.BtnVerInfo.Text = "Ver_Info";
            this.BtnVerInfo.UseVisualStyleBackColor = true;
            this.BtnVerInfo.Click += new System.EventHandler(this.BtnVerInfo_Click);
            // 
            // BtnCrearEmpleado
            // 
            this.BtnCrearEmpleado.Location = new System.Drawing.Point(51, 83);
            this.BtnCrearEmpleado.Name = "BtnCrearEmpleado";
            this.BtnCrearEmpleado.Size = new System.Drawing.Size(102, 23);
            this.BtnCrearEmpleado.TabIndex = 1;
            this.BtnCrearEmpleado.Text = "Crear_Empleado";
            this.BtnCrearEmpleado.UseVisualStyleBackColor = true;
            this.BtnCrearEmpleado.Click += new System.EventHandler(this.BtnCrearEmpleado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 145);
            this.Controls.Add(this.BtnCrearEmpleado);
            this.Controls.Add(this.BtnVerInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVerInfo;
        private System.Windows.Forms.Button BtnCrearEmpleado;
    }
}


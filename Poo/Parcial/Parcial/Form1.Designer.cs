namespace Parcial
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
            this.btCrear = new System.Windows.Forms.Button();
            this.BtVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(80, 22);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(92, 49);
            this.btCrear.TabIndex = 0;
            this.btCrear.Text = "Crear Empleado";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // BtVer
            // 
            this.BtVer.Location = new System.Drawing.Point(80, 118);
            this.BtVer.Name = "BtVer";
            this.BtVer.Size = new System.Drawing.Size(75, 49);
            this.BtVer.TabIndex = 1;
            this.BtVer.Text = "Ver Info";
            this.BtVer.UseVisualStyleBackColor = true;
            this.BtVer.Click += new System.EventHandler(this.BtVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.BtVer);
            this.Controls.Add(this.btCrear);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button BtVer;
    }
}


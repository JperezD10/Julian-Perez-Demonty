namespace Posible_parcial_2
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
            this.btPasajero = new System.Windows.Forms.Button();
            this.btViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPasajero
            // 
            this.btPasajero.Location = new System.Drawing.Point(120, 32);
            this.btPasajero.Name = "btPasajero";
            this.btPasajero.Size = new System.Drawing.Size(93, 41);
            this.btPasajero.TabIndex = 0;
            this.btPasajero.Text = "Pasajero";
            this.btPasajero.UseVisualStyleBackColor = true;
            this.btPasajero.Click += new System.EventHandler(this.btPasajero_Click);
            // 
            // btViaje
            // 
            this.btViaje.Location = new System.Drawing.Point(120, 114);
            this.btViaje.Name = "btViaje";
            this.btViaje.Size = new System.Drawing.Size(93, 41);
            this.btViaje.TabIndex = 0;
            this.btViaje.Text = "Viaje";
            this.btViaje.UseVisualStyleBackColor = true;
            this.btViaje.Click += new System.EventHandler(this.btViaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 191);
            this.Controls.Add(this.btViaje);
            this.Controls.Add(this.btPasajero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPasajero;
        private System.Windows.Forms.Button btViaje;
    }
}


namespace Parcial_Perez_Demonty
{
    partial class MenuInicio
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
            this.btProductos = new System.Windows.Forms.Button();
            this.btVentas = new System.Windows.Forms.Button();
            this.btSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btProductos
            // 
            this.btProductos.Location = new System.Drawing.Point(161, 35);
            this.btProductos.Name = "btProductos";
            this.btProductos.Size = new System.Drawing.Size(75, 52);
            this.btProductos.TabIndex = 0;
            this.btProductos.Text = "Productos";
            this.btProductos.UseVisualStyleBackColor = true;
            this.btProductos.Click += new System.EventHandler(this.btProductos_Click);
            // 
            // btVentas
            // 
            this.btVentas.Location = new System.Drawing.Point(161, 110);
            this.btVentas.Name = "btVentas";
            this.btVentas.Size = new System.Drawing.Size(75, 52);
            this.btVentas.TabIndex = 0;
            this.btVentas.Text = "Ventas";
            this.btVentas.UseVisualStyleBackColor = true;
            this.btVentas.Click += new System.EventHandler(this.btVentas_Click);
            // 
            // btSucursal
            // 
            this.btSucursal.Location = new System.Drawing.Point(161, 181);
            this.btSucursal.Name = "btSucursal";
            this.btSucursal.Size = new System.Drawing.Size(75, 52);
            this.btSucursal.TabIndex = 0;
            this.btSucursal.Text = "Sucursal";
            this.btSucursal.UseVisualStyleBackColor = true;
            this.btSucursal.Click += new System.EventHandler(this.btSucursal_Click);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 310);
            this.Controls.Add(this.btSucursal);
            this.Controls.Add(this.btVentas);
            this.Controls.Add(this.btProductos);
            this.Name = "MenuInicio";
            this.Text = "MenuInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btProductos;
        private System.Windows.Forms.Button btVentas;
        private System.Windows.Forms.Button btSucursal;
    }
}
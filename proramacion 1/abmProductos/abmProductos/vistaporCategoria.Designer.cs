namespace abmProductos
{
    partial class vistaporCategoria
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colCodProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPrecioU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodProducto,
            this.colDescripcion,
            this.colStock,
            this.ColPrecioU,
            this.colPrecioVenta,
            this.colCategoria});
            this.listView1.Location = new System.Drawing.Point(29, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 492);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colCodProducto
            // 
            this.colCodProducto.Text = "Cod Producto";
            this.colCodProducto.Width = 79;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Text = "Descripcion";
            this.colDescripcion.Width = 116;
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            this.colStock.Width = 70;
            // 
            // ColPrecioU
            // 
            this.ColPrecioU.Text = "P.Unitario";
            this.ColPrecioU.Width = 98;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.Text = "P.Venta";
            this.colPrecioVenta.Width = 98;
            // 
            // colCategoria
            // 
            this.colCategoria.Text = "Categoria";
            this.colCategoria.Width = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Categoria:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(221, 21);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(273, 24);
            this.comboCategoria.TabIndex = 31;
            this.comboCategoria.Enter += new System.EventHandler(this.comboCategoria_Enter);
            // 
            // vistaporCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 596);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Name = "vistaporCategoria";
            this.Text = "vistaporCategoria";
            this.Load += new System.EventHandler(this.vistaporCategoria_Load);
            this.MouseHover += new System.EventHandler(this.vistaporCategoria_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colCodProducto;
        private System.Windows.Forms.ColumnHeader colDescripcion;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ColumnHeader ColPrecioU;
        private System.Windows.Forms.ColumnHeader colPrecioVenta;
        private System.Windows.Forms.ColumnHeader colCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCategoria;
    }
}
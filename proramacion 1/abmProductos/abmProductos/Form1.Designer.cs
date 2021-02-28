namespace abmProductos
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaMinimaYMaximaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.realizarVentaToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // realizarVentaToolStripMenuItem
            // 
            this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.realizarVentaToolStripMenuItem.Text = "Realizar Venta";
            this.realizarVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarPorCategoriaToolStripMenuItem,
            this.promedioDeVentasToolStripMenuItem,
            this.ventaMinimaYMaximaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // visualizarPorCategoriaToolStripMenuItem
            // 
            this.visualizarPorCategoriaToolStripMenuItem.Name = "visualizarPorCategoriaToolStripMenuItem";
            this.visualizarPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.visualizarPorCategoriaToolStripMenuItem.Text = "Visualizar Por Categoria";
            this.visualizarPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.visualizarPorCategoriaToolStripMenuItem_Click);
            // 
            // promedioDeVentasToolStripMenuItem
            // 
            this.promedioDeVentasToolStripMenuItem.Name = "promedioDeVentasToolStripMenuItem";
            this.promedioDeVentasToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.promedioDeVentasToolStripMenuItem.Text = "Promedio De Ventas";
            this.promedioDeVentasToolStripMenuItem.Click += new System.EventHandler(this.promedioDeVentasToolStripMenuItem_Click);
            // 
            // ventaMinimaYMaximaToolStripMenuItem
            // 
            this.ventaMinimaYMaximaToolStripMenuItem.Name = "ventaMinimaYMaximaToolStripMenuItem";
            this.ventaMinimaYMaximaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.ventaMinimaYMaximaToolStripMenuItem.Text = "Venta Minima y Maxima";
            this.ventaMinimaYMaximaToolStripMenuItem.Click += new System.EventHandler(this.ventaMinimaYMaximaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 580);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaMinimaYMaximaToolStripMenuItem;
    }
}


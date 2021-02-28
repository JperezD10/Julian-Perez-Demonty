namespace Formularios
{
    partial class frmMain
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarSueldoPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCategoriaMasEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarRecaudacionTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaArquitectosMayores45AñosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEmpleadoToolStripMenuItem,
            this.agregarTrabajoToolStripMenuItem});
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // crearEmpleadoToolStripMenuItem
            // 
            this.crearEmpleadoToolStripMenuItem.Name = "crearEmpleadoToolStripMenuItem";
            this.crearEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.crearEmpleadoToolStripMenuItem.Text = "Crear empleado";
            this.crearEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.crearEmpleadoToolStripMenuItem_Click);
            // 
            // agregarTrabajoToolStripMenuItem
            // 
            this.agregarTrabajoToolStripMenuItem.Name = "agregarTrabajoToolStripMenuItem";
            this.agregarTrabajoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agregarTrabajoToolStripMenuItem.Text = "Agregar trabajo";
            this.agregarTrabajoToolStripMenuItem.Click += new System.EventHandler(this.agregarTrabajoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem,
            this.mostrarSueldoPorEmpleadoToolStripMenuItem,
            this.mostrarCategoriaMasEmpleadosToolStripMenuItem,
            this.mostrarRecaudacionTotalToolStripMenuItem,
            this.mostrarListaArquitectosMayores45AñosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem
            // 
            this.mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem.Name = "mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem";
            this.mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem.Text = "Mostrar pagado por puesto de trabajo";
            this.mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem_Click);
            // 
            // mostrarSueldoPorEmpleadoToolStripMenuItem
            // 
            this.mostrarSueldoPorEmpleadoToolStripMenuItem.Name = "mostrarSueldoPorEmpleadoToolStripMenuItem";
            this.mostrarSueldoPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.mostrarSueldoPorEmpleadoToolStripMenuItem.Text = "Mostrar sueldo por empleado";
            this.mostrarSueldoPorEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.mostrarSueldoPorEmpleadoToolStripMenuItem_Click);
            // 
            // mostrarCategoriaMasEmpleadosToolStripMenuItem
            // 
            this.mostrarCategoriaMasEmpleadosToolStripMenuItem.Name = "mostrarCategoriaMasEmpleadosToolStripMenuItem";
            this.mostrarCategoriaMasEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.mostrarCategoriaMasEmpleadosToolStripMenuItem.Text = "Mostrar Categoria mas empleados";
            this.mostrarCategoriaMasEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarCategoriaMasEmpleadosToolStripMenuItem_Click);
            // 
            // mostrarRecaudacionTotalToolStripMenuItem
            // 
            this.mostrarRecaudacionTotalToolStripMenuItem.Name = "mostrarRecaudacionTotalToolStripMenuItem";
            this.mostrarRecaudacionTotalToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.mostrarRecaudacionTotalToolStripMenuItem.Text = "Mostrar Recaudacion total";
            this.mostrarRecaudacionTotalToolStripMenuItem.Click += new System.EventHandler(this.mostrarRecaudacionTotalToolStripMenuItem_Click);
            // 
            // mostrarListaArquitectosMayores45AñosToolStripMenuItem
            // 
            this.mostrarListaArquitectosMayores45AñosToolStripMenuItem.Name = "mostrarListaArquitectosMayores45AñosToolStripMenuItem";
            this.mostrarListaArquitectosMayores45AñosToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.mostrarListaArquitectosMayores45AñosToolStripMenuItem.Text = "Mostrar lista Arquitectos mayores 45 años";
            this.mostrarListaArquitectosMayores45AñosToolStripMenuItem.Click += new System.EventHandler(this.mostrarListaArquitectosMayores45AñosToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 471);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarSueldoPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCategoriaMasEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarRecaudacionTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaArquitectosMayores45AñosToolStripMenuItem;
    }
}
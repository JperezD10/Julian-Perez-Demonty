namespace Jardin
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
            this.BtnAgregarMaestra = new System.Windows.Forms.Button();
            this.BtnInscribirAlumno = new System.Windows.Forms.Button();
            this.BtnImprBoleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVerInfo
            // 
            this.BtnVerInfo.Location = new System.Drawing.Point(107, 12);
            this.BtnVerInfo.Name = "BtnVerInfo";
            this.BtnVerInfo.Size = new System.Drawing.Size(78, 40);
            this.BtnVerInfo.TabIndex = 0;
            this.BtnVerInfo.Text = "Ver Informacion";
            this.BtnVerInfo.UseVisualStyleBackColor = true;
            this.BtnVerInfo.Click += new System.EventHandler(this.BtnVerInfo_Click);
            // 
            // BtnAgregarMaestra
            // 
            this.BtnAgregarMaestra.Location = new System.Drawing.Point(107, 78);
            this.BtnAgregarMaestra.Name = "BtnAgregarMaestra";
            this.BtnAgregarMaestra.Size = new System.Drawing.Size(78, 47);
            this.BtnAgregarMaestra.TabIndex = 1;
            this.BtnAgregarMaestra.Text = "Agregar Maestra";
            this.BtnAgregarMaestra.UseVisualStyleBackColor = true;
            this.BtnAgregarMaestra.Click += new System.EventHandler(this.BtnAgregarMaestra_Click);
            // 
            // BtnInscribirAlumno
            // 
            this.BtnInscribirAlumno.Location = new System.Drawing.Point(107, 147);
            this.BtnInscribirAlumno.Name = "BtnInscribirAlumno";
            this.BtnInscribirAlumno.Size = new System.Drawing.Size(78, 35);
            this.BtnInscribirAlumno.TabIndex = 2;
            this.BtnInscribirAlumno.Text = "Inscribir Alumno";
            this.BtnInscribirAlumno.UseVisualStyleBackColor = true;
            this.BtnInscribirAlumno.Click += new System.EventHandler(this.BtnInscribirAlumno_Click);
            // 
            // BtnImprBoleta
            // 
            this.BtnImprBoleta.Location = new System.Drawing.Point(107, 198);
            this.BtnImprBoleta.Name = "BtnImprBoleta";
            this.BtnImprBoleta.Size = new System.Drawing.Size(78, 40);
            this.BtnImprBoleta.TabIndex = 3;
            this.BtnImprBoleta.Text = "Imprimir Boleta";
            this.BtnImprBoleta.UseVisualStyleBackColor = true;
            this.BtnImprBoleta.Click += new System.EventHandler(this.BtnImprBoleta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnImprBoleta);
            this.Controls.Add(this.BtnInscribirAlumno);
            this.Controls.Add(this.BtnAgregarMaestra);
            this.Controls.Add(this.BtnVerInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVerInfo;
        private System.Windows.Forms.Button BtnAgregarMaestra;
        private System.Windows.Forms.Button BtnInscribirAlumno;
        private System.Windows.Forms.Button BtnImprBoleta;
    }
}


namespace HOSPITAL
{
    partial class frmCrearEspecialidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTipoEspecialidad = new System.Windows.Forms.TextBox();
            this.BtnCrearEspecialidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Especialidad: ";
            // 
            // TxtTipoEspecialidad
            // 
            this.TxtTipoEspecialidad.Location = new System.Drawing.Point(137, 47);
            this.TxtTipoEspecialidad.Name = "TxtTipoEspecialidad";
            this.TxtTipoEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.TxtTipoEspecialidad.TabIndex = 1;
            // 
            // BtnCrearEspecialidad
            // 
            this.BtnCrearEspecialidad.Location = new System.Drawing.Point(89, 97);
            this.BtnCrearEspecialidad.Name = "BtnCrearEspecialidad";
            this.BtnCrearEspecialidad.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearEspecialidad.TabIndex = 2;
            this.BtnCrearEspecialidad.Text = "Crear";
            this.BtnCrearEspecialidad.UseVisualStyleBackColor = true;
            this.BtnCrearEspecialidad.Click += new System.EventHandler(this.BtnCrearEspecialidad_Click);
            // 
            // frmCrearEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 162);
            this.Controls.Add(this.BtnCrearEspecialidad);
            this.Controls.Add(this.TxtTipoEspecialidad);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearEspecialidad";
            this.Text = "frmCrearEspecialidad";
            this.Load += new System.EventHandler(this.frmCrearEspecialidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTipoEspecialidad;
        private System.Windows.Forms.Button BtnCrearEspecialidad;
    }
}
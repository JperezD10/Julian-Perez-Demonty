namespace HOSPITAL
{
    partial class frmAsignarMedico
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
            this.CmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.CmbMedicos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbEspecialidad
            // 
            this.CmbEspecialidad.FormattingEnabled = true;
            this.CmbEspecialidad.Location = new System.Drawing.Point(119, 44);
            this.CmbEspecialidad.Name = "CmbEspecialidad";
            this.CmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.CmbEspecialidad.TabIndex = 0;
            // 
            // CmbMedicos
            // 
            this.CmbMedicos.FormattingEnabled = true;
            this.CmbMedicos.Location = new System.Drawing.Point(119, 96);
            this.CmbMedicos.Name = "CmbMedicos";
            this.CmbMedicos.Size = new System.Drawing.Size(121, 21);
            this.CmbMedicos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Especialidades:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medicos:";
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.Location = new System.Drawing.Point(66, 152);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(82, 30);
            this.BtnAsignar.TabIndex = 4;
            this.BtnAsignar.Text = "Asignar";
            this.BtnAsignar.UseVisualStyleBackColor = true;
            this.BtnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // frmAsignarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 216);
            this.Controls.Add(this.BtnAsignar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbMedicos);
            this.Controls.Add(this.CmbEspecialidad);
            this.Name = "frmAsignarMedico";
            this.Text = "frmAsignarMedico";
            this.Load += new System.EventHandler(this.frmAsignarMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbEspecialidad;
        private System.Windows.Forms.ComboBox CmbMedicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAsignar;
    }
}
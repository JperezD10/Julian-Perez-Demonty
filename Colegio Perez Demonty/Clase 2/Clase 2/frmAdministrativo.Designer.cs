namespace Clase_2
{
    partial class frmAdministrativo
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
            this.btSalir = new System.Windows.Forms.Button();
            this.btEfectuar = new System.Windows.Forms.Button();
            this.cmbEfectuar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Señor Administrativo";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(18, 246);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(112, 26);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Cerrar Sesion";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEfectuar
            // 
            this.btEfectuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btEfectuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEfectuar.Location = new System.Drawing.Point(185, 124);
            this.btEfectuar.Name = "btEfectuar";
            this.btEfectuar.Size = new System.Drawing.Size(133, 52);
            this.btEfectuar.TabIndex = 5;
            this.btEfectuar.Text = "Efectuar";
            this.btEfectuar.UseVisualStyleBackColor = false;
            this.btEfectuar.Click += new System.EventHandler(this.btEfectuar_Click);
            // 
            // cmbEfectuar
            // 
            this.cmbEfectuar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEfectuar.FormattingEnabled = true;
            this.cmbEfectuar.Items.AddRange(new object[] {
            "Gestionar Alumnos",
            "Gestionar Materias",
            "Gestionar Profesores",
            "Asignar Profesor a Materias"});
            this.cmbEfectuar.Location = new System.Drawing.Point(160, 70);
            this.cmbEfectuar.Name = "cmbEfectuar";
            this.cmbEfectuar.Size = new System.Drawing.Size(201, 24);
            this.cmbEfectuar.TabIndex = 6;
            // 
            // frmAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 280);
            this.Controls.Add(this.cmbEfectuar);
            this.Controls.Add(this.btEfectuar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label1);
            this.Name = "frmAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrativo";
            this.Load += new System.EventHandler(this.frmAdministrativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEfectuar;
        private System.Windows.Forms.ComboBox cmbEfectuar;
    }
}
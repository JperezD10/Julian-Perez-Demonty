namespace HOSPITAL
{
    partial class CrearEstudio
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
            this.CmbEspecializacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtReceta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBfIRMA = new System.Windows.Forms.CheckBox();
            this.CmbMedico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbPaciente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Especializacion";
            // 
            // CmbEspecializacion
            // 
            this.CmbEspecializacion.FormattingEnabled = true;
            this.CmbEspecializacion.Location = new System.Drawing.Point(177, 87);
            this.CmbEspecializacion.Name = "CmbEspecializacion";
            this.CmbEspecializacion.Size = new System.Drawing.Size(121, 21);
            this.CmbEspecializacion.TabIndex = 1;
            this.CmbEspecializacion.SelectedIndexChanged += new System.EventHandler(this.CmbEspecializacion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero: ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(177, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(35, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "label3";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(124, 410);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnCrear.TabIndex = 4;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receta:";
            // 
            // TxtReceta
            // 
            this.TxtReceta.Location = new System.Drawing.Point(176, 179);
            this.TxtReceta.Name = "TxtReceta";
            this.TxtReceta.Size = new System.Drawing.Size(121, 20);
            this.TxtReceta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Firma Del Medico:";
            // 
            // CBfIRMA
            // 
            this.CBfIRMA.AutoSize = true;
            this.CBfIRMA.Location = new System.Drawing.Point(175, 349);
            this.CBfIRMA.Name = "CBfIRMA";
            this.CBfIRMA.Size = new System.Drawing.Size(63, 17);
            this.CBfIRMA.TabIndex = 8;
            this.CBfIRMA.Text = "Firmado";
            this.CBfIRMA.UseVisualStyleBackColor = true;
            this.CBfIRMA.CheckedChanged += new System.EventHandler(this.CBfIRMA_CheckedChanged);
            // 
            // CmbMedico
            // 
            this.CmbMedico.FormattingEnabled = true;
            this.CmbMedico.Location = new System.Drawing.Point(177, 128);
            this.CmbMedico.Name = "CmbMedico";
            this.CmbMedico.Size = new System.Drawing.Size(121, 21);
            this.CmbMedico.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Medico:";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(173, 297);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(124, 20);
            this.TxtFecha.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Paciente:";
            // 
            // CmbPaciente
            // 
            this.CmbPaciente.FormattingEnabled = true;
            this.CmbPaciente.Location = new System.Drawing.Point(173, 241);
            this.CmbPaciente.Name = "CmbPaciente";
            this.CmbPaciente.Size = new System.Drawing.Size(121, 21);
            this.CmbPaciente.TabIndex = 14;
            // 
            // CrearEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 505);
            this.Controls.Add(this.CmbPaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbMedico);
            this.Controls.Add(this.CBfIRMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtReceta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbEspecializacion);
            this.Controls.Add(this.label1);
            this.Name = "CrearEstudio";
            this.Text = "CrearEstudio";
            this.Load += new System.EventHandler(this.CrearEstudio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbEspecializacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtReceta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CBfIRMA;
        private System.Windows.Forms.ComboBox CmbMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbPaciente;
    }
}
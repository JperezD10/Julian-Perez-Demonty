namespace HOSPITAL
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
            this.BtnCrearEspecialidad = new System.Windows.Forms.Button();
            this.BtnCrearMedico = new System.Windows.Forms.Button();
            this.BtnAsignarMedico = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnCrearEstudio = new System.Windows.Forms.Button();
            this.BtnPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrearEspecialidad
            // 
            this.BtnCrearEspecialidad.Location = new System.Drawing.Point(106, 12);
            this.BtnCrearEspecialidad.Name = "BtnCrearEspecialidad";
            this.BtnCrearEspecialidad.Size = new System.Drawing.Size(75, 34);
            this.BtnCrearEspecialidad.TabIndex = 1;
            this.BtnCrearEspecialidad.Text = "Crear Especialidad";
            this.BtnCrearEspecialidad.UseVisualStyleBackColor = true;
            this.BtnCrearEspecialidad.Click += new System.EventHandler(this.BtnCrearEspecialidad_Click);
            // 
            // BtnCrearMedico
            // 
            this.BtnCrearMedico.Location = new System.Drawing.Point(106, 70);
            this.BtnCrearMedico.Name = "BtnCrearMedico";
            this.BtnCrearMedico.Size = new System.Drawing.Size(75, 45);
            this.BtnCrearMedico.TabIndex = 2;
            this.BtnCrearMedico.Text = "Crear Medico";
            this.BtnCrearMedico.UseVisualStyleBackColor = true;
            this.BtnCrearMedico.Click += new System.EventHandler(this.BtnCrearMedico_Click);
            // 
            // BtnAsignarMedico
            // 
            this.BtnAsignarMedico.Location = new System.Drawing.Point(106, 135);
            this.BtnAsignarMedico.Name = "BtnAsignarMedico";
            this.BtnAsignarMedico.Size = new System.Drawing.Size(75, 39);
            this.BtnAsignarMedico.TabIndex = 3;
            this.BtnAsignarMedico.Text = "Asignar Medico";
            this.BtnAsignarMedico.UseVisualStyleBackColor = true;
            this.BtnAsignarMedico.Click += new System.EventHandler(this.BtnAsignarMedico_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(106, 181);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(75, 38);
            this.BtnInfo.TabIndex = 4;
            this.BtnInfo.Text = "Ver Informacion";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnCrearEstudio
            // 
            this.BtnCrearEstudio.Location = new System.Drawing.Point(106, 226);
            this.BtnCrearEstudio.Name = "BtnCrearEstudio";
            this.BtnCrearEstudio.Size = new System.Drawing.Size(75, 40);
            this.BtnCrearEstudio.TabIndex = 5;
            this.BtnCrearEstudio.Text = "Crear Estudio";
            this.BtnCrearEstudio.UseVisualStyleBackColor = true;
            this.BtnCrearEstudio.Click += new System.EventHandler(this.BtnCrearEstudio_Click);
            // 
            // BtnPaciente
            // 
            this.BtnPaciente.Location = new System.Drawing.Point(256, 42);
            this.BtnPaciente.Name = "BtnPaciente";
            this.BtnPaciente.Size = new System.Drawing.Size(75, 38);
            this.BtnPaciente.TabIndex = 6;
            this.BtnPaciente.Text = "Crear Paciente";
            this.BtnPaciente.UseVisualStyleBackColor = true;
            this.BtnPaciente.Click += new System.EventHandler(this.BtnPaciente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 278);
            this.Controls.Add(this.BtnPaciente);
            this.Controls.Add(this.BtnCrearEstudio);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.BtnAsignarMedico);
            this.Controls.Add(this.BtnCrearMedico);
            this.Controls.Add(this.BtnCrearEspecialidad);
            this.Name = "Form1";
            this.Text = "Ver Informacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearEspecialidad;
        private System.Windows.Forms.Button BtnCrearMedico;
        private System.Windows.Forms.Button BtnAsignarMedico;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnCrearEstudio;
        private System.Windows.Forms.Button BtnPaciente;
    }
}


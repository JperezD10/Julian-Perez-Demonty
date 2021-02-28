namespace Parcial
{
    partial class FrmCrearEmpleado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblPeones = new System.Windows.Forms.Label();
            this.lblProyectos = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtPeonACargo = new System.Windows.Forms.TextBox();
            this.txtProyectos = new System.Windows.Forms.TextBox();
            this.btCrearEmpleado = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Puesto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(94, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(94, 134);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 1;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Peon",
            "Capataz",
            "Arquitecto"});
            this.cmbPuesto.Location = new System.Drawing.Point(94, 185);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(121, 24);
            this.cmbPuesto.TabIndex = 2;
            this.cmbPuesto.SelectedIndexChanged += new System.EventHandler(this.cmbPuesto_SelectedIndexChanged);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(15, 268);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(121, 17);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas trabajadas:";
            // 
            // lblPeones
            // 
            this.lblPeones.AutoSize = true;
            this.lblPeones.Location = new System.Drawing.Point(12, 316);
            this.lblPeones.Name = "lblPeones";
            this.lblPeones.Size = new System.Drawing.Size(108, 17);
            this.lblPeones.TabIndex = 3;
            this.lblPeones.Text = "Peones a cargo";
            // 
            // lblProyectos
            // 
            this.lblProyectos.AutoSize = true;
            this.lblProyectos.Location = new System.Drawing.Point(15, 361);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(150, 17);
            this.lblProyectos.TabIndex = 3;
            this.lblProyectos.Text = "Cantidad de proyectos";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(171, 263);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 22);
            this.txtHoras.TabIndex = 1;
            // 
            // txtPeonACargo
            // 
            this.txtPeonACargo.Location = new System.Drawing.Point(171, 311);
            this.txtPeonACargo.Name = "txtPeonACargo";
            this.txtPeonACargo.Size = new System.Drawing.Size(100, 22);
            this.txtPeonACargo.TabIndex = 1;
            // 
            // txtProyectos
            // 
            this.txtProyectos.Location = new System.Drawing.Point(171, 356);
            this.txtProyectos.Name = "txtProyectos";
            this.txtProyectos.Size = new System.Drawing.Size(100, 22);
            this.txtProyectos.TabIndex = 1;
            // 
            // btCrearEmpleado
            // 
            this.btCrearEmpleado.Location = new System.Drawing.Point(224, 402);
            this.btCrearEmpleado.Name = "btCrearEmpleado";
            this.btCrearEmpleado.Size = new System.Drawing.Size(100, 58);
            this.btCrearEmpleado.TabIndex = 4;
            this.btCrearEmpleado.Text = "Crear Empleado";
            this.btCrearEmpleado.UseVisualStyleBackColor = true;
            this.btCrearEmpleado.Click += new System.EventHandler(this.btCrearEmpleado_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(15, 437);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 5;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // FrmCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 472);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btCrearEmpleado);
            this.Controls.Add(this.lblProyectos);
            this.Controls.Add(this.lblPeones);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.txtProyectos);
            this.Controls.Add(this.txtPeonACargo);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCrearEmpleado";
            this.Text = "FrmCrearEmpleado";
            this.Load += new System.EventHandler(this.FrmCrearEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblPeones;
        private System.Windows.Forms.Label lblProyectos;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtPeonACargo;
        private System.Windows.Forms.TextBox txtProyectos;
        private System.Windows.Forms.Button btCrearEmpleado;
        private System.Windows.Forms.Button btVolver;
    }
}
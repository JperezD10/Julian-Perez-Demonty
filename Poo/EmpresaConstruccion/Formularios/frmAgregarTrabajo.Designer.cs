namespace Formularios
{
    partial class frmAgregarTrabajo
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
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.btnSortLegajo = new System.Windows.Forms.Button();
            this.btnSortAlfab = new System.Windows.Forms.Button();
            this.panelCapataz = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.peonesAsignadosNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAceptarAsignarPeones = new System.Windows.Forms.Button();
            this.panelPeon = new System.Windows.Forms.Panel();
            this.btnAgregarHoras = new System.Windows.Forms.Button();
            this.horasDeTrabajonumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelArquitecto = new System.Windows.Forms.Panel();
            this.btnAgregarProyecto = new System.Windows.Forms.Button();
            this.proyectoNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCapataz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peonesAsignadosNumericUpDown1)).BeginInit();
            this.panelPeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horasDeTrabajonumericUpDown1)).BeginInit();
            this.panelArquitecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un empleado: ";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(220, 68);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleados.TabIndex = 1;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            this.cmbEmpleados.SelectedValueChanged += new System.EventHandler(this.cmbEmpleados_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puesto Trabajo: ";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(220, 115);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(16, 13);
            this.lblPuesto.TabIndex = 3;
            this.lblPuesto.Text = "---";
            // 
            // btnSortLegajo
            // 
            this.btnSortLegajo.Location = new System.Drawing.Point(99, 26);
            this.btnSortLegajo.Name = "btnSortLegajo";
            this.btnSortLegajo.Size = new System.Drawing.Size(125, 23);
            this.btnSortLegajo.TabIndex = 4;
            this.btnSortLegajo.Text = "Ordenar por Legajo";
            this.btnSortLegajo.UseVisualStyleBackColor = true;
            this.btnSortLegajo.Click += new System.EventHandler(this.btnSortLegajo_Click);
            // 
            // btnSortAlfab
            // 
            this.btnSortAlfab.Location = new System.Drawing.Point(242, 26);
            this.btnSortAlfab.Name = "btnSortAlfab";
            this.btnSortAlfab.Size = new System.Drawing.Size(144, 23);
            this.btnSortAlfab.TabIndex = 5;
            this.btnSortAlfab.Text = "Ordenar Alfabeticamente";
            this.btnSortAlfab.UseVisualStyleBackColor = true;
            this.btnSortAlfab.Click += new System.EventHandler(this.btnSortAlfab_Click);
            // 
            // panelCapataz
            // 
            this.panelCapataz.Controls.Add(this.btnAceptarAsignarPeones);
            this.panelCapataz.Controls.Add(this.peonesAsignadosNumericUpDown1);
            this.panelCapataz.Controls.Add(this.label3);
            this.panelCapataz.Location = new System.Drawing.Point(79, 210);
            this.panelCapataz.Name = "panelCapataz";
            this.panelCapataz.Size = new System.Drawing.Size(336, 111);
            this.panelCapataz.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de peones asignados:   ";
            // 
            // peonesAsignadosNumericUpDown1
            // 
            this.peonesAsignadosNumericUpDown1.Location = new System.Drawing.Point(176, 28);
            this.peonesAsignadosNumericUpDown1.Name = "peonesAsignadosNumericUpDown1";
            this.peonesAsignadosNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.peonesAsignadosNumericUpDown1.TabIndex = 1;
            // 
            // btnAceptarAsignarPeones
            // 
            this.btnAceptarAsignarPeones.Location = new System.Drawing.Point(121, 74);
            this.btnAceptarAsignarPeones.Name = "btnAceptarAsignarPeones";
            this.btnAceptarAsignarPeones.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAsignarPeones.TabIndex = 2;
            this.btnAceptarAsignarPeones.Text = "Aceptar";
            this.btnAceptarAsignarPeones.UseVisualStyleBackColor = true;
            this.btnAceptarAsignarPeones.Click += new System.EventHandler(this.btnAceptarAsignarPeones_Click);
            // 
            // panelPeon
            // 
            this.panelPeon.Controls.Add(this.btnAgregarHoras);
            this.panelPeon.Controls.Add(this.horasDeTrabajonumericUpDown1);
            this.panelPeon.Controls.Add(this.label4);
            this.panelPeon.Location = new System.Drawing.Point(82, 199);
            this.panelPeon.Name = "panelPeon";
            this.panelPeon.Size = new System.Drawing.Size(313, 100);
            this.panelPeon.TabIndex = 7;
            // 
            // btnAgregarHoras
            // 
            this.btnAgregarHoras.Location = new System.Drawing.Point(127, 62);
            this.btnAgregarHoras.Name = "btnAgregarHoras";
            this.btnAgregarHoras.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHoras.TabIndex = 5;
            this.btnAgregarHoras.Text = "Agregar";
            this.btnAgregarHoras.UseVisualStyleBackColor = true;
            // 
            // horasDeTrabajonumericUpDown1
            // 
            this.horasDeTrabajonumericUpDown1.Location = new System.Drawing.Point(167, 14);
            this.horasDeTrabajonumericUpDown1.Name = "horasDeTrabajonumericUpDown1";
            this.horasDeTrabajonumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.horasDeTrabajonumericUpDown1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Agregar horas de trabajo:";
            // 
            // panelArquitecto
            // 
            this.panelArquitecto.Controls.Add(this.btnAgregarProyecto);
            this.panelArquitecto.Controls.Add(this.proyectoNumericUpDown1);
            this.panelArquitecto.Controls.Add(this.label5);
            this.panelArquitecto.Location = new System.Drawing.Point(86, 187);
            this.panelArquitecto.Name = "panelArquitecto";
            this.panelArquitecto.Size = new System.Drawing.Size(323, 91);
            this.panelArquitecto.TabIndex = 8;
            // 
            // btnAgregarProyecto
            // 
            this.btnAgregarProyecto.Location = new System.Drawing.Point(135, 58);
            this.btnAgregarProyecto.Name = "btnAgregarProyecto";
            this.btnAgregarProyecto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProyecto.TabIndex = 8;
            this.btnAgregarProyecto.Text = "Agregar";
            this.btnAgregarProyecto.UseVisualStyleBackColor = true;
            // 
            // proyectoNumericUpDown1
            // 
            this.proyectoNumericUpDown1.Location = new System.Drawing.Point(175, 10);
            this.proyectoNumericUpDown1.Name = "proyectoNumericUpDown1";
            this.proyectoNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.proyectoNumericUpDown1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Agregar nuevo proyecto: ";
            // 
            // frmAgregarTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 371);
            this.Controls.Add(this.panelArquitecto);
            this.Controls.Add(this.panelPeon);
            this.Controls.Add(this.panelCapataz);
            this.Controls.Add(this.btnSortAlfab);
            this.Controls.Add(this.btnSortLegajo);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarTrabajo";
            this.Text = "frmAgregarTrabajo";
            this.Load += new System.EventHandler(this.frmAgregarTrabajo_Load);
            this.panelCapataz.ResumeLayout(false);
            this.panelCapataz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peonesAsignadosNumericUpDown1)).EndInit();
            this.panelPeon.ResumeLayout(false);
            this.panelPeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horasDeTrabajonumericUpDown1)).EndInit();
            this.panelArquitecto.ResumeLayout(false);
            this.panelArquitecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Button btnSortLegajo;
        private System.Windows.Forms.Button btnSortAlfab;
        private System.Windows.Forms.Panel panelCapataz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown peonesAsignadosNumericUpDown1;
        private System.Windows.Forms.Button btnAceptarAsignarPeones;
        private System.Windows.Forms.Panel panelPeon;
        private System.Windows.Forms.Button btnAgregarHoras;
        private System.Windows.Forms.NumericUpDown horasDeTrabajonumericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelArquitecto;
        private System.Windows.Forms.Button btnAgregarProyecto;
        private System.Windows.Forms.NumericUpDown proyectoNumericUpDown1;
        private System.Windows.Forms.Label label5;
    }
}
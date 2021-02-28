namespace _2do_Parcial
{
    partial class Crear_Empleado
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
            this.BtnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbPuestoTrabajo = new System.Windows.Forms.ComboBox();
            this.LblPeones = new System.Windows.Forms.Label();
            this.numericUpDownPeones = new System.Windows.Forms.NumericUpDown();
            this.LblProyectos = new System.Windows.Forms.Label();
            this.numericUpDownProyectos = new System.Windows.Forms.NumericUpDown();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.numericUpDownTrabajo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(71, 374);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnCrear.TabIndex = 0;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(148, 26);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(10, 13);
            this.LblID.TabIndex = 3;
            this.LblID.Text = "-";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(151, 64);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(118, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(151, 114);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(118, 20);
            this.TxtApellido.TabIndex = 6;
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(151, 164);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownEdad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puesto_De_Trabajo";
            // 
            // CmbPuestoTrabajo
            // 
            this.CmbPuestoTrabajo.FormattingEnabled = true;
            this.CmbPuestoTrabajo.Items.AddRange(new object[] {
            "Capataz",
            "Peon",
            "Arquitecto"});
            this.CmbPuestoTrabajo.Location = new System.Drawing.Point(148, 208);
            this.CmbPuestoTrabajo.Name = "CmbPuestoTrabajo";
            this.CmbPuestoTrabajo.Size = new System.Drawing.Size(121, 21);
            this.CmbPuestoTrabajo.TabIndex = 10;
            this.CmbPuestoTrabajo.SelectedIndexChanged += new System.EventHandler(this.CmbPuestoTrabajo_SelectedIndexChanged);
            // 
            // LblPeones
            // 
            this.LblPeones.AutoSize = true;
            this.LblPeones.Location = new System.Drawing.Point(33, 267);
            this.LblPeones.Name = "LblPeones";
            this.LblPeones.Size = new System.Drawing.Size(93, 13);
            this.LblPeones.TabIndex = 11;
            this.LblPeones.Text = "Peones_A_Cargo:";
            this.LblPeones.Visible = false;
            // 
            // numericUpDownPeones
            // 
            this.numericUpDownPeones.Location = new System.Drawing.Point(202, 260);
            this.numericUpDownPeones.Name = "numericUpDownPeones";
            this.numericUpDownPeones.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownPeones.TabIndex = 12;
            this.numericUpDownPeones.Visible = false;
            // 
            // LblProyectos
            // 
            this.LblProyectos.AutoSize = true;
            this.LblProyectos.Location = new System.Drawing.Point(33, 295);
            this.LblProyectos.Name = "LblProyectos";
            this.LblProyectos.Size = new System.Drawing.Size(125, 13);
            this.LblProyectos.TabIndex = 13;
            this.LblProyectos.Text = "Cantidad_De_Proyectos:";
            this.LblProyectos.Visible = false;
            // 
            // numericUpDownProyectos
            // 
            this.numericUpDownProyectos.Location = new System.Drawing.Point(202, 295);
            this.numericUpDownProyectos.Name = "numericUpDownProyectos";
            this.numericUpDownProyectos.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownProyectos.TabIndex = 14;
            this.numericUpDownProyectos.Visible = false;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.AutoSize = true;
            this.lblTrabajo.Location = new System.Drawing.Point(36, 329);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(100, 13);
            this.lblTrabajo.TabIndex = 15;
            this.lblTrabajo.Text = "Horas_De_Trabajo:";
            this.lblTrabajo.Visible = false;
            // 
            // numericUpDownTrabajo
            // 
            this.numericUpDownTrabajo.Location = new System.Drawing.Point(202, 329);
            this.numericUpDownTrabajo.Name = "numericUpDownTrabajo";
            this.numericUpDownTrabajo.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownTrabajo.TabIndex = 16;
            this.numericUpDownTrabajo.Visible = false;
            // 
            // Crear_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 433);
            this.Controls.Add(this.numericUpDownTrabajo);
            this.Controls.Add(this.lblTrabajo);
            this.Controls.Add(this.numericUpDownProyectos);
            this.Controls.Add(this.LblProyectos);
            this.Controls.Add(this.numericUpDownPeones);
            this.Controls.Add(this.LblPeones);
            this.Controls.Add(this.CmbPuestoTrabajo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownEdad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCrear);
            this.Name = "Crear_Empleado";
            this.Text = "Crear_Empleado";
            this.Load += new System.EventHandler(this.Crear_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbPuestoTrabajo;
        private System.Windows.Forms.Label LblPeones;
        private System.Windows.Forms.NumericUpDown numericUpDownPeones;
        private System.Windows.Forms.Label LblProyectos;
        private System.Windows.Forms.NumericUpDown numericUpDownProyectos;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.NumericUpDown numericUpDownTrabajo;
    }
}
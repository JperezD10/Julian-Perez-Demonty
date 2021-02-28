namespace Jardin
{
    partial class Inscribir_Alumno
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
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbSalas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnInscribir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NupDEdad = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMañana = new System.Windows.Forms.CheckBox();
            this.checkBoxTarde = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBtnNo = new System.Windows.Forms.RadioButton();
            this.RbtnSi = new System.Windows.Forms.RadioButton();
            this.LblNroInscripcion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbtnNoHermanos = new System.Windows.Forms.RadioButton();
            this.RbtnSiHermanos = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NupDEdad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NroInscripcion:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Enabled = false;
            this.TxtApellido.Location = new System.Drawing.Point(150, 125);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(121, 20);
            this.TxtApellido.TabIndex = 9;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(150, 96);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtNombre.TabIndex = 7;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salita:";
            // 
            // CmbSalas
            // 
            this.CmbSalas.Enabled = false;
            this.CmbSalas.FormattingEnabled = true;
            this.CmbSalas.Location = new System.Drawing.Point(150, 62);
            this.CmbSalas.Name = "CmbSalas";
            this.CmbSalas.Size = new System.Drawing.Size(121, 21);
            this.CmbSalas.TabIndex = 5;
            this.CmbSalas.SelectedIndexChanged += new System.EventHandler(this.CmbSalas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // BtnInscribir
            // 
            this.BtnInscribir.Enabled = false;
            this.BtnInscribir.Location = new System.Drawing.Point(75, 429);
            this.BtnInscribir.Name = "BtnInscribir";
            this.BtnInscribir.Size = new System.Drawing.Size(75, 23);
            this.BtnInscribir.TabIndex = 11;
            this.BtnInscribir.Text = "Inscribir";
            this.BtnInscribir.UseVisualStyleBackColor = true;
            this.BtnInscribir.Click += new System.EventHandler(this.BtnInscribir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Turno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Con Comedor ?";
            // 
            // NupDEdad
            // 
            this.NupDEdad.Enabled = false;
            this.NupDEdad.Location = new System.Drawing.Point(150, 157);
            this.NupDEdad.Name = "NupDEdad";
            this.NupDEdad.Size = new System.Drawing.Size(36, 20);
            this.NupDEdad.TabIndex = 15;
            this.NupDEdad.ValueChanged += new System.EventHandler(this.NupDEdad_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMañana);
            this.groupBox1.Controls.Add(this.checkBoxTarde);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(142, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 67);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxMañana
            // 
            this.checkBoxMañana.AutoSize = true;
            this.checkBoxMañana.Location = new System.Drawing.Point(11, 35);
            this.checkBoxMañana.Name = "checkBoxMañana";
            this.checkBoxMañana.Size = new System.Drawing.Size(65, 17);
            this.checkBoxMañana.TabIndex = 1;
            this.checkBoxMañana.Text = "Mañana";
            this.checkBoxMañana.UseVisualStyleBackColor = true;
            this.checkBoxMañana.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxTarde
            // 
            this.checkBoxTarde.Location = new System.Drawing.Point(11, 12);
            this.checkBoxTarde.Name = "checkBoxTarde";
            this.checkBoxTarde.Size = new System.Drawing.Size(54, 17);
            this.checkBoxTarde.TabIndex = 0;
            this.checkBoxTarde.Text = "Tarde";
            this.checkBoxTarde.UseVisualStyleBackColor = true;
            this.checkBoxTarde.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBtnNo);
            this.groupBox2.Controls.Add(this.RbtnSi);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(142, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 67);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // RBtnNo
            // 
            this.RBtnNo.AutoSize = true;
            this.RBtnNo.Location = new System.Drawing.Point(6, 42);
            this.RBtnNo.Name = "RBtnNo";
            this.RBtnNo.Size = new System.Drawing.Size(39, 17);
            this.RBtnNo.TabIndex = 1;
            this.RBtnNo.TabStop = true;
            this.RBtnNo.Text = "No";
            this.RBtnNo.UseVisualStyleBackColor = true;
            this.RBtnNo.CheckedChanged += new System.EventHandler(this.RBtnNo_CheckedChanged);
            // 
            // RbtnSi
            // 
            this.RbtnSi.AutoSize = true;
            this.RbtnSi.Location = new System.Drawing.Point(6, 18);
            this.RbtnSi.Name = "RbtnSi";
            this.RbtnSi.Size = new System.Drawing.Size(34, 17);
            this.RbtnSi.TabIndex = 0;
            this.RbtnSi.TabStop = true;
            this.RbtnSi.Text = "Si";
            this.RbtnSi.UseVisualStyleBackColor = true;
            this.RbtnSi.CheckedChanged += new System.EventHandler(this.RbtnSi_CheckedChanged);
            // 
            // LblNroInscripcion
            // 
            this.LblNroInscripcion.AutoSize = true;
            this.LblNroInscripcion.Location = new System.Drawing.Point(150, 30);
            this.LblNroInscripcion.Name = "LblNroInscripcion";
            this.LblNroInscripcion.Size = new System.Drawing.Size(10, 13);
            this.LblNroInscripcion.TabIndex = 18;
            this.LblNroInscripcion.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RbtnNoHermanos);
            this.groupBox3.Controls.Add(this.RbtnSiHermanos);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(142, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 67);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // RbtnNoHermanos
            // 
            this.RbtnNoHermanos.AutoSize = true;
            this.RbtnNoHermanos.Location = new System.Drawing.Point(6, 42);
            this.RbtnNoHermanos.Name = "RbtnNoHermanos";
            this.RbtnNoHermanos.Size = new System.Drawing.Size(39, 17);
            this.RbtnNoHermanos.TabIndex = 1;
            this.RbtnNoHermanos.TabStop = true;
            this.RbtnNoHermanos.Text = "No";
            this.RbtnNoHermanos.UseVisualStyleBackColor = true;
            this.RbtnNoHermanos.CheckedChanged += new System.EventHandler(this.RbtnNoHermanos_CheckedChanged);
            // 
            // RbtnSiHermanos
            // 
            this.RbtnSiHermanos.AutoSize = true;
            this.RbtnSiHermanos.Location = new System.Drawing.Point(6, 18);
            this.RbtnSiHermanos.Name = "RbtnSiHermanos";
            this.RbtnSiHermanos.Size = new System.Drawing.Size(34, 17);
            this.RbtnSiHermanos.TabIndex = 0;
            this.RbtnSiHermanos.TabStop = true;
            this.RbtnSiHermanos.Text = "Si";
            this.RbtnSiHermanos.UseVisualStyleBackColor = true;
            this.RbtnSiHermanos.CheckedChanged += new System.EventHandler(this.RbtnSiHermanos_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tiene Hermanos ?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Meses";
            // 
            // Inscribir_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 488);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblNroInscripcion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NupDEdad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnInscribir);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbSalas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Inscribir_Alumno";
            this.Text = "Inscribir_Alumno";
            this.Load += new System.EventHandler(this.Inscribir_Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NupDEdad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbSalas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnInscribir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NupDEdad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBtnNo;
        private System.Windows.Forms.RadioButton RbtnSi;
        private System.Windows.Forms.Label LblNroInscripcion;
        private System.Windows.Forms.CheckBox checkBoxMañana;
        private System.Windows.Forms.CheckBox checkBoxTarde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbtnNoHermanos;
        private System.Windows.Forms.RadioButton RbtnSiHermanos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
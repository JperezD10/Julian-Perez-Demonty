namespace Jardin
{
    partial class Asignar_Maestra
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
            this.CmbSalas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.BtnAsignar = new System.Windows.Forms.Button();
            this.LblLegajo = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBtnNo = new System.Windows.Forms.RadioButton();
            this.RbtnSi = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Legajo:";
            // 
            // CmbSalas
            // 
            this.CmbSalas.FormattingEnabled = true;
            this.CmbSalas.Location = new System.Drawing.Point(115, 91);
            this.CmbSalas.Name = "CmbSalas";
            this.CmbSalas.Size = new System.Drawing.Size(121, 21);
            this.CmbSalas.TabIndex = 0;
            this.CmbSalas.SelectedIndexChanged += new System.EventHandler(this.CmbSalas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salita:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(115, 125);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Enabled = false;
            this.TxtApellido.Location = new System.Drawing.Point(115, 154);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(121, 20);
            this.TxtApellido.TabIndex = 2;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.Enabled = false;
            this.BtnAsignar.Location = new System.Drawing.Point(279, 115);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(75, 23);
            this.BtnAsignar.TabIndex = 3;
            this.BtnAsignar.Text = "Asignar";
            this.BtnAsignar.UseVisualStyleBackColor = true;
            this.BtnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // LblLegajo
            // 
            this.LblLegajo.AutoSize = true;
            this.LblLegajo.Location = new System.Drawing.Point(115, 50);
            this.LblLegajo.Name = "LblLegajo";
            this.LblLegajo.Size = new System.Drawing.Size(10, 13);
            this.LblLegajo.TabIndex = 8;
            this.LblLegajo.Text = "-";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(330, 194);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(75, 23);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Recibidas ?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBtnNo);
            this.groupBox2.Controls.Add(this.RbtnSi);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(118, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 67);
            this.groupBox2.TabIndex = 18;
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
            // Asignar_Maestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 255);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.LblLegajo);
            this.Controls.Add(this.BtnAsignar);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbSalas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Asignar_Maestra";
            this.Text = "Asignar_Maestra";
            this.Load += new System.EventHandler(this.Asignar_Maestra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbSalas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Button BtnAsignar;
        private System.Windows.Forms.Label LblLegajo;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBtnNo;
        private System.Windows.Forms.RadioButton RbtnSi;
    }
}
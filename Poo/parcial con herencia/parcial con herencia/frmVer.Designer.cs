namespace parcial_con_herencia
{
    partial class frmVer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantPeones = new System.Windows.Forms.Label();
            this.lblCantCapataces = new System.Windows.Forms.Label();
            this.lblCantArquitectos = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSueldoPeon = new System.Windows.Forms.Label();
            this.lblSueldoCapataz = new System.Windows.Forms.Label();
            this.lblSueldoArquitecto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalEmpresa = new System.Windows.Forms.Label();
            this.btOrdernar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Empleados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Peones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capataces";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Arquitectos:";
            // 
            // lblCantPeones
            // 
            this.lblCantPeones.AutoSize = true;
            this.lblCantPeones.Location = new System.Drawing.Point(168, 284);
            this.lblCantPeones.Name = "lblCantPeones";
            this.lblCantPeones.Size = new System.Drawing.Size(13, 17);
            this.lblCantPeones.TabIndex = 4;
            this.lblCantPeones.Text = "-";
            // 
            // lblCantCapataces
            // 
            this.lblCantCapataces.AutoSize = true;
            this.lblCantCapataces.Location = new System.Drawing.Point(168, 320);
            this.lblCantCapataces.Name = "lblCantCapataces";
            this.lblCantCapataces.Size = new System.Drawing.Size(13, 17);
            this.lblCantCapataces.TabIndex = 4;
            this.lblCantCapataces.Text = "-";
            // 
            // lblCantArquitectos
            // 
            this.lblCantArquitectos.AutoSize = true;
            this.lblCantArquitectos.Location = new System.Drawing.Point(168, 355);
            this.lblCantArquitectos.Name = "lblCantArquitectos";
            this.lblCantArquitectos.Size = new System.Drawing.Size(13, 17);
            this.lblCantArquitectos.TabIndex = 4;
            this.lblCantArquitectos.Text = "-";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(28, 412);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(85, 30);
            this.btVolver.TabIndex = 5;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sueldo por puesto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Peones:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Capataces:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Arquitectos:";
            // 
            // lblSueldoPeon
            // 
            this.lblSueldoPeon.AutoSize = true;
            this.lblSueldoPeon.Location = new System.Drawing.Point(480, 284);
            this.lblSueldoPeon.Name = "lblSueldoPeon";
            this.lblSueldoPeon.Size = new System.Drawing.Size(13, 17);
            this.lblSueldoPeon.TabIndex = 7;
            this.lblSueldoPeon.Text = "-";
            // 
            // lblSueldoCapataz
            // 
            this.lblSueldoCapataz.AutoSize = true;
            this.lblSueldoCapataz.Location = new System.Drawing.Point(480, 320);
            this.lblSueldoCapataz.Name = "lblSueldoCapataz";
            this.lblSueldoCapataz.Size = new System.Drawing.Size(13, 17);
            this.lblSueldoCapataz.TabIndex = 7;
            this.lblSueldoCapataz.Text = "-";
            // 
            // lblSueldoArquitecto
            // 
            this.lblSueldoArquitecto.AutoSize = true;
            this.lblSueldoArquitecto.Location = new System.Drawing.Point(480, 355);
            this.lblSueldoArquitecto.Name = "lblSueldoArquitecto";
            this.lblSueldoArquitecto.Size = new System.Drawing.Size(13, 17);
            this.lblSueldoArquitecto.TabIndex = 7;
            this.lblSueldoArquitecto.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total De la empresa:";
            // 
            // lblTotalEmpresa
            // 
            this.lblTotalEmpresa.AutoSize = true;
            this.lblTotalEmpresa.Location = new System.Drawing.Point(723, 243);
            this.lblTotalEmpresa.Name = "lblTotalEmpresa";
            this.lblTotalEmpresa.Size = new System.Drawing.Size(13, 17);
            this.lblTotalEmpresa.TabIndex = 9;
            this.lblTotalEmpresa.Text = "-";
            // 
            // btOrdernar
            // 
            this.btOrdernar.Location = new System.Drawing.Point(621, 284);
            this.btOrdernar.Name = "btOrdernar";
            this.btOrdernar.Size = new System.Drawing.Size(75, 61);
            this.btOrdernar.TabIndex = 10;
            this.btOrdernar.Text = "Ordenar Por Nombre";
            this.btOrdernar.UseVisualStyleBackColor = true;
            this.btOrdernar.Click += new System.EventHandler(this.btOrdernar_Click);
            // 
            // frmVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 454);
            this.Controls.Add(this.btOrdernar);
            this.Controls.Add(this.lblTotalEmpresa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSueldoArquitecto);
            this.Controls.Add(this.lblSueldoCapataz);
            this.Controls.Add(this.lblSueldoPeon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lblCantArquitectos);
            this.Controls.Add(this.lblCantCapataces);
            this.Controls.Add(this.lblCantPeones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVer";
            this.Text = "frmVer";
            this.Load += new System.EventHandler(this.frmVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCantPeones;
        private System.Windows.Forms.Label lblCantCapataces;
        private System.Windows.Forms.Label lblCantArquitectos;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSueldoPeon;
        private System.Windows.Forms.Label lblSueldoCapataz;
        private System.Windows.Forms.Label lblSueldoArquitecto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalEmpresa;
        private System.Windows.Forms.Button btOrdernar;
    }
}
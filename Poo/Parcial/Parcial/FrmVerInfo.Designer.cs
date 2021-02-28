namespace Parcial
{
    partial class FrmVerInfo
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
            this.btVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantidadPeon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantidadCapataz = new System.Windows.Forms.Label();
            this.lblCantidadArquitecto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSueldoPeon = new System.Windows.Forms.Label();
            this.lblSueldoCapataz = new System.Windows.Forms.Label();
            this.lblSueldoArquitecto = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMayores = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(12, 598);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 1;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ordenar Por Nombre:";
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(64, 380);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(84, 32);
            this.btOrdenar.TabIndex = 3;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mayor Cantidad De Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trabajo:";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(344, 394);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(13, 17);
            this.lblMayor.TabIndex = 6;
            this.lblMayor.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad De Empleados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peon:";
            // 
            // lblCantidadPeon
            // 
            this.lblCantidadPeon.AutoSize = true;
            this.lblCantidadPeon.Location = new System.Drawing.Point(347, 460);
            this.lblCantidadPeon.Name = "lblCantidadPeon";
            this.lblCantidadPeon.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadPeon.TabIndex = 8;
            this.lblCantidadPeon.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Capataz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Arquitecto:";
            // 
            // lblCantidadCapataz
            // 
            this.lblCantidadCapataz.AutoSize = true;
            this.lblCantidadCapataz.Location = new System.Drawing.Point(347, 512);
            this.lblCantidadCapataz.Name = "lblCantidadCapataz";
            this.lblCantidadCapataz.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadCapataz.TabIndex = 9;
            this.lblCantidadCapataz.Text = "-";
            // 
            // lblCantidadArquitecto
            // 
            this.lblCantidadArquitecto.AutoSize = true;
            this.lblCantidadArquitecto.Location = new System.Drawing.Point(347, 556);
            this.lblCantidadArquitecto.Name = "lblCantidadArquitecto";
            this.lblCantidadArquitecto.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadArquitecto.TabIndex = 8;
            this.lblCantidadArquitecto.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sueldos Totales De:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Peon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Capataz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(556, 486);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Arquitecto";
            // 
            // lblSueldoPeon
            // 
            this.lblSueldoPeon.AutoSize = true;
            this.lblSueldoPeon.Location = new System.Drawing.Point(657, 395);
            this.lblSueldoPeon.Name = "lblSueldoPeon";
            this.lblSueldoPeon.Size = new System.Drawing.Size(13, 17);
            this.lblSueldoPeon.TabIndex = 12;
            this.lblSueldoPeon.Text = "-";
            // 
            // lblSueldoCapataz
            // 
            this.lblSueldoCapataz.AutoSize = true;
            this.lblSueldoCapataz.Location = new System.Drawing.Point(657, 441);
            this.lblSueldoCapataz.Name = "lblSueldoCapataz";
            this.lblSueldoCapataz.Size = new System.Drawing.Size(13, 17);
            this.lblSueldoCapataz.TabIndex = 12;
            this.lblSueldoCapataz.Text = "-";
            // 
            // lblSueldoArquitecto
            // 
            this.lblSueldoArquitecto.AutoSize = true;
            this.lblSueldoArquitecto.Location = new System.Drawing.Point(657, 486);
            this.lblSueldoArquitecto.Name = "lblSueldoArquitecto";
            this.lblSueldoArquitecto.Size = new System.Drawing.Size(13, 17);
            this.lblSueldoArquitecto.TabIndex = 12;
            this.lblSueldoArquitecto.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 598);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Arquitectos Mayores de 40 Años:";
            // 
            // cmbMayores
            // 
            this.cmbMayores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMayores.FormattingEnabled = true;
            this.cmbMayores.Location = new System.Drawing.Point(660, 589);
            this.cmbMayores.Name = "cmbMayores";
            this.cmbMayores.Size = new System.Drawing.Size(121, 24);
            this.cmbMayores.TabIndex = 14;
            // 
            // FrmVerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 633);
            this.Controls.Add(this.cmbMayores);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSueldoArquitecto);
            this.Controls.Add(this.lblSueldoCapataz);
            this.Controls.Add(this.lblSueldoPeon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCantidadCapataz);
            this.Controls.Add(this.lblCantidadArquitecto);
            this.Controls.Add(this.lblCantidadPeon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVerInfo";
            this.Text = "FrmVerInfo";
            this.Load += new System.EventHandler(this.FrmVerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCantidadPeon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCantidadCapataz;
        private System.Windows.Forms.Label lblCantidadArquitecto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSueldoPeon;
        private System.Windows.Forms.Label lblSueldoCapataz;
        private System.Windows.Forms.Label lblSueldoArquitecto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMayores;
    }
}
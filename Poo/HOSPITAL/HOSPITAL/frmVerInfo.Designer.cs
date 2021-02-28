namespace HOSPITAL
{
    partial class frmVerInfo
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
            this.cmbDatos = new System.Windows.Forms.ComboBox();
            this.CmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblGananciaTotal = new System.Windows.Forms.Label();
            this.BtnNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbDatos
            // 
            this.cmbDatos.FormattingEnabled = true;
            this.cmbDatos.Items.AddRange(new object[] {
            "Medicos",
            "Especializaciones",
            "Especialidad de cada medico",
            "Pacientes"});
            this.cmbDatos.Location = new System.Drawing.Point(36, 12);
            this.cmbDatos.Name = "cmbDatos";
            this.cmbDatos.Size = new System.Drawing.Size(121, 21);
            this.cmbDatos.TabIndex = 1;
            this.cmbDatos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CmbEspecialidades
            // 
            this.CmbEspecialidades.FormattingEnabled = true;
            this.CmbEspecialidades.Location = new System.Drawing.Point(47, 252);
            this.CmbEspecialidades.Name = "CmbEspecialidades";
            this.CmbEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.CmbEspecialidades.TabIndex = 2;
            this.CmbEspecialidades.SelectedIndexChanged += new System.EventHandler(this.CmbEspecialidades_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(36, 279);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(484, 163);
            this.dataGridView2.TabIndex = 3;
            // 
            // BtnFecha
            // 
            this.BtnFecha.Location = new System.Drawing.Point(47, 448);
            this.BtnFecha.Name = "BtnFecha";
            this.BtnFecha.Size = new System.Drawing.Size(95, 41);
            this.BtnFecha.TabIndex = 4;
            this.BtnFecha.Text = "Ordenar Por Fecha";
            this.BtnFecha.UseVisualStyleBackColor = true;
            this.BtnFecha.Click += new System.EventHandler(this.BtnFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gnancia taotal:";
            // 
            // LblGananciaTotal
            // 
            this.LblGananciaTotal.AutoSize = true;
            this.LblGananciaTotal.Location = new System.Drawing.Point(192, 509);
            this.LblGananciaTotal.Name = "LblGananciaTotal";
            this.LblGananciaTotal.Size = new System.Drawing.Size(10, 13);
            this.LblGananciaTotal.TabIndex = 6;
            this.LblGananciaTotal.Text = "-";
            // 
            // BtnNombre
            // 
            this.BtnNombre.Location = new System.Drawing.Point(211, 448);
            this.BtnNombre.Name = "BtnNombre";
            this.BtnNombre.Size = new System.Drawing.Size(95, 41);
            this.BtnNombre.TabIndex = 7;
            this.BtnNombre.Text = "Ordenar Por Nombre";
            this.BtnNombre.UseVisualStyleBackColor = true;
            this.BtnNombre.Click += new System.EventHandler(this.BtnNombre_Click);
            // 
            // frmVerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 551);
            this.Controls.Add(this.BtnNombre);
            this.Controls.Add(this.LblGananciaTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFecha);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CmbEspecialidades);
            this.Controls.Add(this.cmbDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVerInfo";
            this.Text = "frmVerInfo";
            this.Load += new System.EventHandler(this.frmVerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbDatos;
        private System.Windows.Forms.ComboBox CmbEspecialidades;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGananciaTotal;
        private System.Windows.Forms.Button BtnNombre;
    }
}
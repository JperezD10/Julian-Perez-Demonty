namespace Jardin
{
    partial class Ver_Info
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
            this.DgVSalas = new System.Windows.Forms.DataGridView();
            this.DatagrivewMaestras = new System.Windows.Forms.DataGridView();
            this.CmbSalon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewInscripciones = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.LblGnanciaTotal = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnOrdenarApellido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgVSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivewMaestras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // DgVSalas
            // 
            this.DgVSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVSalas.Location = new System.Drawing.Point(12, 12);
            this.DgVSalas.Name = "DgVSalas";
            this.DgVSalas.Size = new System.Drawing.Size(441, 150);
            this.DgVSalas.TabIndex = 0;
            // 
            // DatagrivewMaestras
            // 
            this.DatagrivewMaestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagrivewMaestras.Location = new System.Drawing.Point(12, 256);
            this.DatagrivewMaestras.Name = "DatagrivewMaestras";
            this.DatagrivewMaestras.Size = new System.Drawing.Size(441, 150);
            this.DatagrivewMaestras.TabIndex = 1;
            // 
            // CmbSalon
            // 
            this.CmbSalon.FormattingEnabled = true;
            this.CmbSalon.Items.AddRange(new object[] {
            "Lactarios",
            "Deambuladores",
            "Deambuladores II",
            "Sala de 2",
            "Sala de 3"});
            this.CmbSalon.Location = new System.Drawing.Point(100, 207);
            this.CmbSalon.Name = "CmbSalon";
            this.CmbSalon.Size = new System.Drawing.Size(121, 21);
            this.CmbSalon.TabIndex = 4;
            this.CmbSalon.SelectedIndexChanged += new System.EventHandler(this.CmbSalon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo Salon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Maestras Segun Tipo Salon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------";
            // 
            // dataGridViewInscripciones
            // 
            this.dataGridViewInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscripciones.Location = new System.Drawing.Point(12, 449);
            this.dataGridViewInscripciones.Name = "dataGridViewInscripciones";
            this.dataGridViewInscripciones.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewInscripciones.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ganancia Total:";
            // 
            // LblGnanciaTotal
            // 
            this.LblGnanciaTotal.AutoSize = true;
            this.LblGnanciaTotal.Location = new System.Drawing.Point(117, 653);
            this.LblGnanciaTotal.Name = "LblGnanciaTotal";
            this.LblGnanciaTotal.Size = new System.Drawing.Size(11, 13);
            this.LblGnanciaTotal.TabIndex = 11;
            this.LblGnanciaTotal.Text = "*";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(164, 605);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(77, 38);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar Alumno";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Elimine Alumno Seleccionado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alumnos Segun Tipo Salon:";
            // 
            // BtnOrdenarApellido
            // 
            this.BtnOrdenarApellido.Location = new System.Drawing.Point(270, 606);
            this.BtnOrdenarApellido.Name = "BtnOrdenarApellido";
            this.BtnOrdenarApellido.Size = new System.Drawing.Size(79, 37);
            this.BtnOrdenarApellido.TabIndex = 15;
            this.BtnOrdenarApellido.Text = "Ordenar Por Apellido";
            this.BtnOrdenarApellido.UseVisualStyleBackColor = true;
            this.BtnOrdenarApellido.Click += new System.EventHandler(this.BtnOrdenarApellido_Click);
            // 
            // Ver_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 692);
            this.Controls.Add(this.BtnOrdenarApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.LblGnanciaTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewInscripciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSalon);
            this.Controls.Add(this.DatagrivewMaestras);
            this.Controls.Add(this.DgVSalas);
            this.Name = "Ver_Info";
            this.Text = "Ver_Info";
            this.Load += new System.EventHandler(this.Ver_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgVSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivewMaestras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgVSalas;
        private System.Windows.Forms.DataGridView DatagrivewMaestras;
        private System.Windows.Forms.ComboBox CmbSalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewInscripciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblGnanciaTotal;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnOrdenarApellido;
    }
}
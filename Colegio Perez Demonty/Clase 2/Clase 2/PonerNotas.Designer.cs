namespace Clase_2
{
    partial class PonerNotas
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
            this.txtIDAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInstancia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.GrillaMateria = new System.Windows.Forms.DataGridView();
            this.GrillaAlumno = new System.Windows.Forms.DataGridView();
            this.controlNumericoNotas = new Clase_2.ControlNumerico();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Alumno";
            // 
            // txtIDAlumno
            // 
            this.txtIDAlumno.Location = new System.Drawing.Point(172, 24);
            this.txtIDAlumno.Name = "txtIDAlumno";
            this.txtIDAlumno.ReadOnly = true;
            this.txtIDAlumno.Size = new System.Drawing.Size(100, 22);
            this.txtIDAlumno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "IDMateria";
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(172, 97);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.ReadOnly = true;
            this.txtIDMateria.Size = new System.Drawing.Size(100, 22);
            this.txtIDMateria.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione la Insatncia";
            // 
            // cmbInstancia
            // 
            this.cmbInstancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstancia.FormattingEnabled = true;
            this.cmbInstancia.Items.AddRange(new object[] {
            "Primer Parcial",
            "Segundo Parcial",
            "Trabajo Practico"});
            this.cmbInstancia.Location = new System.Drawing.Point(139, 187);
            this.cmbInstancia.Name = "cmbInstancia";
            this.cmbInstancia.Size = new System.Drawing.Size(149, 24);
            this.cmbInstancia.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Poner Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(16, 357);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(69, 44);
            this.btVolver.TabIndex = 7;
            this.btVolver.Text = "Cerrar Sesion";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // GrillaMateria
            // 
            this.GrillaMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMateria.Location = new System.Drawing.Point(511, 215);
            this.GrillaMateria.Name = "GrillaMateria";
            this.GrillaMateria.RowTemplate.Height = 24;
            this.GrillaMateria.Size = new System.Drawing.Size(374, 135);
            this.GrillaMateria.TabIndex = 8;
            this.GrillaMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaMateria_CellClick);
            // 
            // GrillaAlumno
            // 
            this.GrillaAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaAlumno.Location = new System.Drawing.Point(382, 24);
            this.GrillaAlumno.Name = "GrillaAlumno";
            this.GrillaAlumno.RowTemplate.Height = 24;
            this.GrillaAlumno.Size = new System.Drawing.Size(503, 135);
            this.GrillaAlumno.TabIndex = 8;
            this.GrillaAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaAlumno_CellClick);
            // 
            // controlNumericoNotas
            // 
            this.controlNumericoNotas.Etiqueta = "Nota Numerica:";
            this.controlNumericoNotas.Location = new System.Drawing.Point(-4, 236);
            this.controlNumericoNotas.Margin = new System.Windows.Forms.Padding(5);
            this.controlNumericoNotas.Name = "controlNumericoNotas";
            this.controlNumericoNotas.Size = new System.Drawing.Size(309, 45);
            this.controlNumericoNotas.TabIndex = 5;
            this.controlNumericoNotas.Texto = "";
            // 
            // PonerNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 413);
            this.Controls.Add(this.GrillaAlumno);
            this.Controls.Add(this.GrillaMateria);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlNumericoNotas);
            this.Controls.Add(this.cmbInstancia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDMateria);
            this.Controls.Add(this.txtIDAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PonerNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PonerNotas";
            this.Load += new System.EventHandler(this.PonerNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbInstancia;
        private ControlNumerico controlNumericoNotas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.DataGridView GrillaMateria;
        private System.Windows.Forms.DataGridView GrillaAlumno;
    }
}
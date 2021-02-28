namespace Jardin
{
    partial class Imprimir_Boleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imprimir_Boleta));
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewInscripciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSalon = new System.Windows.Forms.ComboBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblTurno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCurso = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblTotal2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alumnos Segun Tipo Salon:";
            // 
            // dataGridViewInscripciones
            // 
            this.dataGridViewInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscripciones.Location = new System.Drawing.Point(12, 84);
            this.dataGridViewInscripciones.Name = "dataGridViewInscripciones";
            this.dataGridViewInscripciones.Size = new System.Drawing.Size(466, 150);
            this.dataGridViewInscripciones.TabIndex = 15;
            this.dataGridViewInscripciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInscripciones_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo Salon:";
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
            this.CmbSalon.Location = new System.Drawing.Point(91, 28);
            this.CmbSalon.Name = "CmbSalon";
            this.CmbSalon.Size = new System.Drawing.Size(121, 21);
            this.CmbSalon.TabIndex = 17;
            this.CmbSalon.SelectedIndexChanged += new System.EventHandler(this.CmbSalon_SelectedIndexChanged);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.LblNombre.Location = new System.Drawing.Point(127, 335);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(6, 7);
            this.LblNombre.TabIndex = 19;
            this.LblNombre.Text = "-";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.LblApellido.Location = new System.Drawing.Point(127, 353);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(6, 7);
            this.LblApellido.TabIndex = 20;
            this.LblApellido.Text = "-";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.LblEdad.Location = new System.Drawing.Point(127, 369);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(6, 7);
            this.LblEdad.TabIndex = 21;
            this.LblEdad.Text = "-";
            // 
            // LblTurno
            // 
            this.LblTurno.AutoSize = true;
            this.LblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.LblTurno.Location = new System.Drawing.Point(127, 386);
            this.LblTurno.Name = "LblTurno";
            this.LblTurno.Size = new System.Drawing.Size(6, 7);
            this.LblTurno.TabIndex = 22;
            this.LblTurno.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-20, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.LblCurso.Location = new System.Drawing.Point(206, 335);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(6, 7);
            this.LblCurso.TabIndex = 24;
            this.LblCurso.Text = "-";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.LblDescripcion.Location = new System.Drawing.Point(163, 430);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(105, 7);
            this.LblDescripcion.TabIndex = 25;
            this.LblDescripcion.Text = "Cuota Mensual - Centro Diseño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.label2.Location = new System.Drawing.Point(93, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 7);
            this.label2.TabIndex = 26;
            this.label2.Text = "1";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.LblTotal.Location = new System.Drawing.Point(363, 430);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(6, 7);
            this.LblTotal.TabIndex = 27;
            this.LblTotal.Text = "-";
            // 
            // LblTotal2
            // 
            this.LblTotal2.AutoSize = true;
            this.LblTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.LblTotal2.Location = new System.Drawing.Point(363, 650);
            this.LblTotal2.Name = "LblTotal2";
            this.LblTotal2.Size = new System.Drawing.Size(6, 7);
            this.LblTotal2.TabIndex = 28;
            this.LblTotal2.Text = "-";
            // 
            // Imprimir_Boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 689);
            this.Controls.Add(this.LblTotal2);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblCurso);
            this.Controls.Add(this.LblTurno);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSalon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewInscripciones);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Imprimir_Boleta";
            this.Text = "Bajas_De_Alumnos";
            this.Load += new System.EventHandler(this.Imprimir_Boleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewInscripciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSalon;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblTurno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblTotal2;
    }
}
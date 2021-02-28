namespace Clase_2
{
    partial class AsignarProfeMaterias
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
            this.btAsignar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.grillaProfesor = new System.Windows.Forms.DataGridView();
            this.GrillaMateria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDProfesor = new System.Windows.Forms.TextBox();
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // btAsignar
            // 
            this.btAsignar.Location = new System.Drawing.Point(149, 177);
            this.btAsignar.Name = "btAsignar";
            this.btAsignar.Size = new System.Drawing.Size(100, 37);
            this.btAsignar.TabIndex = 3;
            this.btAsignar.Text = "Asginar";
            this.btAsignar.UseVisualStyleBackColor = true;
            this.btAsignar.Click += new System.EventHandler(this.btAsignar_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(13, 268);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 4;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // grillaProfesor
            // 
            this.grillaProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProfesor.Location = new System.Drawing.Point(396, 12);
            this.grillaProfesor.Name = "grillaProfesor";
            this.grillaProfesor.RowTemplate.Height = 24;
            this.grillaProfesor.Size = new System.Drawing.Size(372, 108);
            this.grillaProfesor.TabIndex = 5;
            this.grillaProfesor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProfesor_CellClick);
            // 
            // GrillaMateria
            // 
            this.GrillaMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMateria.Location = new System.Drawing.Point(396, 164);
            this.GrillaMateria.Name = "GrillaMateria";
            this.GrillaMateria.RowTemplate.Height = 24;
            this.GrillaMateria.Size = new System.Drawing.Size(372, 108);
            this.GrillaMateria.TabIndex = 5;
            this.GrillaMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaMateria_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDProfesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Materia";
            // 
            // txtIDProfesor
            // 
            this.txtIDProfesor.Location = new System.Drawing.Point(149, 61);
            this.txtIDProfesor.Name = "txtIDProfesor";
            this.txtIDProfesor.ReadOnly = true;
            this.txtIDProfesor.Size = new System.Drawing.Size(100, 22);
            this.txtIDProfesor.TabIndex = 1;
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(149, 115);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.ReadOnly = true;
            this.txtIDMateria.Size = new System.Drawing.Size(100, 22);
            this.txtIDMateria.TabIndex = 2;
            // 
            // AsignarProfeMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 303);
            this.Controls.Add(this.GrillaMateria);
            this.Controls.Add(this.grillaProfesor);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btAsignar);
            this.Controls.Add(this.txtIDMateria);
            this.Controls.Add(this.txtIDProfesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AsignarProfeMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignarProfeMaterias";
            this.Load += new System.EventHandler(this.AsignarProfeMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAsignar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.DataGridView grillaProfesor;
        private System.Windows.Forms.DataGridView GrillaMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDProfesor;
        private System.Windows.Forms.TextBox txtIDMateria;
    }
}
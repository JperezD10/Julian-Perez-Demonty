namespace Clase_2
{
    partial class VerNotas
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
            this.btvolver = new System.Windows.Forms.Button();
            this.GrillaMateria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            this.btVerNotasDeMateria = new System.Windows.Forms.Button();
            this.GrillaNotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btvolver
            // 
            this.btvolver.Location = new System.Drawing.Point(12, 520);
            this.btvolver.Name = "btvolver";
            this.btvolver.Size = new System.Drawing.Size(107, 33);
            this.btvolver.TabIndex = 0;
            this.btvolver.Text = "Volver";
            this.btvolver.UseVisualStyleBackColor = true;
            this.btvolver.Click += new System.EventHandler(this.btvolver_Click);
            // 
            // GrillaMateria
            // 
            this.GrillaMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMateria.Location = new System.Drawing.Point(448, 12);
            this.GrillaMateria.Name = "GrillaMateria";
            this.GrillaMateria.RowTemplate.Height = 24;
            this.GrillaMateria.Size = new System.Drawing.Size(389, 137);
            this.GrillaMateria.TabIndex = 1;
            this.GrillaMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaMateria_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Por Favor Seleccione La Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "IDMateria";
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(194, 83);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.ReadOnly = true;
            this.txtIDMateria.Size = new System.Drawing.Size(100, 22);
            this.txtIDMateria.TabIndex = 4;
            // 
            // btVerNotasDeMateria
            // 
            this.btVerNotasDeMateria.Location = new System.Drawing.Point(194, 132);
            this.btVerNotasDeMateria.Name = "btVerNotasDeMateria";
            this.btVerNotasDeMateria.Size = new System.Drawing.Size(100, 46);
            this.btVerNotasDeMateria.TabIndex = 5;
            this.btVerNotasDeMateria.Text = "Ver Notas de Materia";
            this.btVerNotasDeMateria.UseVisualStyleBackColor = true;
            this.btVerNotasDeMateria.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrillaNotas
            // 
            this.GrillaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaNotas.Location = new System.Drawing.Point(29, 223);
            this.GrillaNotas.Name = "GrillaNotas";
            this.GrillaNotas.RowTemplate.Height = 24;
            this.GrillaNotas.Size = new System.Drawing.Size(808, 275);
            this.GrillaNotas.TabIndex = 6;
            // 
            // VerNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 565);
            this.Controls.Add(this.GrillaNotas);
            this.Controls.Add(this.btVerNotasDeMateria);
            this.Controls.Add(this.txtIDMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrillaMateria);
            this.Controls.Add(this.btvolver);
            this.Name = "VerNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerNotas";
            this.Load += new System.EventHandler(this.VerNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvolver;
        private System.Windows.Forms.DataGridView GrillaMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDMateria;
        private System.Windows.Forms.Button btVerNotasDeMateria;
        private System.Windows.Forms.DataGridView GrillaNotas;
    }
}
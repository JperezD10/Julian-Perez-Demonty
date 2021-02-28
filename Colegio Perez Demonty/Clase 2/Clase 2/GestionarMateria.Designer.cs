namespace Clase_2
{
    partial class GestionarMateria
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
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            this.btAgregarMateria = new System.Windows.Forms.Button();
            this.btModificarMateria = new System.Windows.Forms.Button();
            this.btELiminarMateria = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlNombreMateria = new Clase_2.ControlUsuario();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Materia";
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(168, 41);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.ReadOnly = true;
            this.txtIDMateria.Size = new System.Drawing.Size(100, 22);
            this.txtIDMateria.TabIndex = 2;
            this.txtIDMateria.TextChanged += new System.EventHandler(this.txtIDMateria_TextChanged);
            // 
            // btAgregarMateria
            // 
            this.btAgregarMateria.Location = new System.Drawing.Point(89, 168);
            this.btAgregarMateria.Name = "btAgregarMateria";
            this.btAgregarMateria.Size = new System.Drawing.Size(87, 51);
            this.btAgregarMateria.TabIndex = 3;
            this.btAgregarMateria.Text = "Agregar Materia";
            this.btAgregarMateria.UseVisualStyleBackColor = true;
            this.btAgregarMateria.Click += new System.EventHandler(this.btAgregarMateria_Click);
            // 
            // btModificarMateria
            // 
            this.btModificarMateria.Location = new System.Drawing.Point(201, 168);
            this.btModificarMateria.Name = "btModificarMateria";
            this.btModificarMateria.Size = new System.Drawing.Size(87, 51);
            this.btModificarMateria.TabIndex = 3;
            this.btModificarMateria.Text = "Modificar Materia";
            this.btModificarMateria.UseVisualStyleBackColor = true;
            this.btModificarMateria.Click += new System.EventHandler(this.btModificarMateria_Click);
            // 
            // btELiminarMateria
            // 
            this.btELiminarMateria.Location = new System.Drawing.Point(306, 168);
            this.btELiminarMateria.Name = "btELiminarMateria";
            this.btELiminarMateria.Size = new System.Drawing.Size(87, 51);
            this.btELiminarMateria.TabIndex = 3;
            this.btELiminarMateria.Text = "Eliminar Materia";
            this.btELiminarMateria.UseVisualStyleBackColor = true;
            this.btELiminarMateria.Click += new System.EventHandler(this.btELiminarMateria_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(13, 241);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(72, 23);
            this.btVolver.TabIndex = 4;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(496, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(347, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // controlNombreMateria
            // 
            this.controlNombreMateria.Etiqueta = "Nombre Materia";
            this.controlNombreMateria.Location = new System.Drawing.Point(13, 87);
            this.controlNombreMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlNombreMateria.Name = "controlNombreMateria";
            this.controlNombreMateria.Size = new System.Drawing.Size(325, 50);
            this.controlNombreMateria.TabIndex = 0;
            this.controlNombreMateria.Texto = "";
            // 
            // GestionarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 276);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btELiminarMateria);
            this.Controls.Add(this.btModificarMateria);
            this.Controls.Add(this.btAgregarMateria);
            this.Controls.Add(this.txtIDMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlNombreMateria);
            this.Name = "GestionarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarMateria";
            this.Load += new System.EventHandler(this.GestionarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUsuario controlNombreMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMateria;
        private System.Windows.Forms.Button btAgregarMateria;
        private System.Windows.Forms.Button btModificarMateria;
        private System.Windows.Forms.Button btELiminarMateria;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
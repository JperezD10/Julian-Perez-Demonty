namespace Clase_2
{
    partial class AdministrarProfesor
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
            this.controlNombreProfe = new Clase_2.ControlUsuario();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDProfesor = new System.Windows.Forms.TextBox();
            this.btAgregarProfe = new System.Windows.Forms.Button();
            this.btModificarProfe = new System.Windows.Forms.Button();
            this.btChauProfe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNombreProfe
            // 
            this.controlNombreProfe.Etiqueta = "Nombre";
            this.controlNombreProfe.Location = new System.Drawing.Point(13, 114);
            this.controlNombreProfe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlNombreProfe.Name = "controlNombreProfe";
            this.controlNombreProfe.Size = new System.Drawing.Size(325, 50);
            this.controlNombreProfe.TabIndex = 0;
            this.controlNombreProfe.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Profesor";
            // 
            // txtIDProfesor
            // 
            this.txtIDProfesor.Location = new System.Drawing.Point(177, 57);
            this.txtIDProfesor.Name = "txtIDProfesor";
            this.txtIDProfesor.ReadOnly = true;
            this.txtIDProfesor.Size = new System.Drawing.Size(100, 22);
            this.txtIDProfesor.TabIndex = 2;
            // 
            // btAgregarProfe
            // 
            this.btAgregarProfe.Location = new System.Drawing.Point(89, 180);
            this.btAgregarProfe.Name = "btAgregarProfe";
            this.btAgregarProfe.Size = new System.Drawing.Size(90, 51);
            this.btAgregarProfe.TabIndex = 3;
            this.btAgregarProfe.Text = "Agregar Profesor";
            this.btAgregarProfe.UseVisualStyleBackColor = true;
            this.btAgregarProfe.Click += new System.EventHandler(this.btAgregarProfe_Click);
            // 
            // btModificarProfe
            // 
            this.btModificarProfe.Location = new System.Drawing.Point(216, 180);
            this.btModificarProfe.Name = "btModificarProfe";
            this.btModificarProfe.Size = new System.Drawing.Size(90, 51);
            this.btModificarProfe.TabIndex = 3;
            this.btModificarProfe.Text = "Modificar Profesor";
            this.btModificarProfe.UseVisualStyleBackColor = true;
            this.btModificarProfe.Click += new System.EventHandler(this.btModificarProfe_Click);
            // 
            // btChauProfe
            // 
            this.btChauProfe.Location = new System.Drawing.Point(343, 180);
            this.btChauProfe.Name = "btChauProfe";
            this.btChauProfe.Size = new System.Drawing.Size(90, 51);
            this.btChauProfe.TabIndex = 3;
            this.btChauProfe.Text = "Chau Profe";
            this.btChauProfe.UseVisualStyleBackColor = true;
            this.btChauProfe.Click += new System.EventHandler(this.btChauProfe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(495, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(13, 275);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 5;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // AdministrarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 310);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btChauProfe);
            this.Controls.Add(this.btModificarProfe);
            this.Controls.Add(this.btAgregarProfe);
            this.Controls.Add(this.txtIDProfesor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlNombreProfe);
            this.Name = "AdministrarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarProfesor";
            this.Load += new System.EventHandler(this.AdministrarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUsuario controlNombreProfe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDProfesor;
        private System.Windows.Forms.Button btAgregarProfe;
        private System.Windows.Forms.Button btModificarProfe;
        private System.Windows.Forms.Button btChauProfe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btVolver;
    }
}
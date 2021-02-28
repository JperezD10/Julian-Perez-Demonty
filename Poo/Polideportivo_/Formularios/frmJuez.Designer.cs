namespace Formularios
{
    partial class frmJuez
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNroLegajo = new System.Windows.Forms.Label();
            this.btnCrearJuez = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(64, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(64, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(64, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Legajo: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 199);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(177, 269);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 22);
            this.txtApellido.TabIndex = 4;
            // 
            // lblNroLegajo
            // 
            this.lblNroLegajo.AutoSize = true;
            this.lblNroLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblNroLegajo.Location = new System.Drawing.Point(173, 130);
            this.lblNroLegajo.Name = "lblNroLegajo";
            this.lblNroLegajo.Size = new System.Drawing.Size(20, 24);
            this.lblNroLegajo.TabIndex = 5;
            this.lblNroLegajo.Text = "0";
            // 
            // btnCrearJuez
            // 
            this.btnCrearJuez.Location = new System.Drawing.Point(145, 352);
            this.btnCrearJuez.Name = "btnCrearJuez";
            this.btnCrearJuez.Size = new System.Drawing.Size(145, 60);
            this.btnCrearJuez.TabIndex = 6;
            this.btnCrearJuez.Text = "Crear Juez";
            this.btnCrearJuez.UseVisualStyleBackColor = true;
            this.btnCrearJuez.Click += new System.EventHandler(this.btnCrearJuez_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "- Jueces";
            // 
            // frmJuez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 464);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCrearJuez);
            this.Controls.Add(this.lblNroLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmJuez";
            this.Text = "frmJuez";
            this.Load += new System.EventHandler(this.frmJuez_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNroLegajo;
        private System.Windows.Forms.Button btnCrearJuez;
        private System.Windows.Forms.Label label4;
    }
}
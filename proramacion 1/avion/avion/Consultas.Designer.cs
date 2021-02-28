namespace avion
{
    partial class Consultas
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEstadoAlta = new System.Windows.Forms.Button();
            this.btnEstadoBaja = new System.Windows.Forms.Button();
            this.btnTotalRecaudado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultas";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 363);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(97, 36);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEstadoAlta
            // 
            this.btnEstadoAlta.Location = new System.Drawing.Point(109, 119);
            this.btnEstadoAlta.Name = "btnEstadoAlta";
            this.btnEstadoAlta.Size = new System.Drawing.Size(135, 68);
            this.btnEstadoAlta.TabIndex = 11;
            this.btnEstadoAlta.Text = "ESTADO DE PLANTA ALTA";
            this.btnEstadoAlta.UseVisualStyleBackColor = true;
            this.btnEstadoAlta.Click += new System.EventHandler(this.btnEstadoAlta_Click);
            // 
            // btnEstadoBaja
            // 
            this.btnEstadoBaja.Location = new System.Drawing.Point(339, 119);
            this.btnEstadoBaja.Name = "btnEstadoBaja";
            this.btnEstadoBaja.Size = new System.Drawing.Size(135, 68);
            this.btnEstadoBaja.TabIndex = 12;
            this.btnEstadoBaja.Text = "ESTADO DE PLANTA BAJA";
            this.btnEstadoBaja.UseVisualStyleBackColor = true;
            this.btnEstadoBaja.Click += new System.EventHandler(this.btnEstadoBaja_Click);
            // 
            // btnTotalRecaudado
            // 
            this.btnTotalRecaudado.Location = new System.Drawing.Point(231, 232);
            this.btnTotalRecaudado.Name = "btnTotalRecaudado";
            this.btnTotalRecaudado.Size = new System.Drawing.Size(135, 68);
            this.btnTotalRecaudado.TabIndex = 13;
            this.btnTotalRecaudado.Text = "TOTAL RECAUDADO";
            this.btnTotalRecaudado.UseVisualStyleBackColor = true;
            this.btnTotalRecaudado.Click += new System.EventHandler(this.btnTotalRecaudado_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnTotalRecaudado);
            this.Controls.Add(this.btnEstadoBaja);
            this.Controls.Add(this.btnEstadoAlta);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEstadoAlta;
        private System.Windows.Forms.Button btnEstadoBaja;
        private System.Windows.Forms.Button btnTotalRecaudado;
    }
}
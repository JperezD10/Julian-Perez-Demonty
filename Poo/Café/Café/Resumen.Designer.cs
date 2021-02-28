namespace Café
{
    partial class Resumen
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
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoMaquina = new System.Windows.Forms.ComboBox();
            this.lblTotalPorMaquina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total General:";
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Location = new System.Drawing.Point(110, 31);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(10, 13);
            this.lblTotalGeneral.TabIndex = 1;
            this.lblTotalGeneral.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Por Maquina:";
            // 
            // cmbTipoMaquina
            // 
            this.cmbTipoMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMaquina.FormattingEnabled = true;
            this.cmbTipoMaquina.Location = new System.Drawing.Point(133, 65);
            this.cmbTipoMaquina.Name = "cmbTipoMaquina";
            this.cmbTipoMaquina.Size = new System.Drawing.Size(83, 21);
            this.cmbTipoMaquina.TabIndex = 3;
            this.cmbTipoMaquina.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCafe_SelectedIndexChanged);
            // 
            // lblTotalPorMaquina
            // 
            this.lblTotalPorMaquina.AutoSize = true;
            this.lblTotalPorMaquina.Location = new System.Drawing.Point(235, 68);
            this.lblTotalPorMaquina.Name = "lblTotalPorMaquina";
            this.lblTotalPorMaquina.Size = new System.Drawing.Size(10, 13);
            this.lblTotalPorMaquina.TabIndex = 4;
            this.lblTotalPorMaquina.Text = "-";
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 293);
            this.Controls.Add(this.lblTotalPorMaquina);
            this.Controls.Add(this.cmbTipoMaquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalGeneral);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Resumen";
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.Resumen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoMaquina;
        private System.Windows.Forms.Label lblTotalPorMaquina;
    }
}
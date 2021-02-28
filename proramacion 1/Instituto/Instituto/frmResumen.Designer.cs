namespace Instituto
{
    partial class frmResumen
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblValorTotalR = new System.Windows.Forms.Label();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.txtPreResumen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(48, 449);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(48, 95);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 292);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblValorTotalR
            // 
            this.lblValorTotalR.AutoSize = true;
            this.lblValorTotalR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalR.Location = new System.Drawing.Point(221, 423);
            this.lblValorTotalR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotalR.Name = "lblValorTotalR";
            this.lblValorTotalR.Size = new System.Drawing.Size(0, 24);
            this.lblValorTotalR.TabIndex = 7;
            // 
            // txtResumen
            // 
            this.txtResumen.Location = new System.Drawing.Point(315, 194);
            this.txtResumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResumen.Multiline = true;
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.ReadOnly = true;
            this.txtResumen.Size = new System.Drawing.Size(232, 192);
            this.txtResumen.TabIndex = 8;
            // 
            // txtPreResumen
            // 
            this.txtPreResumen.Location = new System.Drawing.Point(315, 95);
            this.txtPreResumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreResumen.Multiline = true;
            this.txtPreResumen.Name = "txtPreResumen";
            this.txtPreResumen.ReadOnly = true;
            this.txtPreResumen.Size = new System.Drawing.Size(232, 91);
            this.txtPreResumen.TabIndex = 9;
            // 
            // frmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 510);
            this.Controls.Add(this.txtPreResumen);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.lblValorTotalR);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmResumen";
            this.Text = "frmResumen";
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblValorTotalR;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.TextBox txtPreResumen;
    }
}
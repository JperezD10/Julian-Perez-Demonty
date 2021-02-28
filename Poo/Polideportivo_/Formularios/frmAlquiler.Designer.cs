namespace Formularios
{
    partial class frmAlquiler
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCancha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOpcionales = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbArbitro = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelJuecesLinea = new System.Windows.Forms.Panel();
            this.cmbJuezLinea2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbJuezLinea1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.panelArbitro = new System.Windows.Forms.Panel();
            this.panelTurno = new System.Windows.Forms.Panel();
            this.panelJuecesLinea.SuspendLayout();
            this.panelArbitro.SuspendLayout();
            this.panelTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(22, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "- Alquileres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(64, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cancha: ";
            // 
            // cmbCancha
            // 
            this.cmbCancha.FormattingEnabled = true;
            this.cmbCancha.Items.AddRange(new object[] {
            "Cancha de Tenis",
            "Cancha de fútbol 5",
            "Cancha de fútbol 7",
            "Cancha de fútbol 11"});
            this.cmbCancha.Location = new System.Drawing.Point(165, 120);
            this.cmbCancha.Name = "cmbCancha";
            this.cmbCancha.Size = new System.Drawing.Size(196, 24);
            this.cmbCancha.TabIndex = 10;
            this.cmbCancha.SelectedIndexChanged += new System.EventHandler(this.cmbCancha_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(64, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor:    $";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblValor.Location = new System.Drawing.Point(159, 189);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(20, 24);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(64, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Opcionales: ";
            // 
            // cmbOpcionales
            // 
            this.cmbOpcionales.FormattingEnabled = true;
            this.cmbOpcionales.Items.AddRange(new object[] {
            "----------------------------"});
            this.cmbOpcionales.Location = new System.Drawing.Point(186, 248);
            this.cmbOpcionales.Name = "cmbOpcionales";
            this.cmbOpcionales.Size = new System.Drawing.Size(196, 24);
            this.cmbOpcionales.TabIndex = 14;
            this.cmbOpcionales.SelectedIndexChanged += new System.EventHandler(this.cmbOpcionales_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(25, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seleccionar Arbitro: ";
            // 
            // cmbArbitro
            // 
            this.cmbArbitro.FormattingEnabled = true;
            this.cmbArbitro.Location = new System.Drawing.Point(211, 14);
            this.cmbArbitro.Name = "cmbArbitro";
            this.cmbArbitro.Size = new System.Drawing.Size(196, 24);
            this.cmbArbitro.TabIndex = 16;
            this.cmbArbitro.DropDown += new System.EventHandler(this.cmbArbitro_SelectedIndexChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(221, 8);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(196, 24);
            this.cmbTurno.TabIndex = 18;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(35, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seleccionar Turno:";
            // 
            // panelJuecesLinea
            // 
            this.panelJuecesLinea.Controls.Add(this.cmbJuezLinea2);
            this.panelJuecesLinea.Controls.Add(this.label8);
            this.panelJuecesLinea.Controls.Add(this.cmbJuezLinea1);
            this.panelJuecesLinea.Controls.Add(this.label7);
            this.panelJuecesLinea.Location = new System.Drawing.Point(48, 428);
            this.panelJuecesLinea.Name = "panelJuecesLinea";
            this.panelJuecesLinea.Size = new System.Drawing.Size(486, 96);
            this.panelJuecesLinea.TabIndex = 19;
            this.panelJuecesLinea.Visible = false;
            // 
            // cmbJuezLinea2
            // 
            this.cmbJuezLinea2.FormattingEnabled = true;
            this.cmbJuezLinea2.Location = new System.Drawing.Point(248, 56);
            this.cmbJuezLinea2.Name = "cmbJuezLinea2";
            this.cmbJuezLinea2.Size = new System.Drawing.Size(196, 24);
            this.cmbJuezLinea2.TabIndex = 23;
            this.cmbJuezLinea2.DropDown += new System.EventHandler(this.cmbJuezLinea2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(11, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Seleccionar Juez Linea 2: ";
            // 
            // cmbJuezLinea1
            // 
            this.cmbJuezLinea1.FormattingEnabled = true;
            this.cmbJuezLinea1.Location = new System.Drawing.Point(248, 15);
            this.cmbJuezLinea1.Name = "cmbJuezLinea1";
            this.cmbJuezLinea1.Size = new System.Drawing.Size(196, 24);
            this.cmbJuezLinea1.TabIndex = 21;
            this.cmbJuezLinea1.DropDown += new System.EventHandler(this.cmbJuezLinea1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(11, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Seleccionar Juez Linea 1: ";
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Enabled = false;
            this.btnAlquilar.Location = new System.Drawing.Point(197, 548);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(223, 58);
            this.btnAlquilar.TabIndex = 20;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            // 
            // panelArbitro
            // 
            this.panelArbitro.Controls.Add(this.cmbArbitro);
            this.panelArbitro.Controls.Add(this.label5);
            this.panelArbitro.Location = new System.Drawing.Point(38, 362);
            this.panelArbitro.Name = "panelArbitro";
            this.panelArbitro.Size = new System.Drawing.Size(505, 46);
            this.panelArbitro.TabIndex = 21;
            this.panelArbitro.Visible = false;
            // 
            // panelTurno
            // 
            this.panelTurno.Controls.Add(this.cmbTurno);
            this.panelTurno.Controls.Add(this.label6);
            this.panelTurno.Location = new System.Drawing.Point(27, 309);
            this.panelTurno.Name = "panelTurno";
            this.panelTurno.Size = new System.Drawing.Size(443, 47);
            this.panelTurno.TabIndex = 22;
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 636);
            this.Controls.Add(this.panelTurno);
            this.Controls.Add(this.panelArbitro);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.panelJuecesLinea);
            this.Controls.Add(this.cmbOpcionales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCancha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmAlquiler";
            this.Text = "frmAlquiler";
            this.Load += new System.EventHandler(this.frmAlquiler_Load);
            this.panelJuecesLinea.ResumeLayout(false);
            this.panelJuecesLinea.PerformLayout();
            this.panelArbitro.ResumeLayout(false);
            this.panelArbitro.PerformLayout();
            this.panelTurno.ResumeLayout(false);
            this.panelTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCancha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOpcionales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbArbitro;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelJuecesLinea;
        private System.Windows.Forms.ComboBox cmbJuezLinea2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbJuezLinea1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Panel panelArbitro;
        private System.Windows.Forms.Panel panelTurno;
    }
}
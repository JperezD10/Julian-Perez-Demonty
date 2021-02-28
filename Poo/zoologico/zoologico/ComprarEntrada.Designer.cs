namespace zoologico
{
    partial class ComprarEntrada
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
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.txtApellidoPersona = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumeroEntrada = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.cbTerrestre = new System.Windows.Forms.CheckBox();
            this.cbAcuatico = new System.Windows.Forms.CheckBox();
            this.cbAire = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Location = new System.Drawing.Point(116, 98);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(100, 22);
            this.txtNombrePersona.TabIndex = 0;
            // 
            // txtApellidoPersona
            // 
            this.txtApellidoPersona.Location = new System.Drawing.Point(116, 159);
            this.txtApellidoPersona.Name = "txtApellidoPersona";
            this.txtApellidoPersona.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoPersona.TabIndex = 0;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(116, 224);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 22);
            this.nudEdad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Entrada";
            // 
            // lblNumeroEntrada
            // 
            this.lblNumeroEntrada.AutoSize = true;
            this.lblNumeroEntrada.Location = new System.Drawing.Point(143, 40);
            this.lblNumeroEntrada.Name = "lblNumeroEntrada";
            this.lblNumeroEntrada.Size = new System.Drawing.Size(13, 17);
            this.lblNumeroEntrada.TabIndex = 4;
            this.lblNumeroEntrada.Text = "-";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(13, 382);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 35);
            this.btVolver.TabIndex = 5;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // cbTerrestre
            // 
            this.cbTerrestre.AutoSize = true;
            this.cbTerrestre.Location = new System.Drawing.Point(25, 321);
            this.cbTerrestre.Name = "cbTerrestre";
            this.cbTerrestre.Size = new System.Drawing.Size(89, 21);
            this.cbTerrestre.TabIndex = 6;
            this.cbTerrestre.Text = "Terrestre";
            this.cbTerrestre.UseVisualStyleBackColor = true;
            this.cbTerrestre.CheckedChanged += new System.EventHandler(this.cbTerrestre_CheckedChanged);
            // 
            // cbAcuatico
            // 
            this.cbAcuatico.AutoSize = true;
            this.cbAcuatico.Location = new System.Drawing.Point(138, 321);
            this.cbAcuatico.Name = "cbAcuatico";
            this.cbAcuatico.Size = new System.Drawing.Size(84, 21);
            this.cbAcuatico.TabIndex = 6;
            this.cbAcuatico.Text = "Acuatico";
            this.cbAcuatico.UseVisualStyleBackColor = true;
            this.cbAcuatico.CheckedChanged += new System.EventHandler(this.cbAcuatico_CheckedChanged);
            // 
            // cbAire
            // 
            this.cbAire.AutoSize = true;
            this.cbAire.Location = new System.Drawing.Point(242, 321);
            this.cbAire.Name = "cbAire";
            this.cbAire.Size = new System.Drawing.Size(55, 21);
            this.cbAire.TabIndex = 6;
            this.cbAire.Text = "Aire";
            this.cbAire.UseVisualStyleBackColor = true;
            this.cbAire.CheckedChanged += new System.EventHandler(this.cbAire_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sectores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(364, 371);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "-";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(116, 382);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(106, 35);
            this.btCalcular.TabIndex = 10;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // ComprarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 429);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAire);
            this.Controls.Add(this.cbAcuatico);
            this.Controls.Add(this.cbTerrestre);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lblNumeroEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.txtApellidoPersona);
            this.Controls.Add(this.txtNombrePersona);
            this.Name = "ComprarEntrada";
            this.Text = "ComprarEntrada";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComprarEntrada_FormClosed);
            this.Load += new System.EventHandler(this.ComprarEntrada_Load);
            this.ForeColorChanged += new System.EventHandler(this.ComprarEntrada_ForeColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.TextBox txtApellidoPersona;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumeroEntrada;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.CheckBox cbTerrestre;
        private System.Windows.Forms.CheckBox cbAcuatico;
        private System.Windows.Forms.CheckBox cbAire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btCalcular;
    }
}
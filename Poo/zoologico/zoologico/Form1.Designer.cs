namespace zoologico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreAnimal = new System.Windows.Forms.TextBox();
            this.cmbHabitat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudExistencia = new System.Windows.Forms.NumericUpDown();
            this.cmbAlimentacion = new System.Windows.Forms.ComboBox();
            this.cbbipedo = new System.Windows.Forms.CheckBox();
            this.cbcuadrupedo = new System.Windows.Forms.CheckBox();
            this.cbexoesqueleto = new System.Windows.Forms.CheckBox();
            this.nudVelocidad = new System.Windows.Forms.NumericUpDown();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.btCargarAnimal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alimentacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Habitat";
            // 
            // txtNombreAnimal
            // 
            this.txtNombreAnimal.Location = new System.Drawing.Point(195, 53);
            this.txtNombreAnimal.Name = "txtNombreAnimal";
            this.txtNombreAnimal.Size = new System.Drawing.Size(100, 22);
            this.txtNombreAnimal.TabIndex = 1;
            this.txtNombreAnimal.TextChanged += new System.EventHandler(this.txtNombreAnimal_TextChanged);
            // 
            // cmbHabitat
            // 
            this.cmbHabitat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitat.FormattingEnabled = true;
            this.cmbHabitat.Location = new System.Drawing.Point(200, 229);
            this.cmbHabitat.Name = "cmbHabitat";
            this.cmbHabitat.Size = new System.Drawing.Size(121, 24);
            this.cmbHabitat.TabIndex = 2;
            this.cmbHabitat.SelectedIndexChanged += new System.EventHandler(this.cmbHabitat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia";
            // 
            // nudExistencia
            // 
            this.nudExistencia.Location = new System.Drawing.Point(195, 166);
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(120, 22);
            this.nudExistencia.TabIndex = 4;
            // 
            // cmbAlimentacion
            // 
            this.cmbAlimentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlimentacion.FormattingEnabled = true;
            this.cmbAlimentacion.Location = new System.Drawing.Point(194, 95);
            this.cmbAlimentacion.Name = "cmbAlimentacion";
            this.cmbAlimentacion.Size = new System.Drawing.Size(121, 24);
            this.cmbAlimentacion.TabIndex = 5;
            // 
            // cbbipedo
            // 
            this.cbbipedo.AutoSize = true;
            this.cbbipedo.Location = new System.Drawing.Point(378, 229);
            this.cbbipedo.Name = "cbbipedo";
            this.cbbipedo.Size = new System.Drawing.Size(73, 21);
            this.cbbipedo.TabIndex = 6;
            this.cbbipedo.Text = "bipedo";
            this.cbbipedo.UseVisualStyleBackColor = true;
            this.cbbipedo.CheckedChanged += new System.EventHandler(this.cbbipedo_CheckedChanged);
            // 
            // cbcuadrupedo
            // 
            this.cbcuadrupedo.AutoSize = true;
            this.cbcuadrupedo.Location = new System.Drawing.Point(378, 273);
            this.cbcuadrupedo.Name = "cbcuadrupedo";
            this.cbcuadrupedo.Size = new System.Drawing.Size(106, 21);
            this.cbcuadrupedo.TabIndex = 6;
            this.cbcuadrupedo.Text = "cuadrupedo";
            this.cbcuadrupedo.UseVisualStyleBackColor = true;
            this.cbcuadrupedo.CheckedChanged += new System.EventHandler(this.cbcuadrupedo_CheckedChanged);
            // 
            // cbexoesqueleto
            // 
            this.cbexoesqueleto.AutoSize = true;
            this.cbexoesqueleto.Location = new System.Drawing.Point(378, 319);
            this.cbexoesqueleto.Name = "cbexoesqueleto";
            this.cbexoesqueleto.Size = new System.Drawing.Size(114, 21);
            this.cbexoesqueleto.TabIndex = 7;
            this.cbexoesqueleto.Text = "exoesqueleto";
            this.cbexoesqueleto.UseVisualStyleBackColor = true;
            // 
            // nudVelocidad
            // 
            this.nudVelocidad.Location = new System.Drawing.Point(211, 395);
            this.nudVelocidad.Name = "nudVelocidad";
            this.nudVelocidad.Size = new System.Drawing.Size(120, 22);
            this.nudVelocidad.TabIndex = 8;
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(63, 395);
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(120, 22);
            this.nudDistancia.TabIndex = 9;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(63, 362);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(66, 17);
            this.lblDistancia.TabIndex = 10;
            this.lblDistancia.Text = "Distancia";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(208, 362);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(70, 17);
            this.lblVelocidad.TabIndex = 11;
            this.lblVelocidad.Text = "Velocidad";
            // 
            // btCargarAnimal
            // 
            this.btCargarAnimal.Location = new System.Drawing.Point(68, 450);
            this.btCargarAnimal.Name = "btCargarAnimal";
            this.btCargarAnimal.Size = new System.Drawing.Size(115, 67);
            this.btCargarAnimal.TabIndex = 12;
            this.btCargarAnimal.Text = "Cargar animal";
            this.btCargarAnimal.UseVisualStyleBackColor = true;
            this.btCargarAnimal.Click += new System.EventHandler(this.btCargarAnimal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.comprarToolStripMenuItem.Text = "Comprar";
            this.comprarToolStripMenuItem.Click += new System.EventHandler(this.comprarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 529);
            this.Controls.Add(this.btCargarAnimal);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.nudDistancia);
            this.Controls.Add(this.nudVelocidad);
            this.Controls.Add(this.cbexoesqueleto);
            this.Controls.Add(this.cbcuadrupedo);
            this.Controls.Add(this.cbbipedo);
            this.Controls.Add(this.cmbAlimentacion);
            this.Controls.Add(this.nudExistencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHabitat);
            this.Controls.Add(this.txtNombreAnimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreAnimal;
        private System.Windows.Forms.ComboBox cmbHabitat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudExistencia;
        private System.Windows.Forms.ComboBox cmbAlimentacion;
        private System.Windows.Forms.CheckBox cbbipedo;
        private System.Windows.Forms.CheckBox cbcuadrupedo;
        private System.Windows.Forms.CheckBox cbexoesqueleto;
        private System.Windows.Forms.NumericUpDown nudVelocidad;
        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Button btCargarAnimal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
    }
}


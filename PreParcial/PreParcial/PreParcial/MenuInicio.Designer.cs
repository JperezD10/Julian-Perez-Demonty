﻿namespace PreParcial
{
    partial class MenuInicio
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
            this.btEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEmpleado
            // 
            this.btEmpleado.Location = new System.Drawing.Point(98, 40);
            this.btEmpleado.Name = "btEmpleado";
            this.btEmpleado.Size = new System.Drawing.Size(103, 48);
            this.btEmpleado.TabIndex = 0;
            this.btEmpleado.Text = "Empleado";
            this.btEmpleado.UseVisualStyleBackColor = true;
            this.btEmpleado.Click += new System.EventHandler(this.btEmpleado_Click);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 284);
            this.Controls.Add(this.btEmpleado);
            this.Name = "MenuInicio";
            this.Text = "MenuInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEmpleado;
    }
}
namespace semaforo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btencender = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btservicio = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rbmanual = new System.Windows.Forms.RadioButton();
            this.rbautomatico = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::semaforo.Properties.Resources.verde;
            this.pictureBox2.Location = new System.Drawing.Point(171, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btencender
            // 
            this.btencender.Location = new System.Drawing.Point(13, 362);
            this.btencender.Margin = new System.Windows.Forms.Padding(4);
            this.btencender.Name = "btencender";
            this.btencender.Size = new System.Drawing.Size(173, 29);
            this.btencender.TabIndex = 2;
            this.btencender.Text = "encender";
            this.btencender.UseVisualStyleBackColor = true;
            this.btencender.Click += new System.EventHandler(this.btencender_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::semaforo.Properties.Resources.rojo;
            this.pictureBox3.Location = new System.Drawing.Point(434, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btservicio
            // 
            this.btservicio.Location = new System.Drawing.Point(16, 408);
            this.btservicio.Name = "btservicio";
            this.btservicio.Size = new System.Drawing.Size(173, 28);
            this.btservicio.TabIndex = 4;
            this.btservicio.Text = "fuera de servicio";
            this.btservicio.UseVisualStyleBackColor = true;
            this.btservicio.Click += new System.EventHandler(this.btservicio_Click_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // rbmanual
            // 
            this.rbmanual.AutoSize = true;
            this.rbmanual.Location = new System.Drawing.Point(16, 334);
            this.rbmanual.Name = "rbmanual";
            this.rbmanual.Size = new System.Drawing.Size(75, 21);
            this.rbmanual.TabIndex = 5;
            this.rbmanual.TabStop = true;
            this.rbmanual.Text = "manual";
            this.rbmanual.UseVisualStyleBackColor = true;
            this.rbmanual.CheckedChanged += new System.EventHandler(this.rbmanual_CheckedChanged);
            // 
            // rbautomatico
            // 
            this.rbautomatico.AutoSize = true;
            this.rbautomatico.Location = new System.Drawing.Point(401, 334);
            this.rbautomatico.Name = "rbautomatico";
            this.rbautomatico.Size = new System.Drawing.Size(98, 21);
            this.rbautomatico.TabIndex = 6;
            this.rbautomatico.TabStop = true;
            this.rbautomatico.Text = "automatico";
            this.rbautomatico.UseVisualStyleBackColor = true;
            this.rbautomatico.CheckedChanged += new System.EventHandler(this.rbautomatico_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbautomatico);
            this.Controls.Add(this.rbmanual);
            this.Controls.Add(this.btservicio);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btencender);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btencender;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btservicio;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton rbmanual;
        private System.Windows.Forms.RadioButton rbautomatico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
    }
}


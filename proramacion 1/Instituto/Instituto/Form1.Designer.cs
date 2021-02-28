namespace Instituto
{
    partial class frmRegistro
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
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblNumeroLegajo = new System.Windows.Forms.Label();
            this.lblLegajoAlumno = new System.Windows.Forms.Label();
            this.lblEdadAlumno = new System.Windows.Forms.Label();
            this.lblSexoAlumno = new System.Windows.Forms.Label();
            this.mskNombreAlumno = new System.Windows.Forms.MaskedTextBox();
            this.mskEdadAlumno = new System.Windows.Forms.MaskedTextBox();
            this.cmbSexoAlumno = new System.Windows.Forms.ComboBox();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCursoAlumno = new System.Windows.Forms.ComboBox();
            this.lblBeca = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbMediaBeca = new System.Windows.Forms.RadioButton();
            this.rbBecaCompleta = new System.Windows.Forms.RadioButton();
            this.rbBecaRegular = new System.Windows.Forms.RadioButton();
            this.lblValorBeca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(120, 215);
            this.lblNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(85, 24);
            this.lblNombreAlumno.TabIndex = 0;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // lblNumeroLegajo
            // 
            this.lblNumeroLegajo.AutoSize = true;
            this.lblNumeroLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLegajo.Location = new System.Drawing.Point(319, 142);
            this.lblNumeroLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroLegajo.Name = "lblNumeroLegajo";
            this.lblNumeroLegajo.Size = new System.Drawing.Size(66, 24);
            this.lblNumeroLegajo.TabIndex = 1;
            this.lblNumeroLegajo.Text = "label2";
            // 
            // lblLegajoAlumno
            // 
            this.lblLegajoAlumno.AutoSize = true;
            this.lblLegajoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLegajoAlumno.Location = new System.Drawing.Point(120, 142);
            this.lblLegajoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegajoAlumno.Name = "lblLegajoAlumno";
            this.lblLegajoAlumno.Size = new System.Drawing.Size(73, 24);
            this.lblLegajoAlumno.TabIndex = 2;
            this.lblLegajoAlumno.Text = "Legajo";
            // 
            // lblEdadAlumno
            // 
            this.lblEdadAlumno.AutoSize = true;
            this.lblEdadAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEdadAlumno.Location = new System.Drawing.Point(120, 287);
            this.lblEdadAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdadAlumno.Name = "lblEdadAlumno";
            this.lblEdadAlumno.Size = new System.Drawing.Size(59, 24);
            this.lblEdadAlumno.TabIndex = 3;
            this.lblEdadAlumno.Text = "Edad";
            // 
            // lblSexoAlumno
            // 
            this.lblSexoAlumno.AutoSize = true;
            this.lblSexoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSexoAlumno.Location = new System.Drawing.Point(120, 364);
            this.lblSexoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexoAlumno.Name = "lblSexoAlumno";
            this.lblSexoAlumno.Size = new System.Drawing.Size(58, 24);
            this.lblSexoAlumno.TabIndex = 4;
            this.lblSexoAlumno.Text = "Sexo";
            // 
            // mskNombreAlumno
            // 
            this.mskNombreAlumno.AllowPromptAsInput = false;
            this.mskNombreAlumno.BeepOnError = true;
            this.mskNombreAlumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskNombreAlumno.HidePromptOnLeave = true;
            this.mskNombreAlumno.Location = new System.Drawing.Point(289, 214);
            this.mskNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskNombreAlumno.Mask = "??????????????????";
            this.mskNombreAlumno.Name = "mskNombreAlumno";
            this.mskNombreAlumno.PromptChar = ' ';
            this.mskNombreAlumno.RejectInputOnFirstFailure = true;
            this.mskNombreAlumno.ResetOnPrompt = false;
            this.mskNombreAlumno.ResetOnSpace = false;
            this.mskNombreAlumno.Size = new System.Drawing.Size(95, 22);
            this.mskNombreAlumno.TabIndex = 5;
            this.mskNombreAlumno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskNombreAlumno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mskEdadAlumno
            // 
            this.mskEdadAlumno.BeepOnError = true;
            this.mskEdadAlumno.Location = new System.Drawing.Point(337, 286);
            this.mskEdadAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskEdadAlumno.Mask = "00";
            this.mskEdadAlumno.Name = "mskEdadAlumno";
            this.mskEdadAlumno.PromptChar = ' ';
            this.mskEdadAlumno.ResetOnPrompt = false;
            this.mskEdadAlumno.ResetOnSpace = false;
            this.mskEdadAlumno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskEdadAlumno.Size = new System.Drawing.Size(47, 22);
            this.mskEdadAlumno.SkipLiterals = false;
            this.mskEdadAlumno.TabIndex = 6;
            this.mskEdadAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskEdadAlumno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskEdadAlumno.ValidatingType = typeof(int);
            this.mskEdadAlumno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cmbSexoAlumno
            // 
            this.cmbSexoAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoAlumno.FormattingEnabled = true;
            this.cmbSexoAlumno.Location = new System.Drawing.Point(252, 362);
            this.cmbSexoAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSexoAlumno.Name = "cmbSexoAlumno";
            this.cmbSexoAlumno.Size = new System.Drawing.Size(132, 24);
            this.cmbSexoAlumno.TabIndex = 7;
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(695, 491);
            this.btnCompletar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(100, 28);
            this.btnCompletar.TabIndex = 8;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(37, 491);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNro.Location = new System.Drawing.Point(247, 142);
            this.lblNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(44, 24);
            this.lblNro.TabIndex = 10;
            this.lblNro.Text = "Nro";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCurso.Location = new System.Drawing.Point(460, 213);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(65, 24);
            this.lblCurso.TabIndex = 11;
            this.lblCurso.Text = "Curso";
            // 
            // cmbCursoAlumno
            // 
            this.cmbCursoAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoAlumno.FormattingEnabled = true;
            this.cmbCursoAlumno.Location = new System.Drawing.Point(561, 213);
            this.cmbCursoAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCursoAlumno.Name = "cmbCursoAlumno";
            this.cmbCursoAlumno.Size = new System.Drawing.Size(87, 24);
            this.cmbCursoAlumno.TabIndex = 12;
            // 
            // lblBeca
            // 
            this.lblBeca.AutoSize = true;
            this.lblBeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBeca.Location = new System.Drawing.Point(460, 287);
            this.lblBeca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeca.Name = "lblBeca";
            this.lblBeca.Size = new System.Drawing.Size(57, 24);
            this.lblBeca.TabIndex = 13;
            this.lblBeca.Text = "Beca";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(468, 497);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 17);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbMediaBeca
            // 
            this.rbMediaBeca.AutoSize = true;
            this.rbMediaBeca.Location = new System.Drawing.Point(589, 336);
            this.rbMediaBeca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMediaBeca.Name = "rbMediaBeca";
            this.rbMediaBeca.Size = new System.Drawing.Size(57, 21);
            this.rbMediaBeca.TabIndex = 15;
            this.rbMediaBeca.TabStop = true;
            this.rbMediaBeca.Text = "50%";
            this.rbMediaBeca.UseVisualStyleBackColor = true;
            this.rbMediaBeca.CheckedChanged += new System.EventHandler(this.rbMediaBeca_CheckedChanged);
            // 
            // rbBecaCompleta
            // 
            this.rbBecaCompleta.AutoSize = true;
            this.rbBecaCompleta.Location = new System.Drawing.Point(505, 336);
            this.rbBecaCompleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBecaCompleta.Name = "rbBecaCompleta";
            this.rbBecaCompleta.Size = new System.Drawing.Size(57, 21);
            this.rbBecaCompleta.TabIndex = 16;
            this.rbBecaCompleta.TabStop = true;
            this.rbBecaCompleta.Text = "80%";
            this.rbBecaCompleta.UseVisualStyleBackColor = true;
            this.rbBecaCompleta.CheckedChanged += new System.EventHandler(this.rbBecaCompleta_CheckedChanged);
            // 
            // rbBecaRegular
            // 
            this.rbBecaRegular.AutoSize = true;
            this.rbBecaRegular.Location = new System.Drawing.Point(669, 336);
            this.rbBecaRegular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBecaRegular.Name = "rbBecaRegular";
            this.rbBecaRegular.Size = new System.Drawing.Size(49, 21);
            this.rbBecaRegular.TabIndex = 17;
            this.rbBecaRegular.TabStop = true;
            this.rbBecaRegular.Text = "0%";
            this.rbBecaRegular.UseVisualStyleBackColor = true;
            this.rbBecaRegular.CheckedChanged += new System.EventHandler(this.rbBecaRegular_CheckedChanged);
            // 
            // lblValorBeca
            // 
            this.lblValorBeca.AutoSize = true;
            this.lblValorBeca.Location = new System.Drawing.Point(585, 292);
            this.lblValorBeca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorBeca.Name = "lblValorBeca";
            this.lblValorBeca.Size = new System.Drawing.Size(0, 17);
            this.lblValorBeca.TabIndex = 18;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 540);
            this.Controls.Add(this.lblValorBeca);
            this.Controls.Add(this.rbBecaRegular);
            this.Controls.Add(this.rbBecaCompleta);
            this.Controls.Add(this.rbMediaBeca);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBeca);
            this.Controls.Add(this.cmbCursoAlumno);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.cmbSexoAlumno);
            this.Controls.Add(this.mskEdadAlumno);
            this.Controls.Add(this.mskNombreAlumno);
            this.Controls.Add(this.lblSexoAlumno);
            this.Controls.Add(this.lblEdadAlumno);
            this.Controls.Add(this.lblLegajoAlumno);
            this.Controls.Add(this.lblNumeroLegajo);
            this.Controls.Add(this.lblNombreAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label lblNumeroLegajo;
        private System.Windows.Forms.Label lblLegajoAlumno;
        private System.Windows.Forms.Label lblEdadAlumno;
        private System.Windows.Forms.Label lblSexoAlumno;
        private System.Windows.Forms.MaskedTextBox mskNombreAlumno;
        private System.Windows.Forms.MaskedTextBox mskEdadAlumno;
        private System.Windows.Forms.ComboBox cmbSexoAlumno;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbCursoAlumno;
        private System.Windows.Forms.Label lblBeca;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbMediaBeca;
        private System.Windows.Forms.RadioButton rbBecaCompleta;
        private System.Windows.Forms.RadioButton rbBecaRegular;
        private System.Windows.Forms.Label lblValorBeca;
    }
}


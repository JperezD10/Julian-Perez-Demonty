namespace Clase_2
{
    partial class GestionarAlumnos
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.controlNumericoEdad = new Clase_2.ControlNumerico();
            this.controlUsuarioApellido = new Clase_2.ControlUsuario();
            this.controlUsuarioNombre = new Clase_2.ControlUsuario();
            this.btVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDALumno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(33, 300);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 28);
            this.btAgregar.TabIndex = 5;
            this.btAgregar.Text = "Add";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(169, 300);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 28);
            this.btEliminar.TabIndex = 6;
            this.btEliminar.Text = "Delete";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(300, 300);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 28);
            this.btModificar.TabIndex = 7;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(596, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 272);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Promedio de edad:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(349, 407);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(13, 17);
            this.lblPromedio.TabIndex = 11;
            this.lblPromedio.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Edad maxima:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(701, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Edad minima:";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(801, 407);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(13, 17);
            this.lblMinimo.TabIndex = 13;
            this.lblMinimo.Text = "-";
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Location = new System.Drawing.Point(572, 406);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(13, 17);
            this.lblMaxima.TabIndex = 13;
            this.lblMaxima.Text = "-";
            // 
            // controlNumericoEdad
            // 
            this.controlNumericoEdad.Etiqueta = "Edad";
            this.controlNumericoEdad.Location = new System.Drawing.Point(11, 175);
            this.controlNumericoEdad.Margin = new System.Windows.Forms.Padding(5);
            this.controlNumericoEdad.Name = "controlNumericoEdad";
            this.controlNumericoEdad.Size = new System.Drawing.Size(304, 48);
            this.controlNumericoEdad.TabIndex = 17;
            this.controlNumericoEdad.Texto = "";
            // 
            // controlUsuarioApellido
            // 
            this.controlUsuarioApellido.Etiqueta = "Apellido";
            this.controlUsuarioApellido.Location = new System.Drawing.Point(11, 130);
            this.controlUsuarioApellido.Margin = new System.Windows.Forms.Padding(5);
            this.controlUsuarioApellido.Name = "controlUsuarioApellido";
            this.controlUsuarioApellido.Size = new System.Drawing.Size(325, 50);
            this.controlUsuarioApellido.TabIndex = 16;
            this.controlUsuarioApellido.Texto = "";
            // 
            // controlUsuarioNombre
            // 
            this.controlUsuarioNombre.Etiqueta = "Nombre";
            this.controlUsuarioNombre.Location = new System.Drawing.Point(11, 85);
            this.controlUsuarioNombre.Margin = new System.Windows.Forms.Padding(5);
            this.controlUsuarioNombre.Name = "controlUsuarioNombre";
            this.controlUsuarioNombre.Size = new System.Drawing.Size(325, 50);
            this.controlUsuarioNombre.TabIndex = 15;
            this.controlUsuarioNombre.Texto = "";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(33, 483);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(82, 28);
            this.btVolver.TabIndex = 18;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID ALumno";
            // 
            // txtIDALumno
            // 
            this.txtIDALumno.Location = new System.Drawing.Point(169, 45);
            this.txtIDALumno.Name = "txtIDALumno";
            this.txtIDALumno.ReadOnly = true;
            this.txtIDALumno.Size = new System.Drawing.Size(100, 22);
            this.txtIDALumno.TabIndex = 20;
            // 
            // GestionarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 523);
            this.Controls.Add(this.txtIDALumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.controlNumericoEdad);
            this.Controls.Add(this.controlUsuarioApellido);
            this.Controls.Add(this.controlUsuarioNombre);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionarAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaxima;
        private ControlUsuario controlUsuarioNombre;
        private ControlUsuario controlUsuarioApellido;
        private ControlNumerico controlNumericoEdad;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDALumno;
    }
}


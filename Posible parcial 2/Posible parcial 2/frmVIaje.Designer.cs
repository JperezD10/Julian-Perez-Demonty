namespace Posible_parcial_2
{
    partial class frmVIaje
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
            this.GrillaPasajeros = new System.Windows.Forms.DataGridView();
            this.GrillaAutos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtPasajero = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtKilometro = new System.Windows.Forms.TextBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.brAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantViajes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaPasajeros
            // 
            this.GrillaPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPasajeros.Location = new System.Drawing.Point(545, 12);
            this.GrillaPasajeros.Name = "GrillaPasajeros";
            this.GrillaPasajeros.RowTemplate.Height = 24;
            this.GrillaPasajeros.Size = new System.Drawing.Size(630, 160);
            this.GrillaPasajeros.TabIndex = 0;
            this.GrillaPasajeros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaPasajeros_CellClick);
            // 
            // GrillaAutos
            // 
            this.GrillaAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaAutos.Location = new System.Drawing.Point(545, 294);
            this.GrillaAutos.Name = "GrillaAutos";
            this.GrillaAutos.RowTemplate.Height = 24;
            this.GrillaAutos.Size = new System.Drawing.Size(630, 160);
            this.GrillaAutos.TabIndex = 0;
            this.GrillaAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaAutos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Pasajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kilometro";
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(139, 82);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.ReadOnly = true;
            this.txtVehiculo.Size = new System.Drawing.Size(100, 22);
            this.txtVehiculo.TabIndex = 3;
            // 
            // txtPasajero
            // 
            this.txtPasajero.Location = new System.Drawing.Point(139, 154);
            this.txtPasajero.Name = "txtPasajero";
            this.txtPasajero.ReadOnly = true;
            this.txtPasajero.Size = new System.Drawing.Size(100, 22);
            this.txtPasajero.TabIndex = 4;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(139, 233);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 22);
            this.txtDestino.TabIndex = 5;
            // 
            // txtKilometro
            // 
            this.txtKilometro.Location = new System.Drawing.Point(139, 321);
            this.txtKilometro.Name = "txtKilometro";
            this.txtKilometro.Size = new System.Drawing.Size(100, 22);
            this.txtKilometro.TabIndex = 6;
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(16, 595);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 8;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // brAgregar
            // 
            this.brAgregar.Location = new System.Drawing.Point(124, 482);
            this.brAgregar.Name = "brAgregar";
            this.brAgregar.Size = new System.Drawing.Size(115, 43);
            this.brAgregar.TabIndex = 9;
            this.brAgregar.Text = "Agregar Viaje";
            this.brAgregar.UseVisualStyleBackColor = true;
            this.brAgregar.Click += new System.EventHandler(this.brAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad de viajes:";
            // 
            // lblCantViajes
            // 
            this.lblCantViajes.AutoSize = true;
            this.lblCantViajes.Location = new System.Drawing.Point(426, 537);
            this.lblCantViajes.Name = "lblCantViajes";
            this.lblCantViajes.Size = new System.Drawing.Size(13, 17);
            this.lblCantViajes.TabIndex = 11;
            this.lblCantViajes.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 398);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // frmVIaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 630);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantViajes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brAgregar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.txtKilometro);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtPasajero);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrillaAutos);
            this.Controls.Add(this.GrillaPasajeros);
            this.Name = "frmVIaje";
            this.Text = "frmVIaje";
            this.Load += new System.EventHandler(this.frmVIaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaPasajeros;
        private System.Windows.Forms.DataGridView GrillaAutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtPasajero;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtKilometro;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button brAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
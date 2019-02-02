namespace WindowsFormsApp1
{
    partial class RegistroHoras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoras = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarHoras = new System.Windows.Forms.Button();
            this.btnBuscarHoras = new System.Windows.Forms.Button();
            this.btnGuardarHoras = new System.Windows.Forms.Button();
            this.btnBorrarHoras = new System.Windows.Forms.Button();
            this.dtFechaHoras = new System.Windows.Forms.DateTimePicker();
            this.cbxRutHoras = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHorasRealizadas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBuscHora = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHorasRealizadas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxRutHoras);
            this.groupBox1.Controls.Add(this.dtFechaHoras);
            this.groupBox1.Controls.Add(this.btnGuardarHoras);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESO HORAS EXTRAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBuscarHoras);
            this.groupBox2.Controls.Add(this.cbxBuscHora);
            this.groupBox2.Location = new System.Drawing.Point(629, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR HORAS EXTRAS";
            // 
            // dgvHoras
            // 
            this.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rut,
            this.HorasExtas,
            this.Fecha});
            this.dgvHoras.Location = new System.Drawing.Point(146, 428);
            this.dgvHoras.Name = "dgvHoras";
            this.dgvHoras.RowTemplate.Height = 24;
            this.dgvHoras.Size = new System.Drawing.Size(946, 236);
            this.dgvHoras.TabIndex = 2;
            this.dgvHoras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoras_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CRUD HORAS EXTRAS";
            // 
            // btnActualizarHoras
            // 
            this.btnActualizarHoras.Location = new System.Drawing.Point(941, 384);
            this.btnActualizarHoras.Name = "btnActualizarHoras";
            this.btnActualizarHoras.Size = new System.Drawing.Size(93, 23);
            this.btnActualizarHoras.TabIndex = 4;
            this.btnActualizarHoras.Text = "Actualizar";
            this.btnActualizarHoras.UseVisualStyleBackColor = true;
            this.btnActualizarHoras.Click += new System.EventHandler(this.btnActualizarHoras_Click);
            // 
            // btnBuscarHoras
            // 
            this.btnBuscarHoras.Location = new System.Drawing.Point(499, 240);
            this.btnBuscarHoras.Name = "btnBuscarHoras";
            this.btnBuscarHoras.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarHoras.TabIndex = 5;
            this.btnBuscarHoras.Text = "Buscar";
            this.btnBuscarHoras.UseVisualStyleBackColor = true;
            this.btnBuscarHoras.Click += new System.EventHandler(this.btnBuscarHoras_Click);
            // 
            // btnGuardarHoras
            // 
            this.btnGuardarHoras.Location = new System.Drawing.Point(485, 240);
            this.btnGuardarHoras.Name = "btnGuardarHoras";
            this.btnGuardarHoras.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarHoras.TabIndex = 6;
            this.btnGuardarHoras.Text = "Guardar";
            this.btnGuardarHoras.UseVisualStyleBackColor = true;
            this.btnGuardarHoras.Click += new System.EventHandler(this.btnGuardarHoras_Click);
            // 
            // btnBorrarHoras
            // 
            this.btnBorrarHoras.Location = new System.Drawing.Point(1040, 384);
            this.btnBorrarHoras.Name = "btnBorrarHoras";
            this.btnBorrarHoras.Size = new System.Drawing.Size(88, 23);
            this.btnBorrarHoras.TabIndex = 6;
            this.btnBorrarHoras.Text = "Borrar";
            this.btnBorrarHoras.UseVisualStyleBackColor = true;
            this.btnBorrarHoras.Click += new System.EventHandler(this.btnBorrarHoras_Click);
            // 
            // dtFechaHoras
            // 
            this.dtFechaHoras.Location = new System.Drawing.Point(211, 98);
            this.dtFechaHoras.Name = "dtFechaHoras";
            this.dtFechaHoras.Size = new System.Drawing.Size(308, 22);
            this.dtFechaHoras.TabIndex = 7;
            // 
            // cbxRutHoras
            // 
            this.cbxRutHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRutHoras.FormattingEnabled = true;
            this.cbxRutHoras.Location = new System.Drawing.Point(211, 56);
            this.cbxRutHoras.Name = "cbxRutHoras";
            this.cbxRutHoras.Size = new System.Drawing.Size(308, 24);
            this.cbxRutHoras.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rut";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(70, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 17);
            this.label.TabIndex = 10;
            this.label.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horas Realizadas";
            // 
            // txtHorasRealizadas
            // 
            this.txtHorasRealizadas.Location = new System.Drawing.Point(211, 136);
            this.txtHorasRealizadas.Name = "txtHorasRealizadas";
            this.txtHorasRealizadas.Size = new System.Drawing.Size(308, 22);
            this.txtHorasRealizadas.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rut";
            // 
            // cbxBuscHora
            // 
            this.cbxBuscHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscHora.FormattingEnabled = true;
            this.cbxBuscHora.Location = new System.Drawing.Point(224, 56);
            this.cbxBuscHora.Name = "cbxBuscHora";
            this.cbxBuscHora.Size = new System.Drawing.Size(308, 24);
            this.cbxBuscHora.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            // 
            // HorasExtas
            // 
            this.HorasExtas.HeaderText = "Horas Extras";
            this.HorasExtas.Name = "HorasExtas";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // RegistroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 698);
            this.Controls.Add(this.btnBorrarHoras);
            this.Controls.Add(this.btnActualizarHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroHoras";
            this.Text = "Registro Horas";
            this.Load += new System.EventHandler(this.RegistroHoras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoras;
        private System.Windows.Forms.TextBox txtHorasRealizadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRutHoras;
        private System.Windows.Forms.DateTimePicker dtFechaHoras;
        private System.Windows.Forms.Button btnGuardarHoras;
        private System.Windows.Forms.Button btnBuscarHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarHoras;
        private System.Windows.Forms.Button btnBorrarHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBuscHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}
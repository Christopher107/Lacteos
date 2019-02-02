namespace WindowsFormsApp1
{
    partial class Home
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
            this.btnIngresoPersonal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngresoUsuarios = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIngresoHoras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIngresoPersonal);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD PERSONAL";
            // 
            // btnIngresoPersonal
            // 
            this.btnIngresoPersonal.Location = new System.Drawing.Point(83, 164);
            this.btnIngresoPersonal.Name = "btnIngresoPersonal";
            this.btnIngresoPersonal.Size = new System.Drawing.Size(219, 286);
            this.btnIngresoPersonal.TabIndex = 0;
            this.btnIngresoPersonal.Text = "INGRESAR AL CRUD";
            this.btnIngresoPersonal.UseVisualStyleBackColor = true;
            this.btnIngresoPersonal.Click += new System.EventHandler(this.btnIngresoPersonal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIngresoUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(404, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 581);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRUD USUARIOS";
            // 
            // btnIngresoUsuarios
            // 
            this.btnIngresoUsuarios.Location = new System.Drawing.Point(90, 164);
            this.btnIngresoUsuarios.Name = "btnIngresoUsuarios";
            this.btnIngresoUsuarios.Size = new System.Drawing.Size(219, 286);
            this.btnIngresoUsuarios.TabIndex = 1;
            this.btnIngresoUsuarios.Text = "INGRESAR AL CRUD";
            this.btnIngresoUsuarios.UseVisualStyleBackColor = true;
            this.btnIngresoUsuarios.Click += new System.EventHandler(this.btnIngresoUsuarios_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIngresoHoras);
            this.groupBox3.Location = new System.Drawing.Point(805, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 581);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CRUD HORAS";
            // 
            // btnIngresoHoras
            // 
            this.btnIngresoHoras.Location = new System.Drawing.Point(89, 164);
            this.btnIngresoHoras.Name = "btnIngresoHoras";
            this.btnIngresoHoras.Size = new System.Drawing.Size(219, 286);
            this.btnIngresoHoras.TabIndex = 2;
            this.btnIngresoHoras.Text = "INGRESAR AL CRUD";
            this.btnIngresoHoras.UseVisualStyleBackColor = true;
            this.btnIngresoHoras.Click += new System.EventHandler(this.btnIngresoHoras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOME";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresoPersonal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIngresoUsuarios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIngresoHoras;
        private System.Windows.Forms.Label label1;
    }
}
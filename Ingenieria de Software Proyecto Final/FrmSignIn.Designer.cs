namespace Ingenieria_de_Software_Proyecto_Final
{
    partial class FrmSignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.TxtApodo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtAcreditaciones = new System.Windows.Forms.TextBox();
            this.CBFecha = new System.Windows.Forms.DateTimePicker();
            this.CBPais = new System.Windows.Forms.ComboBox();
            this.CBGym = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CBCoJ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Datos Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id_pais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id_gym";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Acreditaciones";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(139, 288);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // TxtApodo
            // 
            this.TxtApodo.Location = new System.Drawing.Point(162, 89);
            this.TxtApodo.Name = "TxtApodo";
            this.TxtApodo.Size = new System.Drawing.Size(100, 20);
            this.TxtApodo.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(162, 137);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 10;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(162, 158);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 11;
            // 
            // TxtAcreditaciones
            // 
            this.TxtAcreditaciones.Location = new System.Drawing.Point(162, 263);
            this.TxtAcreditaciones.Name = "TxtAcreditaciones";
            this.TxtAcreditaciones.Size = new System.Drawing.Size(100, 20);
            this.TxtAcreditaciones.TabIndex = 12;
            // 
            // CBFecha
            // 
            this.CBFecha.CustomFormat = "yyyy.MM.dd";
            this.CBFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CBFecha.Location = new System.Drawing.Point(162, 237);
            this.CBFecha.Name = "CBFecha";
            this.CBFecha.Size = new System.Drawing.Size(200, 20);
            this.CBFecha.TabIndex = 13;
            // 
            // CBPais
            // 
            this.CBPais.FormattingEnabled = true;
            this.CBPais.Location = new System.Drawing.Point(162, 181);
            this.CBPais.Name = "CBPais";
            this.CBPais.Size = new System.Drawing.Size(121, 21);
            this.CBPais.TabIndex = 14;
            this.CBPais.SelectedIndexChanged += new System.EventHandler(this.CBPais_SelectedIndexChanged);
            // 
            // CBGym
            // 
            this.CBGym.FormattingEnabled = true;
            this.CBGym.Location = new System.Drawing.Point(162, 208);
            this.CBGym.Name = "CBGym";
            this.CBGym.Size = new System.Drawing.Size(121, 21);
            this.CBGym.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Contraseña";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(162, 114);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(100, 20);
            this.TxtContraseña.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Competidor o JefeBox";
            // 
            // CBCoJ
            // 
            this.CBCoJ.FormattingEnabled = true;
            this.CBCoJ.Location = new System.Drawing.Point(162, 55);
            this.CBCoJ.Name = "CBCoJ";
            this.CBCoJ.Size = new System.Drawing.Size(121, 21);
            this.CBCoJ.TabIndex = 19;
            this.CBCoJ.SelectedIndexChanged += new System.EventHandler(this.CBCoJ_SelectedIndexChanged);
            // 
            // FrmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 348);
            this.Controls.Add(this.CBCoJ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBGym);
            this.Controls.Add(this.CBPais);
            this.Controls.Add(this.CBFecha);
            this.Controls.Add(this.TxtAcreditaciones);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApodo);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSignIn";
            this.Text = "FrmSignIn";
            this.Load += new System.EventHandler(this.FrmSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.TextBox TxtApodo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtAcreditaciones;
        private System.Windows.Forms.DateTimePicker CBFecha;
        private System.Windows.Forms.ComboBox CBPais;
        private System.Windows.Forms.ComboBox CBGym;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBCoJ;
    }
}
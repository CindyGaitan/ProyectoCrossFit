namespace Ingenieria_de_Software_Proyecto_Final
{
    partial class FrmRegistro
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
            this.TxtNoBoleta = new System.Windows.Forms.TextBox();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.BtnRegistrarPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Boleta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serie";
            // 
            // TxtNoBoleta
            // 
            this.TxtNoBoleta.Location = new System.Drawing.Point(185, 62);
            this.TxtNoBoleta.Name = "TxtNoBoleta";
            this.TxtNoBoleta.Size = new System.Drawing.Size(100, 20);
            this.TxtNoBoleta.TabIndex = 3;
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(185, 93);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(100, 20);
            this.TxtSerie.TabIndex = 4;
            // 
            // BtnRegistrarPago
            // 
            this.BtnRegistrarPago.Location = new System.Drawing.Point(185, 154);
            this.BtnRegistrarPago.Name = "BtnRegistrarPago";
            this.BtnRegistrarPago.Size = new System.Drawing.Size(100, 22);
            this.BtnRegistrarPago.TabIndex = 5;
            this.BtnRegistrarPago.Text = "Registrar Pago";
            this.BtnRegistrarPago.UseVisualStyleBackColor = true;
            this.BtnRegistrarPago.Click += new System.EventHandler(this.BtnRegistrarPago_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 330);
            this.Controls.Add(this.BtnRegistrarPago);
            this.Controls.Add(this.TxtSerie);
            this.Controls.Add(this.TxtNoBoleta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNoBoleta;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Button BtnRegistrarPago;
    }
}
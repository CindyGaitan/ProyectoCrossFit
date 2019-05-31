namespace Ingenieria_de_Software_Proyecto_Final
{
    partial class Juezcs
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.ChbEstado = new System.Windows.Forms.CheckBox();
            this.DtgVJuez = new System.Windows.Forms.DataGridView();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.CbxAcreditacion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVJuez)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(279, 283);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(110, 23);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(155, 283);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(118, 23);
            this.BtnModificar.TabIndex = 22;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(25, 283);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(124, 23);
            this.BtnIngresar.TabIndex = 21;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // ChbEstado
            // 
            this.ChbEstado.AutoSize = true;
            this.ChbEstado.Location = new System.Drawing.Point(25, 246);
            this.ChbEstado.Name = "ChbEstado";
            this.ChbEstado.Size = new System.Drawing.Size(56, 17);
            this.ChbEstado.TabIndex = 20;
            this.ChbEstado.Text = "Activo";
            this.ChbEstado.UseVisualStyleBackColor = true;
            // 
            // DtgVJuez
            // 
            this.DtgVJuez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgVJuez.Location = new System.Drawing.Point(238, 103);
            this.DtgVJuez.Name = "DtgVJuez";
            this.DtgVJuez.Size = new System.Drawing.Size(450, 123);
            this.DtgVJuez.TabIndex = 19;
            this.DtgVJuez.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgVJuez_CellDoubleClick);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(22, 151);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(198, 20);
            this.TxtApellidos.TabIndex = 17;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(22, 103);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(198, 20);
            this.TxtNombres.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 135);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 13);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Apellidos";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 87);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Nombres";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(311, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 24);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Juez";
            // 
            // CbxAcreditacion
            // 
            this.CbxAcreditacion.AutoSize = true;
            this.CbxAcreditacion.Location = new System.Drawing.Point(25, 209);
            this.CbxAcreditacion.Name = "CbxAcreditacion";
            this.CbxAcreditacion.Size = new System.Drawing.Size(77, 17);
            this.CbxAcreditacion.TabIndex = 24;
            this.CbxAcreditacion.Text = "Acreditado";
            this.CbxAcreditacion.UseVisualStyleBackColor = true;
            // 
            // Juezcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 342);
            this.Controls.Add(this.CbxAcreditacion);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.ChbEstado);
            this.Controls.Add(this.DtgVJuez);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Juezcs";
            this.Text = "Juez";
            this.Load += new System.EventHandler(this.Juezcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgVJuez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnEliminar;
        internal System.Windows.Forms.Button BtnModificar;
        internal System.Windows.Forms.Button BtnIngresar;
        internal System.Windows.Forms.CheckBox ChbEstado;
        internal System.Windows.Forms.DataGridView DtgVJuez;
        internal System.Windows.Forms.TextBox TxtApellidos;
        internal System.Windows.Forms.TextBox TxtNombres;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox CbxAcreditacion;
    }
}
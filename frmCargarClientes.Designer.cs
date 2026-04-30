namespace PryLBArchivosLoza
{
    partial class frmCargarClientes
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblDeuda = new System.Windows.Forms.Label();
            this.LblNombreApellido = new System.Windows.Forms.Label();
            this.LblLimiteCredito = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDeuda = new System.Windows.Forms.TextBox();
            this.TxtNombreApellido = new System.Windows.Forms.TextBox();
            this.TxtLimiteCredito = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(96, 53);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // LblDeuda
            // 
            this.LblDeuda.AutoSize = true;
            this.LblDeuda.Location = new System.Drawing.Point(96, 143);
            this.LblDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDeuda.Name = "LblDeuda";
            this.LblDeuda.Size = new System.Drawing.Size(45, 15);
            this.LblDeuda.TabIndex = 1;
            this.LblDeuda.Text = "Deuda:";
            // 
            // LblNombreApellido
            // 
            this.LblNombreApellido.AutoSize = true;
            this.LblNombreApellido.Location = new System.Drawing.Point(379, 52);
            this.LblNombreApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreApellido.Name = "LblNombreApellido";
            this.LblNombreApellido.Size = new System.Drawing.Size(115, 15);
            this.LblNombreApellido.TabIndex = 2;
            this.LblNombreApellido.Text = "Nombre y Apellido:";
            // 
            // LblLimiteCredito
            // 
            this.LblLimiteCredito.AutoSize = true;
            this.LblLimiteCredito.Location = new System.Drawing.Point(379, 143);
            this.LblLimiteCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLimiteCredito.Name = "LblLimiteCredito";
            this.LblLimiteCredito.Size = new System.Drawing.Size(104, 15);
            this.LblLimiteCredito.TabIndex = 3;
            this.LblLimiteCredito.Text = "Limite de credito:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(163, 45);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(116, 23);
            this.TxtCodigo.TabIndex = 4;
            // 
            // TxtDeuda
            // 
            this.TxtDeuda.Location = new System.Drawing.Point(163, 135);
            this.TxtDeuda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDeuda.Name = "TxtDeuda";
            this.TxtDeuda.Size = new System.Drawing.Size(116, 23);
            this.TxtDeuda.TabIndex = 5;
            // 
            // TxtNombreApellido
            // 
            this.TxtNombreApellido.Location = new System.Drawing.Point(497, 44);
            this.TxtNombreApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombreApellido.Name = "TxtNombreApellido";
            this.TxtNombreApellido.Size = new System.Drawing.Size(107, 23);
            this.TxtNombreApellido.TabIndex = 6;
            // 
            // TxtLimiteCredito
            // 
            this.TxtLimiteCredito.Location = new System.Drawing.Point(488, 135);
            this.TxtLimiteCredito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtLimiteCredito.Name = "TxtLimiteCredito";
            this.TxtLimiteCredito.Size = new System.Drawing.Size(116, 23);
            this.TxtLimiteCredito.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGrabar);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(541, 196);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(416, 149);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(115, 36);
            this.BtnGrabar.TabIndex = 0;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            // 
            // frmCargarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 281);
            this.Controls.Add(this.TxtLimiteCredito);
            this.Controls.Add(this.TxtNombreApellido);
            this.Controls.Add(this.TxtDeuda);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblLimiteCredito);
            this.Controls.Add(this.LblNombreApellido);
            this.Controls.Add(this.LblDeuda);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCargarClientes";
            this.Text = "frmCargarClientes";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblDeuda;
        private System.Windows.Forms.Label LblNombreApellido;
        private System.Windows.Forms.Label LblLimiteCredito;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDeuda;
        private System.Windows.Forms.TextBox TxtNombreApellido;
        private System.Windows.Forms.TextBox TxtLimiteCredito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGrabar;
    }
}
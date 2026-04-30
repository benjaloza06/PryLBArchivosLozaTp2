namespace PryLBArchivosLoza
{
    partial class frmListadoClientes
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
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.LblTotalDeuda = new System.Windows.Forms.Label();
            this.LblCantidadClientes = new System.Windows.Forms.Label();
            this.LblPromedioDeuda = new System.Windows.Forms.Label();
            this.LblDeuda = new System.Windows.Forms.Label();
            this.LblClientes = new System.Windows.Forms.Label();
            this.LblPromedio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvClientes.Location = new System.Drawing.Point(162, 31);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(494, 307);
            this.DgvClientes.TabIndex = 0;
            // 
            // LblTotalDeuda
            // 
            this.LblTotalDeuda.AutoSize = true;
            this.LblTotalDeuda.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDeuda.Location = new System.Drawing.Point(466, 363);
            this.LblTotalDeuda.Name = "LblTotalDeuda";
            this.LblTotalDeuda.Size = new System.Drawing.Size(90, 15);
            this.LblTotalDeuda.TabIndex = 1;
            this.LblTotalDeuda.Text = "Total de deuda:";
            // 
            // LblCantidadClientes
            // 
            this.LblCantidadClientes.AutoSize = true;
            this.LblCantidadClientes.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadClientes.Location = new System.Drawing.Point(459, 394);
            this.LblCantidadClientes.Name = "LblCantidadClientes";
            this.LblCantidadClientes.Size = new System.Drawing.Size(120, 15);
            this.LblCantidadClientes.TabIndex = 2;
            this.LblCantidadClientes.Text = "Cantidad de clientes:";
            // 
            // LblPromedioDeuda
            // 
            this.LblPromedioDeuda.AutoSize = true;
            this.LblPromedioDeuda.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPromedioDeuda.Location = new System.Drawing.Point(466, 429);
            this.LblPromedioDeuda.Name = "LblPromedioDeuda";
            this.LblPromedioDeuda.Size = new System.Drawing.Size(116, 15);
            this.LblPromedioDeuda.TabIndex = 3;
            this.LblPromedioDeuda.Text = "Promedio de deuda:";
            // 
            // LblDeuda
            // 
            this.LblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDeuda.Location = new System.Drawing.Point(592, 355);
            this.LblDeuda.Name = "LblDeuda";
            this.LblDeuda.Size = new System.Drawing.Size(64, 23);
            this.LblDeuda.TabIndex = 4;
            // 
            // LblClientes
            // 
            this.LblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblClientes.Location = new System.Drawing.Point(457, 374);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(64, 23);
            this.LblClientes.TabIndex = 5;
            // 
            // LblPromedio
            // 
            this.LblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPromedio.Location = new System.Drawing.Point(585, 421);
            this.LblPromedio.Name = "LblPromedio";
            this.LblPromedio.Size = new System.Drawing.Size(71, 23);
            this.LblPromedio.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReporte);
            this.groupBox1.Controls.Add(this.LblClientes);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(135, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 446);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(27, 409);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(90, 23);
            this.BtnReporte.TabIndex = 6;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deuda";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Limite de Credito";
            this.Column4.Name = "Column4";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.LblPromedio);
            this.Controls.Add(this.LblDeuda);
            this.Controls.Add(this.LblPromedioDeuda);
            this.Controls.Add(this.LblCantidadClientes);
            this.Controls.Add(this.LblTotalDeuda);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListadoClientes";
            this.Text = "frmListadoClientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label LblTotalDeuda;
        private System.Windows.Forms.Label LblCantidadClientes;
        private System.Windows.Forms.Label LblPromedioDeuda;
        private System.Windows.Forms.Label LblDeuda;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.Label LblPromedio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
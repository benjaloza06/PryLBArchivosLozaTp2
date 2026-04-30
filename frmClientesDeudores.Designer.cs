namespace PryLBArchivosLoza
{
    partial class frmClientesDeudores
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
            this.LblPromedio = new System.Windows.Forms.Label();
            this.LblDeuda = new System.Windows.Forms.Label();
            this.LblPromedioDeuda = new System.Windows.Forms.Label();
            this.LblCantidadClientes = new System.Windows.Forms.Label();
            this.LblTotalDeuda = new System.Windows.Forms.Label();
            this.DgvClientesDeudores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientesDeudores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPromedio
            // 
            this.LblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPromedio.Location = new System.Drawing.Point(577, 411);
            this.LblPromedio.Name = "LblPromedio";
            this.LblPromedio.Size = new System.Drawing.Size(71, 23);
            this.LblPromedio.TabIndex = 13;
            // 
            // LblDeuda
            // 
            this.LblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDeuda.Location = new System.Drawing.Point(584, 345);
            this.LblDeuda.Name = "LblDeuda";
            this.LblDeuda.Size = new System.Drawing.Size(64, 23);
            this.LblDeuda.TabIndex = 12;
            // 
            // LblPromedioDeuda
            // 
            this.LblPromedioDeuda.AutoSize = true;
            this.LblPromedioDeuda.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPromedioDeuda.Location = new System.Drawing.Point(458, 419);
            this.LblPromedioDeuda.Name = "LblPromedioDeuda";
            this.LblPromedioDeuda.Size = new System.Drawing.Size(116, 15);
            this.LblPromedioDeuda.TabIndex = 11;
            this.LblPromedioDeuda.Text = "Promedio de deuda:";
            // 
            // LblCantidadClientes
            // 
            this.LblCantidadClientes.AutoSize = true;
            this.LblCantidadClientes.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadClientes.Location = new System.Drawing.Point(451, 384);
            this.LblCantidadClientes.Name = "LblCantidadClientes";
            this.LblCantidadClientes.Size = new System.Drawing.Size(120, 15);
            this.LblCantidadClientes.TabIndex = 10;
            this.LblCantidadClientes.Text = "Cantidad de clientes:";
            // 
            // LblTotalDeuda
            // 
            this.LblTotalDeuda.AutoSize = true;
            this.LblTotalDeuda.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDeuda.Location = new System.Drawing.Point(458, 353);
            this.LblTotalDeuda.Name = "LblTotalDeuda";
            this.LblTotalDeuda.Size = new System.Drawing.Size(90, 15);
            this.LblTotalDeuda.TabIndex = 9;
            this.LblTotalDeuda.Text = "Total de deuda:";
            // 
            // DgvClientesDeudores
            // 
            this.DgvClientesDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientesDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvClientesDeudores.Location = new System.Drawing.Point(154, 21);
            this.DgvClientesDeudores.Name = "DgvClientesDeudores";
            this.DgvClientesDeudores.Size = new System.Drawing.Size(494, 307);
            this.DgvClientesDeudores.TabIndex = 8;
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
            this.Column3.HeaderText = "Limite de credito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblClientes);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(127, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 467);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblClientes
            // 
            this.LblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblClientes.Location = new System.Drawing.Point(457, 374);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(64, 23);
            this.LblClientes.TabIndex = 5;
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 527);
            this.Controls.Add(this.LblPromedio);
            this.Controls.Add(this.LblDeuda);
            this.Controls.Add(this.LblPromedioDeuda);
            this.Controls.Add(this.LblCantidadClientes);
            this.Controls.Add(this.LblTotalDeuda);
            this.Controls.Add(this.DgvClientesDeudores);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClientesDeudores";
            this.Text = "frmClientesDeudores";
            this.Load += new System.EventHandler(this.frmClientesDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientesDeudores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPromedio;
        private System.Windows.Forms.Label LblDeuda;
        private System.Windows.Forms.Label LblPromedioDeuda;
        private System.Windows.Forms.Label LblCantidadClientes;
        private System.Windows.Forms.Label LblTotalDeuda;
        private System.Windows.Forms.DataGridView DgvClientesDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblClientes;
    }
}
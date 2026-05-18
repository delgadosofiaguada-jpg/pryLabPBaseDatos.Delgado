namespace pryLabPBaseDatos.Delgado
{
    partial class frmClientesDeudoresBD
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
            this.gbClientesDeudores = new System.Windows.Forms.GroupBox();
            this.cmdListarDeudores = new System.Windows.Forms.Button();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblCantC = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvConsultaDatos = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbClientesDeudores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientesDeudores
            // 
            this.gbClientesDeudores.Controls.Add(this.cmdListarDeudores);
            this.gbClientesDeudores.Controls.Add(this.lblProm);
            this.gbClientesDeudores.Controls.Add(this.lblCantC);
            this.gbClientesDeudores.Controls.Add(this.lblTot);
            this.gbClientesDeudores.Controls.Add(this.lblPromedioDeuda);
            this.gbClientesDeudores.Controls.Add(this.lblCantidadClientes);
            this.gbClientesDeudores.Controls.Add(this.lblTotal);
            this.gbClientesDeudores.Controls.Add(this.dgvConsultaDatos);
            this.gbClientesDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientesDeudores.Location = new System.Drawing.Point(12, 12);
            this.gbClientesDeudores.Name = "gbClientesDeudores";
            this.gbClientesDeudores.Size = new System.Drawing.Size(625, 394);
            this.gbClientesDeudores.TabIndex = 4;
            this.gbClientesDeudores.TabStop = false;
            this.gbClientesDeudores.Text = "Clientes deudores";
            // 
            // cmdListarDeudores
            // 
            this.cmdListarDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarDeudores.Location = new System.Drawing.Point(19, 357);
            this.cmdListarDeudores.Name = "cmdListarDeudores";
            this.cmdListarDeudores.Size = new System.Drawing.Size(128, 24);
            this.cmdListarDeudores.TabIndex = 7;
            this.cmdListarDeudores.Text = "Listar";
            this.cmdListarDeudores.UseVisualStyleBackColor = true;
            this.cmdListarDeudores.Click += new System.EventHandler(this.cmdListarDeudores_Click);
            // 
            // lblProm
            // 
            this.lblProm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProm.Location = new System.Drawing.Point(507, 352);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(112, 21);
            this.lblProm.TabIndex = 6;
            this.lblProm.Visible = false;
            // 
            // lblCantC
            // 
            this.lblCantC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantC.Location = new System.Drawing.Point(507, 307);
            this.lblCantC.Name = "lblCantC";
            this.lblCantC.Size = new System.Drawing.Size(112, 21);
            this.lblCantC.TabIndex = 5;
            this.lblCantC.Visible = false;
            // 
            // lblTot
            // 
            this.lblTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTot.Location = new System.Drawing.Point(507, 273);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(112, 21);
            this.lblTot.TabIndex = 4;
            this.lblTot.Visible = false;
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(367, 357);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(119, 15);
            this.lblPromedioDeuda.TabIndex = 3;
            this.lblPromedioDeuda.Text = "Promedio de deuda:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(367, 313);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(104, 15);
            this.lblCantidadClientes.TabIndex = 2;
            this.lblCantidadClientes.Text = "Cantidad clientes:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(367, 279);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 15);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total deuda:";
            // 
            // dgvConsultaDatos
            // 
            this.dgvConsultaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clUsuario,
            this.clLimite,
            this.clDeuda});
            this.dgvConsultaDatos.Location = new System.Drawing.Point(19, 36);
            this.dgvConsultaDatos.Name = "dgvConsultaDatos";
            this.dgvConsultaDatos.Size = new System.Drawing.Size(600, 217);
            this.dgvConsultaDatos.TabIndex = 0;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.Width = 120;
            // 
            // clUsuario
            // 
            this.clUsuario.HeaderText = "Usuario";
            this.clUsuario.Name = "clUsuario";
            this.clUsuario.Width = 160;
            // 
            // clLimite
            // 
            this.clLimite.HeaderText = "Limite";
            this.clLimite.Name = "clLimite";
            this.clLimite.Width = 160;
            // 
            // clDeuda
            // 
            this.clDeuda.HeaderText = "Deuda";
            this.clDeuda.Name = "clDeuda";
            // 
            // frmClientesDeudoresBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 418);
            this.Controls.Add(this.gbClientesDeudores);
            this.Name = "frmClientesDeudoresBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientesDeudoresBD";
            this.Load += new System.EventHandler(this.frmClientesDeudoresBD_Load);
            this.gbClientesDeudores.ResumeLayout(false);
            this.gbClientesDeudores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientesDeudores;
        private System.Windows.Forms.Button cmdListarDeudores;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblCantC;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvConsultaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
    }
}
namespace pryLabPBaseDatos.Delgado
{
    partial class frmBusquedaCliente
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblbLimite = new System.Windows.Forms.Label();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.lblDeudaR = new System.Windows.Forms.Label();
            this.lblLimiteR = new System.Windows.Forms.Label();
            this.gbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(34, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(108, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código del cliente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(175, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(135, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(235, 103);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 2;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.lblLimiteR);
            this.gbDatosCliente.Controls.Add(this.lblDeudaR);
            this.gbDatosCliente.Controls.Add(this.lblNombreR);
            this.gbDatosCliente.Controls.Add(this.lblbLimite);
            this.gbDatosCliente.Controls.Add(this.lblDeuda);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Location = new System.Drawing.Point(12, 182);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(298, 168);
            this.gbDatosCliente.TabIndex = 3;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos Cliente";
            this.gbDatosCliente.Enter += new System.EventHandler(this.gbDatosCliente_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(22, 73);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(47, 15);
            this.lblDeuda.TabIndex = 5;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblbLimite
            // 
            this.lblbLimite.AutoSize = true;
            this.lblbLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbLimite.Location = new System.Drawing.Point(22, 116);
            this.lblbLimite.Name = "lblbLimite";
            this.lblbLimite.Size = new System.Drawing.Size(101, 15);
            this.lblbLimite.TabIndex = 6;
            this.lblbLimite.Text = "Limite de crédito:";
            // 
            // lblNombreR
            // 
            this.lblNombreR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreR.Location = new System.Drawing.Point(153, 26);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(139, 23);
            this.lblNombreR.TabIndex = 7;
            // 
            // lblDeudaR
            // 
            this.lblDeudaR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaR.Location = new System.Drawing.Point(153, 65);
            this.lblDeudaR.Name = "lblDeudaR";
            this.lblDeudaR.Size = new System.Drawing.Size(139, 23);
            this.lblDeudaR.TabIndex = 8;
            // 
            // lblLimiteR
            // 
            this.lblLimiteR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLimiteR.Location = new System.Drawing.Point(153, 108);
            this.lblLimiteR.Name = "lblLimiteR";
            this.lblLimiteR.Size = new System.Drawing.Size(139, 23);
            this.lblLimiteR.TabIndex = 9;
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 372);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmBusquedaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaCliente";
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Label lblbLimite;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreR;
        private System.Windows.Forms.Label lblLimiteR;
        private System.Windows.Forms.Label lblDeudaR;
    }
}
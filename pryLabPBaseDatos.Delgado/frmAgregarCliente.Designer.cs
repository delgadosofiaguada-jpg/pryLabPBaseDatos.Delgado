namespace pryLabPBaseDatos.Delgado
{
    partial class frmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCliente));
            this.gbCargarcliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.cmbAutomovil = new System.Windows.Forms.ComboBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.gbCargarcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCargarcliente
            // 
            this.gbCargarcliente.Controls.Add(this.cmdCargar);
            this.gbCargarcliente.Controls.Add(this.cmbAutomovil);
            this.gbCargarcliente.Controls.Add(this.txtLimite);
            this.gbCargarcliente.Controls.Add(this.txtNombre);
            this.gbCargarcliente.Controls.Add(this.lblAutomovil);
            this.gbCargarcliente.Controls.Add(this.lblLimite);
            this.gbCargarcliente.Controls.Add(this.lblNombre);
            this.gbCargarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargarcliente.Location = new System.Drawing.Point(12, 12);
            this.gbCargarcliente.Name = "gbCargarcliente";
            this.gbCargarcliente.Size = new System.Drawing.Size(350, 240);
            this.gbCargarcliente.TabIndex = 0;
            this.gbCargarcliente.TabStop = false;
            this.gbCargarcliente.Text = "Cargar Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(19, 96);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(98, 15);
            this.lblLimite.TabIndex = 1;
            this.lblLimite.Text = "Límite de crédito";
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.Location = new System.Drawing.Point(19, 147);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(60, 15);
            this.lblAutomovil.TabIndex = 2;
            this.lblAutomovil.Text = "Automovil";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 21);
            this.txtNombre.TabIndex = 3;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(166, 90);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(160, 21);
            this.txtLimite.TabIndex = 4;
            // 
            // cmbAutomovil
            // 
            this.cmbAutomovil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutomovil.FormattingEnabled = true;
            this.cmbAutomovil.Location = new System.Drawing.Point(166, 136);
            this.cmbAutomovil.Name = "cmbAutomovil";
            this.cmbAutomovil.Size = new System.Drawing.Size(160, 23);
            this.cmbAutomovil.TabIndex = 5;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(219, 198);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(107, 23);
            this.cmdCargar.TabIndex = 6;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 264);
            this.Controls.Add(this.gbCargarcliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.gbCargarcliente.ResumeLayout(false);
            this.gbCargarcliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargarcliente;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbAutomovil;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button cmdCargar;
    }
}
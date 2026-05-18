namespace pryLabPBaseDatos.Delgado
{
    partial class frmListadoClientesBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientesBD));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.cmdListar = new System.Windows.Forms.Button();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(8, 36);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.Size = new System.Drawing.Size(777, 382);
            this.dgvListado.TabIndex = 0;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(665, 443);
            this.cmdListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(100, 32);
            this.cmdListar.TabIndex = 1;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.dgvListado);
            this.gbConsulta.Controls.Add(this.cmdListar);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(31, 16);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsulta.Size = new System.Drawing.Size(793, 494);
            this.gbConsulta.TabIndex = 2;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de datos";
            // 
            // frmListadoClientesBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 542);
            this.Controls.Add(this.gbConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoClientesBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Clientes - Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbConsulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.GroupBox gbConsulta;
    }
}
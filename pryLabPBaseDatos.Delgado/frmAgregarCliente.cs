using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLabPBaseDatos.Delgado
{
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void cmbAutomovil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            clsAutomovil auto= new clsAutomovil();
            auto.ListarAutomoviles(cmbAutomovil);
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            clsClientes x=new clsClientes();
            x.Nombre = txtNombre.Text;
            x.Limite = Convert.ToDecimal(txtLimite.Text);
            x.IDAutomovil = Convert.ToInt32(cmbAutomovil.SelectedValue);
            x.Agregar();

            MessageBox.Show("Datos cargados correctamente");
            txtNombre.Text = "";
            txtLimite.Text = "";
            cmbAutomovil.SelectedIndex = 0;

        }
    }
}

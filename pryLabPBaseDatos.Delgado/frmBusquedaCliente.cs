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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void gbDatosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 IDCliente= Convert.ToInt32(txtCodigo.Text);
            clsClientes x= new clsClientes();
            x.Buscar(IDCliente);

            if (x.IDCliente != 0)
            {
                lblNombreR.Text = x.Nombre;
                lblDeudaR.Text = x.Deuda.ToString();
                lblLimiteR.Text = x.Limite.ToString();
                txtCodigo.Text = "";

            }
            else
            {
                
                lblNombreR.Text = "";
                lblDeudaR.Text = "";
                lblLimiteR.Text = "";
                MessageBox.Show("Cliente no existente");
            }
        }
    }
}

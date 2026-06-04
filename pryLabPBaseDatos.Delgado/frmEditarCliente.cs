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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            cmdBuscar.Enabled = false;
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            
            clsClientes x = new clsClientes();
            Int32 IDCliente = Convert.ToInt32(txtCodigo.Text);
            x.Buscar(IDCliente);

            if (x.IDCliente != 0)
            {
                lblNombreR.Text = x.Nombre;
                lblDeudaR.Text = x.Deuda.ToString();
                txtLimite.Text = x.Limite.ToString();
            }
            else
            {
                lblNombreR.Text = "";
                lblDeudaR.Text = "";
                txtLimite.Text = "";
                MessageBox.Show("Dato no encontrado!!");
            }
            txtLimite.ReadOnly = true;//solo de lectura para que no se pueda editar
            cmdEliminar.Enabled = true;
            cmdModificar.Enabled =true;
            cmdGuardar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = true;
            txtLimite.ReadOnly = false;
        }

        private void limpiar()
        {
           
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            x.Limite = Convert.ToDecimal(txtLimite.Text);
            x.Modificar(id);
            MessageBox.Show("El dato fue actualizado correctamente");
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            Int32 id = Convert.ToInt32(txtCodigo.Text);

            x.Eliminar(id);
            MessageBox.Show("Cliente Eliminado");
        }
    }
}

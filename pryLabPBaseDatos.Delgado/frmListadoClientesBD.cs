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
    public partial class frmListadoClientesBD : Form
    {
        public frmListadoClientesBD()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.ListarClientes(dgvListado);
        }

        private void frmListadoClientesBD_Load(object sender, EventArgs e)
        {

        }
    }
}

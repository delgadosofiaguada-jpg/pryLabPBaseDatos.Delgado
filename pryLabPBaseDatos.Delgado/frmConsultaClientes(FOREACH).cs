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
    public partial class frmConsultaClientes_FOREACH_ : Form
    {
        public frmConsultaClientes_FOREACH_()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaClientes_FOREACH__Load(object sender, EventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.ListarForeach(dgvClientes);
        }
    }
}

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
    public partial class frmClientesDeudoresBD : Form
    {
        public frmClientesDeudoresBD()
        {
            InitializeComponent();
        }

        private void frmClientesDeudoresBD_Load(object sender, EventArgs e)
        {
          
        }

        private void cmdListarDeudores_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.ListarDeudoresBD(dgvConsultaDatos);
            lblCantC.Text = x.CantidadDeudores.ToString();
            lblTot.Text = x.TotalDeuda.ToString();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.ReporteCliente();
            MessageBox.Show("Reporte generado con exito");
        }
    }
}

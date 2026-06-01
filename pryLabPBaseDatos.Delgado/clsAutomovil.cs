using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO;


namespace pryLabPBaseDatos.Delgado
{
    internal class clsAutomovil
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Clientes.mdb";
        private String Tabla = "Automovil";

        public void ListarAutomoviles(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();//tabla virtual

                adaptador.Fill(DS, Tabla);
                Combo.DataSource = DS.Tables[Tabla];
                Combo.DisplayMember = "Nombre";//el dato que se ve en el combobox
                Combo.ValueMember = "idAutomovil";//el dato invisible

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        
    }
}

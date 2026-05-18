using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace pryLabPBaseDatos.Delgado
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Clientes.mdb";
        private String Tabla = "Client";

        private Decimal deuda;
        private Int32 cantidad;
        public Decimal TotalDeuda
        {
            get { return deuda; }
        }
        public Int32 CantidadDeudores
        { 
            get { return cantidad; }
        }
        public void ListarClientes(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS);

                Grilla.DataSource = DS.Tables[0];
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        public void ListarDeudoresBD(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText=Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                cantidad = 0;
                deuda = 0;
                Grilla.Rows.Clear();
                while (DR.Read())
                {
                    if (DR.GetDecimal(2)>0)
                    {
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2));
                        cantidad++;
                        deuda = deuda + DR.GetDecimal(2);
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}

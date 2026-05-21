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
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
       
        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Clientes.mdb";
        private String Tabla = "Cliente";

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
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2), DR.GetDecimal(3));
                        cantidad++;
                        deuda = deuda + DR.GetDecimal(3);
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ReporteCliente()
        {    try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                //Abrir
                StreamWriter AD = new StreamWriter("ReporteClientes.csv",false);
                AD.WriteLine("Listado de clientes\n");
                AD.WriteLine("Codigo;Nombre;deuda");

                cantidad = 0;
                deuda = 0;
                if (DR.HasRows)//Comprueba si hay datos
                {
                    while (DR.Read())
                    {
                        AD.Write(DR.GetInt32(0));
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.WriteLine(DR.GetDecimal(2));
                       
                        cantidad++;
                        deuda = deuda + DR.GetDecimal(2);
                        
                    }
                    AD.Write("Cantidad de clientes:;;");
                    AD.WriteLine(cantidad);
                    AD.Write("Total de deuda:;; " );
                    AD.WriteLine(deuda);
                    AD.Write("Promedio de deuda:;;");
                    AD.WriteLine(deuda/cantidad);
                    AD.Close(); 

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

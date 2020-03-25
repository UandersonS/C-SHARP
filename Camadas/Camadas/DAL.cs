using System.Data;
using System.Data.OleDb;

namespace Camadas
{
    public class CamadaAcessoDados
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:/dados/cadastro.mdb";

        public DataSet RetornaDataSet(string Sql)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbDataAdapter adp = new OleDbDataAdapter(Sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            conn.Close();
            return ds;


        }
    }
}
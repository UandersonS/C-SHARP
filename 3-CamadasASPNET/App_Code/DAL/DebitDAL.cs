using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for DebitDAL
/// </summary>
public class DebitDAL
{
    string connString = ConfigurationManager.ConnectionStrings["TutTestConn"].ToString();
    public DebitDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    /// <summary>
    /// Insert records into database
    /// </summary>
    /// <param name="accountNo"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public int Insert(int accountNo, decimal amount)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            string sql = "insert into Debit (AccountNo, Amount) " +
                "VALUES (@AccountNo, @Amount)";
            conn.Open();
            using (SqlCommand dCmd = new SqlCommand(sql, conn))
            {
                dCmd.Parameters.AddWithValue("@AccountNo", accountNo);
                dCmd.Parameters.AddWithValue("@Amount", amount);
                return dCmd.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// Load records from database
    /// </summary>
    /// <returns></returns>
    public DataTable Load()
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlDataAdapter dAd = new SqlDataAdapter("select * from Debit order by AutoID DESC", conn))
            {
                DataTable dTable = new DataTable();
                dAd.Fill(dTable);
                return dTable;
            }
        }
    }

}

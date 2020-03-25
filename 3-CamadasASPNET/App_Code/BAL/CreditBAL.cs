using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for CreditBAL
/// </summary>
public class CreditBAL
{
	public CreditBAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    /// <summary>
    /// Insert record into database
    /// </summary>
    /// <param name="accountNo"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public int CreditAmount(int accountNo, decimal amount)
    {
        return new CreditDAL().Insert(accountNo, amount);
    }

    /// <summary>
    /// Load records from database
    /// </summary>
    /// <returns></returns>
    public DataTable Load()
    {
        return new CreditDAL().Load();
    }


}

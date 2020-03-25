using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _3_Tier_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Add records into database
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void AddRecords(object sender, EventArgs e)
    {
        //Lets validate the page first
        if (!Page.IsValid)
            return;

        int intResult = 0;
        // Page is valid, lets go ahead and insert records
        // Instantiate BAL object
        PersonBAL3 pBAL = new PersonBAL3();
        // Instantiate the object we have to deal with
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        int age = Int32.Parse(txtAge.Text);
        
        try
        {
            intResult = pBAL.Insert(firstName, lastName, age);
            if (intResult > 0)
                lblMessage.Text = "New record inserted successfully.";
            else
                lblMessage.Text = "FirstName [<b>"+ txtFirstName.Text +"</b>] alredy exists, try another name";

        }
        catch (Exception ee)
        {
            lblMessage.Text = ee.Message.ToString();
        }
        finally
        {
            pBAL = null;
        }        
    }

}

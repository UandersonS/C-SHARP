using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;


    /// <summary>
    /// Summary description for PersonDAL
    /// </summary>
    public class PersonDAL3
    {
        string connStr = ConfigurationManager.ConnectionStrings["TutTestConn"].ToString();

        public PersonDAL3()
        {

        }

        /// <summary>
        /// Used to insert records into database
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public int Insert(string firstName, string lastName, int age)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("InsertData", conn);
            dCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                dCmd.Parameters.AddWithValue("@firstName", firstName);
                dCmd.Parameters.AddWithValue("@lastName", lastName);
                dCmd.Parameters.AddWithValue("@age", age);
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }


        /// <summary>
        /// Update record into database
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public int Update(int personID, string firstName, string lastName, int age)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("UpdateData", conn);
            dCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                dCmd.Parameters.AddWithValue("@firstName", firstName);
                dCmd.Parameters.AddWithValue("@lastName", lastName);
                dCmd.Parameters.AddWithValue("@age", age);
                dCmd.Parameters.AddWithValue("@personID", personID);
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Load all records from database
        /// </summary>
        /// <returns></returns>
        public DataTable Load()
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter dAd = new SqlDataAdapter("LoadAll", conn);
            dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dSet = new DataSet();
            try
            {
                dAd.Fill(dSet, "PersonTable");
                return dSet.Tables["PersonTable"];
            }
            catch
            {
                throw;
            }
            finally
            {
                dSet.Dispose();
                dAd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Delete record from database
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        public int Delete(int personID)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand dCmd = new SqlCommand("DeleteData", conn);
            dCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                dCmd.Parameters.AddWithValue("@personID", personID);
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

    }

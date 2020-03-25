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
    /// Summary description for PersonBAL
    /// </summary>
    public class PersonBAL3
    {
        public PersonBAL3()
        {

        }

        /// <summary>
        /// insert records into database
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public int Insert(string firstName, string lastName, int age)
        {
            PersonDAL3 pDAL = new PersonDAL3();
            try
            {
                return pDAL.Insert(firstName, lastName, age);
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }

        /// <summary>
        /// Update records into database
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public int Update(int personID, string firstName, string lastName, int age)
        {
            PersonDAL3 pDAL = new PersonDAL3();
            try
            {
                return pDAL.Update(personID, firstName, lastName, age);
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }

        /// <summary>
        /// Load records from database
        /// </summary>
        /// <returns></returns>
        public DataTable Load()
        {
            PersonDAL3 pDAL = new PersonDAL3();
            try
            {
                return pDAL.Load();
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }

        /// <summary>
        /// Delete record from database
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        public int Delete(int personID)
        {
            PersonDAL3 pDAL = new PersonDAL3();
            try
            {
                return pDAL.Delete(personID);
            }
            catch
            {
                throw;
            }
            finally
            {
                pDAL = null;
            }
        }

    }

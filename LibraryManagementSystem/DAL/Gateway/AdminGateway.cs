using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.DAL.Gateway
{
    class AdminGateway :DBGateway
    {
        public bool CheckAll(string username, string password)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from  tbl_Admin where UserName='{0}' AND Password='{1}'", username, password);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                if (reader !=null)
                {
                    return reader.HasRows;
                }
                return false;
            }
            catch (Exception exception)
            {

                throw new Exception("Error occurred during your login System.", exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
            
        }
    }
}

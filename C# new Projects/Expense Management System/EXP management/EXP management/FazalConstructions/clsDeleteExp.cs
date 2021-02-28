using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FazalConstructions
{
    public class clsDeleteExp
    {
        public static SqlConnection con;
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds;
        public static int status_id;
        public static string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;

        public static int deleteExp(string id)
        {
            try
            {
                con = new SqlConnection(ConStr);
                con.Open();
                cmd = new SqlCommand("DELETE from tblExpEntry WHERE TransactionID =@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                
                status_id = 1;
                con.Close();
                return status_id;
                
            }
            catch
            {
                status_id = 0;
                return status_id;
            }



        }

    }
}

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
    public class clsCreatePersonalExp
    {
        public static SqlConnection con;
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds;
        public static int status_id;
        public static string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;

        public static int CreatePerExp(string id, string title, string desc, decimal amt, int qty, DateTime dt, string rcvr)
        {
            try
            {
                con = new SqlConnection(ConStr);
                con.Open();
                cmd = new SqlCommand("INSERT into tblPersonalExp(ID,Title,Description,Amount,Quantity,Receiver,Date)VALUES(@id, @title,@desc,@amt,@qty,@rcvr,@dt)", con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.Add("@amt",SqlDbType.Decimal).Value=amt;
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("@rcvr", rcvr);

                cmd.ExecuteNonQuery();

                status_id = 1;
                return status_id;
            }
            catch
            {
                throw;
                status_id = 0;
                return status_id;

            }
                
        }
    }
}

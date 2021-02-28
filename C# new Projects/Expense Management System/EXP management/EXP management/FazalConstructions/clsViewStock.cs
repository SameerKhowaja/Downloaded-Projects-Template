using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace FazalConstructions
{
   public class clsViewStock
    {
        private static string ConStr = DBConnection.ConStr;

        public static DataSet fetchPreviousDetails()
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT * FROM tblFolding";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DATA");
                    return ds;
                }
            }
        }
    }
}

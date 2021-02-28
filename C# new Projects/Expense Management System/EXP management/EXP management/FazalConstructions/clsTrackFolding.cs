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
    public class clsTrackFolding
    {
        private static string ConStr = DBConnection.ConStr;

        public static DataSet fetchPreviousDetails(string tblName)
        {
            using(var con = new SqlConnection(ConStr))
            {
                string query = "select tblStockManagement.[TransactionID],tblStockManagement.[Quantity], tblFolding.Name, tblClient.ProjectName, tblStockManagement.[DateTime] from "+tblName+" LEFT OUTER JOIN tblFolding ON tblFolding.FoldingID = tblStockManagement.FoldingID LEFT OUTER JOIN tblClient ON tblClient.Client_ID = tblStockManagement.Client_ID";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;



namespace FazalConstructions
{
   public class clsStockManagement
    {
        public static string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        public static SqlConnection con;
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static int status_id;
      

       public static void updateStock(int transId, int projectId, int itemId, int qty, DateTime dt)
        {
            //try
            //{
                con = new SqlConnection(ConStr);
                con.Open();
                cmd = new SqlCommand("INSERT INTO tblStockManagement (TransactionID, Client_ID, FoldingID, Quantity, DateTime)VALUES(@transid, @client_id, @foldingId, @qty, @datetime); update tblFolding set Quantity=Quantity-@qty;", con);
                cmd.Parameters.Add("@transid", System.Data.SqlDbType.Int).Value = transId;
                cmd.Parameters.Add("@client_id", System.Data.SqlDbType.Int).Value = projectId;
                cmd.Parameters.Add("@FoldingID", System.Data.SqlDbType.Int).Value = itemId;

                cmd.Parameters.Add("@qty", System.Data.SqlDbType.Int).Value = qty;
                cmd.Parameters.AddWithValue("@datetime", dt);

                cmd.ExecuteNonQuery();
                con.Close();
                //status_id = 1;
                //return status_id;
                

            }
            //catch (Exception)
            //{

            //    status_id = 0;
            //    return status_id;
            //}
            
        //}
        



    }
}

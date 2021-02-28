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
    public class clsFoldingManagement
    {
        private static string ConStr = DBConnection.ConStr;


        public static DataSet checkItemExisitance(int foldingId, int clientId/* int qty, int TransId*/)//check item existance in tblstockmanagement by selecting data using folding id and client id
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "select CAST(COUNT(*) AS BIT) AS 'R' FROM [tblStockManagement] WHERE (FoldingID = @fold AND Client_ID=@clientId)";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@fold", SqlDbType.Int).Value = foldingId;
                    cmd.Parameters.AddWithValue("@clientId", SqlDbType.Int).Value = clientId;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    string nested_query;
                    //if (ds.Tables[0].Rows[0]["R"].ToString()=="True")
                    //{
                    //    //nested_query = "UPDATE tblStockManagement SET Quantity = Quantity - @qty WHERE TransactionID=@transId";
                    //    //nested_query += " UPDATE tblStockManagement SET ";
                    //}
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public static DataSet fetchProjectDetails()
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT tblClient.Client_ID, tblClient.ProjectName FROM tblClient WHERE StatusID=1";
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

        public static DataSet backItemNames(int id)
        {
            
                using (var con = new SqlConnection(ConStr))
                {
                    string query = @"select tblFolding.FoldingID,tblFolding.Name  from tblStockManagement LEFT OUTER JOIN tblFolding ON tblStockManagement.FoldingID=tblFolding.FoldingID WHERE client_ID =@id";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "DATA");
                        return ds;
                    }
               
            }
            
        }


        public static DataSet fetchProjectsFromStockManagement()
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT tblClient.Client_ID, tblClient.ProjectName FROM tblClient";
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




        public static DataSet fetchProjectsForUpdateQty(int foldingId)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = @"select Distinct tblFolding.Name, tblStockManagement.FoldingID, tblStockManagement.Quantity, tblClient.ProjectName, tblClient.Client_ID from tblStockManagement LEFT OUTER JOIN tblFolding ON tblStockManagement.FoldingID=tblFolding.FoldingID LEFT OUTER JOIN tblClient ON tblClient.Client_ID=tblStockManagement.Client_ID WHERE tblStockManagement.FoldingID=" + foldingId + " AND tblClient.StatusID=1";
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

        public static DataSet w(int projectId, int foldingID)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = @"select Distinct tblStockManagement.TransactionID, tblFolding.Name, tblStockManagement.FoldingID, tblStockManagement.Quantity, tblClient.ProjectName, tblClient.Client_ID from tblStockManagement LEFT OUTER JOIN tblFolding ON tblStockManagement.FoldingID=tblFolding.FoldingID LEFT OUTER JOIN tblClient ON tblClient.Client_ID=tblStockManagement.Client_ID WHERE tblStockManagement.Client_ID=" + projectId + " AND tblStockManagement.FoldingID=" + foldingID + "";
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




        public static DataSet fetchPreviousQtyToUpdate(int foldingId, int projectId)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = @"select TransactionID, Quantity from tblStockManagement
                               where Client_ID="+projectId+" and FoldingID="+foldingId+"";
                using (var cmd = new SqlCommand(query, con))
                {

                    con.Open();
                    //cmd.Parameters.Add("@clientid", SqlDbType.Int).Value = client_id;
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DATA");
                    return ds;
                }
            }
        }



        public static DataSet fetchItemsInStockToUpdate(int foldingId)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = @"select RemQuantity from tblFolding where FoldingID="+foldingId+"";
                using (var cmd = new SqlCommand(query, con))
                {

                    con.Open();
                    //cmd.Parameters.Add("@clientid", SqlDbType.Int).Value = client_id;
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DATA");
                    return ds;
                }
            }
        }





        public static DataSet updateLoadItems()
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = @"select Distinct tblFolding.Name, tblStockManagement.FoldingID from tblStockManagement LEFT OUTER JOIN tblFolding ON tblStockManagement.FoldingID=tblFolding.FoldingID";
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









        public static void enterFolding(int transId, int projectId, int itemId, int qty, DateTime dt)
        {
            
            using (var con = new SqlConnection(ConStr))
            {
                using (var cmd = new SqlCommand("INSERT INTO tblStockManagement (TransactionID, Client_ID, FoldingID, Quantity, DateTime)VALUES(@transid, @client_id, @foldingId, @qty, @datetime); update tblFolding set UsedQuantity=UsedQuantity+@qty WHERE FoldingID=@foldingId;", con))
                {
                    con.Open();
                    cmd.Parameters.Add("@transid", System.Data.SqlDbType.Int).Value = transId;
                    cmd.Parameters.Add("@client_id", System.Data.SqlDbType.Int).Value = projectId;
                    cmd.Parameters.Add("@FoldingID", System.Data.SqlDbType.Int).Value = itemId;

                    cmd.Parameters.Add("@qty", System.Data.SqlDbType.Int).Value = qty;
                    cmd.Parameters.AddWithValue("@datetime", dt);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            

        }


        public static void updateFolding(int transId, int foldingId, int qty, DateTime dt)
        {

            using (var con = new SqlConnection(ConStr))
            {
                using (var cmd = new SqlCommand("UPDATE tblStockManagement SET Quantity=Quantity+@qty, DateTime=@dt WHERE TransactionID=@transid; UPDATE tblFolding SET UsedQuantity=UsedQuantity+@qty WHERE FoldingID="+foldingId+"", con))
                {
                    con.Open();
                    cmd.Parameters.Add("@transid", System.Data.SqlDbType.Int).Value = transId;
                    cmd.Parameters.Add("@qty", System.Data.SqlDbType.Int).Value = qty;
                    cmd.Parameters.AddWithValue("@dt", dt);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }


        }




        //public static DataSet fetchTransactionIDForUpdation(int TransactionID)
        //{
        //    using (var con = new SqlConnection(ConStr))
        //    {
        //        string query = "SELECT isNull(RemQuantity,0) as 'RemQuantity' FROM tblFolding WHERE FoldingID=" + foldingID + "";
        //        using (var cmd = new SqlCommand(query, con))
        //        {
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
        //            DataSet ds = new DataSet();
        //            da.Fill(ds, "DATA");
        //            return ds;
        //        }
        //    }
        //}







        public static DataSet fetchGridInformation()
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


        public  static DataSet fetchFoldingItemNames(int projectId)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT Name, FoldingID FROM tblFolding WHERE FoldingID NOT IN (SELECT FoldingID FROM tblStockManagement WHERE tblStockManagement.Client_ID="+projectId+" );";
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

        public static DataSet fetchItemQuantity(int foldingID)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT isNull(RemQuantity,0) as 'RemQuantity' FROM tblFolding WHERE FoldingID=" +foldingID+ "";
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

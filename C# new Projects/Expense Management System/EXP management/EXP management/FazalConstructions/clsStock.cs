using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace FazalConstructions
{
    
    public class clsStock
    {
        private static string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;

        public static void createFolding(int id, string name, int qty, string narration, DateTime dt)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string sql="INSERT INTO tblFolding(FoldingID, Name,Quantity,UsedQuantity,Narration,DateTime)VALUES(@id, @name, @qty,0, @narration,@dt)";
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@narration", narration);
                    cmd.Parameters.AddWithValue("@dt", dt);
                    cmd.ExecuteNonQuery();
                }
        }
        }




        public static void update(int id, string name, int qty, DateTime dt)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string sql = "UPDATE tblFolding SET Name =@name, Quantity =@qty, DateTime=@dt WHERE FoldingID=@id";
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value=id;
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value=name;
                    cmd.Parameters.Add("@qty", System.Data.SqlDbType.Int).Value = qty;
                    cmd.Parameters.Add("@dt", System.Data.SqlDbType.DateTime).Value=dt;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void delete(int id)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string sql = "DELETE from tblFolding WHERE FoldingID=@id";
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id; 
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

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
    public class clsUpdateCategory
    {
        public static string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        public static SqlConnection con;
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds;
        public static int status;
        public static string err;
        
        //public static string id;
        public static int updateCat(string c_id, string tblName, string categoryName, string desc, DateTime dt)
        {
            try
            {
                con = new SqlConnection(ConStr);
                con.Open();
                cmd = new SqlCommand("UPDATE tblCategory SET CatName =@categoryName, CatDesc=@desc, DateTime=@dt WHERE CatID=@id", con);
               // cmd.Parameters.AddWithValue("@tbName", tblName);
                cmd.Parameters.AddWithValue("@categoryName", categoryName);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@id", c_id);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.ExecuteNonQuery();
                
                status = 1;
                return status;
                
            }
            catch (Exception ex)
            {

                 status = 0;
                return status;
                throw;
                
            }
        }
    }
}

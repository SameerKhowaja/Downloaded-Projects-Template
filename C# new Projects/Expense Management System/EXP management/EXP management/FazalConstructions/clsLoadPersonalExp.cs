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
    
    public class clsLoadPersonalExp
    {
        public static SqlConnection con;
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds;
        //public static int status_id;
        
        public static string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;

        public static DataSet selectData()
        {
                    con = new SqlConnection(ConStr);
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM tblPersonalExp", con);
                    //cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd.CommandText, con);
                    ds = new DataSet();
                    da.Fill(ds, "DATA");                  
                    return ds;       
            }
        }
    }


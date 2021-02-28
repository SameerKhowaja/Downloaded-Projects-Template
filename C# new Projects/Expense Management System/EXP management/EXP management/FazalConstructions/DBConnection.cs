using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace FazalConstructions
{
    public class DBConnection
    {
        public static string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;

        //public static SqlConnection conn = new SqlConnection(c);
    }
}

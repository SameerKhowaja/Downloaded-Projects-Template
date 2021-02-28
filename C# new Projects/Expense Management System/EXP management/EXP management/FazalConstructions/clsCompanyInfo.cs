using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FazalConstructions
{
    public class clsCompanyInfo
    {
        private static string ConStr=DBConnection.ConStr;

        public static DataSet fetchCompanyDetails()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Address, AdditionalInfo FROM tblCompanySetup"))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");
                    return ds;

                    //companyAddress = ds.Tables[0].Rows[0]["Address"].ToString();
                    //companyContact = ds.Tables[0].Rows[0]["AdditionalInfo"].ToString();

                }
            }
        }
       
           
    }
}

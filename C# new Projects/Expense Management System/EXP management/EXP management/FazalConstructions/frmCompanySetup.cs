using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FazalConstructions
{
    public partial class frmCompanySetup : Form
    {
        string ConStr = DBConnection.ConStr;
        public frmCompanySetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbAdd.Text.Trim()==string.Empty || tbExtr.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Required field(s) are empty. Try Again.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var con = new SqlConnection(ConStr))
            {
                string query = "UPDATE tblCompanySetup SET Address = @add, AdditionalInfo=@info";
                using (var cmd = new SqlCommand (query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@add", SqlDbType.NVarChar).Value = tbAdd.Text.Trim();
                    cmd.Parameters.AddWithValue("@info", SqlDbType.NVarChar).Value = tbExtr.Text.Trim();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved");
                }
            }
        }

        private void frmCompanySetup_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT * FROM tblCompanySetup";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    tbAdd.Text=ds.Tables[0].Rows[0]["Address"].ToString();
                   tbExtr.Text = ds.Tables[0].Rows[0]["AdditionalInfo"].ToString();


                }
            }
        }
    }
}

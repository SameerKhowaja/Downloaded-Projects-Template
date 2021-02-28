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
    public partial class frmUpdateRcvPmt : Form
    {
        string ConStr = DBConnection.ConStr;
        public frmUpdateRcvPmt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please enter serial #", "No serial #", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var con = new SqlConnection(ConStr))
            {
                string query = @"SELECT  [RcvPmtID]
      ,[RcvAmount]
      ,[RcvName]
      ,[PaidBy]
      ,tblPaymentMode.Name
      ,tblClient.ProjectName
      ,tblUser.UserName
      ,[Date]
      ,[Description]
      ,[ChqNo]
      ,[BankName]
      ,[IMG]
  FROM [FCProject].[dbo].[tblReceivePayment] LEFT OUTER JOIN tblPaymentMode ON tblReceivePayment.PaymentModeID = tblPaymentMode.PaymentModeID
  LEFT OUTER JOIN tblClient ON tblReceivePayment.Client_ID=tblClient.Client_ID LEFT OUTER JOIN tblUser ON tblReceivePayment.UserID=tblUser.UserID WHERE tblReceivePayment.RcvPmtID=@id";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.Parse(tbID.Text.Trim());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count==0)
                    {
                        MessageBox.Show("No data found against provided serial #. ", "No record found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    updateID.Text = ds.Tables[0].Rows[0]["RcvPmtID"].ToString();
                    tbRcvPmt.Text = ds.Tables[0].Rows[0]["RcvAmount"].ToString();
                    tbRcvName.Text = ds.Tables[0].Rows[0]["RcvName"].ToString();
                    tbPaidBy.Text = ds.Tables[0].Rows[0]["PaidBy"].ToString();
                    tbDesc.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                    tbPaymentMethod.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                   tbSiteName.Text= ds.Tables[0].Rows[0]["ProjectName"].ToString();
                    
                    
                }
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (updateID.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please select transaction first", "Select ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var con = new SqlConnection(ConStr))
                {
                    string query = "UPDATE tblReceivePayment SET RcvAmount = @amt, Description=@desc WHERE RcvPmtID=@uid";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@amt", SqlDbType.Decimal).Value = decimal.Parse(tbRcvPmt.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", SqlDbType.NVarChar).Value = tbDesc.Text.Trim();
                        cmd.Parameters.AddWithValue("@uid", SqlDbType.Int).Value = int.Parse(updateID.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();
                        tbID.Clear();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while Updating transaction\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmUpdateRcvPmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (updateID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select transaction first", "Select ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                using (var con = new SqlConnection(ConStr))
                {
                    string query = "DELETE FROM tblReceivePayment WHERE RcvPmtID=@id";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.Parse(updateID.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbID.Clear();
                        updateID.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while deleting transaction\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmUpdateRcvPmt_Load(object sender, EventArgs e)
        {

        }
    }
}

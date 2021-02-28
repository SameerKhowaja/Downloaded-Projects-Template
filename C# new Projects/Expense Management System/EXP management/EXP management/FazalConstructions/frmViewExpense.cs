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
using System.Configuration;
using System.IO;


namespace FazalConstructions
{
    public partial class frmViewExpense : Form
    {
        DataSet detailsDS = new DataSet();
        private static string ConStr = DBConnection.ConStr;
        public frmViewExpense()
        {
            InitializeComponent();
        }

        private void frmViewExpense_Load(object sender, EventArgs e)
        {
            detailsDS.Clear();
            loadExp();
        }

        private void loadExp()
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = @"SELECT [TransactionID]
      ,tblClient.ProjectName
      ,tblCategory.CatName
      ,[Date]
      ,[Exp_Title]
      ,[Payee]
      ,[TotalPayment]
      ,[PaidPayment]
      ,[Area]
      ,[Floor]
      ,[Hours]
      ,[Minutes]
      ,[ChqNo]
      ,[Quantity]
      ,[Amount]
      ,[Narration]
      ,[REM_PMT]
      ,tblPaymentStatus.Name AS 'PaymentStatusName'
      ,tblPaymentMode.Name AS 'PaymentModeName'
      ,tblUser.UserName
      ,[IMG]
  FROM [FCProject].[dbo].[tblExpEntry]
  LEFT OUTER JOIN tblClient ON tblClient.Client_ID = tblExpEntry.Client_ID 
  LEFT OUTER JOIN tblCategory ON tblCategory.CatID=tblExpEntry.CatID 
  LEFT OUTER JOIN tblPaymentStatus ON tblPaymentStatus.PaymentStatusID=tblExpEntry.PaymentStatusID  
  LEFT OUTER JOIN tblPaymentMode ON tblPaymentMode.PaymentModeID=tblExpEntry.PaymentModeID
   LEFT OUTER JOIN tblUser ON tblExpEntry.UserID=tblUser.UserID";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //DataSet ds = new DataSet();
                    
                    da.Fill(detailsDS);
                    dataGridView1.DataSource = detailsDS.Tables[0].DefaultView;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // detailsDS.Clear();
            
            //MessageBox.Show(detailsDS.Tables[0].Rows.Count.ToString());
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                frmExpDetails frm = new frmExpDetails();
                
                frm.tbAcc.Text = row.Cells["ProjectName"].Value.ToString();
                frm.tbCat.Text= row.Cells["CatName"].Value.ToString();
               frm.tbExp.Text = row.Cells["Exp_Title"].Value.ToString();
                frm.tbPayee.Text= row.Cells["Payee"].Value.ToString();
                frm.tbTotalPayment.Text = row.Cells["TotalPayment"].Value.ToString();
                frm.tbPaidPayment.Text = row.Cells["PaidPayment"].Value.ToString();
                frm.tbArea.Text = row.Cells["Area"].Value.ToString();
                frm.tbFloor.Text = row.Cells["Floor"].Value.ToString();
                frm.tbHours.Text = row.Cells["Hours"].Value.ToString();
                frm.tbMinutes.Text = row.Cells["Minutes"].Value.ToString();
               frm.tbCHQNo.Text = row.Cells["ChqNo"].Value.ToString();
                frm.tbQty.Text = row.Cells["Quantity"].Value.ToString();
                frm.tbAmt.Text = row.Cells["Amount"].Value.ToString();
                frm.tbNarration.Text = row.Cells["Narration"].Value.ToString();

                frm.tbRemainingPayment.Text = row.Cells["REM_PMT"].Value.ToString();
                frm.tbPaymentStatus.Text = row.Cells["PaymentStatusName"].Value.ToString();
                frm.tbPaymentMode.Text = row.Cells["PaymentModeName"].Value.ToString();

                frm.date.Text = row.Cells["Date"].Value.ToString();

               frm.lbl_ID.Text = row.Cells["TransactionID"].Value.ToString();
               frm.lblUser.Text = row.Cells["UserName"].Value.ToString();
               // frm.pictureBox1.Image = row.Cells["IMG"].Value.ToString();

              

               byte[] img = (row.Cells["IMG"].Value is DBNull ? null : (byte[])(row.Cells["IMG"].Value));
               if (img == null)
               {
                   frm.pictureBox1.Image = null;
               }
               else
               {
                   MemoryStream ms = new MemoryStream(img);
                   frm.pictureBox1.Image = Image.FromStream(ms);

               }
               frm.Show();
                

            }
        }

        private void frmViewExpense_Activated(object sender, EventArgs e)
        {
            detailsDS.Clear();
            loadExp();
        }

        private void frmViewExpense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tbProject_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "ProjectName LIKE '%" + tbProject.Text.Trim() + "%'";
        }

        private void frmViewExpense_Deactivate(object sender, EventArgs e)
        {

        }

        private void tbCategory_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "CatName LIKE '%" + tbCategory.Text.Trim() + "%'";
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "Exp_Title LIKE '%" + tbTitle.Text.Trim() + "%'";
        }

        private void tbPayee_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "Payee LIKE '%" + tbPayee.Text.Trim() + "%'";
        }

        private void tbPmtMethod_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "PaymentModeName LIKE '%" + tbPmtMethod.Text.Trim() + "%'";
        }

        private void tbPmtStatus_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "PaymentStatusName LIKE '%" + tbPmtStatus.Text.Trim() + "%'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim()==string.Empty)
            {
                return;
            }
            DataView dv = detailsDS.Tables[0].DefaultView;
            dv.RowFilter = "TransactionID = " + tbID.Text.Trim() + "";
        }
    }
}

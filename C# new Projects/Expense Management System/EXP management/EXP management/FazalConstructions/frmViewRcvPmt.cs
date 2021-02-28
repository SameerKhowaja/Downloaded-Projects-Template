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
    public partial class frmViewRcvPmt : Form
    {
        DataSet detailsDS = new DataSet();
        private static string ConStr = DBConnection.ConStr;
        public frmViewRcvPmt()
        {
            InitializeComponent();
        }

        private void frmViewRcvPmt_Load(object sender, EventArgs e)
        {
            detailsDS.Clear();

            using (var con = new SqlConnection(ConStr))
            {
                string query = @"SELECT [RcvPmtID] as 'ID'
      ,[RcvAmount] AS 'Payment'
      ,[RcvName] AS 'Receivedby'
      ,[PaidBy] AS 'Paidby'
      ,tblPaymentMode.Name AS 'PaymentMode'
      ,tblClient.ProjectName
      ,tblUser.UserName
      ,[Date]
      ,[Description]
      ,[ChqNo] as 'CHQNo'
      ,[BankName]
      ,[IMG]
  FROM [FCProject].[dbo].[tblReceivePayment] 
  LEFT OUTER JOIN tblPaymentMode ON tblPaymentMode.PaymentModeID=tblReceivePayment.PaymentModeID 
  LEFT OUTER JOIN tblUser ON tblUser.UserID=tblReceivePayment.UserID 
  LEFT OUTER JOIN tblClient ON tblClient.Client_ID=tblReceivePayment.Client_ID";
                using (var cmd = new SqlCommand(query,con))
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                frmRcvPmtDetails frm = new frmRcvPmtDetails();
                frm.tbRcvPmt.Text = row.Cells["Payment"].Value.ToString();
                frm.tbRcvName.Text = row.Cells["Receivedby"].Value.ToString();
                frm.tbPaidBy.Text = row.Cells["Paidby"].Value.ToString();
                frm.cbPmtModeID.Text = row.Cells["PaymentMode"].Value.ToString();
                frm.tbProject.Text = row.Cells["ProjectName"].Value.ToString();
                frm.tbDesc.Text = row.Cells["Description"].Value.ToString();
                frm.tbBankName.Text = row.Cells["BankName"].Value.ToString();
                frm.tbChqNo.Text = row.Cells["CHQNo"].Value.ToString();
                frm.lbl_ID.Text = row.Cells["ID"].Value.ToString();

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

        private void frmViewRcvPmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tbProjectName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "ProjectName LIKE '%" + tbProjectName.Text.Trim() + "%'";
        }

        private void tbPaidBy_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "Paidby LIKE '%" + tbPaidBy.Text.Trim() + "%'";
        }

        private void tbReceivedBy_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "Receivedby LIKE '%" + tbReceivedBy.Text.Trim() + "%'";
        }

        private void tbPaymentMode_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "PaymentMode LIKE '%" + tbPaymentMode.Text.Trim() + "%'";
        }

        private void tbChqNo_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "CHQNo LIKE '%" + tbChqNo.Text.Trim() + "%'";
        }

        private void tbBankName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailsDS.Tables[0].DefaultView;

            dv.RowFilter = "BankName LIKE '%" + tbBankName.Text.Trim() + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Trim() == string.Empty)
            {
                return;
            }
            DataView dv = detailsDS.Tables[0].DefaultView;
            dv.RowFilter = "ID = " + tbID.Text.Trim() + "";
        }
    }
}

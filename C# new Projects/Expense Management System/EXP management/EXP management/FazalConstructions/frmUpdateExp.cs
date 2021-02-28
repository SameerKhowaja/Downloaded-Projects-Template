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

namespace FazalConstructions
{
    public partial class frmUpdateExp : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        public frmUpdateExp()
        {
            InitializeComponent();
        }

        private void cbSerial_Click(object sender, EventArgs e)
        {
         
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                //string query = "SELECT * FROM tblExpEntry WHERE TransactionID = @id";
                string query = @"SELECT
      tblClient.ProjectName
      ,tblCategory.CatName
      ,[Date]
        ,tblClient.[Client_ID] AS 'ID'
      ,[Exp_Title]
,tblCategory.CatID AS 'CatID'
      ,[Payee]
,[TransactionID]
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
      ,tblPaymentStatus.Name AS 'Payment Status'
,tblPaymentStatus.PaymentStatusID AS 'PmtStatusID'
      ,tblPaymentMode.Name AS 'Payment Mode'
,tblPaymentMode.PaymentModeID AS 'PmtModeID'
      ,[UserID]
  FROM [dbo].[tblExpEntry] LEFT OUTER JOIN tblClient ON tblExpEntry.Client_ID=tblClient.Client_ID LEFT OUTER JOIN tblCategory ON tblExpEntry.CatID=tblCategory.CatID LEFT OUTER JOIN tblPaymentMode ON tblExpEntry.PaymentModeID=tblPaymentMode.PaymentModeID LEFT OUTER JOIN tblPaymentStatus ON tblExpEntry.PaymentStatusID=tblPaymentStatus.PaymentStatusID  WHERE tblExpEntry.TransactionID=@id;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.BigInt).Value = cbSerial.Text;

                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);

                    if (dt.Rows.Count<1)
                    {
                        MessageBox.Show("No data found against Provided Serial #. Try Again", "No data found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    

                    lblProjectName.Text = dt.Rows[0]["ProjectName"].ToString();
                    lblCategory.Text = dt.Rows[0]["CatName"].ToString();
                    lblPaymentStatus.Text = dt.Rows[0]["Payment Status"].ToString();
                    lblPaymentMode.Text = dt.Rows[0]["Payment Mode"].ToString();


                    ID.Text = dt.Rows[0]["TransactionID"].ToString();
                        tbExp.Text = dt.Rows[0]["Exp_Title"].ToString();
                        tbPayee.Text = dt.Rows[0]["Payee"].ToString();
                        tbQty.Text = dt.Rows[0]["Quantity"].ToString();
                        tbAmt.Text = dt.Rows[0]["Amount"].ToString();
                        tbTotalPayment.Text = dt.Rows[0]["TotalPayment"].ToString();
                        tbPaidPayment.Text = dt.Rows[0]["PaidPayment"].ToString();
                        tbRemainingPayment.Text = dt.Rows[0]["REM_PMT"].ToString();
                        lbl_user.Text = dt.Rows[0]["UserID"].ToString();
                        tbCHQNo.Text = dt.Rows[0]["ChqNo"].ToString();
                        tbNarration.Text = dt.Rows[0]["Narration"].ToString();
                        tbArea.Text = dt.Rows[0]["Area"].ToString();
                        tbFloor.Text = dt.Rows[0]["Floor"].ToString();
                        tbHours.Text = dt.Rows[0]["Hours"].ToString();
                        tbMinutes.Text = dt.Rows[0]["Minutes"].ToString();
                    

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = @"UPDATE tblExpEntry SET Date=@date,Client_ID=@Acc,CatID=@Cat,Narration=@narration,UserID=@uID,Exp_Title=@Exp_title,Payee=@Payee,Quantity=@Quantity,Amount=@Amount,
                                TotalPayment=@TotalPmt, PaidPayment=@PaidPmt,PaymentStatusID=@PmtStatusID,PaymentModeID=@PmtModeID,ChqNo=@ChqNo,
                                Area=@Area,Floor=@Floor,Hours=@Hours,Minutes=@Minutes WHERE TransactionID = @transid";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@transid", SqlDbType.BigInt).Value = cbSerial.Text;

                    cmd.Parameters.AddWithValue("@PmtStatusID", tbPaymentStatus.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PmtModeID", cbPmtMode.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Acc", Project.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Cat", cbCategory.SelectedValue.ToString());

                    cmd.Parameters.AddWithValue("@date", DateTimee.Value);
                    cmd.Parameters.AddWithValue("@narration", tbNarration.Text.Trim());
                    cmd.Parameters.AddWithValue("@uID", lbl_user.Text);
                    cmd.Parameters.AddWithValue("@Exp_title", tbExp.Text.Trim());
                    cmd.Parameters.AddWithValue("@Payee", tbPayee.Text.Trim());
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = tbQty.Text.Trim();
                    cmd.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = tbAmt.Text.Trim();
                    cmd.Parameters.Add("@TotalPmt", SqlDbType.Decimal).Value = tbTotalPayment.Text.Trim();
                    cmd.Parameters.Add("@PaidPmt", SqlDbType.Decimal).Value = tbPaidPayment.Text.Trim();
                    cmd.Parameters.AddWithValue("@ChqNo", tbCHQNo.Text.Trim());
                    cmd.Parameters.Add("@Area", SqlDbType.Decimal).Value = tbArea.Text.Trim();
                    cmd.Parameters.Add("@Floor", SqlDbType.Int).Value = tbFloor.Text.Trim();
                    cmd.Parameters.Add("@Hours", SqlDbType.Int).Value = tbHours.Text.Trim();
                    cmd.Parameters.Add("@Minutes", SqlDbType.Int).Value = tbMinutes.Text.Trim();

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //preparePrint();
                    //PrintSlip.Print();

                }
            }
           
        }

        private void preparePrint()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;

                    if (textBox.Text.Trim() == "")
                    {
                        textBox.Text = "-";
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateExp_Load(object sender, EventArgs e)
        {
            loadUser();
            loadCategories();
            loadClients();
            loadPaymentStatus();
            loadPaymentMode();

        }

        private void loadPaymentMode()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name, PaymentModeID FROM tblPaymentMode"))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");

                    cbPmtMode.DataSource = ds.Tables[0].DefaultView;
                    cbPmtMode.DisplayMember = "Name";
                    cbPmtMode.ValueMember = "PaymentModeID";
                }
            }
        }

        private void loadPaymentStatus()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name, PaymentStatusID FROM tblPaymentStatus"))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");

                    tbPaymentStatus.DataSource = ds.Tables[0].DefaultView;
                    tbPaymentStatus.DisplayMember = "Name";
                    tbPaymentStatus.ValueMember = "PaymentStatusID";

                }
            }
        }

        private void loadClients()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = "SELECT Client_ID, ProjectName FROM tblClient WHERE StatusID=1";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    Project.DataSource = dt;
                    Project.DisplayMember = "ProjectName";
                    Project.ValueMember = "Client_ID";                }
            }
        }

        private void loadCategories()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = "SELECT CatName, CatID FROM tblCategory";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    cbCategory.DataSource = dt;
                    cbCategory.DisplayMember = "CatName";
                    cbCategory.ValueMember = "CatID";
                    

                    //cbCatID.DataSource = dt;
                    //cbCatID.DisplayMember = "CatID";
                }
            }
        }

        private void loadUser()
        {
            //using (SqlConnection con = new SqlConnection(ConStr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("SELECT UserID FROM tblUser"))
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
            //        DataSet ds = new DataSet();
            //        da.Fill(ds, "Data");

            //        lbl_user.Text = ds.Tables[0].Rows[0]["UserID"].ToString();

            //    }
            //}
            lbl_user.Text = clsUserDetails.userID.ToString();
        }

        private void cbProject_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDateEntry da = new frmDateEntry();
            da.Show();
        }

        private void cbCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbCategory.SelectedValue.ToString());
        }

        private void tbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tbPaymentStatus.SelectedValue.ToString());
        }

        private void cbPmtMode_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cbPmtMode.SelectedValue.ToString());
        }

        private void Project_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Project.SelectedValue.ToString());
        }

        private void tbTotalPayment_TextChanged(object sender, EventArgs e)
        {
            if (tbTotalPayment.Text.Trim() == string.Empty)
            {
                tbTotalPayment.Text = "0";
            }
            else
            {
                try
                {
                    tbRemainingPayment.Text = (decimal.Parse(tbTotalPayment.Text) - decimal.Parse(tbPaidPayment.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void tbPaidPayment_TextChanged(object sender, EventArgs e)
        {
            if (tbPaidPayment.Text.Trim() == string.Empty)
            {
                tbPaidPayment.Text = "0";
            }
            else
            {
                try
                {
                    tbRemainingPayment.Text = (decimal.Parse(tbTotalPayment.Text) - decimal.Parse(tbPaidPayment.Text)).ToString();
                }
                catch (Exception ex)
                { MessageBox.Show("Error\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }
        }

        private void tbRemainingPayment_TextChanged(object sender, EventArgs e)
        {
            if (tbRemainingPayment.Text.Trim() == string.Empty)
            {
                tbRemainingPayment.Text = "0";
            }
            if (tbRemainingPayment.Text.Trim() == "0" || tbRemainingPayment.Text.Trim() == "0.00")
            {
                //tbPaymentStatus.Text = "OK";
                tbPaymentStatus.SelectedIndex = 0;
                //MessageBox.Show("COndintion met: OK");
            }
            //if (tbRemainingPayment.Text.Trim() != "0" || tbRemainingPayment.Text.Trim() != "0.00")
            else
            {
                //tbPaymentStatus.Text = "Pending";
                tbPaymentStatus.SelectedIndex = 1;
                //MessageBox.Show("COndintion met: Pending");
            }
        }

        private void PrintSlip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                DataSet company = clsCompanyInfo.fetchCompanyDetails();
                string address = company.Tables[0].Rows[0]["Address"].ToString();
                string contactInfo = company.Tables[0].Rows[0]["AdditionalInfo"].ToString();
                //HEADER
                e.Graphics.DrawString("F A Z A L", new Font("Arial", 50, FontStyle.Underline), Brushes.Black, new Point(250, 50));
                e.Graphics.DrawString("CONSTRUCTION SERVICES", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(260, 130));
                //DATE & TIME
                e.Graphics.DrawString("Date & Time: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 180));
                e.Graphics.DrawString(DateTimee.Value.ToString("dd/MM/yyyy (HH:mm)"), new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 180));
                //SERIAL #
                e.Graphics.DrawString("Serial #:  " + ID.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 180));

                //ACCOUNT INFORMATION
                e.Graphics.DrawString("Account / Sight Name: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 210));
                e.Graphics.DrawString(Project.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 210));
                //PAYMENT CATEGORY
                e.Graphics.DrawString("Payment Category: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 240));
                // e.Graphics.DrawString(cbCategory.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 240));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 260));
                e.Graphics.DrawString(cbCategory.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 240));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 1030));
                //FOOTER
                e.Graphics.DrawString(address, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 1010));
                e.Graphics.DrawString(contactInfo, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 1050));

                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 150));


                //DETAILS(
                e.Graphics.DrawString("Receiver Name:     " + tbPayee.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 280));
                e.Graphics.DrawString("Payment Title:      " + tbExp.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 300));
                e.Graphics.DrawString("Quantity:      " + tbQty.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 280));
                e.Graphics.DrawString("Amount:      " + tbAmt.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 300));
                e.Graphics.DrawString("Area:                    " + tbArea.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 320));
                e.Graphics.DrawString("Floor #:       " + tbFloor.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 320));
                e.Graphics.DrawString("Hours:                  " + tbHours.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 340));
                e.Graphics.DrawString("Minutes:      " + tbMinutes.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 340));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 350));


                e.Graphics.DrawString("Total Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 420));
                e.Graphics.DrawString(tbTotalPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 420));

                e.Graphics.DrawString("Paid Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 450));
                e.Graphics.DrawString(tbPaidPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 450));

                e.Graphics.DrawString(singleDash.Text + "---------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 460));

                e.Graphics.DrawString("Remaining Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 480));
                e.Graphics.DrawString(tbRemainingPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 480));

                e.Graphics.DrawString("Payment Status:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 510));
                e.Graphics.DrawString(tbPaymentStatus.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 510));

                e.Graphics.DrawString("Payment Mode:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 540));
                e.Graphics.DrawString(cbPmtMode.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 540));

                e.Graphics.DrawString("CHQ#:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 570));
                e.Graphics.DrawString(tbCHQNo.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 570));

                e.Graphics.DrawString(singleDash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 870));
                e.Graphics.DrawString("Paid by (signature):", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 880));

                e.Graphics.DrawString(singleDash.Text + "-----", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 870));
                e.Graphics.DrawString("Received by (signature):", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 880));
            }
            catch (Exception x)
            {
                MessageBox.Show("Error while Printing Slip.\n" + x.Message, "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clsDeleteExp.deleteExp(ID.Text);
            if (clsDeleteExp.status_id==1)
            {
                MessageBox.Show("Expense Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadClients();
            }
            else if (clsDeleteExp.status_id==0)
            {
                MessageBox.Show("Expense Not Deleted", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateExp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

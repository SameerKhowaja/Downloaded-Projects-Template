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
    public partial class frmPendingPayments : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        public frmPendingPayments()
        {
            InitializeComponent();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            loadSerialID();
        }

        private void loadSerialID()
        {
            //using (SqlConnection con = new SqlConnection(ConStr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("SELECT TransactionID FROM tblExpEntry WHERE PaymentStatusID = 2"))
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
            //        DataSet ds = new DataSet();
            //        da.Fill(ds, "Data");

            //        comboBox1.DataSource = ds.Tables[0].DefaultView;
            //        comboBox1.DisplayMember = "TransactionID";

            //        if (ds.Tables[0].Rows.Count == 0)
            //        {
            //            MessageBox.Show("No Transaction Found in System!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
        }

        private void frmPendingPayments_Load(object sender, EventArgs e)
        {
            try
            {
                loadPaymentStatus();
                populateGrid();
            }
            catch { throw; }
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

                    tbStatus.DataSource = ds.Tables[0].DefaultView;
                    tbStatus.DisplayMember = "Name";
                    tbStatus.ValueMember = "PaymentStatusID";
                    tbStatus.SelectedItem = "Cash in Hand";

                    

                }
            }
        }

        private void populateGrid()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
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
      ,tblPaymentStatus.Name AS 'Payment Status'
      ,tblPaymentMode.Name AS 'Payment Mode'
      ,tblUser.UserName
  FROM [dbo].[tblExpEntry] LEFT OUTER JOIN tblClient ON tblExpEntry.Client_ID=tblClient.Client_ID LEFT OUTER JOIN tblCategory ON tblExpEntry.CatID=tblCategory.CatID LEFT OUTER JOIN tblPaymentMode ON tblExpEntry.PaymentModeID=tblPaymentMode.PaymentModeID LEFT OUTER JOIN tblPaymentStatus ON tblExpEntry.PaymentStatusID=tblPaymentStatus.PaymentStatusID LEFT OUTER JOIN tblUser ON tblExpEntry.UserID=tblUser.UserID WHERE tblExpEntry.PaymentStatusID=2;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TBL");
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;


                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbPayNow_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbPayNow_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select Serial ID first", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (tbPayNow.Text.Trim() == string.Empty || tbPayNow.Text.Trim() == "0")
            {
                MessageBox.Show("Please enter amount to pay now", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            decimal payNow = Convert.ToDecimal(tbPayNow.Text);
            decimal remBal = Convert.ToDecimal(tbRemBalance.Text);
            if (payNow>remBal)
            {
                MessageBox.Show("Pay now can't greater than remaining Amount to pay, Try again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            update();

        }

        private void update()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = @"UPDATE [dbo].[tblExpEntry]
                 SET PaymentStatusID =@statusID, PaidPayment =PaidPayment+@payNow, Date=@date, Narration=@narrate WHERE TransactionID = @transId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@statusID", tbStatus.SelectedValue.ToString());
                    cmd.Parameters.Add("@payNow", SqlDbType.Decimal).Value = Decimal.Parse(tbPayNow.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", DateTimee.Value);
                    cmd.Parameters.AddWithValue("@transId", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@narrate", tbNarration.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully.","Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateGrid();
                    tbPayNow.Clear();
                    tbPayNow.ReadOnly = false;
                    tbTotalPayment.Clear();
                    tbRemBalance.Clear();
                    tbPaidPayment.Clear();
                    comboBox1.Clear();

                }
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    string query = "SELECT TotalPayment, PaidPayment, REM_PMT FROM tblExpEntry WHERE PaymentStatusID = 2 AND TransactionID = '"+comboBox1.Text.Trim()+"'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                       // cmd.Parameters.AddWithValue("@id", comboBox1.Text.Trim());
                        SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "TBL");
                        if (ds.Tables[0].Rows.Count<1)
	                     {
                             MessageBox.Show("Invalid Serial #, Try Again", "No data found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
	                     } 
                           
                        tbRemBalance.Text = ds.Tables[0].Rows[0]["REM_PMT"].ToString();
                        tbPaidPayment.Text = ds.Tables[0].Rows[0]["PaidPayment"].ToString();
                        tbTotalPayment.Text = ds.Tables[0].Rows[0]["TotalPayment"].ToString();
                        tbPayNow.Clear();
                        tbPayNow.ReadOnly = false;
                    }
                }
            }
            catch { throw; }
        }

        private void tbPayNow_TextChanged(object sender, EventArgs e)
        {
            if (tbTotalPayment.Text.Trim() == string.Empty)
            {
                tbTotalPayment.Text = "0";
            }
            if (tbPayNow.Text.Trim() == string.Empty)
            {
                tbPayNow.Text = "0";
            }

            if (decimal.Parse(tbPayNow.Text.Trim())>decimal.Parse(tbRemBalance.Text.Trim()))
            {
                MessageBox.Show("Invalid amount. can not greater than remaining balance"); return;
            }

            //decimal payNow = Decimal.Parse(tbPayNow.Text.Trim());
            //decimal remBal = Decimal.Parse(tbRemBalance.Text.Trim());
            try
            {
                if (Decimal.Parse(tbPayNow.Text.Trim()) == Decimal.Parse(tbRemBalance.Text.Trim()))
                {
                    tbStatus.Text = "OK";
                }
                else
                {
                    tbStatus.Text = "Pending";
                }
            }
            catch { }
            //if (tbPayNow.Text.Trim()!=string.Empty)
            //{
            //    decimal d = decimal.Parse(tbTotalPayment.Text) - decimal.Parse(tbPayNow.Text);
            //    tbRemBalance.Text = d.ToString();
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
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
      ,tblPaymentStatus.Name AS 'Payment Status'
      ,tblPaymentMode.Name AS 'Payment Mode'
      ,tblUser.UserName
  FROM [dbo].[tblExpEntry] LEFT OUTER JOIN tblClient ON tblExpEntry.Client_ID=tblClient.Client_ID LEFT OUTER JOIN tblCategory ON tblExpEntry.CatID=tblCategory.CatID LEFT OUTER JOIN tblPaymentMode ON tblExpEntry.PaymentModeID=tblPaymentMode.PaymentModeID LEFT OUTER JOIN tblPaymentStatus ON tblExpEntry.PaymentStatusID=tblPaymentStatus.PaymentStatusID LEFT OUTER JOIN tblUser ON tblExpEntry.UserID=tblUser.UserID WHERE tblExpEntry.PaymentStatusID=2 AND tblClient.ProjectName LIKE  '" + textBox1.Text + '%' + "' ;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        //cmd.Parameters.AddWithValue("@txt", textBox1.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "TBL");
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;


                    }

                }
            }
            catch {  }
        }

        private void tbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tbStatus.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void PrintSlip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {

        }

        private void SlipPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            decimal paidPayment = (decimal.Parse(tbPaidPayment.Text) + decimal.Parse(tbPayNow.Text));
            //n = (decimal.Parse(tbTotalPayment.Text) - decimal.Parse(tbPaidPayment.Text));
            decimal remainigPayment = decimal.Parse(tbTotalPayment.Text)-paidPayment;
            //MessageBox.Show(remainigPayment.ToString());
            try
            {
                //HEADER
                e.Graphics.DrawString("F A Z A L", new Font("Arial", 50, FontStyle.Underline), Brushes.Black, new Point(250, 50));
                e.Graphics.DrawString("CONSTRUCTION SERVICES", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(260, 130));
                //DATE & TIME
                e.Graphics.DrawString("Date & Time: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 180));
                e.Graphics.DrawString(DateTimee.Value.ToString("dd/MM/yyyy (HH:mm)"), new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 180));
                //SERIAL #
                e.Graphics.DrawString("Serial #:  " + comboBox1.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 180));

                //ACCOUNT INFORMATION
                //e.Graphics.DrawString("Account / Sight Name: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 210));
                //e.Graphics.DrawString(, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 210));
                //PAYMENT CATEGORY
                //e.Graphics.DrawString("Payment Category: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 240));
                //e.Graphics.DrawString(cbCat.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 240));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 260));
                //e.Graphics.DrawString(cbCat.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 240));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 1030));
                //FOOTER
                e.Graphics.DrawString("Kamran Ali - 03007602220 , Iftikhar Ahmed - 03057138762 , Asad Shah - 03009653681", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 1010));
                e.Graphics.DrawString("3RD F L O O R, B U R J-AL-K U W A I T, K O H I N O O R  C I T Y,  F A I S A L A B A D.", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 1050));

                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 150));


                //DETAILS(
               // e.Graphics.DrawString("Receiver Name:     " + tbPayee.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 280));
                e.Graphics.DrawString("Payment Title: PENDIG PAYMENT" , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 300));
               // e.Graphics.DrawString("Quantity:      " + tbQty.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 280));
               // e.Graphics.DrawString("Amount:      " + tbAmt.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 300));
               // e.Graphics.DrawString("Area:                    " + tbArea.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 320));
              //  e.Graphics.DrawString("Floor #:       " + tbFloor.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 320));
              //  e.Graphics.DrawString("Hours:                  " + tbHours.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 340));
              //  e.Graphics.DrawString("Minutes:      " + tbMinutes.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 340));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 350));


                e.Graphics.DrawString("Total Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 420));
                e.Graphics.DrawString(tbTotalPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 420));

                e.Graphics.DrawString("Paid Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 450));
                e.Graphics.DrawString(tbPaidPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 450));

                e.Graphics.DrawString(singleDash.Text + "---------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 460));

                e.Graphics.DrawString("Remaining Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 480));
                e.Graphics.DrawString(remainigPayment.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 480));

                e.Graphics.DrawString("Payment Status:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 510));
                e.Graphics.DrawString(tbStatus.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 510));

                //e.Graphics.DrawString("Payment Mode:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 540));
               // e.Graphics.DrawString(cbPmtMode.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 540));

               // e.Graphics.DrawString("CHQ#:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 570));
               // e.Graphics.DrawString(tbCHQNo.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 570));

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

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = SlipPrint;
            printPreviewDialog1.ShowDialog();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void frmPendingPayments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

      
    
    
    }
}

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
    public partial class frmDateEntry : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        //string pmtMode = "Cash in Hand";
        public frmDateEntry()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDateEntry_Load(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(ConStr))
                {
                    string query = "SELECT Exp_Title FROM tblExpEntry";
                    using(var cmd = new SqlCommand(query,con))
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                        while (reader.Read())
                        {
                            MyCollection.Add(reader.GetString(0));
                        }
                        tbExp.AutoCompleteCustomSource = MyCollection;
                    }
                }


                fetchProjects();
                fetchCategories();
                loadUser();
                loadPaymentStatus();
                loadPaymentMethod();
                generateTransactionID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error occurred! \n" + ex.Message);
                return;
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

        private void loadPaymentMethod()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PaymentModeID, Name FROM tblPaymentMode "))
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
                using (SqlCommand cmd = new SqlCommand("SELECT PaymentStatusID, Name FROM tblPaymentStatus "))
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

        private void generateTransactionID()
        {

            //try
            //{

            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = "SELECT MAX(TransactionID) AS 'ID' FROM tblExpEntry";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int n;
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    if (dt.Rows[0]["ID"].ToString() == "")
                    {
                        n = 0;
                    }
                    else
                    {
                        n = int.Parse(dt.Rows[0]["ID"].ToString());
                    }
                    lbl_ID.Text = (n + 1).ToString();
                }
            }
           
        }

        private void fetchCategories()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = "SELECT CatID AS 'ID', CatName FROM tblCategory";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);


                    cbCat.DataSource = dt;
                    cbCat.DisplayMember = "CatName";
                    cbCat.ValueMember = "ID";


                
                }
            }
        }

        public void fetchProjects()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Client_ID AS 'ID', ProjectName FROM tblClient WHERE StatusID=1 "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");


                    cb_P_ID.DataSource = ds.Tables[0].DefaultView;
                    cb_P_ID.DisplayMember = "ProjectName";
                    cb_P_ID.ValueMember = "ID";
                    
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No Client Found in System!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cb_P_ID.Text.Trim() == "" || cbCat.Text.Trim() == "")
            {
                MessageBox.Show("Project or Category Not selected. Try Again!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbPaymentStatus.SelectedIndex<0 || cbPmtMode.SelectedIndex<0)
            {
                MessageBox.Show("Please fill the form again. Some fields are not supplied, Try Again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbTotalPayment.Text.Trim() == "0")
            {
                MessageBox.Show("Total Payment Can not be Zero (0), Try Again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            highlightInput();
            if (MessageBox.Show("Are you sure you want to Insert Below Information in System?Please Note that all the Blank Fields will be consider as 0 (Zero).", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
                insertDetails();
                if (MessageBox.Show("Do you want to print slip?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    putDashInstedOfZero();
                    PrintSlip.Print();
                    generateTransactionID();
                    refreshForm();
                    tbExp.Focus();
                    return;
                }
                generateTransactionID();
                refreshForm();
                tbExp.Focus();
        }

        private void putDashInstedOfZero()
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

       

        private void refreshForm()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    textBox.BackColor = Color.White;
                    textBox.Clear();
                }
            }
           
        }

        private void insertDetails()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    string query = @"INSERT INTO tblExpEntry(Date,TransactionID,Client_ID,CatID,Narration,UserID,Exp_Title,Payee,Quantity,Amount,
                                TotalPayment, PaidPayment,PaymentStatusID,PaymentModeID,ChqNo,
                                Area,Floor,Hours,Minutes)
                                VALUES(@date,@transId,@Acc,@Cat,@narration,@uID,@Exp_title,@Payee,@Quantity, @Amount,
                                @TotalPmt, @PaidPmt, @PmtStatusID, @PmtModeID, @ChqNo,
                                @Area,@Floor,@Hours,@Minutes)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTimee.Value);
                        cmd.Parameters.Add("@transid", SqlDbType.Decimal).Value = decimal.Parse(lbl_ID.Text);
                        cmd.Parameters.Add("@Acc", SqlDbType.Int).Value=cb_P_ID.SelectedValue.ToString();
                        cmd.Parameters.Add("@Cat", SqlDbType.Int).Value=cbCat.SelectedValue.ToString();
                        cmd.Parameters.AddWithValue("@narration", tbNarration.Text.Trim());
                        cmd.Parameters.AddWithValue("@uID", lbl_user.Text);


                        cmd.Parameters.AddWithValue("@Exp_title", tbExp.Text.Trim());
                        cmd.Parameters.AddWithValue("@Payee", tbPayee.Text.Trim());
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = tbQty.Text.Trim();
                        cmd.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = tbAmt.Text.Trim();
                        cmd.Parameters.Add("@TotalPmt", SqlDbType.Decimal).Value = tbTotalPayment.Text.Trim();
                        cmd.Parameters.Add("@PaidPmt", SqlDbType.Decimal).Value = tbPaidPayment.Text.Trim();
                        //cmd.Parameters.Add("@RemainingPmt", SqlDbType.Decimal).Value = tbRemainingPayment.Text.Trim();
                        cmd.Parameters.AddWithValue("@PmtStatusID", tbPaymentStatus.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@PmtModeID", cbPmtMode.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@ChqNo", tbCHQNo.Text.Trim());
                        cmd.Parameters.Add("@Area", SqlDbType.Decimal).Value = tbArea.Text.Trim();
                        cmd.Parameters.Add("@Floor", SqlDbType.Int).Value = tbFloor.Text.Trim();
                        cmd.Parameters.Add("@Hours", SqlDbType.Int).Value = tbHours.Text.Trim();
                        cmd.Parameters.Add("@Minutes", SqlDbType.Int).Value = tbMinutes.Text.Trim();

                        con.Open();
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("INFORMATION CREATED SUCCESSFULLY.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error while Inserting Record in Database.\n" + x.Message, "New Data Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void highlightInput()
        {
          

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;

                    if (textBox.Text.Trim() == string.Empty && textBox.Name != "tbExp" && textBox.Name != "tbPayee" && textBox.Name != "tbCHQNo" && textBox.Name != "tbNarration")
                    {
                        //textBox.BackColor = Color.MistyRose;
                        //textBox.Clear();
                        textBox.Text = "0";
                    }
                }
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbProject_Click(object sender, EventArgs e)
        {
            refreshForm();
            
        }

        private void cbCategory_Click(object sender, EventArgs e)
        {
            refreshForm();
            
        }

        private void rbBank_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void tbPayee_TextChanged(object sender, EventArgs e)
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
                catch (Exception ex) { MessageBox.Show("Error\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (tbRemainingPayment.Text.Trim() == "0")
            {
                //tbPaymentStatus.Text = "OK";
                tbPaymentStatus.SelectedIndex = 0;
            }
            if (tbRemainingPayment.Text.Trim() != "0")
            {
                //tbPaymentStatus.Text = "Pending";
                tbPaymentStatus.SelectedIndex = 1;
            }
        }

        private void tbTotalPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbPaidPayment_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbPaidPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && (!char.IsControl(e.KeyChar))))
            {
                e.Handled = true;

            }
        }

        private void tbPayee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && (!char.IsControl(e.KeyChar))))
            {
                e.Handled = true;

            }
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && (!char.IsControl(e.KeyChar))))
            {
                e.Handled = true;

            }
        }

        private void tbCHQNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = PrintSlip;
            printPreviewDialog.ShowDialog();
        }

        private void PrintSlip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                DataSet company= clsCompanyInfo.fetchCompanyDetails();
                string address = company.Tables[0].Rows[0]["Address"].ToString();
                string contact = company.Tables[0].Rows[0]["AdditionalInfo"].ToString();
                //HEADER
                e.Graphics.DrawString("CONTACT FOR COMPLETE FEATURES", new Font("Arial", 50, FontStyle.Underline), Brushes.Black, new Point(250, 50));
                e.Graphics.DrawString("muhammadwaqas_ali@outlook.com", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(260, 130));
                //DATE & TIME
                e.Graphics.DrawString("Date & Time: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 180));
                e.Graphics.DrawString(DateTimee.Value.ToString("dd/MM/yyyy (HH:mm)"), new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 180));
                //SERIAL #
                e.Graphics.DrawString("Serial #:  " + lbl_ID.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 180));

               

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

        private void cbSerial_Click(object sender, EventArgs e)
        {
            refreshForm();    
        }

       

        private void cbSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fetchPendingPayments();
        }

        private void fetchPendingPayments()
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
           
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            fetchPendingPayments();
        }

        private void cb_P_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frmTrackFolding frm = new frmTrackFolding();
            //frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmStockMoving frm = new frmStockMoving();
            frm.ShowDialog();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            frmViewExpense frm = new frmViewExpense();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPendingPayments frm = new frmPendingPayments();
            frm.ShowDialog();
        }

        private void frmDateEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                fetchProjects();
                fetchCategories();
                loadUser();
                loadPaymentStatus();
                loadPaymentMethod();
                //generateTransactionID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error occurred! \n" + ex.Message);
                return;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmPendingPayments frm = new frmPendingPayments();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmRcvPmt frm = new frmRcvPmt();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmExtraExpense frm = new frmExtraExpense();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmServices frm = new frmServices();
            frm.ShowDialog();
        }

        private void tbExp_TextChanged(object sender, EventArgs e)
        {
            tbNarration.Text = tbExp.Text;
        }
        }
        
    }


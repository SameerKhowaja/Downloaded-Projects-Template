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
    public partial class frmRcvPmt : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        public frmRcvPmt()
        {
            InitializeComponent();
        }

        private void cbProject_Click(object sender, EventArgs e)
        {
            
        }

        private void loadProjects()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = "SELECT Client_ID, ProjectName FROM tblClient";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    cb_P_ID.DataSource = dt;
                    cb_P_ID.DisplayMember = "ProjectName";
                    cb_P_ID.ValueMember = "Client_ID";

                    
                    //label16.Text = dt.Rows[0]["ProjectName"].ToString();

                }
            }
        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbRcvPmt.Text.Trim() == string.Empty)
            {
                tbRcvPmt.Text = "0";
            }
        }

        private void frmRcvPmt_Load(object sender, EventArgs e)
        {
            loadPaymentMethod();
            loadUser();
            
            generateID();
        }

        private void generateID()
        {
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                string query = "SELECT MAX(RcvPmtID) AS 'ID' FROM tblReceivePayment";
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

        private void loadUser()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UserID FROM tblUser"))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");

                    lbl_user.Text = ds.Tables[0].Rows[0]["UserID"].ToString();

                }
            }
        }

        private void loadPaymentMethod()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PaymentModeID, Name FROM tblPaymentMode ", con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    cbPmtModeID.DataSource = dt;
                    cbPmtModeID.DisplayMember = "Name";
                    cbPmtModeID.ValueMember = "PaymentModeID";
                }
            }
        }

        private void tbRcvPmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPaidBy.Text.Trim()==string.Empty || tbRcvName.Text.Trim()==string.Empty || tbRcvPmt.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Some required fields are missing. please try again.", "Missing field(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            insertDetails(); 
            populateEXP();
            populateRcvAmt();
            calculateMainTotal();
            putDashes();
            PrintSlip.Print();
            generateID();
        }

        private void insertDetails()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = @"INSERT INTO [dbo].[tblReceivePayment]
           ([RcvPmtID]
           ,[RcvName]
           ,[PaidBy]
           ,[PaymentModeID]
           ,[Client_ID]
           ,[UserID]
           ,[Date]
           ,[Description]
           ,[ChqNo]
           ,[BankName]
,[RcvAmount])
            VALUES(@id, @rcvName, @paidBy, @pmtModeID, @clientid, @userid, @date, @desc, @chqNo, @bankName, @Amt)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", lbl_ID.Text);
                    cmd.Parameters.AddWithValue("@rcvName", tbRcvName.Text);
                    cmd.Parameters.AddWithValue("@paidBy", tbPaidBy.Text);
                    cmd.Parameters.Add("@pmtModeID", SqlDbType.Int).Value = int.Parse(cbPmtModeID.SelectedValue.ToString());
                    cmd.Parameters.Add("@clientid", SqlDbType.Int).Value = int.Parse(cb_P_ID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@userid", lbl_user.Text);

                    cmd.Parameters.AddWithValue("@date", DateTimee.Value);
                    cmd.Parameters.AddWithValue("@desc", tbDesc.Text);
                    cmd.Parameters.AddWithValue("@chqNo", tbChqNo.Text);
                    cmd.Parameters.AddWithValue("@bankName", tbBankName.Text);
                    cmd.Parameters.Add("@amt", SqlDbType.Decimal).Value = decimal.Parse(tbRcvPmt.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Saved Successfully", "Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    


                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            

        }

        private void calculateMainTotal()
        {
            decimal mainTotal = 0;
            mainTotal = decimal.Parse(lblRcvPayment.Text) - decimal.Parse(lblTotalExp.Text);
            lbl_m_toal.Text = mainTotal.ToString();
        }

        private void populateRcvAmt()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    string query = @"select tblClient.ProjectName,tblReceivePayment.RcvAmount, tblReceivePayment.date
                    FROM tblReceivePayment LEFT OUTER JOIN tblClient ON tblClient.Client_ID=tblReceivePayment.Client_ID 
                    WHERE tblReceivePayment.Client_ID=@id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", cb_P_ID.SelectedValue.ToString());
                        cmd.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataReader dr = cmd.ExecuteReader();
                        dt.Load(dr);
                        RcvAmtGrid.DataSource = dt;

                        decimal totalRcvAmt = 0;
                        for (int i = 0; i < RcvAmtGrid.Rows.Count; i++)
                        {
                            totalRcvAmt += decimal.Parse(RcvAmtGrid["RcvAmount", i].Value.ToString());
                        }
                        lblRcvPayment.Text = totalRcvAmt.ToString();

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error in Loading Received Payment\n" + ex.Message); }
        }

        private void populateEXP()
        {
            //try
            //{
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    string query = @"select  tblClient.ProjectName, tblCategory.CatName, tblExpEntry.TotalPayment, tblExpEntry.Exp_Title, tblExpEntry.Date from tblExpEntry  
                    LEFT OUTER JOIN tblClient ON tblClient.Client_ID=tblExpEntry.Client_ID LEFT OUTER JOIN tblCategory ON tblCategory.CatID=tblExpEntry.CatID WHERE tblExpEntry.Client_ID=@id;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.Add("@id", SqlDbType.Decimal).Value =decimal.Parse(cb_P_ID.SelectedValue.ToString());
                        cmd.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        SqlDataReader dr = cmd.ExecuteReader();
                        dt.Load(dr);
                        TotalAmtGrid.DataSource = dt;

                        calculateTotalExp();
                    }
                }
            }

        private void calculateTotalExp()
        {
            //try
            //{
            if (TotalAmtGrid.Rows.Count == 0)
            {

            }
            else
            {
                MessageBox.Show(TotalAmtGrid.Rows.Count.ToString());
                decimal totalPayment = 0;
                for (int i = 0; i < TotalAmtGrid.Rows.Count; i++)
                {
                    totalPayment += decimal.Parse(TotalAmtGrid["TotalPayment", i].Value.ToString());
                }
                lblTotalExp.Text = totalPayment.ToString();
            }
            //}
            //catch
            //{

            //}
        }
            

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cb_P_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_P_ID.SelectedValue.ToString()=="System.Data.DataRowView")
            {
                //MessageBox.Show("Row View");

                return;
            }
            else
            {
                //cb_P_ID.SelectedValue.ToString();
                populateEXP();
                populateRcvAmt();
                calculateMainTotal();
            }


            ////try
            ////{
            //    populateEXP();
            //    populateRcvAmt();
            //    calculateMainTotal();
            ////}
            ////catch { }
        }

        private void cbPmtModeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbPmtModeID.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            putDashes();
            printPreviewDialog.Document = PrintSlip;
            printPreviewDialog.ShowDialog();
        }

        private void putDashes()
        {
            foreach (Control c in splitContainer1.Panel1.Controls)
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

        private void PrintSlip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                DataSet details = clsCompanyInfo.fetchCompanyDetails();
                string address=details.Tables[0].Rows[0]["Address"].ToString();
                string contactInfo = details.Tables[0].Rows[0]["AdditionalInfo"].ToString();
                //String s = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                //HEADER
                e.Graphics.DrawString("Payment Received", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(30, 130));
                e.Graphics.DrawString("Contact for complete features", new Font("Arial", 50, FontStyle.Underline), Brushes.Black, new Point(250, 50));
                e.Graphics.DrawString("muhammadwaqas_ali@outlook.com", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(260, 130));
                //DATE & TIME
               
            }
            catch (Exception x)
            {
                MessageBox.Show("Error while Printing Slip.\n" + x.Message, "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cb_P_ID_Click(object sender, EventArgs e)
        {
            loadProjects();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUpdateRcvPmt update = new frmUpdateRcvPmt();
            update.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmViewRcvPmt frm = new frmViewRcvPmt();
            frm.ShowDialog();
        }

        private void frmRcvPmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

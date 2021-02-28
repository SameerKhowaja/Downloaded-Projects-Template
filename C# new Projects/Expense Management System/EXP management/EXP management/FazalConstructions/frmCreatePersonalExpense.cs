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
    public partial class frmCreatePersonalExpense : Form
    {
        string companyAddress;
        string companyContact;
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
         SqlDataAdapter da = new SqlDataAdapter();
       DataSet ds;
      

        public static string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        
        public frmCreatePersonalExpense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmCreatePersonalExpense_Load(object sender, EventArgs e)
        {
            ID.Text = CreateDBID.CreateID("tblPersonalExp", "ID").ToString();

            loadPreviousItems();
            //ExpDgv.DataSource = clsLoadPersonalExp.selectData();
            ExpDgv.DataSource = (clsLoadPersonalExp.selectData()).Tables[0];


            populateTitle();
        }

        private void populateTitle()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Title FROM tblPersonalExp"))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");

                    cbExpTitle.DataSource = ds.Tables[0].DefaultView;
                    cbExpTitle.DisplayMember = "Title";
                    //cbExpTitle.ValueMember = ds.Tables[0].Rows[0]["AdditionalInfo"].ToString();

                }



            }
        }

        private void loadPreviousItems()
        {
            try
            {
                loadExp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading previous items" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void loadExp()
        {
            con = new SqlConnection(ConStr);
            con.Open();
            string query = "SELECT * FROM tblPersonalExp";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            da = new SqlDataAdapter(cmd.CommandText, con);
            da.Fill(ds, "DATA");
            ExpDgv.DataSource = ds.Tables[0].DefaultView;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbExpTitle.Text.Trim()==string.Empty || tbAmt.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Some Required fields are not provided. Try Again", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsCreatePersonalExp.CreatePerExp(ID.Text, cbExpTitle.Text, tbDescription.Text, decimal.Parse(tbAmt.Text), int.Parse(tbQty.Text), DateTimee.Value, tbRecName.Text);
            if (clsCreatePersonalExp.status_id==1)
            {
                MessageBox.Show("Expense Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (MessageBox.Show("Print Slip?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SlipPrint.Print();
                }
                ID.Text = CreateDBID.CreateID("tblPersonalExp", "ID").ToString();
                tbAmt.Clear();
                tbDescription.Clear();
                //cbExpTitle.Items.Clear();
                populateTitle();
                tbQty.Clear();
                tbRecName.Clear();
                loadExp();
                cbExpTitle.Text = "";
            }
            else if ((clsCreatePersonalExp.status_id == 0))
            {
                MessageBox.Show("Expense did not created successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ExpDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ExpDgv.Rows[e.RowIndex];
                frmViewPersonalExp frm = new frmViewPersonalExp();



                frm.cbExpTitle.Text = row.Cells["Title"].Value.ToString();
                frm.tbAmt.Text = row.Cells["Amount"].Value.ToString();
                frm.tbQty.Text = row.Cells["Quantity"].Value.ToString();

                frm.tbRecName.Text = row.Cells["Receiver"].Value.ToString();

                frm.updateID.Text = row.Cells["ID"].Value.ToString();
                frm.tbDescription.Text = row.Cells["Description"].Value.ToString();
                //frm.pictureBox1.Image = row.Cells["IMG"].Value;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query="DELETE FROM tblPersonalExp WHERE ID=@id ";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.Parse(updateID.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    tbAmt.Clear();
                    tbDescription.Clear();
                    tbQty.Clear();
                    tbRecName.Clear();
                    
                    updateID.Text = "";
                    loadExp();

                }
            }
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            if (tbQty.Text.Trim()==string.Empty)
            {
                tbQty.Text = "0";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rptViewPersonalExp rpt = new rptViewPersonalExp();
            rpt.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            rptViewPersonalExp rpt = new rptViewPersonalExp();
            rpt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = SlipPrint;
            printPreviewDialog.ShowDialog();
        }

        private void SlipPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                fetchCompanyInfo();

                //HEADER
                e.Graphics.DrawString("F A Z A L", new Font("Arial", 50, FontStyle.Underline), Brushes.Black, new Point(250, 50));
                e.Graphics.DrawString("CONSTRUCTION SERVICES", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(260, 130));
                //DATE & TIME
                e.Graphics.DrawString("Date & Time: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 180));
                e.Graphics.DrawString(DateTimee.Value.ToString("dd/MM/yyyy (HH:mm)"), new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 180));
                //SERIAL #
                e.Graphics.DrawString("Serial #:  " + ID.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 180));

                //ACCOUNT INFORMATION
                //e.Graphics.DrawString("Account / Sight Name: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 210));
                //e.Graphics.DrawString(cb_P_ID.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 210));
                //PAYMENT CATEGORY
                e.Graphics.DrawString("Payment Title: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 240));
                e.Graphics.DrawString(cbExpTitle.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 240));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 260));
               // e.Graphics.DrawString(cbCat.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 240));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 1030));
                //FOOTER
                e.Graphics.DrawString(companyAddress, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 1010));
                e.Graphics.DrawString(companyContact, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 1050));

                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 150));


                //DETAILS(
                e.Graphics.DrawString("Personal Expense", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 140));
                e.Graphics.DrawString("Receiver Name:     " + tbRecName.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 280));
               // e.Graphics.DrawString("Payment Title:      " + tbExp.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 300));
                e.Graphics.DrawString("Quantity:      " + tbQty.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 280));
                e.Graphics.DrawString("Amount:                 " + tbAmt.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 300));
                //e.Graphics.DrawString("Area:                    " + tbArea.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 320));
                //e.Graphics.DrawString("Floor #:       " + tbFloor.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 320));
                //e.Graphics.DrawString("Hours:                  " + tbHours.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 340));
                //e.Graphics.DrawString("Minutes:      " + tbMinutes.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 340));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 350));


                //e.Graphics.DrawString("Total Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 420));
                //e.Graphics.DrawString(tbTotalPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 420));

                //e.Graphics.DrawString("Paid Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 450));
                //e.Graphics.DrawString(tbPaidPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 450));

              //  e.Graphics.DrawString(singleDash.Text + "---------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 460));

               // e.Graphics.DrawString("Remaining Payment:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 480));
               // e.Graphics.DrawString(tbRemainingPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 480));

              //  e.Graphics.DrawString("Payment Status:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 510));
              //  e.Graphics.DrawString(tbPaymentStatus.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, 510));

              //  e.Graphics.DrawString("Payment Mode:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 540));
              //  e.Graphics.DrawString(cbPmtMode.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 540));

              //  e.Graphics.DrawString("CHQ#:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 570));
              //  e.Graphics.DrawString(tbCHQNo.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 570));

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

        private void fetchCompanyInfo()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Address, AdditionalInfo FROM tblCompanySetup"))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");

                    companyAddress = ds.Tables[0].Rows[0]["Address"].ToString();
                    companyContact = ds.Tables[0].Rows[0]["AdditionalInfo"].ToString();

                }
            }
        }
    }
}

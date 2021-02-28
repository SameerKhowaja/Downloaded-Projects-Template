using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace FazalConstructions
{
    public partial class frmExpDetails : Form
    {
        string companyAddress;
        string companyContact;
        string imgLoc_Upload;
        string ConStr = DBConnection.ConStr;
        public frmExpDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fbd = new SaveFileDialog();
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    string path = fbd.FileName; 
                    pictureBox1.Image.Save(path + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    MessageBox.Show("Image saved to location: " + fbd.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {      
                    MessageBox.Show("Image not saved successfully. \nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            
            
        }

        private void frmExpDetails_Load(object sender, EventArgs e)
        {

        }

        private void PrintSlip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
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
                //HEADER
                e.Graphics.DrawString("F A Z A L", new Font("Arial", 50, FontStyle.Underline), Brushes.Black, new Point(250, 50));
                e.Graphics.DrawString("CONSTRUCTION SERVICES", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(260, 130));
                //DATE & TIME
                e.Graphics.DrawString("Date & Time: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 180));
                e.Graphics.DrawString(DateTimee.Value.ToString("dd/MM/yyyy (HH:mm)"), new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 180));
                //SERIAL #
                e.Graphics.DrawString("Serial #:  " + lbl_ID.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 180));

                //ACCOUNT INFORMATION
                e.Graphics.DrawString("Account / Sight Name: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 210));
                e.Graphics.DrawString(tbAcc.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 210));
                //PAYMENT CATEGORY
                e.Graphics.DrawString("Payment Category: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 240));
                e.Graphics.DrawString(tbCat.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 240));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 260));
                e.Graphics.DrawString(tbCat.Text, new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(210, 240));
                //DASH
                e.Graphics.DrawString(dash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 1030));
                //FOOTER
                e.Graphics.DrawString(companyContact, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 1010));
                e.Graphics.DrawString(companyContact, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 1050));

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
                e.Graphics.DrawString(tbPaymentMode.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 540));

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

        private void button3_Click(object sender, EventArgs e)
        {
            PrintSlip.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(imgLoc_Upload))
            {
                MessageBox.Show("Please Select Image by clicking picture box.", "Image not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "UPDATE tblExpEntry SET IMG = @image WHERE TransactionID=@id";

            byte[] img = processImage();

            using (var con = new SqlConnection(ConStr))
            {
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@image", SqlDbType.Image).Value = img;
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.Parse(lbl_ID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Image Uploaded successfully", "Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
             private byte[] processImage()
        {
            
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc_Upload, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                return img;
            }

             private void pictureBox1_Click(object sender, EventArgs e)
             {
                 try
                 {
                     OpenFileDialog ofd = new OpenFileDialog();
                     ofd.Filter = "Image File (*.png; *.jpg; *.bmp; *.gif)|*.png; *.jpg; *.bmp; *.gif";
                     ofd.Title = "Select Image to Upload";
                     if (ofd.ShowDialog() == DialogResult.OK)
                     {
                         imgLoc_Upload = ofd.FileName.ToString();
                         pictureBox1.Image = new Bitmap(ofd.FileName);
                         pictureBox1.ImageLocation = imgLoc_Upload;
                     }
                 }
                 catch (Exception ex)
                 {

                     MessageBox.Show(ex.Message);
                 }
             }

             private void frmExpDetails_KeyDown(object sender, KeyEventArgs e)
             {
                 if (e.KeyCode == Keys.Escape)
                 {
                     this.Close();
                 }
             }
        }
    }


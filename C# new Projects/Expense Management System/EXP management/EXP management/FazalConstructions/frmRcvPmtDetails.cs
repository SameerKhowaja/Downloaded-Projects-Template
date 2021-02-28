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
    public partial class frmRcvPmtDetails : Form
    {
        string companyAddress;
        string companyContact;
        string ConStr = DBConnection.ConStr;
        string imgLoc_Upload;
        public frmRcvPmtDetails()
        {
            InitializeComponent();
        }

        private void frmRcvPmtDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fbd = new SaveFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(imgLoc_Upload))
            {
                MessageBox.Show("Please Select Image by clicking picture box.", "Image not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "UPDATE tblReceivePayment SET IMG = @image WHERE RcvPmtID=@id";

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

            private void PrintSlip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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

                 try
                 {
                     //String s = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                     //HEADER
                     e.Graphics.DrawString("muhammadwaqas_ali@outlook.com", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(30, 130));
                     e.Graphics.DrawString("Contact For COmplete Features", new Font("Arial", 50, FontStyle.Underline), Brushes.Black, new Point(250, 50));


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

            private void frmRcvPmtDetails_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
        }
    }


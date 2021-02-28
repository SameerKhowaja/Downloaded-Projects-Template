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
    public partial class frmUploadImages : Form
    {

        //picture saving
        string uploadQuery;
        string imgLoc_Upload;
        string sqlQuery;
        private static string ConStr = DBConnection.ConStr;
        public frmUploadImages()
        {
            InitializeComponent();
        }

        private void frmUploadImages_Load(object sender, EventArgs e)
        {
            loadProjects();
//cbProject.ValueMember = "0";
        }

        private void loadProjects()
        {
            using (var con = new SqlConnection(ConStr))
            {
                using (var cmd = new SqlCommand("SELECT Client_ID AS 'ID', ProjectName FROM tblClient "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");
                    cbProject.DataSource = ds.Tables[0].DefaultView;
                    cbProject.DisplayMember = "ProjectName";
                    cbProject.ValueMember = "ID";
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
                    pbImg.Image = new Bitmap(ofd.FileName);
                    pbImg.ImageLocation = imgLoc_Upload;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cbCat.SelectedIndex.ToString());
            if (cbCat.SelectedIndex==0)
            {
                tbSerial.Enabled = true;
                cbProject.Enabled = true;
                
            }
            else
            {
                //cbProject.DataSource = null;
                tbSerial.Enabled = false;
                //cbProject.Enabled = false;
            }
            if (cbCat.SelectedIndex == 1 || cbCat.SelectedIndex == 2)
            {
                tbSerial.Enabled = true; btnFetch.Enabled = true;
            }
            else
            {
                tbSerial.Enabled = false; btnFetch.Enabled = false ;
            }
        }

        private void tbSerial_TextChanged(object sender, EventArgs e)
        {
            if (tbSerial.Text.Trim()!=string.Empty)
            {
                btnFetch.Enabled = true;
            }
            else
            {
                btnFetch.Enabled = false;
                tbClientName.Clear();
            }
        }

        private void tbSerial_Click(object sender, EventArgs e)
       {
        }

        private void tbSerial_KeyPress(object sender, KeyPressEventArgs e)
        {

            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (cbCat.SelectedIndex<0)
            {
                MessageBox.Show("Please select image category", "Category not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pbImg.Image==null)
            {
                MessageBox.Show("Please select Image to upload.", "Image not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbImg.Focus();
                return;
            }

            if (cbCat.SelectedIndex==0)
            {
                uploadQuery = "UPDATE tblClient SET Aggreement_IMG = @image_upload WHERE Client_ID = @clientId";
            }
            if (cbCat.SelectedIndex == 1)
            {
                if (tbClientName.Text.Trim()==string.Empty || tbSerial.Text.Trim()==string.Empty)
                {
                    MessageBox.Show("Please select ID first and try again", "ID Not supplied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSerial.Focus();
                    return;
                }
                uploadQuery = "UPDATE tblExpEntry SET IMG = @image_upload WHERE TransactionID = @expTranId";
            }
            if (cbCat.SelectedIndex == 2)
            {
                if (tbClientName.Text.Trim() == string.Empty || tbSerial.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please select ID first and try again", "ID Not supplied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSerial.Focus();
                    return;
                }
                uploadQuery = "UPDATE tblReceivePayment SET IMG = @image_upload WHERE RcvPmtID = @rcvPmtID";
            }


            byte[] img_upload = processImage();
            
            using (var con = new SqlConnection(ConStr))
            {
                using (var cmd = new SqlCommand(uploadQuery, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@image_upload", SqlDbType.Binary).Value = img_upload;
                    cmd.Parameters.AddWithValue("@clientId", SqlDbType.Int).Value = int.Parse(cbProject.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@expTranId", SqlDbType.Int).Value = int.Parse(tbSerial.Text.Trim());
                    cmd.Parameters.AddWithValue("@rcvPmtID", SqlDbType.Int).Value = int.Parse(tbSerial.Text.Trim());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Image Saved Successfully");
                    tbClientName.Clear();
                    pbImg.Image = null;
                }
            }            
        }

        private byte[] processImage()
        {
            byte[] img_upload = null;
            FileStream fs = new FileStream(imgLoc_Upload, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img_upload = br.ReadBytes((int)fs.Length);//image to save(binary form)
            return img_upload;
        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (cbCat.SelectedIndex==1)//scanned image of exp
            {
                sqlQuery = @"select tblClient.ProjectName 
                from tblStockManagement LEFT OUTER JOIN tblClient 
                ON tblStockManagement.Client_ID=tblClient.Client_ID 
                WHERE TransactionID=@transid;";
            }
            if (cbCat.SelectedIndex == 2)//receive payment
            {
                sqlQuery = @"select tblClient.ProjectName 
                from tblReceivePayment LEFT OUTER JOIN tblClient 
                ON tblReceivePayment.Client_ID=tblClient.Client_ID 
                WHERE tblReceivePayment.RcvPmtID = @pmtId;";
            }

            using(var con = new SqlConnection(ConStr))
            {
                using (var cmd = new SqlCommand(sqlQuery, con))
                {
                    tbClientName.Text = "";
                    con.Open();
                    cmd.Parameters.AddWithValue("@transid", SqlDbType.Int).Value=int.Parse(tbSerial.Text.Trim());
                    cmd.Parameters.AddWithValue("@pmtId", SqlDbType.Int).Value = int.Parse(tbSerial.Text.Trim());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tbl");
                    if (ds.Tables[0].Rows.Count<1)
                    {
                        tbClientName.Text = "";
                        MessageBox.Show("Invalid Serial # or ID", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    tbClientName.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
        }

        private void frmUploadImages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

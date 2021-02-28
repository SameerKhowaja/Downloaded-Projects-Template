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
using System.IO;
using System.Configuration;
namespace FazalConstructions
{
    public partial class frmCreateOrManageClients : Form
    {

        //string imgLocAgg;

        //string imgLocCNIC;
        //byte[] imgCNIC = null;
        //byte[] imgAGG = null;
        
        string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        public frmCreateOrManageClients()
        {
            InitializeComponent();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            //allows only string, white space and backspace key
            if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar) && (!char.IsControl(e.KeyChar))))
            {
                e.Handled = true;

            }
        }

        private void tbCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbLandLine_TextChanged(object sender, EventArgs e)
        {
            //this will allow only digits 
            
        }

        private void tbCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbLandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCell.Text.Trim() == "" || tbCNIC.Text.Trim() == "" || tbName.Text.Trim() == "" || tbPresentAddress.Text.Trim() == "" || tbProjectName.Text.Trim() == "")
            {
                if (MessageBox.Show("Some Required Fields are not provided. Please Try Again!", "Required Field(s) Missing", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    this.Close();
                    return;
                }
                else
                {
                    return;
                }
            }
            insertClientData();
        }


        private void insertClientData()
        {

           


            int client_status=1;
            if (rbActive.Checked)
            {
                client_status = 1;
            }
            if (rbInactive.Checked)
            {
                client_status = 2;
            }
            using (SqlConnection con = new SqlConnection(ConStr))
            {

//                string query = @"INSERT INTO tblClient(DateTime, Status, LandLine,Client_ID, FullName,CNICNo, PresentAddress, Cell,Country,City,ProjectName,Comments)
//                                    VALUES('" + DateTimee.Value + "','" + client_status + "','" + tbLandLine.Text.Trim() + "','" + lbl_ID.Text + "','" + tbName.Text.Trim() + "', '"+tbCNIC.Text.Trim()+"', '" + tbPresentAddress.Text.Trim() + "', '" + tbCell.Text.Trim() + "', '" + cbCountry.Text.Trim() + "', '" + cbCity.Text.Trim() + "', '" + tbProjectName.Text.Trim() + "', '" + tbComments.Text.Trim() + "')";
                string query = @"INSERT INTO tblClient([Client_ID]
      ,[FullName]
      ,[LandLine]
      ,[CNICNo]
      ,[PresentAddress]
      ,[Cell]
      ,[Country]
      ,[City]
      ,[ProjectName]
      ,[Comments]
      ,[DateTime]
      ,[StatusID])VALUES(@clientid,@name, @landline,@cnic,@presentaddress,@cell,@country,@city,@projectName,@comments,@datetime,@status)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.Parameters.AddWithValue("@clientid", SqlDbType.Int).Value = int.Parse(lbl_ID.Text.Trim());
                    cmd.Parameters.AddWithValue("@cnic", SqlDbType.NVarChar).Value = tbCNIC.Text.Trim();
                    cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = tbName.Text.Trim();
                    cmd.Parameters.AddWithValue("@landline", SqlDbType.NVarChar).Value = tbLandLine.Text.Trim();
                    cmd.Parameters.AddWithValue("@presentaddress", SqlDbType.NVarChar).Value = tbPresentAddress.Text.Trim();
                    cmd.Parameters.AddWithValue("@cell", SqlDbType.NVarChar).Value = tbCell.Text.Trim();
                    cmd.Parameters.AddWithValue("@country", SqlDbType.NVarChar).Value = cbCountry.Text.Trim();
                    cmd.Parameters.AddWithValue("@city", SqlDbType.NVarChar).Value = cbCity.Text.Trim();
                    cmd.Parameters.AddWithValue("@projectName", SqlDbType.NVarChar).Value = tbProjectName.Text.Trim();
                    cmd.Parameters.AddWithValue("@comments", SqlDbType.NVarChar).Value = tbComments.Text.Trim();
                    cmd.Parameters.AddWithValue("@datetime", SqlDbType.DateTime).Value = DateTimee.Value;
                    cmd.Parameters.AddWithValue("@status", SqlDbType.Int).Value = client_status;

                    
                    cmd.ExecuteNonQuery();
                    generateClientID();
                    MessageBox.Show("Client " + tbName.Text.Trim() + " Created Successfully!", "New Client Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear all textboxes
                    clearButtons();
                    rbActive.Checked = true;
                }
            }
        }

        private void clearButtons()
        {
            cbCity.Clear(); cbCountry.Clear();  tbCell.Clear(); tbProjectName.Clear(); tbName.Clear(); tbComments.Clear(); tbCNIC.Clear(); tbLandLine.Clear(); tbPresentAddress.Clear();
        }

    

        private void pbCNIC_Click(object sender, EventArgs e)
        {
         
                
           

        }

        private void pbAggrement_Click(object sender, EventArgs e)
        {
   

        }

        private void frmCreateOrManageClients_Load(object sender, EventArgs e)
        {
            var bmp = Properties.Resources.no_image_available;
            var bmp2 = Properties.Resources.no_image_available;
            //GENERATE CLIENT ID:
            generateClientID();
            DateTimee.MaxDate = DateTime.Now;    
        }

        private void generateClientID()
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(ConStr))
                {
                    string query = "SELECT MAX(Client_ID) AS 'ID' FROM tblClient";
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
            catch
            {
                MessageBox.Show("Error in Generating auto Client ID. Try Again!", "Client ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void cbEdit_SelectedIndexChanged(object sender, EventArgs e)
        {  
            
        }

        private void cbEdit_Click(object sender, EventArgs e)
        {
            loadCBUpdate();
        }

        private void loadCBUpdate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT ProjectName, Client_ID FROM tblClient "))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Data");

                        cbEdit.DataSource = ds.Tables[0].DefaultView;
                        cbEdit.DisplayMember = "ProjectName";
                        cbEdit.ValueMember = "Client_ID";
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("No Client Found in System!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error occurred! \n" + ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection con = new SqlConnection(ConStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblClient WHERE Client_ID=@id", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value =int.Parse(cbEdit.SelectedValue.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {

                            lbl_C_ID.Text = reader["Client_ID"].ToString();
                            tbName.Text = reader["FullName"].ToString();
                            tbCNIC.Text = reader["CNICNo"].ToString();
                            tbPresentAddress.Text = reader["PresentAddress"].ToString();
                            tbCell.Text = reader["Cell"].ToString();
                            cbCity.Text = reader["City"].ToString();
                            cbCountry.Text = reader["Country"].ToString();
                            tbProjectName.Text = reader["ProjectName"].ToString();
                            tbComments.Text = reader["Comments"].ToString();
                            tbLandLine.Text = reader["LandLine"].ToString();
                            LBL_DATE.Text = reader["DateTime"].ToString();
                            if (reader["StatusID"].ToString() == "1")
                            {
                                rbActive.Checked = true;
                            }
                            else
                            {
                                rbInactive.Checked = true;
                            }
                            gbox_New.Enabled = true;
                            btnDelete.Enabled = true;
                        }          
                    }
                }
                catch (Exception ex)
                {
                    if (ex is System.IndexOutOfRangeException)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("System Error Occurred while getting data back\n" + ex.Message);
                    }


                }
            }
        }

        private void rbCreate_CheckedChanged(object sender, EventArgs e)
        {
            clearButtons();
            if (rbCreate.Checked)
            {
                btnCreateNewAccount.Enabled = true;
                gbox_update.Enabled = false;
                btnDelete.Enabled = false;
                gbox_New.Enabled = true;
                lbl_C_ID.Text = "";
                LBL_DATE.Text = "";
            }
            else
            {
                btnCreateNewAccount.Enabled = false;
                gbox_New.Enabled = false;
            }
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            clearButtons();
            if (rbUpdate.Checked)
            {
                btnUpdateExistingAccount.Enabled = true;
                gbox_update.Enabled = true;
                btnDelete.Enabled = true;
                lbl_C_ID.Text = "";
                LBL_DATE.Text = "";
                
            }
            else
            {
                btnUpdateExistingAccount.Enabled = false ;
                lbl_C_ID.Text = "";
                gbox_update.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnUpdateExistingAccount_Click(object sender, EventArgs e)
        {
            //Input Validations
            if (tbCell.Text.Trim() == "" || tbCNIC.Text.Trim() == "" || tbName.Text.Trim() == "" || tbPresentAddress.Text.Trim() == "" || tbProjectName.Text.Trim() == "")
            {
                if (MessageBox.Show("Some Required Fields are not provided. Please Try Again!", "Required Field(s) Missing", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    this.Close();
                    return;
                }
                else
                {
                    return;
                }
            }
            if (lbl_C_ID.Text=="")
            {
                MessageBox.Show("Please Select Project from  list to Update or Delete Information.", "Select Project to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int client_status = activeOrInactive();
            UPDATE(client_status);            
        }

        private void UPDATE(int client_status)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {

                    //string query = @"UPDATE tblClient SET Status='" + client_status + "',DateTime='" + DateTimee.Value + "', LandLine ='" + tbLandLine.Text.Trim() + "', CNICNo = '" + tbCNIC.Text.Trim() + "', FullName='" + tbName.Text.Trim() + "', PresentAddress = '" + tbPresentAddress.Text.Trim() + "', City = '" + cbCity.Text.Trim() + "', Country = '" + cbCountry.Text.Trim() + "', ProjectName = '" + tbProjectName.Text.Trim() + "', Cell='" + tbCell.Text.Trim() + "', Comments = '" + tbComments.Text.Trim() + "' WHERE Client_ID='" + lbl_C_ID.Text.Trim() + "'";
                    string query = @"UPDATE tblClient SET 
        
      [FullName]=@name
      ,[LandLine]=@landline
      ,[CNICNo]=@cnic
      ,[PresentAddress]=@address
      ,[Cell]=@cell
      ,[Country]=@country
      ,[City]=@city
      ,[ProjectName]=@projectName
      ,[Comments]=@comments
      ,[DateTime]=@dt
      ,[StatusID]=@statusID WHERE Client_ID=@updateId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@updateId", SqlDbType.Int).Value = int.Parse(cbEdit.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@cnic", SqlDbType.NVarChar).Value = tbCNIC.Text.Trim();
                        cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = tbName.Text.Trim();
                        cmd.Parameters.AddWithValue("@landline", SqlDbType.NVarChar).Value = tbLandLine.Text.Trim();
                        cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = tbPresentAddress.Text.Trim();
                        cmd.Parameters.AddWithValue("@cell", SqlDbType.NVarChar).Value = tbCell.Text.Trim();
                        cmd.Parameters.AddWithValue("@country", SqlDbType.NVarChar).Value = cbCountry.Text.Trim();
                        cmd.Parameters.AddWithValue("@city", SqlDbType.NVarChar).Value = cbCity.Text.Trim();
                        cmd.Parameters.AddWithValue("@projectName", SqlDbType.NVarChar).Value = tbProjectName.Text.Trim();
                        cmd.Parameters.AddWithValue("@comments", SqlDbType.NVarChar).Value = tbComments.Text.Trim();
                        cmd.Parameters.AddWithValue("@dt", SqlDbType.DateTime).Value = DateTimee.Value;
                        cmd.Parameters.AddWithValue("@statusID", SqlDbType.Int).Value = client_status;



                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Client " + tbName.Text + "'s Record Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl_C_ID.Text = "";
                        clearButtons();
                        rbActive.Checked = true;
                        LBL_DATE.Text = "";
                        loadCBUpdate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error while Updating client from system\n" + ex.Message);
                return;
            }
        }

        private int activeOrInactive()
        {
            int client_status = 1;
            if (rbActive.Checked)
            {
                client_status = 1;
            }
            if (rbInactive.Checked)
            {
                client_status = 2;
            }
            return client_status;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbl_C_ID.Text == "")
            {
                MessageBox.Show("Please Select Project from  list to Update or Delete Information.", "Select Project to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM tblClient WHERE Client_ID = @id", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id",SqlDbType.Int).Value=int.Parse(cbEdit.SelectedValue.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Client Associated with Project " + tbProjectName.Text.Trim() + " deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearButtons();
                        LBL_DATE.Text = "";
                        generateClientID();
                        lbl_C_ID.Text = "";
                        loadCBUpdate();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error occurred while deleting account from system. Try Again\n" + ex.Message);
                return;
            }


            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void frmCreateOrManageClients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

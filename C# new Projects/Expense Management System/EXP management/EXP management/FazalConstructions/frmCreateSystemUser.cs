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

namespace FazalConstructions
{
    public partial class frmCreateSystemUser : Form
    {
        int id;
        private static string ConStr = DBConnection.ConStr;
        public frmCreateSystemUser()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbRole.SelectedIndex<0)
            {
                MessageBox.Show("Please select User Role first.", "Field(s) missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbUsername.Text.Trim()==string.Empty || tbPassword.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Some required field(s) are empty. Try again.", "Field(s) missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string clearText = tbPassword.Text.Trim();
            string cipherText = Encryption.Encrypt(clearText, true);
            string password = cipherText;

            using (var con = new SqlConnection (ConStr))
            {
                string query="INSERT INTO tblUser (UserID, Username, Password, FirstName, LastName,Cell,Address,Notes,DateTime,RoleID)VALUES(@id, @username,@password,@fname,@lname,@cell,@address,@notes,@datetime,@RoleID)";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value=tbUsername.Text.Trim();
                    cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;
                    cmd.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value=tbFname.Text.Trim();
                    cmd.Parameters.AddWithValue("@lname", SqlDbType.NVarChar).Value=tbLname.Text.Trim();
                    cmd.Parameters.AddWithValue("@cell", SqlDbType.NVarChar).Value=tbCell.Text.Trim();
                    cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value=tbAddress.Text.Trim();
                    cmd.Parameters.AddWithValue("@notes", SqlDbType.NVarChar).Value=tbNotes.Text.Trim();
                    cmd.Parameters.AddWithValue("@datetime", SqlDbType.DateTime).Value=DateTimee.Value;
                    cmd.Parameters.AddWithValue("@RoleID", SqlDbType.Int).Value = int.Parse(cbRole.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Created");
                    id = CreateDBID.CreateID("tblUser", "UserID");
                    loadGrid();

                }
            }



        }

        private void frmCreateSystemUser_Load(object sender, EventArgs e)
        {
             id = CreateDBID.CreateID("tblUser", "UserID");
             loadCBox();

             loadGrid();

        }

        private void loadGrid()
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = @"SELECT [UserID]
      ,[UserName]
      ,[Password]
      ,[FirstName]
      ,[LastName]
      ,[Cell]
      ,[Address]
      ,[Notes]
      ,[DateTime]
      ,tblUserRole.Name as 'Role'
  FROM [FCProject].[dbo].[tblUser] LEFT OUTER JOIN tblUserRole ON tblUserRole.RoleID=tblUser.RoleID";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet datas = new DataSet();
                    da.Fill(datas);
                    dataGridView1.DataSource = datas.Tables[0].DefaultView;
                }
            }
        }

        private void loadCBox()
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT Name,RoleID FROM tblUserRole";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    cbRole.DataSource = ds.Tables[0].DefaultView;
                    cbRole.DisplayMember = "Name";
                    cbRole.ValueMember = "RoleID";

                    
                }
            }
        }

        private void cbRole_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            frmUserDetails frm = new frmUserDetails();

            try
            {
                frm.tbFname.Text = row.Cells["FirstName"].Value.ToString();
                frm.tbLname.Text = row.Cells["LastName"].Value.ToString();
                frm.tbUsername.Text = row.Cells["Username"].Value.ToString();
                frm.tbCell.Text = row.Cells["Cell"].Value.ToString();
                frm.tbAddress.Text = row.Cells["Address"].Value.ToString();
                frm.tbNotes.Text = row.Cells["Notes"].Value.ToString();
                frm.cbRole.Text = row.Cells["Role"].Value.ToString();
                frm.lblUpdateID.Text = row.Cells["UserID"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while displaying details page. please verify user details and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            

            string cipherText = row.Cells["Password"].Value.ToString();
            string decryptedText = Encryption.Decrypt(cipherText, true);
            frm.tbPassword.Text = decryptedText;

            frm.Show();

        }

        private void frmCreateSystemUser_Activated(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void frmCreateSystemUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

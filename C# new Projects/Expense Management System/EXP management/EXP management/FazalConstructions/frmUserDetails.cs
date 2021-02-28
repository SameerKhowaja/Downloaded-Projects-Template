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
    public partial class frmUserDetails : Form
    {
        string ConStr = DBConnection.ConStr;
        public frmUserDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim() == string.Empty || tbPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Some required field(s) are empty. Try again.", "Field(s) missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string clearText = tbPassword.Text.Trim();
            string cipherText = Encryption.Encrypt(clearText, true);
            string password = cipherText;

            using (var con = new SqlConnection (ConStr))
            {
                string query = "UPDATE tblUser SET Username=@user, Password=@pass, FirstName=@fname, LastName=@lname,Cell=@cell,Address=@address,Notes=@notes,DateTime=@dt WHERE UserID=@userid";
                using (var cmd = new SqlCommand (query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = int.Parse(lblUpdateID.Text);
                    cmd.Parameters.AddWithValue("@User", SqlDbType.NVarChar).Value = tbUsername.Text.Trim();
                    cmd.Parameters.AddWithValue("@pass", SqlDbType.NVarChar).Value = password;
                    cmd.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = tbFname.Text.Trim();
                    cmd.Parameters.AddWithValue("@lname", SqlDbType.NVarChar).Value = tbLname.Text.Trim();
                    cmd.Parameters.AddWithValue("@cell", SqlDbType.NVarChar).Value = tbCell.Text.Trim();
                    cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = tbAddress.Text.Trim();
                    cmd.Parameters.AddWithValue("@notes", SqlDbType.NVarChar).Value = tbNotes.Text.Trim();
                    cmd.Parameters.AddWithValue("@dt", SqlDbType.DateTime).Value = DateTimee.Value;
                    //cmd.Parameters.AddWithValue("@RoleID", SqlDbType.Int).Value = int.Parse(cbRole.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Created");
                    

                }
            }
        }

        private void frmUserDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

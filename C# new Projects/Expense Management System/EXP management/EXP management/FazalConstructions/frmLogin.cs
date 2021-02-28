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
    public partial class frmLogin : Form
    {
        string ConStr = DBConnection.ConStr;
        //string role;
        int role;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //using (var con = new SqlConnection(ConStr))
            //{
            //    string query = "SELECT * FROM tblUser";
            //    using (var cmd= new SqlCommand(query,con))
            //    {
            //        con.Open();
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataSet ds = new DataSet();
            //        da.Fill(ds);
            //        comboBox1.DataSource=ds.Tables[0].DefaultView;
            //        comboBox1.DisplayMember="UserName";
            //        comboBox1.ValueMember="UserID";
                    
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please enter password", "Password missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT Password FROM tblUser WHERE UserID=@id";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.Parse(comboBox1.SelectedValue.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    string cipherText = ds.Tables[0].Rows[0]["Password"].ToString();              
                    string decryptedText = Encryption.Decrypt(cipherText, true);              
                    if (decryptedText !=tbPass.Text.Trim())
                    {
                        MessageBox.Show("Invalid password. try again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    clsUserDetails.userID=int.Parse(comboBox1.SelectedValue.ToString());
                    clsUserDetails.userName = comboBox1.Text;
                    clsUserDetails.roleId = role;
                    this.Hide();
                    MDIParentForm main = new MDIParentForm(); main.Show();
                }
            }

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                using (var con = new SqlConnection(ConStr))
                {
                    string query = "SELECT RoleID FROM tblUser WHERE UserID=@userdi";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@userdi", SqlDbType.Int).Value = int.Parse(comboBox1.SelectedValue.ToString());
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        //clsUserDetails.userID = int.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString());
                         role = int.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString());


                    }
                }
            }
            catch { }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT * FROM tblUser";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    comboBox1.DataSource = ds.Tables[0].DefaultView;
                    comboBox1.DisplayMember = "UserName";
                    comboBox1.ValueMember = "UserID";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

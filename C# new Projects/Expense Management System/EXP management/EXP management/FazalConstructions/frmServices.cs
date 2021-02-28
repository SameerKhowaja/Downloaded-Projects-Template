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
    public partial class frmServices : Form
    {
        string ConStr = DBConnection.ConStr;
        int TransactionID;
        public frmServices()
        {
            InitializeComponent();
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            TransactionID = CreateDBID.CreateID("tblServices", "TransactionID");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Client_ID AS 'ID', ProjectName FROM tblClient "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");


                    cb_P_ID.DataSource = ds.Tables[0].DefaultView;
                    cb_P_ID.DisplayMember = "ProjectName";
                    cb_P_ID.ValueMember = "ID";

                    
                }
            }
        }

        private void cbPerson_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("select tblServicePerson.PersonName, tblServicePerson.PersonID FROM tblServicePerson "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");


                    cbPerson.DataSource = ds.Tables[0].DefaultView;
                    cbPerson.DisplayMember = "PersonName";
                    cbPerson.ValueMember = "PersonID";

                     
                    }
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbPayment.Text.Trim()==string.Empty)
            {
                tbPayment.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_P_ID.SelectedIndex < 0 || cbPerson.SelectedIndex < 0)
            {
                MessageBox.Show("Invalid selection. one or more list items are not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbPayment.Text.Trim() == "0" || tbPayment.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Selection. Please enter amount to pay to " + cbPerson.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var con = new SqlConnection (ConStr))
            {
                string query = "INSERT INTO tblServices(TransactionID, Client_ID, PersonID, Payment, DateTime)VALUES(@tid, @cid, @pid, @payment, @dt)";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@tid", SqlDbType.Int).Value = TransactionID;
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.Int).Value = int.Parse(cb_P_ID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@pid", SqlDbType.Int).Value = int.Parse(cbPerson.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Payment", SqlDbType.Decimal).Value = decimal.Parse(tbPayment.Text.Trim());
                    cmd.Parameters.AddWithValue("@dt", SqlDbType.DateTime).Value = DateTimee.Value;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully","Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TransactionID = CreateDBID.CreateID("tblServices", "TransactionID");
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreatePerson frm = new frmCreatePerson();
            frm.ShowDialog();
        }

        private void frmServices_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        }
    }


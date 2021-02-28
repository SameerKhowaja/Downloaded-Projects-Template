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
    public partial class frmSalary : Form
    {
        string ConStr = DBConnection.ConStr;
        int ID;
        public frmSalary()
        {
            InitializeComponent();
        }

        private void tbPayment_TextChanged(object sender, EventArgs e)
        {
            if (tbPayment.Text.Trim()==string.Empty)
            {
                tbPayment.Text = "0";
            }
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {
            ID = CreateDBID.CreateID("tblSalary", "TransactionID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbPerson.SelectedIndex<0)
            {
               MessageBox.Show("Please select salary Person Name","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (tbPayment.Text.Trim()==string.Empty || tbPayment.Text.Trim()=="0")
            {
                MessageBox.Show("Please select salary amount","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var con = new SqlConnection(ConStr))
            {
                string query = "INSERT INTO tblSalary(TransactionID, SalaryPersonID, SalaryAmount,Narration,Date)VALUES(@id, @personId, @amount, @narration, @dt)";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = ID;
                    cmd.Parameters.AddWithValue("@personId", SqlDbType.Int).Value = int.Parse(cbPerson.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@amount", SqlDbType.Decimal).Value = decimal.Parse(tbPayment.Text.Trim());
                    cmd.Parameters.AddWithValue("@narration", SqlDbType.NVarChar).Value = tbNarration.Text.Trim();
                    cmd.Parameters.AddWithValue("@dt", SqlDbType.DateTime).Value = DateTimee.Value;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID = CreateDBID.CreateID("tblSalary", "TransactionID");

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSalaryPerson frm = new frmSalaryPerson();
            frm.ShowDialog();
        }

        private void cbPerson_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT SalaryPersonID,SalaryPersonName FROM tblSalaryPerson "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");


                    cbPerson.DataSource = ds.Tables[0].DefaultView;
                    cbPerson.DisplayMember = "SalaryPersonName";
                    cbPerson.ValueMember = "SalaryPersonID";


                }
            }
        }

        private void frmSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

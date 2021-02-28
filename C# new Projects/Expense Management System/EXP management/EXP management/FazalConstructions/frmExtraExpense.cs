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
    public partial class frmExtraExpense : Form
    {
        int id;
        string ConStr = DBConnection.ConStr;
        public frmExtraExpense()
        {
            InitializeComponent();
        }

        private void tbAmt_TextChanged(object sender, EventArgs e)
        {
            if (tbAmt.Text.Trim()==string.Empty)
            {
                tbAmt.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbExp.SelectedIndex<0)
            {
                MessageBox.Show("Please select expense", "Select expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbAmt.Text.Trim()==string.Empty || tbAmt.Text.Trim()=="0")
            {
                MessageBox.Show("Please select expense amount", "Select amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (var con = new SqlConnection(ConStr))
            {
                string query = "INSERT INTO tblExtraExpense(TransactionID, ExtraExpenseID, ExtraExpenseAmount, Narration,Date)VALUES(@id,@expid, @expAmt,@narration,@dt)";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.AddWithValue("@expAmt", SqlDbType.Decimal).Value = decimal.Parse(tbAmt.Text.Trim());
                    cmd.Parameters.AddWithValue("@expid", SqlDbType.Int).Value = int.Parse(cbExp.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@narration", SqlDbType.NVarChar).Value = tbNarration.Text.Trim();
                    cmd.Parameters.AddWithValue("@dt", SqlDbType.DateTime).Value = DateTimee.Value;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Extra Expense saved successfully", "Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = CreateDBID.CreateID("tblExtraExpense", "TransactionID");

                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateExtraExpense frm = new frmCreateExtraExpense();
            frm.ShowDialog();
        }

        private void cbExp_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ExtraExpenseID,ExpenseName FROM tblCreateExtraExpense "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");


                    cbExp.DataSource = ds.Tables[0].DefaultView;
                    cbExp.DisplayMember = "ExpenseName";
                    cbExp.ValueMember = "ExtraExpenseID";


                }
            }
        }

        private void frmExtraExpense_Load(object sender, EventArgs e)
        {
            id = CreateDBID.CreateID("tblExtraExpense", "TransactionID");
        }

        private void frmExtraExpense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

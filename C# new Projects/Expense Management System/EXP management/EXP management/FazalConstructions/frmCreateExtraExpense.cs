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
    public partial class frmCreateExtraExpense : Form
    {
        int ID;
        string ConStr = DBConnection.ConStr;
        public frmCreateExtraExpense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbExpName.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please enter extra expense name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var con = new SqlConnection(ConStr))
            {
                string query = "INSERT INTO tblCreateExtraExpense (ExtraExpenseID, ExpenseName,Date)VALUES(@id, @name,@dt)";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = ID;
                    cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = tbExpName.Text.Trim();
                    cmd.Parameters.AddWithValue("@dt", SqlDbType.DateTime).Value = DateTimee.Value;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Extra Expense Created Successfully", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID = CreateDBID.CreateID("tblCreateExtraExpense", "ExtraExpenseID");
                }
            }


        }

        private void frmCreateExtraExpense_Load(object sender, EventArgs e)
        {
            ID = CreateDBID.CreateID("tblCreateExtraExpense", "ExtraExpenseID");
        }

        private void frmCreateExtraExpense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

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
    public partial class frmSalaryPerson : Form
    {
        string ConStr = DBConnection.ConStr;
        int ID;
        public frmSalaryPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPersonName.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please enter person name", "Person name required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var con = new SqlConnection (ConStr))
            {
                string query = "INSERT INTO tblSalaryPerson(SalaryPersonID, SalaryPersonName, Date)VALUES(@id, @name, @dt)";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = ID;
                    cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = tbPersonName.Text.Trim();
                    cmd.Parameters.AddWithValue("dt", SqlDbType.DateTime).Value = DateTimee.Value;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Salary Person Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID = CreateDBID.CreateID("tblSalaryPerson", "SalaryPersonID");
                }
   
            }
        }

        private void frmSalaryPerson_Load(object sender, EventArgs e)
        {
            ID = CreateDBID.CreateID("tblSalaryPerson", "SalaryPersonID");
        }

        private void frmSalaryPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

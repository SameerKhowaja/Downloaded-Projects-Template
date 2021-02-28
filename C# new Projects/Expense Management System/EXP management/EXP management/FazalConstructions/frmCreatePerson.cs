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
    public partial class frmCreatePerson : Form
    {
        string ConStr = DBConnection.ConStr;
        int ID;
        public frmCreatePerson()
        {
            InitializeComponent();
        }

        private void frmCreatePerson_Load(object sender, EventArgs e)
        {
            ID = CreateDBID.CreateID("tblServicePerson", "PersonID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPersonName.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please type name of new person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var con = new SqlConnection(ConStr))
            {
                string query = "INSERT INTO tblServicePerson (PersonID,PersonName,Datetime)VALUES(@id,@name,@dt)";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = ID;
                    cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = tbPersonName.Text.Trim();
                    cmd.Parameters.AddWithValue("@dt", SqlDbType.DateTime).Value = DateTimee.Value;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Person Created", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID = CreateDBID.CreateID("tblServicePerson", "PersonID");

                }
            }

        }

        private void frmCreatePerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

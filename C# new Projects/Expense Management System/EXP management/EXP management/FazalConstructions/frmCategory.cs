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
using System.Configuration;
namespace FazalConstructions
{
    public partial class frmCategory : Form
    {
       

        string str = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
          
            lblID.Text  = CreateDBID.CreateID("tblCategory", "CatID").ToString();
            
            try
            {
                populatePreviousCategories();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "SqlError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void populatePreviousCategories()
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                string query = "SELECT CatID, CatName, CatDesc, DateTime FROM tblCategory";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    cbCat.DataSource = dt;
                    cbCat.DisplayMember = "CatName";
                    cbCat.ValueMember = "CatID";
                    dataGridView1.DataSource = dt;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    string query = "INSERT INTO tblCategory(CatID, CatName,  CatDesc, DateTime)VALUES(@id, @name, @desc, @date)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(lblID.Text);
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = tbName.Text.Trim();
                        cmd.Parameters.Add("@desc", SqlDbType.NVarChar).Value = tbDesc.Text.Trim();
                        cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTimee.Value;
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Category " + tbName.Text.Trim() + " Created Successfully!", "New Category Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblID.Text = CreateDBID.CreateID("tblCategory", "CatID").ToString();
                        tbName.Clear();
                        tbDesc.Clear();
                        populatePreviousCategories();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cbCat.SelectedValue.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clsUpdateCategory.updateCat(cbCat.SelectedValue.ToString(), "tblCategory", tbName.Text.Trim(), tbDesc.Text.Trim(), DateTimee.Value);
            if (clsUpdateCategory.status==0)
            {
                MessageBox.Show("Error occurred. Try Again");
            }
            else
            {
                MessageBox.Show("Request completed successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDesc.Clear();
                tbName.Clear();
            }
        }

        private void frmCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                populatePreviousCategories();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "SqlError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

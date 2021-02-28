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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            ID.Text = CreateDBID.CreateID("tblFolding", "FoldingID").ToString();
            dataGridView1.DataSource = clsFoldingManagement.fetchGridInformation().Tables[0].DefaultView;
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim()==string.Empty || tbQty.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Some Required fields are empty for Item Saving. try again","Field(s) missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                clsStock.createFolding(int.Parse(ID.Text), tbName.Text.Trim(), int.Parse(tbQty.Text.Trim()), tbNarration.Text.Trim(), DateTimee.Value);
                MessageBox.Show("Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNarration.Clear();
                tbName.Clear();
                tbQty.Clear();
                ID.Text = CreateDBID.CreateID("tblFolding", "FoldingID").ToString();
                dataGridView1.DataSource = clsFoldingManagement.fetchGridInformation().Tables[0].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error occurred, could not write to database\nDetails: "+ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error occurred, non-database error\nDetails: " + ee.Message, "Non-SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNarration_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DateTimee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblUpdateID.Text.Trim()==string.Empty)
            {
               MessageBox.Show("Please select item from grid to update item.", "Item not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (tbUpdateName.Text.Trim()==string.Empty || tbUpdateQty.Text.Trim()==String.Empty)
            {
                MessageBox.Show("Some Required fields are empty for Item Updation. try again","Field(s) missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(lblUsedQty.Text)>int.Parse(tbUpdateQty.Text.Trim()))
            {
                MessageBox.Show("New Quantity can not less than currently used quantity.Currently used quantity is: " + lblUsedQty.Text + ". change the quantity and try again", "Quantity error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                clsStock.update(int.Parse(lblUpdateID.Text.Trim()), tbUpdateName.Text.Trim(), int.Parse(tbUpdateQty.Text.Trim()), DateTimee.Value);
                MessageBox.Show("Item Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = clsFoldingManagement.fetchGridInformation().Tables[0].DefaultView;
                tbUpdateName.Clear();
                tbUpdateQty.Clear();
                lblUpdateID.Text = "";
                lblUsedQty.Text = "";
            }
            catch (SqlException sqlE)
            {
                MessageBox.Show("Error occurred, Can not write to database.\nDetails: " + sqlE.Message, "SqlError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception E)
            {
                MessageBox.Show("Error occurred, Non Sql Error.\nDetails: " + E.Message, "Non Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbUpdateName.Text = row.Cells["Name"].Value.ToString();
                lblUpdateID.Text = row.Cells["FoldingID"].Value.ToString();
                tbUpdateQty.Text = row.Cells["Quantity"].Value.ToString();
                lblUsedQty.Text = row.Cells["UsedQuantity"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblUpdateID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select item from grid to delete.", "Item not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(lblUsedQty.Text.Trim())!=0)
            {
                MessageBox.Show("Item can not deleted because it is currently used at some sites. please put used quantity to zero and try again.", "Can't Delete item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                clsStock.delete(int.Parse(lblUpdateID.Text.Trim()));
                MessageBox.Show("Item Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = clsFoldingManagement.fetchGridInformation().Tables[0].DefaultView;
                ID.Text = CreateDBID.CreateID("tblFolding", "FoldingID").ToString();
                tbUpdateName.Clear();
                tbUpdateQty.Clear();
                lblUpdateID.Text = "";
                lblUsedQty.Text = "";
            }
            catch (SqlException sqlE)
            {
                MessageBox.Show("Item deletion Error. Can not read from database.\nDetails: "+sqlE.Message, "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception E)
            {
                MessageBox.Show("Item deletion Error. non sql error.\nDetails: " + E.Message, "Non Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

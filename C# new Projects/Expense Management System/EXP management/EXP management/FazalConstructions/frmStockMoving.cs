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
    public partial class frmStockMoving : Form
    {
        string nested_query;
        string backToStockQuery;
        private static string ConStr = DBConnection.ConStr;
        public frmStockMoving()
        {
            InitializeComponent();
        }

        private void frmStockMoving_Load(object sender, EventArgs e)
        {
            loadStockInformation();
        }

        private void loadStockInformation()
        {
            //DgvStock.DataSource = clsViewStock.fetchPreviousDetails().Tables[0].DefaultView;
            DgvStock.DataSource = clsFoldingManagement.fetchGridInformation().Tables[0].DefaultView;
            TransactionID.Text = CreateDBID.CreateID("tblStockManagement", "TransactionID").ToString();

            //numQty.Maximum = decimal.Parse(lblRemItems.Text);
        }



        private void cbProject_Click(object sender, EventArgs e)
        {
            populateProjectNames();
        }

        private void populateProjectNames()
        {
            cbFoldingItem.DataSource = null;
            DataSet data = clsFoldingManagement.fetchProjectDetails();
            cbProject.DataSource = data.Tables[0].DefaultView;
            cbProject.DisplayMember = "ProjectName";
            cbProject.ValueMember = "Client_ID";
        }

        private void cbItem_Click(object sender, EventArgs e)
        {
            loadItemNames();//IT WILL LOAD NAMES OF ITEMS THAT ARE NOT CURRENLTY USED ON SELECTED SITE OR PROJECT
        }

        private void loadItemNames()
        {
            if (cbProject.Items.Count == 0)
            {
                return;
            }
            //selects name of items used on selected site
            cbFoldingItem.DataSource = clsFoldingManagement.fetchFoldingItemNames(int.Parse(cbProject.SelectedValue.ToString())).Tables[0];
            cbFoldingItem.DisplayMember = "Name";
            cbFoldingItem.ValueMember = "FoldingID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (numQty.Value == 0 || numQty.Value.ToString() == "")
            {
                MessageBox.Show("Please select Quantity", "Quantity not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numQty.Value > decimal.Parse(lblRemItems.Text))
            {
                MessageBox.Show("Not Much Stock Available.", "No Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFoldingInformation();//IT WILL (1) INSERT FOLDING DATA INTO TBLSTOCKMANAGEMENT AND (2) UPDATE USED QUANTITY IN TBLFOLDING
        }

        private void SaveFoldingInformation()
        {
            try
            {
                clsFoldingManagement.enterFolding(int.Parse(TransactionID.Text), int.Parse(cbProject.SelectedValue.ToString()), int.Parse(cbFoldingItem.SelectedValue.ToString()), int.Parse(numQty.Value.ToString()), DateTimee.Value);
                MessageBox.Show("Process completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TransactionID.Text = CreateDBID.CreateID("tblStockManagement", "TransactionID").ToString();
                cbProject.DataSource = null;
                cbFoldingItem.DataSource = null;
                lblRemItems.Text = "0";
                numQty.Value = 0;
                loadStockInformation();


            }
            catch (SqlException sqlE)
            {
                MessageBox.Show("Error occurred, could not write to database\n" + sqlE.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            catch (Exception E)
            {
                MessageBox.Show("Error occurred, non database error occurred\n" + E.Message, "Non-Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void cbFoldingItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchRemainingItemsInStock();//IT WILL RETURN QUANTITY OF ITEMS REMAINING IN STOCK
        }

        private void fetchRemainingItemsInStock()
        {
            try
            {
                lblRemItems.Text = clsFoldingManagement.fetchItemQuantity(int.Parse(cbFoldingItem.SelectedValue.ToString())).Tables[0].Rows[0]["RemQuantity"].ToString();
            }
            catch
            {

            }
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            //numQty.Maximum = decimal.Parse(lblRemItems.Text);
        }

        private void cbUpdateProject_Click(object sender, EventArgs e)
        {
            loadProjectsWithName();//THIS WILL LOAD NAMES OF PROJECTS THAT ARE USING THE SELECTED ITEMS(FROM TBLSTOCKMANAGEMENT)
        }

        private void loadProjectsWithName()
        {
            try
            {
                DataSet ds = clsFoldingManagement.fetchProjectsForUpdateQty(int.Parse(cbUpdateItemName.SelectedValue.ToString()));
                cbUpdateProject.DataSource = ds.Tables["DATA"].DefaultView;
                cbUpdateProject.DisplayMember = "ProjectName";
                cbUpdateProject.ValueMember = "Client_ID";
            }
            catch { }
        }

        private void cbUpdateItemName_Click(object sender, EventArgs e)
        {
            loadItems();//THIS WILL LOAD NAMES OF ITEMS THAT ARE BEING USED IN FOLDING (FROM TBLSTOCKMANAGEMENT)
        }

        private void loadItems()
        {
            cbUpdateProject.DataSource = null;
            lblAvInStock.Text = "0";
            lblUsedQty.Text = "0";
            DataSet ds = clsFoldingManagement.updateLoadItems();
            cbUpdateItemName.DataSource = ds.Tables["DATA"].DefaultView;
            cbUpdateItemName.DisplayMember = "Name";
            cbUpdateItemName.ValueMember = "FoldingID";
        }

        private void cbUpdateProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadUedQuantity();
        }

        private void loadUedQuantity()
        {
            FetchPreviousQtyAndStockQty();//THIS WILL LOAD PREVIOUS QUANTITY OF ITEMS THAT ARE USING ON SELECTED SPOT AND ITEM QUANTITY AVAILABLE IN STOCK
        }

        private void FetchPreviousQtyAndStockQty()
        {
            try
            {
                DataSet ds = clsFoldingManagement.fetchPreviousQtyToUpdate(int.Parse(cbUpdateItemName.SelectedValue.ToString()), int.Parse(cbUpdateProject.SelectedValue.ToString()));
                lblUsedQty.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                lblUpdateID.Text = ds.Tables[0].Rows[0]["TransactionID"].ToString();
            }
            catch
            {
                lblUsedQty.Text = "0";
                lblUpdateID.Text = "0";
            }

            try
            {
                lblAvInStock.Text = clsFoldingManagement.fetchItemsInStockToUpdate(int.Parse(cbUpdateItemName.SelectedValue.ToString())).Tables[0].Rows[0]["RemQuantity"].ToString();
            }
            catch { lblAvInStock.Text = "0"; }
        }

        private void UpdateNumQty_ValueChanged(object sender, EventArgs e)
        {
            //UpdateNumQty.Maximum = decimal.Parse(lblAvInStock.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UpdateNumQty.Value == 0 || UpdateNumQty.Value.ToString() == "")
            {
                MessageBox.Show("Please Select Quantity", "Quantity not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (decimal.Parse(lblAvInStock.Text) < UpdateNumQty.Value)
            {
                MessageBox.Show("Not much stock available", "Not Much Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            updateQuantity();//THIS WILL UPDATE THE QUANTITY OF SELECTED ITEM ON SELETECTED SITE  
        }

        private void updateQuantity()
        {
            try
            {
                clsFoldingManagement.updateFolding(int.Parse(lblUpdateID.Text), int.Parse(cbUpdateItemName.SelectedValue.ToString()), int.Parse(UpdateNumQty.Value.ToString()), DateTimee.Value);
                MessageBox.Show("Process Successfully Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateNumQty.Value = 0;
                cbUpdateItemName.DataSource = null;
                cbUpdateProject.DataSource = null;
                loadStockInformation();

            }
            catch (SqlException x)
            {
                MessageBox.Show("Error. unable to write to database.", " SQL Error\n" + x.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving changes, non database error\n" + ex.Message, "Non SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbSourceItemName_Click(object sender, EventArgs e)
        {
            loadItemName();
        }

        private void loadItemName()
        {
            cbSourceItemName.DataSource = clsFoldingManagement.updateLoadItems().Tables[0].DefaultView;
            cbSourceItemName.DisplayMember = "Name";
            cbSourceItemName.ValueMember = "FoldingID";
            //dataGridView1.DataSource = clsFoldingManagement.updateLoadItems().Tables[0].DefaultView;
        }

        private void cbSourceProject_Click(object sender, EventArgs e)
        {
            loadProjectNameAndQuantity();//THIS WILL LOAD PROJECT NAMES THAT ARE USING SELECTED ITEM AND LOAD QUANTITY (FROM TBLSTOCKMANAGEMENT)
        }

        private void loadProjectNameAndQuantity()
        {
            try
            {
                //cbSourceProject.DataSource = null;
                DataSet ds = clsFoldingManagement.fetchProjectsForUpdateQty(int.Parse(cbSourceItemName.SelectedValue.ToString()));
                cbSourceProject.DataSource = ds.Tables[0].DefaultView; ;
                cbSourceProject.DisplayMember = "ProjectName";
                cbSourceProject.ValueMember = "Client_ID";
                //lblPrevQty.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
            }
            catch { }

        }

        private void cbDestinationProject_Click(object sender, EventArgs e)
        {
            loadProjectNames();//THIS WILL LOAD ALL PROJECT'S NAME FROM TBLCLIENT TABLE
        }

        private void loadProjectNames()
        {
            DataSet ds = clsFoldingManagement.fetchProjectDetails();
            cbDestinationProject.DataSource = ds.Tables[0].DefaultView;
            cbDestinationProject.DisplayMember = "ProjectName";
            cbDestinationProject.ValueMember = "Client_ID";
        }

        private void cbSourceItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // label17.Text = cbSourceItemName.SelectedValue.ToString();
        }

        private void cbSourceProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = clsFoldingManagement.w(int.Parse(cbSourceProject.SelectedValue.ToString()), int.Parse(cbSourceItemName.SelectedValue.ToString()));

                lblPrevQty.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                lblT_ID.Text = ds.Tables[0].Rows[0]["TransactionID"].ToString();
            }
            catch { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           


            using (var connection = new SqlConnection(ConStr))
            {

                    using (var command = new SqlCommand(nested_query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@newQty", SqlDbType.Int).Value = int.Parse(numDestinationQty.Value.ToString());
                        command.Parameters.AddWithValue("@sourceTransID", SqlDbType.Int).Value = int.Parse(lblT_ID.Text);
                        command.Parameters.AddWithValue("@transid", SqlDbType.Int).Value = int.Parse(id2.Text);
                        command.Parameters.AddWithValue("@insertTransid", SqlDbType.Int).Value = int.Parse(lblTransIDtoInsert.Text);
                        command.Parameters.AddWithValue("@insertClient_ID", SqlDbType.Int).Value = int.Parse(cbDestinationProject.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@insertFoldingID", SqlDbType.Int).Value = int.Parse(cbSourceItemName.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@insertDateTime", SqlDbType.DateTime).Value = DateTimee.Value;
                        command.Parameters.AddWithValue("@dt", SqlDbType.DateTime).Value = DateTimee.Value;
                        command.Parameters.AddWithValue("@insertQuantity", SqlDbType.Int).Value = int.Parse(numDestinationQty.Value.ToString());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Changes Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadStockInformation();
                    }
            }
        }

        private void cbDestinationProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = clsFoldingManagement.checkItemExisitance(int.Parse(cbSourceItemName.SelectedValue.ToString()), int.Parse(cbDestinationProject.SelectedValue.ToString()));                
                nested_query="UPDATE tblStockManagement SET Quantity=Quantity-@newQty WHERE TransactionID=@sourceTransID";
                if (ds.Tables[0].Rows[0]["R"].ToString() == "True")
                {
                    loadTransID();
                    nested_query += " UPDATE tblStockManagement SET Quantity=Quantity+@newQty, DateTime=@dt WHERE TransactionID= @transid";    
                }
                else if (ds.Tables[0].Rows[0]["R"].ToString() == "False")
                {
                    generateTransID();
                    nested_query += " INSERT INTO tblStockManagement (TransactionID, Client_ID, FoldingID, DateTime, Quantity)VALUES(@insertTransid, @insertClient_ID, @insertFoldingID, @insertDateTime, @insertQuantity)";
                }
            }
            catch {  }     
              
        }

        private void generateTransID()
        {
            lblTransIDtoInsert.Text = CreateDBID.CreateID("tblStockManagement", "TransactionID").ToString();
        }

        private void loadTransID()
        {
            using (var con = new SqlConnection(ConStr))
            {
                string query = "SELECT TransactionID FROM tblStockManagement WHERE Client_ID = @cid AND FoldingID = @fid";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@fid", SqlDbType.Int).Value = int.Parse(cbSourceItemName.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@cid", SqlDbType.Int).Value = int.Parse(cbDestinationProject.SelectedValue.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dateset = new DataSet();
                    da.Fill(dateset, "tbl");
                    id2.Text = dateset.Tables[0].Rows[0]["TransactionID"].ToString();

                }
            }
        }

        private void frmStockMoving_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbBackProject_Click(object sender, EventArgs e)
        {
            cbBackItem.DataSource = null;
            cbBackProject.DataSource = null;
            cbBackProject.DataSource = clsFoldingManagement.fetchProjectDetails().Tables[0].DefaultView;
            cbBackProject.DisplayMember = "ProjectName";
            cbBackProject.ValueMember = "Client_ID";
        }

        private void cbBackItem_Click(object sender, EventArgs e)
        {
            cbBackItem.DataSource = clsFoldingManagement.backItemNames(int.Parse(cbBackProject.SelectedValue.ToString())).Tables[0].DefaultView;
            cbBackItem.DisplayMember = "Name";
            cbBackItem.ValueMember = "FoldingID";
        }

        private void cbBackItem_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cbBackItem.SelectedValue.ToString());
//return;
            try
            {
                using (var con = new SqlConnection(ConStr))
                {
                    string query = "SELECT TransactionID,Quantity FROM tblStockManagement WHERE Client_ID =@client AND FoldingID = @folding; Select FoldingID from tblFolding";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@client", SqlDbType.Int).Value = int.Parse(cbBackProject.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@folding", SqlDbType.Int).Value = int.Parse(cbBackItem.SelectedValue.ToString());
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables[0].Rows.Count==0)
                        {
                            MessageBox.Show("No record found");
                            return;
                        }
                        lblBack_TransactionID.Text = ds.Tables[0].Rows[0]["TransactionID"].ToString();
                        lblBack_Qty.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                        FoldingID.Text = cbBackItem.SelectedValue.ToString();

                    }
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numBackQty.Value>int.Parse(lblBack_Qty.Text))
            {
                MessageBox.Show("Not much quantity available on spot.", "Not much quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numBackQty.Value = 0; return; 
            }
            if (numBackQty.Value==int.Parse(lblBack_Qty.Text))
            {
                //delete from destination
                //update stock quantity
                backToStockQuery = "delete from tblStockManagement WHERE TransactionID=@transid; Update tblFolding Set UsedQuantity=UsedQuantity-@qty WHERE FoldingID=@foldingid";
            }
            if (numBackQty.Value!=int.Parse(lblBack_Qty.Text))
            {
                //update from destination
                //update from stock
                backToStockQuery = "UPDATE tblStockManagement SET Quantity=Quantity-@qty WHERE TransactionID=@transid; Update tblFolding Set UsedQuantity=UsedQuantity-@qty WHERE FoldingID=@foldingid";
            }
            using (var con = new SqlConnection(ConStr))
            {
                
                using (var cmd = new SqlCommand(backToStockQuery,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@transid", SqlDbType.Int).Value = int.Parse(lblBack_TransactionID.Text);
                    cmd.Parameters.AddWithValue("@qty", SqlDbType.Int).Value = numBackQty.Value;
                    cmd.Parameters.AddWithValue("@foldingid", SqlDbType.Int).Value = int.Parse(FoldingID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved Successfully","Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbBackItem.DataSource = null;
                    cbBackProject.DataSource = null;
                    lblBack_TransactionID.Text = "";
                    lblBack_TransactionID.Text = "";
                    FoldingID.Text = "";
                    numBackQty.Value = 0;
                    loadStockInformation();
                }
            }
        }

    }
 }

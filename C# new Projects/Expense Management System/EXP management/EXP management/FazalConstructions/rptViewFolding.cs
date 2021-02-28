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
    public partial class rptViewFolding : Form
    {
        string ConStr = DBConnection.ConStr;
        public rptViewFolding()
        {
            InitializeComponent();
        }

        private void rptViewFolding_Load(object sender, EventArgs e)
        {
            loadProjects();
            loadFolding();
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
           
        }

        private void loadFolding()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name, FoldingID FROM tblFolding "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");


                    comboBox1.DataSource = ds.Tables[0].DefaultView;
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "FoldingID";
                }
            }
        }

        private void loadProjects()
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

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblStockManagement' table. You can move, or remove it, as needed.
            this.tblStockManagementTableAdapter.FillBy(this.FCProjectDataSet.tblStockManagement, int.Parse(cb_P_ID.SelectedValue.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));

            //this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadProjects();
            loadFolding();
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblStockManagement' table. You can move, or remove it, as needed.
            this.tblStockManagementTableAdapter.Fill(this.FCProjectDataSet.tblStockManagement);

            //this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblStockManagement' table. You can move, or remove it, as needed.
            this.tblStockManagementTableAdapter.FillBy1(this.FCProjectDataSet.tblStockManagement, DateTimePickerFrom.Value.ToShortDateString(), dateTimePickerTo.Value.ToShortDateString());

           // this.reportViewer1.RefreshReport();
        }
    }
}

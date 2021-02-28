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
    public partial class viewRptCatVise : Form
    {
        string ConStr = DBConnection.ConStr;
        public viewRptCatVise()
        {
            InitializeComponent();
        }

        private void viewRptCatVise_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblExpEntry' table. You can move, or remove it, as needed.
            this.tblExpEntryTableAdapter.FillBy(this.FCProjectDataSet.tblExpEntry);
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);
            loadProjects();

            loadCategories();
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblExpEntry' table. You can move, or remove it, as needed.

            
        }

        private void loadCategories()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = "SELECT CatID AS 'ID', CatName FROM tblCategory";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);


                    cbCat.DataSource = dt;
                    cbCat.DisplayMember = "CatName";
                    cbCat.ValueMember = "ID";



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

        private void cb_P_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblExpEntryTableAdapter.Fill(this.FCProjectDataSet.tblExpEntry, int.Parse(cb_P_ID.SelectedValue.ToString()), int.Parse(cbCat.SelectedValue.ToString()));
                //this.reportViewer1.RefreshReport();
            }
            catch { }
        }
    }
}

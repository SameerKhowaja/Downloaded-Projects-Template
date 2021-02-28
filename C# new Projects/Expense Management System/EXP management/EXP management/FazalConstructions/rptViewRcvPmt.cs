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

    public partial class rptViewRcvPmt : Form
    {
        string ConStr = DBConnection.ConStr;
        public rptViewRcvPmt()
        {
            InitializeComponent();
        }

        private void rptViewRcvPmt_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);

            loadProject();

            // TODO: This line of code loads data into the 'FCProjectDataSet.tblReceivePayment' table. You can move, or remove it, as needed.
           

           
        }

        private void loadProject()
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
            try
            {
                // TODO: This line of code loads data into the 'FCProjectDataSet.tblReceivePayment' table. You can move, or remove it, as needed.
                this.tblReceivePaymentTableAdapter.Fill(this.FCProjectDataSet.tblReceivePayment, int.Parse(cb_P_ID.SelectedValue.ToString()));

                
            }
            catch { }
        }
    }
}

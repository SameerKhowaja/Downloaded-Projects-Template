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
    public partial class rptPendingPayments : Form
    {
        string ConStr = DBConnection.ConStr;
        public rptPendingPayments()
        {
            InitializeComponent();
        }

        private void rptViewPendingPayment_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            

            loadPmtStatus();

            loadProjects();
        }

        private void loadPmtStatus()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PaymentStatusID, Name FROM tblPaymentStatus "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");

                    tbPaymentStatus.DataSource = ds.Tables[0].DefaultView;
                    tbPaymentStatus.DisplayMember = "Name";
                    tbPaymentStatus.ValueMember = "PaymentStatusID";

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

            try
            {
                // TODO: This line of code loads data into the 'FCProjectDataSet.tblExpEntry' table. You can move, or remove it, as needed.
                this.tblExpEntryTableAdapter.FillBy1(this.FCProjectDataSet.tblExpEntry, int.Parse(cb_P_ID.SelectedValue.ToString()), int.Parse(tbPaymentStatus.SelectedValue.ToString()) );

                //this.reportViewer1.RefreshReport();
            }
            catch
            {
                
               
            }
        }

        private void tbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           //MessageBox.Show( tbPaymentStatus.SelectedValue.ToString());
        }
    }
}

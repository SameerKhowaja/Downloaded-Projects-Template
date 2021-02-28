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
    public partial class rptViewPersonalExp : Form
    {
        string ConStr = DBConnection.ConStr;
        public rptViewPersonalExp()
        {
            InitializeComponent();
        }

        private void rptViewPersonalExp_Load(object sender, EventArgs e)
        {
            fetchTitle();


            fetchReceiver();

            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            
        }

        private void fetchReceiver()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Receiver FROM tblPersonalExp"))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");

                    comboBox1.DataSource = ds.Tables[0].DefaultView;
                    comboBox1.DisplayMember = "Receiver";
                    //cbExpTitle.ValueMember = ds.Tables[0].Rows[0]["AdditionalInfo"].ToString();

                }



            }
        }

        private void fetchTitle()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Title FROM tblPersonalExp"))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");

                    cbExpTitle.DataSource = ds.Tables[0].DefaultView;
                    cbExpTitle.DisplayMember = "Title";
                    //cbExpTitle.ValueMember = ds.Tables[0].Rows[0]["AdditionalInfo"].ToString();

                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.tblPersonalExpTableAdapter.FillBy(this.FCProjectDataSet.tblPersonalExp, DateTimePickerFrom.Value.ToShortDateString(), dateTimePickerTo.Value.ToShortDateString());
           // this.reportViewer1.RefreshReport();

            //DateTimePickerFrom.Value.ToShortDateString()
        }

        private void cbExpTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblPersonalExp' table. You can move, or remove it, as needed.
            this.tblPersonalExpTableAdapter.Title(this.FCProjectDataSet.tblPersonalExp, cbExpTitle.Text);

           // this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblPersonalExp' table. You can move, or remove it, as needed.
            this.tblPersonalExpTableAdapter.Rcvr(this.FCProjectDataSet.tblPersonalExp, comboBox1.Text);

           // this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class rptViewSalaryReport : Form
    {
        string ConStr = DBConnection.ConStr;
        public rptViewSalaryReport()
        {
            InitializeComponent();
        }

        private void rptViewSalaryReport_Load(object sender, EventArgs e)
        {    loadPersonn();
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblSalary' table. You can move, or remove it, as needed.
           

          


        }

        private void loadPersonn()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT SalaryPersonID,SalaryPersonName FROM tblSalaryPerson "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");
                    cbPerson.DataSource = ds.Tables[0].DefaultView;
                    cbPerson.DisplayMember = "SalaryPersonName";
                    cbPerson.ValueMember = "SalaryPersonID";


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblSalary' table. You can move, or remove it, as needed.
            this.tblSalaryTableAdapter.FillBy(this.FCProjectDataSet.tblSalary, DateTimePickerFrom.Value.ToShortDateString(), dateTimePickerTo.Value.ToShortDateString());
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);

            
        }

        private void tbPersonName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.tblSalaryTableAdapter.FillBy1(this.FCProjectDataSet.tblSalary, int.Parse(cbPerson.SelectedValue.ToString()));
                // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
                this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);

                //this.reportViewer1.RefreshReport();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadPersonn();
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblSalary' table. You can move, or remove it, as needed.
            this.tblSalaryTableAdapter.Fill(this.FCProjectDataSet.tblSalary);
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);

           // this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazalConstructions
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewRptCatVise frm = new viewRptCatVise();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rptViewRcvPmt frp = new rptViewRcvPmt();
            frp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rptPendingPayments rpt = new rptPendingPayments();
            rpt.ShowDialog();
        }

        private void frmReports_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rptViewFolding rpt = new rptViewFolding();
            rpt.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmViewExtraExpense frm = new frmViewExtraExpense();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rptViewSalaryReport rpt = new rptViewSalaryReport();
            rpt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rptViewServicesReport rpt = new rptViewServicesReport();
            rpt.ShowDialog();
        }
    }
}

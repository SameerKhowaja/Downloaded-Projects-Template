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
    public partial class frmViewExtraExpense : Form
    {
        public frmViewExtraExpense()
        {
            InitializeComponent();
        }

        private void frmViewExtraExpense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblCompanySetup' table. You can move, or remove it, as needed.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblCompanySetupTableAdapter.Fill(this.FCProjectDataSet.tblCompanySetup);
            // TODO: This line of code loads data into the 'FCProjectDataSet.tblExtraExpense' table. You can move, or remove it, as needed.
            this.tblExtraExpenseTableAdapter.FillBy(this.FCProjectDataSet.tblExtraExpense, DateTimePickerFrom.Value.ToShortDateString(), dateTimePickerTo.Value.ToShortDateString());

           
        }
    }
}

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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCreateOrManageClients frm = new frmCreateOrManageClients();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //frmTrackClientsAndViewProfiles frm = new frmTrackClientsAndViewProfiles();
            //frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmCreatePersonalExpense frm = new frmCreatePersonalExpense();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //frmGenerateBill frm = new frmGenerateBill();
            //frm.Show();
        }
    }
}

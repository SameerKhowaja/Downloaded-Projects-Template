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
    public partial class MDIParentForm : Form
    {
        private int childFormNumber = 0;

        public MDIParentForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            frmCompanySetup frm = new frmCompanySetup();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateOrManageClients frm = new frmCreateOrManageClients();
            frm.MdiParent = this;
            frm.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void updateExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateExp frm = new frmUpdateExp();
            frm.MdiParent = this;
            frm.Show();
        }

        private void personalExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreatePersonalExpense frm = new frmCreatePersonalExpense();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCompanySetup frm = new frmCompanySetup();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCreateOrManageClients frm = new frmCreateOrManageClients();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmDateEntry frm = new frmDateEntry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmPendingPayments frm = new frmPendingPayments();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmStockMoving frm = new frmStockMoving();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmStockMoving frm = new frmStockMoving();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmStockMoving frm = new frmStockMoving();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmRcvPmt frm = new frmRcvPmt();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmUploadImages frm = new frmUploadImages();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            frmUploadImages frm = new frmUploadImages();
            frm.MdiParent = this;
            frm.Show();
        }

        private void extraExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtraExpense frm = new frmExtraExpense();
            frm.MdiParent = this;
            frm.Show();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServices frm = new frmServices();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalary frm = new frmSalary();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createSystemUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateSystemUser frm = new frmCreateSystemUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDIParentForm_Load(object sender, EventArgs e)
        {
            windowsMenu.Enabled = false;
            if (clsUserDetails.roleId==1)
            {
                windowsMenu.Enabled = true;
            }
            else if (clsUserDetails.roleId==2)
            {
                windowsMenu.Enabled = false;
            }
            this.Text = "Contact: muhammadwaqas_ali@outlook.com " + clsUserDetails.userName + " Login";
        }
    }
}

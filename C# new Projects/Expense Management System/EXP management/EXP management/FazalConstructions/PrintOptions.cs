using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FazalConstructions
{
    public partial class PrintOptions : Form
    {
        internal CheckBox chkFitToPageWidth;
        internal Label lblTitle;
        internal TextBox txtTitle;
        internal GroupBox gboxRowsToPrint;
        internal RadioButton rdoSelectedRows;
        internal RadioButton rdoAllRows;
        internal Label lblColumnsToPrint;
        protected Button btnOK;
        protected Button btnCancel;
        protected Button btnHelp;
        internal CheckedListBox chklst;
    
        public PrintOptions()
        {
            InitializeComponent();
        }
        public PrintOptions(List<string> availableFields)
        {
            InitializeComponent();

            foreach (string field in availableFields)
                     chklst.Items.Add(field, true);
        }

        private void PrintOtions_Load(object sender, EventArgs e)
        {
           
        }

        public List<string> GetSelectedColumns()
        {
            List<string> lst = new List<string>();
            foreach (object item in chklst.CheckedItems)
                    lst.Add(item.ToString());
            return lst;
        }

        public string PrintTitle
        {
            get { return txtTitle.Text; }
        }

        public bool PrintAllRows
        {
            get { return rdoAllRows.Checked; }
        }

        public bool FitToPageWidth
        {
            get { return chkFitToPageWidth.Checked; }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOptions));
            this.chkFitToPageWidth = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.gboxRowsToPrint = new System.Windows.Forms.GroupBox();
            this.rdoSelectedRows = new System.Windows.Forms.RadioButton();
            this.rdoAllRows = new System.Windows.Forms.RadioButton();
            this.lblColumnsToPrint = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.gboxRowsToPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFitToPageWidth
            // 
            this.chkFitToPageWidth.AutoSize = true;
            this.chkFitToPageWidth.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFitToPageWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFitToPageWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFitToPageWidth.Location = new System.Drawing.Point(185, 74);
            this.chkFitToPageWidth.Name = "chkFitToPageWidth";
            this.chkFitToPageWidth.Size = new System.Drawing.Size(127, 18);
            this.chkFitToPageWidth.TabIndex = 30;
            this.chkFitToPageWidth.Text = "Fit to page width";
            this.chkFitToPageWidth.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(182, 103);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 13);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Title of print ";
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.Location = new System.Drawing.Point(182, 120);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTitle.Size = new System.Drawing.Size(176, 77);
            this.txtTitle.TabIndex = 28;
            // 
            // gboxRowsToPrint
            // 
            this.gboxRowsToPrint.Controls.Add(this.rdoSelectedRows);
            this.gboxRowsToPrint.Controls.Add(this.rdoAllRows);
            this.gboxRowsToPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRowsToPrint.Location = new System.Drawing.Point(182, 18);
            this.gboxRowsToPrint.Name = "gboxRowsToPrint";
            this.gboxRowsToPrint.Size = new System.Drawing.Size(173, 42);
            this.gboxRowsToPrint.TabIndex = 27;
            this.gboxRowsToPrint.TabStop = false;
            this.gboxRowsToPrint.Text = "Rows to print";
            // 
            // rdoSelectedRows
            // 
            this.rdoSelectedRows.AutoSize = true;
            this.rdoSelectedRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSelectedRows.Location = new System.Drawing.Point(91, 19);
            this.rdoSelectedRows.Name = "rdoSelectedRows";
            this.rdoSelectedRows.Size = new System.Drawing.Size(75, 17);
            this.rdoSelectedRows.TabIndex = 1;
            this.rdoSelectedRows.TabStop = true;
            this.rdoSelectedRows.Text = "Selected";
            this.rdoSelectedRows.UseVisualStyleBackColor = true;
            // 
            // rdoAllRows
            // 
            this.rdoAllRows.AutoSize = true;
            this.rdoAllRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAllRows.Location = new System.Drawing.Point(9, 19);
            this.rdoAllRows.Name = "rdoAllRows";
            this.rdoAllRows.Size = new System.Drawing.Size(39, 17);
            this.rdoAllRows.TabIndex = 0;
            this.rdoAllRows.TabStop = true;
            this.rdoAllRows.Text = "All";
            this.rdoAllRows.UseVisualStyleBackColor = true;
            // 
            // lblColumnsToPrint
            // 
            this.lblColumnsToPrint.AutoSize = true;
            this.lblColumnsToPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnsToPrint.Location = new System.Drawing.Point(6, 5);
            this.lblColumnsToPrint.Name = "lblColumnsToPrint";
            this.lblColumnsToPrint.Size = new System.Drawing.Size(102, 13);
            this.lblColumnsToPrint.TabIndex = 26;
            this.lblColumnsToPrint.Text = "Columns to print ";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(182, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOK.Size = new System.Drawing.Size(56, 25);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(244, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(56, 25);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(306, 243);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHelp.Size = new System.Drawing.Size(56, 25);
            this.btnHelp.TabIndex = 25;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // chklst
            // 
            this.chklst.CheckOnClick = true;
            this.chklst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklst.FormattingEnabled = true;
            this.chklst.Location = new System.Drawing.Point(6, 24);
            this.chklst.Name = "chklst";
            this.chklst.Size = new System.Drawing.Size(170, 244);
            this.chklst.TabIndex = 22;
            // 
            // PrintOptions
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(368, 271);
            this.Controls.Add(this.chkFitToPageWidth);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.gboxRowsToPrint);
            this.Controls.Add(this.lblColumnsToPrint);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.chklst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PrintOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PrintOptions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintOptions_KeyDown);
            this.gboxRowsToPrint.ResumeLayout(false);
            this.gboxRowsToPrint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PrintOptions_Load(object sender, EventArgs e)
        {
             // Initialize some controls
            rdoAllRows.Checked = true;
            chkFitToPageWidth.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PrintOptions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
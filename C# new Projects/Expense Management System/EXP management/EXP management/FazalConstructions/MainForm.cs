using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace FazalConstructions
{
    public partial class MainForm : Form
    {
        string ConStr = ConfigurationManager.ConnectionStrings["FazalConstructions.Properties.Settings.ConnString"].ConnectionString;
        internal DataGridView dgv;
        public Label lblTOTAL;
        private Label label2;
        public Label lblRcvAmt;
        private Label label4;
        public Label lblGrandExp;
        public Label lblCategories;
        private Label label3;
        private Label label1;
        private Button button1;
        private ComboBox cbProject;
        public Label label5;
        public Label label6;
        internal Button btnPrint;
        private TextBox tbWidth;
        private Label label7;
        private TextBox tbPrice;
        private Label label8;
        private TextBox tbHeight;
        private Label label9;
        private Button button3;
        private Label label10;
        private Label lblArea;
        private Button button4;
        private Label label11;
        private Label lblTotalPrice;
        public Label lblAfterComission;
        private Label label13;
        private GroupBox groupBox1;

        public string ID = "";
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            
            // Declare dataBase variables
            string cnStr, cmdText;
            cnStr =@"Data Source=.\sqlexpress;Initial Catalog=FCProject;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd;
            SqlDataReader dr;
            DataTable dt = new DataTable("Persons");
            try
            {
                cn.Open();
                
                // Load Data into DataGridView
                cmdText = "select tblCategory.CatName AS 'Expense Type / Category Name', sum(tblExpEntry.TotalPayment)  as 'Total Amount Used' from tblExpEntry LEFT OUTER JOIN tblCategory ON tblCategory.CatID=tblExpEntry.CatID WHERE tblExpEntry.Client_ID=@id GROUP BY CatName";
                
                cmd = new SqlCommand(cmdText, cn);
                cmd.Parameters.AddWithValue("@id", ID);
                dr = cmd.ExecuteReader();
                if (dr.HasRows) dt.Load(dr);
                dr.Close();

                dgv.DataSource = dt;

                // Initialize DataGridView Columns
                dgv.RowHeadersVisible = false;
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.ReadOnly = true;
                    if (col.GetType().Name == "DataGridViewImageColumn") 
                    {
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (row.IsNewRow) continue;
                            row.Height = row.Cells["image"].ContentBounds.Height + 6;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                cn = null;
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            PrintDGV.blnc = lblTOTAL.Text;
            PrintDGV.projectName = cbProject.Text;
            PrintDGV.cat = lblCategories.Text;
            PrintDGV.RcvAmt = lblRcvAmt.Text;
            PrintDGV.GrandExp = lblGrandExp.Text;
            PrintDGV.afterComission = lblAfterComission.Text;
            // Calling DataGridView Printing
            PrintDGV.Print_DataGridView(dgv);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRcvAmt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrandExp = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblAfterComission = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(4, 43);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.DefaultCellStyle.Format = "N2";
            this.dgv.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.Size = new System.Drawing.Size(608, 193);
            this.dgv.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(482, 430);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 34);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Preview";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOTAL.Location = new System.Drawing.Point(143, 436);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(18, 20);
            this.lblTOTAL.TabIndex = 23;
            this.lblTOTAL.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "TOTAL:";
            // 
            // lblRcvAmt
            // 
            this.lblRcvAmt.AutoSize = true;
            this.lblRcvAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRcvAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcvAmt.Location = new System.Drawing.Point(144, 388);
            this.lblRcvAmt.Name = "lblRcvAmt";
            this.lblRcvAmt.Size = new System.Drawing.Size(15, 16);
            this.lblRcvAmt.TabIndex = 21;
            this.lblRcvAmt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Received Amount:";
            // 
            // lblGrandExp
            // 
            this.lblGrandExp.AutoSize = true;
            this.lblGrandExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGrandExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandExp.Location = new System.Drawing.Point(143, 341);
            this.lblGrandExp.Name = "lblGrandExp";
            this.lblGrandExp.Size = new System.Drawing.Size(15, 16);
            this.lblGrandExp.TabIndex = 19;
            this.lblGrandExp.Text = "0";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(143, 313);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(15, 16);
            this.lblCategories.TabIndex = 18;
            this.lblCategories.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grand EXP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 313);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Categories:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(417, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "FETCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(4, 12);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(316, 21);
            this.cbProject.TabIndex = 26;
            this.cbProject.Click += new System.EventHandler(this.cbProject_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "===============================================";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(432, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "===============================================";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(221, 17);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(93, 20);
            this.tbWidth.TabIndex = 36;
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Width:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(75, 68);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(230, 20);
            this.tbPrice.TabIndex = 33;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Price";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(75, 17);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(93, 20);
            this.tbHeight.TabIndex = 31;
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Height:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 20);
            this.button3.TabIndex = 37;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Area:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblArea.Location = new System.Drawing.Point(174, 49);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 13);
            this.lblArea.TabIndex = 39;
            this.lblArea.Text = "VALUE";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 20);
            this.button4.TabIndex = 40;
            this.button4.Text = "O";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(174, 122);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(42, 13);
            this.lblTotalPrice.TabIndex = 42;
            this.lblTotalPrice.Text = "VALUE";
            // 
            // lblAfterComission
            // 
            this.lblAfterComission.AutoSize = true;
            this.lblAfterComission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAfterComission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterComission.Location = new System.Drawing.Point(144, 364);
            this.lblAfterComission.Name = "lblAfterComission";
            this.lblAfterComission.Size = new System.Drawing.Size(15, 16);
            this.lblAfterComission.TabIndex = 44;
            this.lblAfterComission.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 364);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "After Comission:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.tbWidth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbHeight);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(246, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 138);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Comission";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAfterComission);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRcvAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGrandExp);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cbProject_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Client_ID AS 'ID', ProjectName FROM tblClient "))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Data");


                    cbProject.DataSource = ds.Tables[0].DefaultView;
                    cbProject.DisplayMember = "ProjectName";
                    cbProject.ValueMember = "ID";
                    //MessageBox.Show(cb_P_ID.SelectedValue.ToString());
                    //ProjectsGrid.DataSource=ds.Tables[0].DefaultView;
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No Project Found in System!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchData();
            getRcvAmt();
            calculateTotalEXP();

            decimal aftercomission = 0;
            try
            {
                aftercomission = decimal.Parse(lblGrandExp.Text) + decimal.Parse(lblTotalPrice.Text);
                lblAfterComission.Text = aftercomission.ToString();
            }
            catch
            {
                lblAfterComission.Text = "0";
            }

            lblCategories.Text = dgv.Rows.Count.ToString();//calculate categories
            grandTotal();

        }

        private void fetchData()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = @"select tblCategory.CatName AS 'Expense Type / Category Name', sum(tblExpEntry.TotalPayment)  AS 'Total Amount Used' from tblExpEntry LEFT OUTER JOIN tblCategory ON tblCategory.CatID=tblExpEntry.CatID WHERE tblExpEntry.Client_ID=@id GROUP BY CatName;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", cbProject.SelectedValue.ToString());
                    cmd.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    dgv.DataSource = dt;
                }
            }
        }

        private void getRcvAmt()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                string query = @"select isNull(sum(RcvAmount),0) as 'RCVAMT' from tblReceivePayment where Client_ID=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", cbProject.SelectedValue.ToString());
                    cmd.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    //EXPGrid.DataSource = dt;
                    if ( dt.Rows[0]["RCVAMT"].ToString()==null )
                    {
                        lblRcvAmt.Text = "0";
                        return;
                    }
                    lblRcvAmt.Text = dt.Rows[0]["RCVAMT"].ToString();
                }
            }
        }

        private void grandTotal()
        {
            try
            {
                decimal result = 0;
                result = decimal.Parse(lblRcvAmt.Text) - decimal.Parse(lblAfterComission.Text);
                lblTOTAL.Text = result.ToString();
            }
            catch { }
        }

        private void calculateTotalEXP()
        {
            try
            {
                decimal totalExp = 0;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    totalExp += decimal.Parse(dgv["Total Amount Used", i].Value.ToString());
                }
                lblGrandExp.Text = totalExp.ToString();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal width = 0;
            decimal height = 0;
            width = decimal.Parse(tbWidth.Text);
            height = decimal.Parse(tbHeight.Text);

            decimal area = width * height;
            lblArea.Text = area.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            decimal price = 0;
            price = decimal.Parse(tbPrice.Text);
            totalPrice = decimal.Parse(lblArea.Text) * price;
            lblTotalPrice.Text = totalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //decimal mainTotal = 0;
            decimal n = decimal.Parse(lblTotalPrice.Text) + decimal.Parse(lblGrandExp.Text);
            lblGrandExp.Text = n.ToString() + "(Grand EXP " + lblGrandExp.Text + " )";
            //n=total price + grand expense
           // mainTotal = decimal.Parse(lblTOTAL.Text);
            decimal mainBalance = decimal.Parse(lblTOTAL.Text);
            mainBalance = mainBalance - n;
            lblTOTAL.Text = mainBalance.ToString();

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        


        
    }
}
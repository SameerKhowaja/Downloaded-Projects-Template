namespace FazalConstructions
{
    partial class frmStockMoving
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvStock = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUpdateID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAvInStock = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUsedQty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateNumQty = new System.Windows.Forms.NumericUpDown();
            this.cbUpdateProject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUpdateItemName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRemItems = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFoldingItem = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.TransactionID = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTransIDtoInsert = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numDestinationQty = new System.Windows.Forms.NumericUpDown();
            this.cbDestinationProject = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblT_ID = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPrevQty = new System.Windows.Forms.Label();
            this.cbSourceItemName = new System.Windows.Forms.ComboBox();
            this.cbSourceProject = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.cbBackProject = new System.Windows.Forms.ComboBox();
            this.cbBackItem = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.numBackQty = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblBack_Qty = new System.Windows.Forms.Label();
            this.lblBack_TransactionID = new System.Windows.Forms.Label();
            this.FoldingID = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNumQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestinationQty)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBackQty)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.DgvStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Stock";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Short Summary";
            // 
            // DgvStock
            // 
            this.DgvStock.AllowUserToAddRows = false;
            this.DgvStock.AllowUserToDeleteRows = false;
            this.DgvStock.BackgroundColor = System.Drawing.Color.White;
            this.DgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStock.GridColor = System.Drawing.Color.White;
            this.DgvStock.Location = new System.Drawing.Point(8, 45);
            this.DgvStock.Name = "DgvStock";
            this.DgvStock.ReadOnly = true;
            this.DgvStock.Size = new System.Drawing.Size(662, 249);
            this.DgvStock.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.TransactionID);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Move from Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lblUpdateID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblAvInStock);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblUsedQty);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.UpdateNumQty);
            this.groupBox2.Controls.Add(this.cbUpdateProject);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbUpdateItemName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(10, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 129);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Previous";
            // 
            // lblUpdateID
            // 
            this.lblUpdateID.AutoSize = true;
            this.lblUpdateID.Location = new System.Drawing.Point(179, 109);
            this.lblUpdateID.Name = "lblUpdateID";
            this.lblUpdateID.Size = new System.Drawing.Size(52, 16);
            this.lblUpdateID.TabIndex = 59;
            this.lblUpdateID.Text = "label12";
            this.lblUpdateID.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "TransactionID:";
            this.label11.Visible = false;
            // 
            // lblAvInStock
            // 
            this.lblAvInStock.AutoSize = true;
            this.lblAvInStock.Location = new System.Drawing.Point(179, 87);
            this.lblAvInStock.Name = "lblAvInStock";
            this.lblAvInStock.Size = new System.Drawing.Size(15, 16);
            this.lblAvInStock.TabIndex = 57;
            this.lblAvInStock.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "Quantity available in stock:";
            // 
            // lblUsedQty
            // 
            this.lblUsedQty.AutoSize = true;
            this.lblUsedQty.Location = new System.Drawing.Point(179, 65);
            this.lblUsedQty.Name = "lblUsedQty";
            this.lblUsedQty.Size = new System.Drawing.Size(15, 16);
            this.lblUsedQty.TabIndex = 55;
            this.lblUsedQty.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Quantity currenlty on Spot:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 48;
            this.button1.Text = "Apply Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateNumQty
            // 
            this.UpdateNumQty.Location = new System.Drawing.Point(493, 39);
            this.UpdateNumQty.Name = "UpdateNumQty";
            this.UpdateNumQty.Size = new System.Drawing.Size(101, 22);
            this.UpdateNumQty.TabIndex = 53;
            this.UpdateNumQty.ValueChanged += new System.EventHandler(this.UpdateNumQty_ValueChanged);
            // 
            // cbUpdateProject
            // 
            this.cbUpdateProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateProject.FormattingEnabled = true;
            this.cbUpdateProject.Location = new System.Drawing.Point(208, 38);
            this.cbUpdateProject.Name = "cbUpdateProject";
            this.cbUpdateProject.Size = new System.Drawing.Size(279, 24);
            this.cbUpdateProject.TabIndex = 48;
            this.cbUpdateProject.SelectedIndexChanged += new System.EventHandler(this.cbUpdateProject_SelectedIndexChanged);
            this.cbUpdateProject.Click += new System.EventHandler(this.cbUpdateProject_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Quantity";
            // 
            // cbUpdateItemName
            // 
            this.cbUpdateItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateItemName.FormattingEnabled = true;
            this.cbUpdateItemName.Location = new System.Drawing.Point(7, 38);
            this.cbUpdateItemName.Name = "cbUpdateItemName";
            this.cbUpdateItemName.Size = new System.Drawing.Size(192, 24);
            this.cbUpdateItemName.TabIndex = 49;
            this.cbUpdateItemName.Click += new System.EventHandler(this.cbUpdateItemName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Select Item to Update Quantity\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Select Project / Site";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblRemItems);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFoldingItem);
            this.groupBox1.Controls.Add(this.cbProject);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 141);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New";
            // 
            // lblRemItems
            // 
            this.lblRemItems.AutoSize = true;
            this.lblRemItems.Location = new System.Drawing.Point(145, 119);
            this.lblRemItems.Name = "lblRemItems";
            this.lblRemItems.Size = new System.Drawing.Size(15, 16);
            this.lblRemItems.TabIndex = 47;
            this.lblRemItems.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Remaining Items:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(497, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 33);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Apply Changes";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(497, 35);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(101, 22);
            this.numQty.TabIndex = 5;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Item to Move";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Project / Site";
            // 
            // cbFoldingItem
            // 
            this.cbFoldingItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoldingItem.FormattingEnabled = true;
            this.cbFoldingItem.Location = new System.Drawing.Point(294, 36);
            this.cbFoldingItem.Name = "cbFoldingItem";
            this.cbFoldingItem.Size = new System.Drawing.Size(192, 24);
            this.cbFoldingItem.TabIndex = 1;
            this.cbFoldingItem.SelectedIndexChanged += new System.EventHandler(this.cbFoldingItem_SelectedIndexChanged);
            this.cbFoldingItem.Click += new System.EventHandler(this.cbItem_Click);
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(10, 37);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(279, 24);
            this.cbProject.TabIndex = 0;
            this.cbProject.Click += new System.EventHandler(this.cbProject_Click);
            // 
            // TransactionID
            // 
            this.TransactionID.AutoSize = true;
            this.TransactionID.Location = new System.Drawing.Point(10, 288);
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.Size = new System.Drawing.Size(45, 16);
            this.TransactionID.TabIndex = 44;
            this.TransactionID.Text = "label1";
            this.TransactionID.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(671, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Move from Another Site";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save Changes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTransIDtoInsert);
            this.groupBox4.Controls.Add(this.id2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.numDestinationQty);
            this.groupBox4.Controls.Add(this.cbDestinationProject);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(15, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 86);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DESTINATION SITE";
            // 
            // lblTransIDtoInsert
            // 
            this.lblTransIDtoInsert.AutoSize = true;
            this.lblTransIDtoInsert.Location = new System.Drawing.Point(6, 63);
            this.lblTransIDtoInsert.Name = "lblTransIDtoInsert";
            this.lblTransIDtoInsert.Size = new System.Drawing.Size(15, 16);
            this.lblTransIDtoInsert.TabIndex = 12;
            this.lblTransIDtoInsert.Text = "0";
            this.lblTransIDtoInsert.Visible = false;
            // 
            // id2
            // 
            this.id2.AutoSize = true;
            this.id2.Location = new System.Drawing.Point(6, 19);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(15, 16);
            this.id2.TabIndex = 11;
            this.id2.Text = "0";
            this.id2.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(465, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Quantity move:";
            // 
            // numDestinationQty
            // 
            this.numDestinationQty.Location = new System.Drawing.Point(468, 38);
            this.numDestinationQty.Name = "numDestinationQty";
            this.numDestinationQty.Size = new System.Drawing.Size(90, 22);
            this.numDestinationQty.TabIndex = 9;
            // 
            // cbDestinationProject
            // 
            this.cbDestinationProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationProject.FormattingEnabled = true;
            this.cbDestinationProject.Location = new System.Drawing.Point(119, 36);
            this.cbDestinationProject.Name = "cbDestinationProject";
            this.cbDestinationProject.Size = new System.Drawing.Size(302, 24);
            this.cbDestinationProject.TabIndex = 7;
            this.cbDestinationProject.SelectedIndexChanged += new System.EventHandler(this.cbDestinationProject_SelectedIndexChanged);
            this.cbDestinationProject.Click += new System.EventHandler(this.cbDestinationProject_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "TO: Project / Site";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblT_ID);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblPrevQty);
            this.groupBox3.Controls.Add(this.cbSourceItemName);
            this.groupBox3.Controls.Add(this.cbSourceProject);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(13, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 131);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOURCE SITE";
            // 
            // lblT_ID
            // 
            this.lblT_ID.AutoEllipsis = true;
            this.lblT_ID.AutoSize = true;
            this.lblT_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblT_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblT_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_ID.Location = new System.Drawing.Point(485, 87);
            this.lblT_ID.Name = "lblT_ID";
            this.lblT_ID.Size = new System.Drawing.Size(56, 27);
            this.lblT_ID.TabIndex = 10;
            this.lblT_ID.Text = "------";
            this.lblT_ID.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(467, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "TransactionID:";
            this.label17.Visible = false;
            // 
            // lblPrevQty
            // 
            this.lblPrevQty.AutoEllipsis = true;
            this.lblPrevQty.AutoSize = true;
            this.lblPrevQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrevQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrevQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevQty.Location = new System.Drawing.Point(485, 34);
            this.lblPrevQty.Name = "lblPrevQty";
            this.lblPrevQty.Size = new System.Drawing.Size(56, 27);
            this.lblPrevQty.TabIndex = 8;
            this.lblPrevQty.Text = "------";
            // 
            // cbSourceItemName
            // 
            this.cbSourceItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSourceItemName.FormattingEnabled = true;
            this.cbSourceItemName.Location = new System.Drawing.Point(187, 34);
            this.cbSourceItemName.Name = "cbSourceItemName";
            this.cbSourceItemName.Size = new System.Drawing.Size(177, 24);
            this.cbSourceItemName.TabIndex = 5;
            this.cbSourceItemName.SelectedIndexChanged += new System.EventHandler(this.cbSourceItemName_SelectedIndexChanged);
            this.cbSourceItemName.Click += new System.EventHandler(this.cbSourceItemName_Click);
            // 
            // cbSourceProject
            // 
            this.cbSourceProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSourceProject.FormattingEnabled = true;
            this.cbSourceProject.Location = new System.Drawing.Point(144, 101);
            this.cbSourceProject.Name = "cbSourceProject";
            this.cbSourceProject.Size = new System.Drawing.Size(273, 24);
            this.cbSourceProject.TabIndex = 4;
            this.cbSourceProject.SelectedIndexChanged += new System.EventHandler(this.cbSourceProject_SelectedIndexChanged);
            this.cbSourceProject.Click += new System.EventHandler(this.cbSourceProject_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(465, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Quantity Used:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Item Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "FROM: Select Project / Site";
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy       hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(437, 12);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(240, 20);
            this.DateTimee.TabIndex = 45;
            this.DateTimee.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.numBackQty);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.cbBackItem);
            this.tabPage4.Controls.Add(this.cbBackProject);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(671, 310);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Back to Stock";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(223, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Select Project";
            // 
            // cbBackProject
            // 
            this.cbBackProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBackProject.FormattingEnabled = true;
            this.cbBackProject.Location = new System.Drawing.Point(171, 40);
            this.cbBackProject.Name = "cbBackProject";
            this.cbBackProject.Size = new System.Drawing.Size(195, 24);
            this.cbBackProject.TabIndex = 1;
            this.cbBackProject.Click += new System.EventHandler(this.cbBackProject_Click);
            // 
            // cbBackItem
            // 
            this.cbBackItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBackItem.FormattingEnabled = true;
            this.cbBackItem.Location = new System.Drawing.Point(200, 102);
            this.cbBackItem.Name = "cbBackItem";
            this.cbBackItem.Size = new System.Drawing.Size(155, 24);
            this.cbBackItem.TabIndex = 2;
            this.cbBackItem.SelectedIndexChanged += new System.EventHandler(this.cbBackItem_SelectedIndexChanged);
            this.cbBackItem.Click += new System.EventHandler(this.cbBackItem_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(232, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Select Item";
            // 
            // numBackQty
            // 
            this.numBackQty.Location = new System.Drawing.Point(528, 243);
            this.numBackQty.Name = "numBackQty";
            this.numBackQty.Size = new System.Drawing.Size(120, 22);
            this.numBackQty.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Send back to Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(538, 222);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 16);
            this.label20.TabIndex = 6;
            this.label20.Text = "Quantity to move:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FoldingID);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.lblBack_TransactionID);
            this.groupBox5.Controls.Add(this.lblBack_Qty);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(29, 256);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 48);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Previous Information";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Item(s) used: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "TransactionID: ";
            this.label22.Visible = false;
            // 
            // lblBack_Qty
            // 
            this.lblBack_Qty.AutoSize = true;
            this.lblBack_Qty.Location = new System.Drawing.Point(143, 24);
            this.lblBack_Qty.Name = "lblBack_Qty";
            this.lblBack_Qty.Size = new System.Drawing.Size(52, 16);
            this.lblBack_Qty.TabIndex = 2;
            this.lblBack_Qty.Text = "label23";
            // 
            // lblBack_TransactionID
            // 
            this.lblBack_TransactionID.AutoSize = true;
            this.lblBack_TransactionID.Location = new System.Drawing.Point(143, 50);
            this.lblBack_TransactionID.Name = "lblBack_TransactionID";
            this.lblBack_TransactionID.Size = new System.Drawing.Size(52, 16);
            this.lblBack_TransactionID.TabIndex = 3;
            this.lblBack_TransactionID.Text = "label24";
            this.lblBack_TransactionID.Visible = false;
            // 
            // FoldingID
            // 
            this.FoldingID.AutoSize = true;
            this.FoldingID.Location = new System.Drawing.Point(143, 82);
            this.FoldingID.Name = "FoldingID";
            this.FoldingID.Size = new System.Drawing.Size(52, 16);
            this.FoldingID.TabIndex = 5;
            this.FoldingID.Text = "label24";
            this.FoldingID.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 16);
            this.label24.TabIndex = 4;
            this.label24.Text = "FoldingID";
            this.label24.Visible = false;
            // 
            // frmStockMoving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(687, 402);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DateTimee);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmStockMoving";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Moving";
            this.Load += new System.EventHandler(this.frmStockMoving_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockMoving_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNumQty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestinationQty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBackQty)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvStock;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFoldingItem;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label lblRemItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.Label TransactionID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown UpdateNumQty;
        private System.Windows.Forms.ComboBox cbUpdateProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUpdateItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsedQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAvInStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUpdateID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numDestinationQty;
        private System.Windows.Forms.Label lblPrevQty;
        private System.Windows.Forms.ComboBox cbDestinationProject;
        private System.Windows.Forms.ComboBox cbSourceItemName;
        private System.Windows.Forms.ComboBox cbSourceProject;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblT_ID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label id2;
        private System.Windows.Forms.Label lblTransIDtoInsert;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numBackQty;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbBackItem;
        private System.Windows.Forms.ComboBox cbBackProject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblBack_TransactionID;
        private System.Windows.Forms.Label lblBack_Qty;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label FoldingID;
        private System.Windows.Forms.Label label24;
    }
}
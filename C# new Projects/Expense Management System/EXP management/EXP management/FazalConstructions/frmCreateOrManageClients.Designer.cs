namespace FazalConstructions
{
    partial class frmCreateOrManageClients
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
            this.components = new System.ComponentModel.Container();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLandLine = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCell = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.tbPresentAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTipCreateClients = new System.Windows.Forms.ToolTip(this.components);
            this.btnCreateNewAccount = new System.Windows.Forms.Button();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.cbEdit = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpdateExistingAccount = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbox_New = new System.Windows.Forms.GroupBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.cbCity = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbox_update = new System.Windows.Forms.GroupBox();
            this.LBL_DATE = new System.Windows.Forms.Label();
            this.lbl_C_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.gbox_New.SuspendLayout();
            this.gbox_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(102, 47);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbName.Size = new System.Drawing.Size(187, 22);
            this.tbName.TabIndex = 0;
            this.toolTipCreateClients.SetToolTip(this.tbName, "Type Client Full Name here (Required) - Max 30 Char");
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = " Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CNIC #";
            // 
            // tbCNIC
            // 
            this.tbCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCNIC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCNIC.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCNIC.Location = new System.Drawing.Point(101, 75);
            this.tbCNIC.Name = "tbCNIC";
            this.tbCNIC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCNIC.Size = new System.Drawing.Size(187, 22);
            this.tbCNIC.TabIndex = 1;
            this.toolTipCreateClients.SetToolTip(this.tbCNIC, "Type Client CNIC # (Required) - Max 30 Char");
            this.tbCNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNIC_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Landline";
            // 
            // tbLandLine
            // 
            this.tbLandLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLandLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbLandLine.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLandLine.Location = new System.Drawing.Point(101, 101);
            this.tbLandLine.Name = "tbLandLine";
            this.tbLandLine.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLandLine.Size = new System.Drawing.Size(187, 22);
            this.tbLandLine.TabIndex = 2;
            this.toolTipCreateClients.SetToolTip(this.tbLandLine, "Type Client Landline No (Optional) - Max 30 Char");
            this.tbLandLine.TextChanged += new System.EventHandler(this.tbLandLine_TextChanged);
            this.tbLandLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLandLine_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cell #";
            // 
            // tbCell
            // 
            this.tbCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCell.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCell.Location = new System.Drawing.Point(101, 127);
            this.tbCell.Name = "tbCell";
            this.tbCell.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCell.Size = new System.Drawing.Size(187, 22);
            this.tbCell.TabIndex = 3;
            this.toolTipCreateClients.SetToolTip(this.tbCell, "Type Client Cell No (Required) - Max 30 Char");
            this.tbCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCell_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Comments";
            // 
            // tbComments
            // 
            this.tbComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbComments.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbComments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbComments.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComments.Location = new System.Drawing.Point(102, 159);
            this.tbComments.MaxLength = 500;
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbComments.Size = new System.Drawing.Size(187, 72);
            this.tbComments.TabIndex = 4;
            this.toolTipCreateClients.SetToolTip(this.tbComments, "Extra Notes && Comments (Optional) - Max 500 Char");
            // 
            // tbPresentAddress
            // 
            this.tbPresentAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPresentAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPresentAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPresentAddress.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPresentAddress.Location = new System.Drawing.Point(296, 127);
            this.tbPresentAddress.MaxLength = 300;
            this.tbPresentAddress.Name = "tbPresentAddress";
            this.tbPresentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPresentAddress.Size = new System.Drawing.Size(296, 22);
            this.tbPresentAddress.TabIndex = 7;
            this.toolTipCreateClients.SetToolTip(this.tbPresentAddress, "Enter Permanent Address (Required) - Max 300 Char");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Country";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(297, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Present Address";
            // 
            // toolTipCreateClients
            // 
            this.toolTipCreateClients.AutomaticDelay = 100;
            this.toolTipCreateClients.AutoPopDelay = 6000;
            this.toolTipCreateClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolTipCreateClients.InitialDelay = 100;
            this.toolTipCreateClients.ReshowDelay = 20;
            this.toolTipCreateClients.ShowAlways = true;
            this.toolTipCreateClients.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipCreateClients.ToolTipTitle = "Create or Manage Clients";
            // 
            // btnCreateNewAccount
            // 
            this.btnCreateNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNewAccount.Enabled = false;
            this.btnCreateNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewAccount.ForeColor = System.Drawing.Color.Green;
            this.btnCreateNewAccount.Location = new System.Drawing.Point(626, 56);
            this.btnCreateNewAccount.Name = "btnCreateNewAccount";
            this.btnCreateNewAccount.Size = new System.Drawing.Size(113, 86);
            this.btnCreateNewAccount.TabIndex = 0;
            this.btnCreateNewAccount.Text = "Create New Account";
            this.toolTipCreateClients.SetToolTip(this.btnCreateNewAccount, "Click here to Create Client");
            this.btnCreateNewAccount.UseVisualStyleBackColor = true;
            this.btnCreateNewAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbProjectName
            // 
            this.tbProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProjectName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProjectName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbProjectName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectName.Location = new System.Drawing.Point(102, 239);
            this.tbProjectName.MaxLength = 100;
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProjectName.Size = new System.Drawing.Size(506, 22);
            this.tbProjectName.TabIndex = 8;
            this.toolTipCreateClients.SetToolTip(this.tbProjectName, "Project Name associated with this Client");
            // 
            // cbEdit
            // 
            this.cbEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEdit.FormattingEnabled = true;
            this.cbEdit.Location = new System.Drawing.Point(6, 62);
            this.cbEdit.Name = "cbEdit";
            this.cbEdit.Size = new System.Drawing.Size(235, 21);
            this.cbEdit.TabIndex = 0;
            this.toolTipCreateClients.SetToolTip(this.cbEdit, "Select Client Name from List");
            this.cbEdit.SelectedIndexChanged += new System.EventHandler(this.cbEdit_SelectedIndexChanged);
            this.cbEdit.Click += new System.EventHandler(this.cbEdit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Green;
            this.btnLoad.Location = new System.Drawing.Point(23, 89);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 26);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Data";
            this.toolTipCreateClients.SetToolTip(this.btnLoad, "Click to Update");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdateExistingAccount
            // 
            this.btnUpdateExistingAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateExistingAccount.Enabled = false;
            this.btnUpdateExistingAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExistingAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExistingAccount.ForeColor = System.Drawing.Color.Green;
            this.btnUpdateExistingAccount.Location = new System.Drawing.Point(641, 175);
            this.btnUpdateExistingAccount.Name = "btnUpdateExistingAccount";
            this.btnUpdateExistingAccount.Size = new System.Drawing.Size(78, 49);
            this.btnUpdateExistingAccount.TabIndex = 0;
            this.btnUpdateExistingAccount.Text = "Update";
            this.toolTipCreateClients.SetToolTip(this.btnUpdateExistingAccount, "Click here to Create Client");
            this.btnUpdateExistingAccount.UseVisualStyleBackColor = true;
            this.btnUpdateExistingAccount.Click += new System.EventHandler(this.btnUpdateExistingAccount_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Location = new System.Drawing.Point(641, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.toolTipCreateClients.SetToolTip(this.btnDelete, "Click to delete");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbox_New
            // 
            this.gbox_New.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_New.Controls.Add(this.rbInactive);
            this.gbox_New.Controls.Add(this.rbActive);
            this.gbox_New.Controls.Add(this.cbCity);
            this.gbox_New.Controls.Add(this.cbCountry);
            this.gbox_New.Controls.Add(this.lbl_ID);
            this.gbox_New.Controls.Add(this.label16);
            this.gbox_New.Controls.Add(this.tbProjectName);
            this.gbox_New.Controls.Add(this.label13);
            this.gbox_New.Controls.Add(this.tbName);
            this.gbox_New.Controls.Add(this.label12);
            this.gbox_New.Controls.Add(this.label3);
            this.gbox_New.Controls.Add(this.label11);
            this.gbox_New.Controls.Add(this.tbCNIC);
            this.gbox_New.Controls.Add(this.label10);
            this.gbox_New.Controls.Add(this.label4);
            this.gbox_New.Controls.Add(this.tbLandLine);
            this.gbox_New.Controls.Add(this.label5);
            this.gbox_New.Controls.Add(this.tbPresentAddress);
            this.gbox_New.Controls.Add(this.tbCell);
            this.gbox_New.Controls.Add(this.label6);
            this.gbox_New.Controls.Add(this.tbComments);
            this.gbox_New.Controls.Add(this.label7);
            this.gbox_New.Enabled = false;
            this.gbox_New.Location = new System.Drawing.Point(4, 48);
            this.gbox_New.Name = "gbox_New";
            this.gbox_New.Size = new System.Drawing.Size(616, 292);
            this.gbox_New.TabIndex = 22;
            this.gbox_New.TabStop = false;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(459, 267);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(133, 17);
            this.rbInactive.TabIndex = 10;
            this.rbInactive.Text = "This client is not active";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.Location = new System.Drawing.Point(137, 267);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(115, 17);
            this.rbActive.TabIndex = 9;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "This is active client";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // cbCity
            // 
            this.cbCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCity.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCity.Location = new System.Drawing.Point(459, 72);
            this.cbCity.Name = "cbCity";
            this.cbCity.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cbCity.Size = new System.Drawing.Size(133, 22);
            this.cbCity.TabIndex = 6;
            // 
            // cbCountry
            // 
            this.cbCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCountry.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.Location = new System.Drawing.Point(302, 72);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cbCountry.Size = new System.Drawing.Size(132, 22);
            this.cbCountry.TabIndex = 5;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(180, 25);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(61, 12);
            this.lbl_ID.TabIndex = 25;
            this.lbl_ID.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(39, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Project Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Select Project Name to Update";
            // 
            // gbox_update
            // 
            this.gbox_update.Controls.Add(this.LBL_DATE);
            this.gbox_update.Controls.Add(this.lbl_C_ID);
            this.gbox_update.Controls.Add(this.label1);
            this.gbox_update.Controls.Add(this.btnLoad);
            this.gbox_update.Controls.Add(this.label15);
            this.gbox_update.Controls.Add(this.cbEdit);
            this.gbox_update.Enabled = false;
            this.gbox_update.Location = new System.Drawing.Point(214, 346);
            this.gbox_update.Name = "gbox_update";
            this.gbox_update.Size = new System.Drawing.Size(247, 119);
            this.gbox_update.TabIndex = 26;
            this.gbox_update.TabStop = false;
            // 
            // LBL_DATE
            // 
            this.LBL_DATE.AutoSize = true;
            this.LBL_DATE.Location = new System.Drawing.Point(112, 96);
            this.LBL_DATE.Name = "LBL_DATE";
            this.LBL_DATE.Size = new System.Drawing.Size(0, 13);
            this.LBL_DATE.TabIndex = 33;
            // 
            // lbl_C_ID
            // 
            this.lbl_C_ID.AutoSize = true;
            this.lbl_C_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_C_ID.Location = new System.Drawing.Point(94, 46);
            this.lbl_C_ID.Name = "lbl_C_ID";
            this.lbl_C_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_C_ID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Client ID:";
            // 
            // rbCreate
            // 
            this.rbCreate.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCreate.AutoSize = true;
            this.rbCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbCreate.FlatAppearance.BorderSize = 3;
            this.rbCreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbCreate.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbCreate.Location = new System.Drawing.Point(4, 12);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(152, 27);
            this.rbCreate.TabIndex = 28;
            this.rbCreate.Text = "Create New Client";
            this.rbCreate.UseVisualStyleBackColor = false;
            this.rbCreate.CheckedChanged += new System.EventHandler(this.rbCreate_CheckedChanged);
            // 
            // rbUpdate
            // 
            this.rbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbUpdate.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbUpdate.FlatAppearance.BorderSize = 3;
            this.rbUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbUpdate.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbUpdate.Location = new System.Drawing.Point(433, 12);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(187, 27);
            this.rbUpdate.TabIndex = 29;
            this.rbUpdate.Text = "Update Existing Client";
            this.rbUpdate.UseVisualStyleBackColor = false;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "OR";
            // 
            // DateTimee
            // 
            this.DateTimee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimee.CustomFormat = "dd/MM/yyyy       hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(512, 445);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(218, 20);
            this.DateTimee.TabIndex = 32;
            this.DateTimee.TabStop = false;
            this.DateTimee.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmCreateOrManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(742, 467);
            this.Controls.Add(this.DateTimee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateExistingAccount);
            this.Controls.Add(this.rbUpdate);
            this.Controls.Add(this.rbCreate);
            this.Controls.Add(this.gbox_update);
            this.Controls.Add(this.gbox_New);
            this.Controls.Add(this.btnCreateNewAccount);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmCreateOrManageClients";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Or Manage Clients";
            this.Load += new System.EventHandler(this.frmCreateOrManageClients_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCreateOrManageClients_KeyDown);
            this.gbox_New.ResumeLayout(false);
            this.gbox_New.PerformLayout();
            this.gbox_update.ResumeLayout(false);
            this.gbox_update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLandLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.TextBox tbPresentAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTipCreateClients;
        private System.Windows.Forms.GroupBox gbox_New;
        private System.Windows.Forms.Button btnCreateNewAccount;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbEdit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbox_update;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_C_ID;
        private System.Windows.Forms.TextBox cbCity;
        private System.Windows.Forms.TextBox cbCountry;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.Button btnUpdateExistingAccount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Label LBL_DATE;
    }
}
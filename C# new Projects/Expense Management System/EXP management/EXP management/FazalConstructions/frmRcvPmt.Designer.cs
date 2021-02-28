namespace FazalConstructions
{
    partial class frmRcvPmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRcvPmt));
            this.tbRcvPmt = new System.Windows.Forms.TextBox();
            this.tbRcvName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPaidBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbChqNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBankName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.singleDash = new System.Windows.Forms.Label();
            this.cbPmtModeID = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl_m_toal = new System.Windows.Forms.Label();
            this.dash = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalExp = new System.Windows.Forms.Label();
            this.lblRcvPayment = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RcvAmtGrid = new System.Windows.Forms.DataGridView();
            this.TotalAmtGrid = new System.Windows.Forms.DataGridView();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_P_ID = new System.Windows.Forms.ComboBox();
            this.PrintSlip = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RcvAmtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalAmtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRcvPmt
            // 
            this.tbRcvPmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRcvPmt.Location = new System.Drawing.Point(138, 29);
            this.tbRcvPmt.Name = "tbRcvPmt";
            this.tbRcvPmt.Size = new System.Drawing.Size(159, 22);
            this.tbRcvPmt.TabIndex = 40;
            this.tbRcvPmt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbRcvPmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRcvPmt_KeyPress);
            // 
            // tbRcvName
            // 
            this.tbRcvName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRcvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRcvName.Location = new System.Drawing.Point(138, 69);
            this.tbRcvName.Name = "tbRcvName";
            this.tbRcvName.Size = new System.Drawing.Size(159, 22);
            this.tbRcvName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Receive Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Receiver Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Paid by:";
            // 
            // tbPaidBy
            // 
            this.tbPaidBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPaidBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaidBy.Location = new System.Drawing.Point(138, 107);
            this.tbPaidBy.Name = "tbPaidBy";
            this.tbPaidBy.Size = new System.Drawing.Size(159, 22);
            this.tbPaidBy.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Payment Method:";
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy  hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(557, 13);
            this.DateTimee.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(180, 20);
            this.DateTimee.TabIndex = 49;
            this.DateTimee.TabStop = false;
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(139, 234);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(158, 46);
            this.tbDesc.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Narration:";
            // 
            // tbChqNo
            // 
            this.tbChqNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChqNo.Location = new System.Drawing.Point(138, 178);
            this.tbChqNo.Name = "tbChqNo";
            this.tbChqNo.Size = new System.Drawing.Size(159, 22);
            this.tbChqNo.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "CHQ #:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(12, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbBankName);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.singleDash);
            this.splitContainer1.Panel1.Controls.Add(this.cbPmtModeID);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tbRcvPmt);
            this.splitContainer1.Panel1.Controls.Add(this.tbRcvName);
            this.splitContainer1.Panel1.Controls.Add(this.tbChqNo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tbPaidBy);
            this.splitContainer1.Panel1.Controls.Add(this.tbDesc);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.lbl_m_toal);
            this.splitContainer1.Panel2.Controls.Add(this.dash);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalExp);
            this.splitContainer1.Panel2.Controls.Add(this.lblRcvPayment);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.RcvAmtGrid);
            this.splitContainer1.Panel2.Controls.Add(this.TotalAmtGrid);
            this.splitContainer1.Size = new System.Drawing.Size(728, 488);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Bank Name:";
            // 
            // tbBankName
            // 
            this.tbBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBankName.Location = new System.Drawing.Point(139, 206);
            this.tbBankName.Name = "tbBankName";
            this.tbBankName.Size = new System.Drawing.Size(159, 22);
            this.tbBankName.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(25, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 158);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Links";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(34, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 40);
            this.button3.TabIndex = 64;
            this.button3.Text = "Receive Payment Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 43);
            this.button2.TabIndex = 63;
            this.button2.Text = "Update Previous Payments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // singleDash
            // 
            this.singleDash.Location = new System.Drawing.Point(50, 448);
            this.singleDash.Name = "singleDash";
            this.singleDash.Size = new System.Drawing.Size(82, 22);
            this.singleDash.TabIndex = 62;
            this.singleDash.Text = "-----------------------------";
            this.singleDash.Visible = false;
            // 
            // cbPmtModeID
            // 
            this.cbPmtModeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPmtModeID.FormattingEnabled = true;
            this.cbPmtModeID.Location = new System.Drawing.Point(138, 151);
            this.cbPmtModeID.Name = "cbPmtModeID";
            this.cbPmtModeID.Size = new System.Drawing.Size(156, 21);
            this.cbPmtModeID.TabIndex = 59;
            this.cbPmtModeID.SelectedIndexChanged += new System.EventHandler(this.cbPmtModeID_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(138, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 28);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Process Payment";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_m_toal
            // 
            this.lbl_m_toal.AutoSize = true;
            this.lbl_m_toal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m_toal.ForeColor = System.Drawing.Color.Red;
            this.lbl_m_toal.Location = new System.Drawing.Point(191, 440);
            this.lbl_m_toal.Name = "lbl_m_toal";
            this.lbl_m_toal.Size = new System.Drawing.Size(18, 20);
            this.lbl_m_toal.TabIndex = 17;
            this.lbl_m_toal.Text = "0";
            // 
            // dash
            // 
            this.dash.Location = new System.Drawing.Point(32, 460);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(283, 13);
            this.dash.TabIndex = 61;
            this.dash.Text = "=============================================================================";
            this.dash.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(41, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "TOTAL:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(36, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(265, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "===========================================";
            // 
            // lblTotalExp
            // 
            this.lblTotalExp.AutoSize = true;
            this.lblTotalExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExp.Location = new System.Drawing.Point(191, 410);
            this.lblTotalExp.Name = "lblTotalExp";
            this.lblTotalExp.Size = new System.Drawing.Size(15, 16);
            this.lblTotalExp.TabIndex = 14;
            this.lblTotalExp.Text = "0";
            // 
            // lblRcvPayment
            // 
            this.lblRcvPayment.AutoSize = true;
            this.lblRcvPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcvPayment.Location = new System.Drawing.Point(190, 385);
            this.lblRcvPayment.Name = "lblRcvPayment";
            this.lblRcvPayment.Size = new System.Drawing.Size(15, 16);
            this.lblRcvPayment.TabIndex = 13;
            this.lblRcvPayment.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total Received Payment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total Expense:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(97, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "RECEIVED PAYMENT DETAIL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "EXPENSE DETAIL";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // RcvAmtGrid
            // 
            this.RcvAmtGrid.AllowUserToAddRows = false;
            this.RcvAmtGrid.AllowUserToDeleteRows = false;
            this.RcvAmtGrid.BackgroundColor = System.Drawing.Color.White;
            this.RcvAmtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RcvAmtGrid.GridColor = System.Drawing.Color.White;
            this.RcvAmtGrid.Location = new System.Drawing.Point(2, 234);
            this.RcvAmtGrid.Name = "RcvAmtGrid";
            this.RcvAmtGrid.ReadOnly = true;
            this.RcvAmtGrid.Size = new System.Drawing.Size(353, 143);
            this.RcvAmtGrid.TabIndex = 7;
            // 
            // TotalAmtGrid
            // 
            this.TotalAmtGrid.AllowUserToAddRows = false;
            this.TotalAmtGrid.AllowUserToDeleteRows = false;
            this.TotalAmtGrid.BackgroundColor = System.Drawing.Color.White;
            this.TotalAmtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalAmtGrid.GridColor = System.Drawing.Color.White;
            this.TotalAmtGrid.Location = new System.Drawing.Point(4, 30);
            this.TotalAmtGrid.Name = "TotalAmtGrid";
            this.TotalAmtGrid.ReadOnly = true;
            this.TotalAmtGrid.Size = new System.Drawing.Size(353, 176);
            this.TotalAmtGrid.TabIndex = 6;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(227, 47);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(42, 13);
            this.lbl_user.TabIndex = 57;
            this.lbl_user.Text = "VALUE";
            this.lbl_user.Visible = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(73, 45);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(42, 13);
            this.lbl_ID.TabIndex = 58;
            this.lbl_ID.Text = "VALUE";
            this.lbl_ID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Serial #:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "USER ID:";
            this.label9.Visible = false;
            // 
            // cb_P_ID
            // 
            this.cb_P_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_P_ID.FormattingEnabled = true;
            this.cb_P_ID.Location = new System.Drawing.Point(18, 12);
            this.cb_P_ID.Name = "cb_P_ID";
            this.cb_P_ID.Size = new System.Drawing.Size(358, 21);
            this.cb_P_ID.TabIndex = 62;
            this.cb_P_ID.SelectedIndexChanged += new System.EventHandler(this.cb_P_ID_SelectedIndexChanged);
            this.cb_P_ID.Click += new System.EventHandler(this.cb_P_ID_Click);
            // 
            // PrintSlip
            // 
            this.PrintSlip.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintSlip_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.PrintSlip;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // frmRcvPmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 555);
            this.Controls.Add(this.cb_P_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.DateTimee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmRcvPmt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive Payment";
            this.Load += new System.EventHandler(this.frmRcvPmt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRcvPmt_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RcvAmtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalAmtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRcvPmt;
        private System.Windows.Forms.TextBox tbRcvName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPaidBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbChqNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView RcvAmtGrid;
        private System.Windows.Forms.DataGridView TotalAmtGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalExp;
        private System.Windows.Forms.Label lblRcvPayment;
        private System.Windows.Forms.Label lbl_m_toal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_P_ID;
        private System.Windows.Forms.ComboBox cbPmtModeID;
        private System.Drawing.Printing.PrintDocument PrintSlip;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label singleDash;
        private System.Windows.Forms.Label dash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBankName;
        private System.Windows.Forms.Label label7;
    }
}
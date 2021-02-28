namespace FazalConstructions
{
    partial class frmCreatePersonalExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatePersonalExpense));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRecName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAmt = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExpDgv = new System.Windows.Forms.DataGridView();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.Label();
            this.updateID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SlipPrint = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.singleDash = new System.Windows.Forms.Label();
            this.dash = new System.Windows.Forms.Label();
            this.cbExpTitle = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpDgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Title";
            // 
            // tbDescription
            // 
            this.tbDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescription.Location = new System.Drawing.Point(102, 35);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(170, 82);
            this.tbDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // tbQty
            // 
            this.tbQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbQty.Location = new System.Drawing.Point(102, 152);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(175, 20);
            this.tbQty.TabIndex = 3;
            this.tbQty.Text = "0";
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity (Optional)";
            // 
            // tbRecName
            // 
            this.tbRecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRecName.Location = new System.Drawing.Point(102, 183);
            this.tbRecName.Name = "tbRecName";
            this.tbRecName.Size = new System.Drawing.Size(174, 20);
            this.tbRecName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Receiver(Optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount";
            // 
            // tbAmt
            // 
            this.tbAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAmt.Location = new System.Drawing.Point(101, 123);
            this.tbAmt.Name = "tbAmt";
            this.tbAmt.Size = new System.Drawing.Size(175, 20);
            this.tbAmt.TabIndex = 2;
            this.tbAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmt_KeyPress);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(6, 28);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(482, 41);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create this Personal Expense";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpDgv);
            this.groupBox1.Controls.Add(this.DateTimee);
            this.groupBox1.Location = new System.Drawing.Point(282, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 195);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ExpDgv
            // 
            this.ExpDgv.AllowUserToAddRows = false;
            this.ExpDgv.AllowUserToDeleteRows = false;
            this.ExpDgv.BackgroundColor = System.Drawing.Color.White;
            this.ExpDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpDgv.GridColor = System.Drawing.Color.White;
            this.ExpDgv.Location = new System.Drawing.Point(6, 27);
            this.ExpDgv.MultiSelect = false;
            this.ExpDgv.Name = "ExpDgv";
            this.ExpDgv.ReadOnly = true;
            this.ExpDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpDgv.Size = new System.Drawing.Size(389, 158);
            this.ExpDgv.TabIndex = 0;
            this.ExpDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpDgv_CellClick);
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy       hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(179, 7);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(216, 20);
            this.DateTimee.TabIndex = 33;
            this.DateTimee.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(5, 113);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(35, 13);
            this.ID.TabIndex = 15;
            this.ID.Text = "label6";
            this.ID.Visible = false;
            // 
            // updateID
            // 
            this.updateID.AutoSize = true;
            this.updateID.Location = new System.Drawing.Point(20, 83);
            this.updateID.Name = "updateID";
            this.updateID.Size = new System.Drawing.Size(35, 13);
            this.updateID.TabIndex = 34;
            this.updateID.Text = "label6";
            this.updateID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Location = new System.Drawing.Point(17, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 75);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options:";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(519, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 41);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete this Expense";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "OR";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(536, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 36;
            this.button1.Text = "View Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // SlipPrint
            // 
            this.SlipPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.SlipPrint_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // singleDash
            // 
            this.singleDash.Location = new System.Drawing.Point(58, 222);
            this.singleDash.Name = "singleDash";
            this.singleDash.Size = new System.Drawing.Size(254, 22);
            this.singleDash.TabIndex = 47;
            this.singleDash.Text = "-----------------------------";
            this.singleDash.Visible = false;
            // 
            // dash
            // 
            this.dash.Location = new System.Drawing.Point(17, 206);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(446, 13);
            this.dash.TabIndex = 46;
            this.dash.Text = "=============================================================================";
            this.dash.Visible = false;
            // 
            // cbExpTitle
            // 
            this.cbExpTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExpTitle.FormattingEnabled = true;
            this.cbExpTitle.Location = new System.Drawing.Point(101, 12);
            this.cbExpTitle.Name = "cbExpTitle";
            this.cbExpTitle.Size = new System.Drawing.Size(172, 21);
            this.cbExpTitle.TabIndex = 48;
            // 
            // frmCreatePersonalExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(689, 329);
            this.Controls.Add(this.cbExpTitle);
            this.Controls.Add(this.singleDash);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.updateID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRecName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreatePersonalExpense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create & Manage Personal Expense";
            this.Load += new System.EventHandler(this.frmCreatePersonalExpense_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpDgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRecName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAmt;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ExpDgv;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label updateID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument SlipPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label singleDash;
        private System.Windows.Forms.Label dash;
        private System.Windows.Forms.ComboBox cbExpTitle;
    }
}
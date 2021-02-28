namespace FazalConstructions
{
    partial class frmViewRcvPmt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbPaidBy = new System.Windows.Forms.TextBox();
            this.tbReceivedBy = new System.Windows.Forms.TextBox();
            this.tbBankName = new System.Windows.Forms.TextBox();
            this.tbChqNo = new System.Windows.Forms.TextBox();
            this.tbPaymentMode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 72);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(12, 38);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(100, 22);
            this.tbProjectName.TabIndex = 1;
            this.tbProjectName.TextChanged += new System.EventHandler(this.tbProjectName_TextChanged);
            // 
            // tbPaidBy
            // 
            this.tbPaidBy.Location = new System.Drawing.Point(118, 38);
            this.tbPaidBy.Name = "tbPaidBy";
            this.tbPaidBy.Size = new System.Drawing.Size(100, 22);
            this.tbPaidBy.TabIndex = 2;
            this.tbPaidBy.TextChanged += new System.EventHandler(this.tbPaidBy_TextChanged);
            // 
            // tbReceivedBy
            // 
            this.tbReceivedBy.Location = new System.Drawing.Point(224, 38);
            this.tbReceivedBy.Name = "tbReceivedBy";
            this.tbReceivedBy.Size = new System.Drawing.Size(100, 22);
            this.tbReceivedBy.TabIndex = 3;
            this.tbReceivedBy.TextChanged += new System.EventHandler(this.tbReceivedBy_TextChanged);
            // 
            // tbBankName
            // 
            this.tbBankName.Location = new System.Drawing.Point(542, 38);
            this.tbBankName.Name = "tbBankName";
            this.tbBankName.Size = new System.Drawing.Size(100, 22);
            this.tbBankName.TabIndex = 6;
            this.tbBankName.TextChanged += new System.EventHandler(this.tbBankName_TextChanged);
            // 
            // tbChqNo
            // 
            this.tbChqNo.Location = new System.Drawing.Point(436, 38);
            this.tbChqNo.Name = "tbChqNo";
            this.tbChqNo.Size = new System.Drawing.Size(100, 22);
            this.tbChqNo.TabIndex = 5;
            this.tbChqNo.TextChanged += new System.EventHandler(this.tbChqNo_TextChanged);
            // 
            // tbPaymentMode
            // 
            this.tbPaymentMode.Location = new System.Drawing.Point(330, 38);
            this.tbPaymentMode.Name = "tbPaymentMode";
            this.tbPaymentMode.Size = new System.Drawing.Size(100, 22);
            this.tbPaymentMode.TabIndex = 4;
            this.tbPaymentMode.TextChanged += new System.EventHandler(this.tbPaymentMode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Paid By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Received by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Payment Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "CHQ #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bank Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(648, 38);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(66, 22);
            this.tbID.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmViewRcvPmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(759, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBankName);
            this.Controls.Add(this.tbChqNo);
            this.Controls.Add(this.tbPaymentMode);
            this.Controls.Add(this.tbReceivedBy);
            this.Controls.Add(this.tbPaidBy);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmViewRcvPmt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Receive Payment";
            this.Load += new System.EventHandler(this.frmViewRcvPmt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmViewRcvPmt_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbPaidBy;
        private System.Windows.Forms.TextBox tbReceivedBy;
        private System.Windows.Forms.TextBox tbBankName;
        private System.Windows.Forms.TextBox tbChqNo;
        private System.Windows.Forms.TextBox tbPaymentMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button button1;
    }
}
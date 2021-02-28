namespace FazalConstructions
{
    partial class frmExtraExpense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbExp = new System.Windows.Forms.ComboBox();
            this.tbAmt = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNarration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Expense:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount:";
            // 
            // cbExp
            // 
            this.cbExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExp.FormattingEnabled = true;
            this.cbExp.Location = new System.Drawing.Point(134, 31);
            this.cbExp.Name = "cbExp";
            this.cbExp.Size = new System.Drawing.Size(233, 24);
            this.cbExp.Sorted = true;
            this.cbExp.TabIndex = 2;
            this.cbExp.Click += new System.EventHandler(this.cbExp_Click);
            // 
            // tbAmt
            // 
            this.tbAmt.Location = new System.Drawing.Point(134, 77);
            this.tbAmt.Name = "tbAmt";
            this.tbAmt.Size = new System.Drawing.Size(232, 22);
            this.tbAmt.TabIndex = 3;
            this.tbAmt.Text = "0";
            this.tbAmt.TextChanged += new System.EventHandler(this.tbAmt_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(281, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy       hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(148, 5);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(218, 20);
            this.DateTimee.TabIndex = 34;
            this.DateTimee.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 32);
            this.button1.TabIndex = 35;
            this.button1.Text = "Save Expense";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNarration
            // 
            this.tbNarration.Location = new System.Drawing.Point(134, 105);
            this.tbNarration.Multiline = true;
            this.tbNarration.Name = "tbNarration";
            this.tbNarration.Size = new System.Drawing.Size(232, 52);
            this.tbNarration.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Amount:";
            // 
            // frmExtraExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(379, 207);
            this.Controls.Add(this.tbNarration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTimee);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbAmt);
            this.Controls.Add(this.cbExp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmExtraExpense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extra Expense";
            this.Load += new System.EventHandler(this.frmExtraExpense_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmExtraExpense_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbExp;
        private System.Windows.Forms.TextBox tbAmt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNarration;
        private System.Windows.Forms.Label label3;
    }
}
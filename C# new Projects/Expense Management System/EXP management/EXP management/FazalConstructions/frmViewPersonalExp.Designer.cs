namespace FazalConstructions
{
    partial class frmViewPersonalExp
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
            this.cbExpTitle = new System.Windows.Forms.TextBox();
            this.updateID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRecName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PrintSlip = new System.Drawing.Printing.PrintDocument();
            this.singleDash = new System.Windows.Forms.Label();
            this.dash = new System.Windows.Forms.Label();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbExpTitle
            // 
            this.cbExpTitle.Location = new System.Drawing.Point(119, 10);
            this.cbExpTitle.Name = "cbExpTitle";
            this.cbExpTitle.ReadOnly = true;
            this.cbExpTitle.Size = new System.Drawing.Size(170, 22);
            this.cbExpTitle.TabIndex = 35;
            // 
            // updateID
            // 
            this.updateID.AutoSize = true;
            this.updateID.Location = new System.Drawing.Point(12, 219);
            this.updateID.Name = "updateID";
            this.updateID.Size = new System.Drawing.Size(45, 16);
            this.updateID.TabIndex = 45;
            this.updateID.Text = "label6";
            this.updateID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Amount";
            // 
            // tbAmt
            // 
            this.tbAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAmt.Location = new System.Drawing.Point(120, 40);
            this.tbAmt.Name = "tbAmt";
            this.tbAmt.ReadOnly = true;
            this.tbAmt.Size = new System.Drawing.Size(170, 22);
            this.tbAmt.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Receiver(Optional)";
            // 
            // tbRecName
            // 
            this.tbRecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRecName.Location = new System.Drawing.Point(131, 101);
            this.tbRecName.Name = "tbRecName";
            this.tbRecName.ReadOnly = true;
            this.tbRecName.Size = new System.Drawing.Size(170, 22);
            this.tbRecName.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Quantity (Optional)";
            // 
            // tbQty
            // 
            this.tbQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbQty.Location = new System.Drawing.Point(131, 75);
            this.tbQty.Name = "tbQty";
            this.tbQty.ReadOnly = true;
            this.tbQty.Size = new System.Drawing.Size(170, 22);
            this.tbQty.TabIndex = 39;
            this.tbQty.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescription.Location = new System.Drawing.Point(131, 129);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(170, 89);
            this.tbDescription.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Expense Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(317, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 34);
            this.button1.TabIndex = 47;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 34);
            this.button2.TabIndex = 48;
            this.button2.Text = "Download Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 34);
            this.button3.TabIndex = 49;
            this.button3.Text = "Print Slip";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PrintSlip
            // 
            this.PrintSlip.DocumentName = "";
            this.PrintSlip.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintSlip_PrintPage);
            // 
            // singleDash
            // 
            this.singleDash.Location = new System.Drawing.Point(4, 193);
            this.singleDash.Name = "singleDash";
            this.singleDash.Size = new System.Drawing.Size(121, 22);
            this.singleDash.TabIndex = 51;
            this.singleDash.Text = "-----------------------------";
            this.singleDash.Visible = false;
            // 
            // dash
            // 
            this.dash.Location = new System.Drawing.Point(23, -4);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(446, 13);
            this.dash.TabIndex = 50;
            this.dash.Text = "=============================================================================";
            this.dash.Visible = false;
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy       hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(296, 12);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(216, 20);
            this.DateTimee.TabIndex = 52;
            this.DateTimee.TabStop = false;
            // 
            // frmViewPersonalExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(513, 253);
            this.Controls.Add(this.DateTimee);
            this.Controls.Add(this.singleDash);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbExpTitle);
            this.Controls.Add(this.updateID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRecName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmViewPersonalExp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Personal Expense";
            this.Load += new System.EventHandler(this.frmViewPersonalExp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmViewPersonalExp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox cbExpTitle;
        public System.Windows.Forms.Label updateID;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbAmt;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbRecName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbQty;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbDescription;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument PrintSlip;
        private System.Windows.Forms.Label singleDash;
        private System.Windows.Forms.Label dash;
        private System.Windows.Forms.DateTimePicker DateTimee;

    }
}
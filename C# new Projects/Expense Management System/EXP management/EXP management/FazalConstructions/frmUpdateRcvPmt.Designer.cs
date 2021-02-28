namespace FazalConstructions
{
    partial class frmUpdateRcvPmt
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRcvPmt = new System.Windows.Forms.TextBox();
            this.tbRcvName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPaidBy = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateID = new System.Windows.Forms.Label();
            this.tbSiteName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPaymentMethod = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial #:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(130, 25);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(86, 22);
            this.tbID.TabIndex = 1;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Narration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Paid by:";
            // 
            // tbRcvPmt
            // 
            this.tbRcvPmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRcvPmt.Location = new System.Drawing.Point(130, 110);
            this.tbRcvPmt.Name = "tbRcvPmt";
            this.tbRcvPmt.Size = new System.Drawing.Size(159, 22);
            this.tbRcvPmt.TabIndex = 60;
            // 
            // tbRcvName
            // 
            this.tbRcvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRcvName.Location = new System.Drawing.Point(130, 138);
            this.tbRcvName.Name = "tbRcvName";
            this.tbRcvName.ReadOnly = true;
            this.tbRcvName.Size = new System.Drawing.Size(159, 22);
            this.tbRcvName.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Receive Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Receiver Name:";
            // 
            // tbPaidBy
            // 
            this.tbPaidBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaidBy.Location = new System.Drawing.Point(130, 166);
            this.tbPaidBy.Name = "tbPaidBy";
            this.tbPaidBy.ReadOnly = true;
            this.tbPaidBy.Size = new System.Drawing.Size(159, 22);
            this.tbPaidBy.TabIndex = 64;
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(130, 223);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(158, 46);
            this.tbDesc.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Payment Method:";
            // 
            // updateID
            // 
            this.updateID.AutoSize = true;
            this.updateID.Location = new System.Drawing.Point(87, 33);
            this.updateID.Name = "updateID";
            this.updateID.Size = new System.Drawing.Size(0, 16);
            this.updateID.TabIndex = 74;
            // 
            // tbSiteName
            // 
            this.tbSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSiteName.Location = new System.Drawing.Point(130, 82);
            this.tbSiteName.Name = "tbSiteName";
            this.tbSiteName.ReadOnly = true;
            this.tbSiteName.Size = new System.Drawing.Size(159, 22);
            this.tbSiteName.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 76;
            this.label9.Text = "Site Name:";
            // 
            // tbPaymentMethod
            // 
            this.tbPaymentMethod.Location = new System.Drawing.Point(131, 195);
            this.tbPaymentMethod.Name = "tbPaymentMethod";
            this.tbPaymentMethod.ReadOnly = true;
            this.tbPaymentMethod.Size = new System.Drawing.Size(157, 22);
            this.tbPaymentMethod.TabIndex = 77;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 78;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 37);
            this.button3.TabIndex = 79;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmUpdateRcvPmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbPaymentMethod);
            this.Controls.Add(this.tbSiteName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.updateID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRcvPmt);
            this.Controls.Add(this.tbRcvName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPaidBy);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmUpdateRcvPmt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Receive Payment";
            this.Load += new System.EventHandler(this.frmUpdateRcvPmt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUpdateRcvPmt_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRcvPmt;
        private System.Windows.Forms.TextBox tbRcvName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPaidBy;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label updateID;
        private System.Windows.Forms.TextBox tbSiteName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPaymentMethod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
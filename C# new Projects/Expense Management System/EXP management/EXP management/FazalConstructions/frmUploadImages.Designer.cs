namespace FazalConstructions
{
    partial class frmUploadImages
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
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Category:";
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Items.AddRange(new object[] {
            "Client Aggreement",
            "Expense Scanned Image",
            "Receive Payment Scanned Receipt"});
            this.cbCat.Location = new System.Drawing.Point(1, 28);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(365, 24);
            this.cbCat.TabIndex = 1;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Items.AddRange(new object[] {
            ""});
            this.cbProject.Location = new System.Drawing.Point(2, 83);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(361, 24);
            this.cbProject.TabIndex = 3;
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.cbProject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Project:";
            // 
            // tbSerial
            // 
            this.tbSerial.Enabled = false;
            this.tbSerial.Location = new System.Drawing.Point(11, 154);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(100, 22);
            this.tbSerial.TabIndex = 4;
            this.tbSerial.Text = "0";
            this.tbSerial.Click += new System.EventHandler(this.tbSerial_Click);
            this.tbSerial.TextChanged += new System.EventHandler(this.tbSerial_TextChanged);
            this.tbSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSerial_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "EXP / RCV #: ";
            // 
            // btnFetch
            // 
            this.btnFetch.Enabled = false;
            this.btnFetch.Location = new System.Drawing.Point(118, 153);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(34, 23);
            this.btnFetch.TabIndex = 6;
            this.btnFetch.Text = ">>";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // tbClientName
            // 
            this.tbClientName.Enabled = false;
            this.tbClientName.Location = new System.Drawing.Point(158, 153);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(209, 22);
            this.tbClientName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Site Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Picture / Image";
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(19, 217);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(347, 180);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImg.TabIndex = 10;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(208, 403);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(158, 30);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "-------------------------------------------------------------------------";
            // 
            // frmUploadImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(379, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSerial);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmUploadImages";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Images";
            this.Load += new System.EventHandler(this.frmUploadImages_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUploadImages_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label6;
    }
}
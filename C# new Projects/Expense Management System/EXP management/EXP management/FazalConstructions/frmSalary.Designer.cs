namespace FazalConstructions
{
    partial class frmSalary
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.tbNarration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(93, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New Person?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Process Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPayment
            // 
            this.tbPayment.Location = new System.Drawing.Point(82, 87);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(142, 22);
            this.tbPayment.TabIndex = 5;
            this.tbPayment.TextChanged += new System.EventHandler(this.tbPayment_TextChanged);
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy  hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(51, 11);
            this.DateTimee.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(173, 20);
            this.DateTimee.TabIndex = 36;
            this.DateTimee.TabStop = false;
            // 
            // cbPerson
            // 
            this.cbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(82, 33);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(142, 24);
            this.cbPerson.TabIndex = 37;
            this.cbPerson.SelectedIndexChanged += new System.EventHandler(this.cbPerson_SelectedIndexChanged);
            this.cbPerson.Click += new System.EventHandler(this.cbPerson_Click);
            // 
            // tbNarration
            // 
            this.tbNarration.Location = new System.Drawing.Point(82, 111);
            this.tbNarration.Multiline = true;
            this.tbNarration.Name = "tbNarration";
            this.tbNarration.Size = new System.Drawing.Size(142, 45);
            this.tbNarration.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Narration:";
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(226, 191);
            this.Controls.Add(this.tbNarration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPerson);
            this.Controls.Add(this.DateTimee);
            this.Controls.Add(this.tbPayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSalary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sallary";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalary_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.TextBox tbNarration;
        private System.Windows.Forms.Label label3;
    }
}
namespace FazalConstructions
{
    partial class frmCreateSystemUser
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
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.tbCell = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updationID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Role:";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(176, 41);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(227, 24);
            this.cbRole.TabIndex = 0;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            this.cbRole.Click += new System.EventHandler(this.cbRole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cell #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Permanent Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Extra Notes:";
            // 
            // tbFname
            // 
            this.tbFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFname.Location = new System.Drawing.Point(176, 72);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(227, 22);
            this.tbFname.TabIndex = 1;
            // 
            // tbLname
            // 
            this.tbLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLname.Location = new System.Drawing.Point(176, 99);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(227, 22);
            this.tbLname.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAddress.Location = new System.Drawing.Point(176, 212);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(227, 45);
            this.tbAddress.TabIndex = 6;
            // 
            // tbNotes
            // 
            this.tbNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNotes.Location = new System.Drawing.Point(176, 260);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(227, 58);
            this.tbNotes.TabIndex = 7;
            this.tbNotes.TextChanged += new System.EventHandler(this.tbNotes_TextChanged);
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(176, 182);
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(227, 22);
            this.tbCell.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUsername.Location = new System.Drawing.Point(176, 127);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(227, 22);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbPassword.Location = new System.Drawing.Point(176, 154);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(227, 22);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(176, 320);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(227, 33);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create new user";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy       hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(176, 12);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(227, 20);
            this.DateTimee.TabIndex = 46;
            this.DateTimee.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 359);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(409, 120);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // updationID
            // 
            this.updationID.AutoSize = true;
            this.updationID.Location = new System.Drawing.Point(14, 307);
            this.updationID.Name = "updationID";
            this.updationID.Size = new System.Drawing.Size(45, 16);
            this.updationID.TabIndex = 48;
            this.updationID.Text = "label9";
            // 
            // frmCreateSystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(415, 481);
            this.Controls.Add(this.updationID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DateTimee);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCell);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCreateSystemUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create System User";
            this.Activated += new System.EventHandler(this.frmCreateSystemUser_Activated);
            this.Load += new System.EventHandler(this.frmCreateSystemUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCreateSystemUser_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.MaskedTextBox tbCell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label updationID;
    }
}
namespace FazalConstructions
{
    partial class frmStock
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
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNarration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbUpdateQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUsedQty = new System.Windows.Forms.Label();
            this.lblUpdateID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 9);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(45, 16);
            this.ID.TabIndex = 0;
            this.ID.Text = "label1";
            this.ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name:";
            // 
            // tbName
            // 
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbName.Location = new System.Drawing.Point(113, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(232, 22);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(113, 45);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(232, 22);
            this.tbQty.TabIndex = 4;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Quantity:";
            // 
            // tbNarration
            // 
            this.tbNarration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNarration.Location = new System.Drawing.Point(113, 70);
            this.tbNarration.Multiline = true;
            this.tbNarration.Name = "tbNarration";
            this.tbNarration.Size = new System.Drawing.Size(232, 51);
            this.tbNarration.TabIndex = 6;
            this.tbNarration.TextChanged += new System.EventHandler(this.tbNarration_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Narration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNarration);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbQty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy  hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(509, 9);
            this.DateTimee.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(229, 20);
            this.DateTimee.TabIndex = 34;
            this.DateTimee.TabStop = false;
            this.DateTimee.ValueChanged += new System.EventHandler(this.DateTimee_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(153, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(450, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "S a v e    this item";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Format = "D";
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 208);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbUpdateQty
            // 
            this.tbUpdateQty.Location = new System.Drawing.Point(249, 49);
            this.tbUpdateQty.Name = "tbUpdateQty";
            this.tbUpdateQty.Size = new System.Drawing.Size(79, 22);
            this.tbUpdateQty.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "New Quantity:";
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUpdateName.Location = new System.Drawing.Point(96, 21);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(232, 22);
            this.tbUpdateName.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "New Name:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(609, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 40;
            this.button1.Text = "Update this item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(10, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 37);
            this.button2.TabIndex = 41;
            this.button2.Text = "Delete this item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUsedQty);
            this.groupBox2.Controls.Add(this.tbUpdateQty);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblUpdateID);
            this.groupBox2.Controls.Add(this.tbUpdateName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(371, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 125);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update ";
            // 
            // lblUsedQty
            // 
            this.lblUsedQty.AutoSize = true;
            this.lblUsedQty.Location = new System.Drawing.Point(102, 94);
            this.lblUsedQty.Name = "lblUsedQty";
            this.lblUsedQty.Size = new System.Drawing.Size(45, 16);
            this.lblUsedQty.TabIndex = 41;
            this.lblUsedQty.Text = "label4";
            this.lblUsedQty.Visible = false;
            // 
            // lblUpdateID
            // 
            this.lblUpdateID.AutoSize = true;
            this.lblUpdateID.Location = new System.Drawing.Point(16, 94);
            this.lblUpdateID.Name = "lblUpdateID";
            this.lblUpdateID.Size = new System.Drawing.Size(80, 16);
            this.lblUpdateID.TabIndex = 40;
            this.lblUpdateID.Text = "lblUpdateID";
            this.lblUpdateID.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(8, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 66);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(753, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DateTimee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock ";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStock_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNarration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbUpdateQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUpdateID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUsedQty;
    }
}
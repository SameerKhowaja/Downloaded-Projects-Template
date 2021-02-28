namespace FazalConstructions
{
    partial class frmPendingPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPendingPayments));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbRemBalance = new System.Windows.Forms.TextBox();
            this.tbPayNow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPaidPayment = new System.Windows.Forms.TextBox();
            this.tbTotalPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNarration = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.TextBox();
            this.SlipPrint = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.singleDash = new System.Windows.Forms.Label();
            this.dash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(16, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(728, 227);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbRemBalance
            // 
            this.tbRemBalance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemBalance.Location = new System.Drawing.Point(328, 89);
            this.tbRemBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRemBalance.Name = "tbRemBalance";
            this.tbRemBalance.ReadOnly = true;
            this.tbRemBalance.Size = new System.Drawing.Size(147, 26);
            this.tbRemBalance.TabIndex = 2;
            // 
            // tbPayNow
            // 
            this.tbPayNow.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPayNow.Location = new System.Drawing.Point(612, 89);
            this.tbPayNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPayNow.Name = "tbPayNow";
            this.tbPayNow.ReadOnly = true;
            this.tbPayNow.Size = new System.Drawing.Size(132, 26);
            this.tbPayNow.TabIndex = 3;
            this.tbPayNow.TextChanged += new System.EventHandler(this.tbPayNow_TextChanged);
            this.tbPayNow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPayNow_KeyDown);
            this.tbPayNow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPayNow_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remaining Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pay Now:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stautus:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Process Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(141, 23);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(57, 28);
            this.btnFetch.TabIndex = 9;
            this.btnFetch.Text = ">>>";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy  hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(505, 23);
            this.DateTimee.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(239, 20);
            this.DateTimee.TabIndex = 34;
            this.DateTimee.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Paid Payment:";
            // 
            // tbPaidPayment
            // 
            this.tbPaidPayment.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaidPayment.Location = new System.Drawing.Point(166, 89);
            this.tbPaidPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPaidPayment.Name = "tbPaidPayment";
            this.tbPaidPayment.ReadOnly = true;
            this.tbPaidPayment.Size = new System.Drawing.Size(151, 26);
            this.tbPaidPayment.TabIndex = 36;
            // 
            // tbTotalPayment
            // 
            this.tbTotalPayment.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPayment.Location = new System.Drawing.Point(6, 89);
            this.tbTotalPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTotalPayment.Name = "tbTotalPayment";
            this.tbTotalPayment.ReadOnly = true;
            this.tbTotalPayment.Size = new System.Drawing.Size(139, 26);
            this.tbTotalPayment.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Total Payment:";
            // 
            // tbStatus
            // 
            this.tbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbStatus.Enabled = false;
            this.tbStatus.FormattingEnabled = true;
            this.tbStatus.Location = new System.Drawing.Point(489, 91);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(115, 24);
            this.tbStatus.TabIndex = 39;
            this.tbStatus.SelectedIndexChanged += new System.EventHandler(this.tbStatus_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Select by Serial #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Narration:";
            // 
            // tbNarration
            // 
            this.tbNarration.Location = new System.Drawing.Point(87, 121);
            this.tbNarration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNarration.Name = "tbNarration";
            this.tbNarration.Size = new System.Drawing.Size(388, 22);
            this.tbNarration.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 170);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Project Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(6, 29);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 22);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // SlipPrint
            // 
            this.SlipPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.SlipPrint_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // singleDash
            // 
            this.singleDash.Location = new System.Drawing.Point(486, 165);
            this.singleDash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.singleDash.Name = "singleDash";
            this.singleDash.Size = new System.Drawing.Size(258, 27);
            this.singleDash.TabIndex = 50;
            this.singleDash.Text = "-----------------------------";
            this.singleDash.Visible = false;
            // 
            // dash
            // 
            this.dash.Location = new System.Drawing.Point(149, 52);
            this.dash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(595, 16);
            this.dash.TabIndex = 49;
            this.dash.Text = "=============================================================================";
            this.dash.Visible = false;
            // 
            // frmPendingPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(746, 430);
            this.Controls.Add(this.singleDash);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbNarration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbTotalPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPaidPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTimee);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPayNow);
            this.Controls.Add(this.tbRemBalance);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPendingPayments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending Payments";
            this.Load += new System.EventHandler(this.frmPendingPayments_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPendingPayments_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbRemBalance;
        private System.Windows.Forms.TextBox tbPayNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPaidPayment;
        private System.Windows.Forms.TextBox tbTotalPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNarration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox comboBox1;
        private System.Drawing.Printing.PrintDocument SlipPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label singleDash;
        private System.Windows.Forms.Label dash;
    }
}
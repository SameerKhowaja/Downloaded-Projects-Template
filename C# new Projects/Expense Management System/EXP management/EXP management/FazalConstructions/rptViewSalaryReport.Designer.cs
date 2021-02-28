namespace FazalConstructions
{
    partial class rptViewSalaryReport
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
            this.components = new System.ComponentModel.Container();
            this.tblSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FCProjectDataSet = new FazalConstructions.FCProjectDataSet();
            this.tblCompanySetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tblSalaryTableAdapter = new FazalConstructions.FCProjectDataSetTableAdapters.tblSalaryTableAdapter();
            this.tblCompanySetupTableAdapter = new FazalConstructions.FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanySetupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSalaryBindingSource
            // 
            this.tblSalaryBindingSource.DataMember = "tblSalary";
            this.tblSalaryBindingSource.DataSource = this.FCProjectDataSet;
            // 
            // FCProjectDataSet
            // 
            this.FCProjectDataSet.DataSetName = "FCProjectDataSet";
            this.FCProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCompanySetupBindingSource
            // 
            this.tblCompanySetupBindingSource.DataMember = "tblCompanySetup";
            this.tblCompanySetupBindingSource.DataSource = this.FCProjectDataSet;
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerFrom.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DateTimePickerFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DateTimePickerFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DateTimePickerFrom.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(18, 34);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(117, 20);
            this.DateTimePickerFrom.TabIndex = 8;
            this.DateTimePickerFrom.Value = new System.DateTime(2015, 1, 1, 10, 20, 0, 0);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePickerTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateTimePickerTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateTimePickerTo.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(177, 33);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerTo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "FROM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "TO:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(431, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Salary Person";
            // 
            // tblSalaryTableAdapter
            // 
            this.tblSalaryTableAdapter.ClearBeforeFill = true;
            // 
            // tblCompanySetupTableAdapter
            // 
            this.tblCompanySetupTableAdapter.ClearBeforeFill = true;
            // 
            // cbPerson
            // 
            this.cbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(304, 36);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(121, 21);
            this.cbPerson.TabIndex = 14;
            this.cbPerson.SelectedIndexChanged += new System.EventHandler(this.cbPerson_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(506, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Refresh Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contact for Complete Software\r\nmuhammadwaqas_ali@outlook.com";
            // 
            // rptViewSalaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(595, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.MaximizeBox = false;
            this.Name = "rptViewSalaryReport";
            this.ShowIcon = false;
            this.Text = "View Salary Repoert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptViewSalaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanySetupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblSalaryBindingSource;
        private FCProjectDataSet FCProjectDataSet;
        private System.Windows.Forms.BindingSource tblCompanySetupBindingSource;
        private FCProjectDataSetTableAdapters.tblSalaryTableAdapter tblSalaryTableAdapter;
        private FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter tblCompanySetupTableAdapter;
        private System.Windows.Forms.DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}
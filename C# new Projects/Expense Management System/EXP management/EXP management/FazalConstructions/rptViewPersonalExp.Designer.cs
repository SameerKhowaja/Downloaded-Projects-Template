namespace FazalConstructions
{
    partial class rptViewPersonalExp
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
            this.tblPersonalExpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FCProjectDataSet = new FazalConstructions.FCProjectDataSet();
            this.tblCompanySetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbExpTitle = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblPersonalExpTableAdapter = new FazalConstructions.FCProjectDataSetTableAdapters.tblPersonalExpTableAdapter();
            this.tblCompanySetupTableAdapter = new FazalConstructions.FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalExpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanySetupBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPersonalExpBindingSource
            // 
            this.tblPersonalExpBindingSource.DataMember = "tblPersonalExp";
            this.tblPersonalExpBindingSource.DataSource = this.FCProjectDataSet;
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
            this.DateTimePickerFrom.Location = new System.Drawing.Point(22, 26);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(117, 22);
            this.DateTimePickerFrom.TabIndex = 6;
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
            this.dateTimePickerTo.Location = new System.Drawing.Point(145, 25);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(110, 22);
            this.dateTimePickerTo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbExpTitle);
            this.groupBox1.Location = new System.Drawing.Point(343, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cbExpTitle
            // 
            this.cbExpTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExpTitle.FormattingEnabled = true;
            this.cbExpTitle.Location = new System.Drawing.Point(21, 22);
            this.cbExpTitle.Name = "cbExpTitle";
            this.cbExpTitle.Size = new System.Drawing.Size(177, 24);
            this.cbExpTitle.TabIndex = 0;
            this.cbExpTitle.SelectedIndexChanged += new System.EventHandler(this.cbExpTitle_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(560, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 59);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // tblPersonalExpTableAdapter
            // 
            this.tblPersonalExpTableAdapter.ClearBeforeFill = true;
            // 
            // tblCompanySetupTableAdapter
            // 
            this.tblCompanySetupTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contact for Complete Software\r\nmuhammadwaqas_ali@outlook.com";
            // 
            // rptViewPersonalExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(737, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rptViewPersonalExp";
            this.Text = "rptViewPersonalExp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptViewPersonalExp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonalExpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanySetupBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblPersonalExpBindingSource;
        private FCProjectDataSet FCProjectDataSet;
        private FCProjectDataSetTableAdapters.tblPersonalExpTableAdapter tblPersonalExpTableAdapter;
        private System.Windows.Forms.DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblCompanySetupBindingSource;
        private FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter tblCompanySetupTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbExpTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}
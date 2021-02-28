namespace FazalConstructions
{
    partial class rptPendingPayments
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
            this.tblExpEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FCProjectDataSet = new FazalConstructions.FCProjectDataSet();
            this.tblCompanySetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblExpEntryTableAdapter = new FazalConstructions.FCProjectDataSetTableAdapters.tblExpEntryTableAdapter();
            this.cb_P_ID = new System.Windows.Forms.ComboBox();
            this.tbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tblCompanySetupTableAdapter = new FazalConstructions.FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanySetupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblExpEntryBindingSource
            // 
            this.tblExpEntryBindingSource.DataMember = "tblExpEntry";
            this.tblExpEntryBindingSource.DataSource = this.FCProjectDataSet;
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
            // tblExpEntryTableAdapter
            // 
            this.tblExpEntryTableAdapter.ClearBeforeFill = true;
            // 
            // cb_P_ID
            // 
            this.cb_P_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_P_ID.FormattingEnabled = true;
            this.cb_P_ID.Location = new System.Drawing.Point(19, 13);
            this.cb_P_ID.Name = "cb_P_ID";
            this.cb_P_ID.Size = new System.Drawing.Size(348, 24);
            this.cb_P_ID.TabIndex = 1;
            // 
            // tbPaymentStatus
            // 
            this.tbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbPaymentStatus.FormattingEnabled = true;
            this.tbPaymentStatus.Location = new System.Drawing.Point(383, 12);
            this.tbPaymentStatus.Name = "tbPaymentStatus";
            this.tbPaymentStatus.Size = new System.Drawing.Size(169, 24);
            this.tbPaymentStatus.TabIndex = 2;
            this.tbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.tbPaymentStatus_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblCompanySetupTableAdapter
            // 
            this.tblCompanySetupTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contact for Complete Software\r\nmuhammadwaqas_ali@outlook.com";
            // 
            // rptPendingPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(779, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPaymentStatus);
            this.Controls.Add(this.cb_P_ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rptPendingPayments";
            this.Text = "rptViewPendingPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptViewPendingPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblExpEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanySetupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblExpEntryBindingSource;
        private FCProjectDataSet FCProjectDataSet;
        private FCProjectDataSetTableAdapters.tblExpEntryTableAdapter tblExpEntryTableAdapter;
        private System.Windows.Forms.ComboBox cb_P_ID;
        private System.Windows.Forms.ComboBox tbPaymentStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblCompanySetupBindingSource;
        private FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter tblCompanySetupTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
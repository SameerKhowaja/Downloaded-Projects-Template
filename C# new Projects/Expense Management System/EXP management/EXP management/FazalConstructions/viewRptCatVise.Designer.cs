namespace FazalConstructions
{
    partial class viewRptCatVise
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
            this.cbCat = new System.Windows.Forms.ComboBox();
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
            this.cb_P_ID.Location = new System.Drawing.Point(8, 12);
            this.cb_P_ID.Name = "cb_P_ID";
            this.cb_P_ID.Size = new System.Drawing.Size(217, 21);
            this.cb_P_ID.TabIndex = 1;
            this.cb_P_ID.SelectedIndexChanged += new System.EventHandler(this.cb_P_ID_SelectedIndexChanged);
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(243, 12);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(217, 21);
            this.cbCat.TabIndex = 2;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
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
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contact for Complete Software\r\nmuhammadwaqas_ali@outlook.com";
            // 
            // viewRptCatVise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.cb_P_ID);
            this.Name = "viewRptCatVise";
            this.Text = "viewRptCatVise";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.viewRptCatVise_Load);
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
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblCompanySetupBindingSource;
        private FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter tblCompanySetupTableAdapter;
        private System.Windows.Forms.Label label1;


    }
}
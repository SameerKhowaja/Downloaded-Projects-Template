namespace FazalConstructions
{
    partial class rptViewRcvPmt
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
            this.tblReceivePaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FCProjectDataSet = new FazalConstructions.FCProjectDataSet();
            this.tblCompanySetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_P_ID = new System.Windows.Forms.ComboBox();
            this.tblReceivePaymentTableAdapter = new FazalConstructions.FCProjectDataSetTableAdapters.tblReceivePaymentTableAdapter();
            this.tableAdapterManager1 = new FazalConstructions.FCProjectDataSetTableAdapters.TableAdapterManager();
            this.tblCompanySetupTableAdapter = new FazalConstructions.FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblReceivePaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanySetupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblReceivePaymentBindingSource
            // 
            this.tblReceivePaymentBindingSource.DataMember = "tblReceivePayment";
            this.tblReceivePaymentBindingSource.DataSource = this.FCProjectDataSet;
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
            // cb_P_ID
            // 
            this.cb_P_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_P_ID.FormattingEnabled = true;
            this.cb_P_ID.Location = new System.Drawing.Point(105, 25);
            this.cb_P_ID.Name = "cb_P_ID";
            this.cb_P_ID.Size = new System.Drawing.Size(382, 24);
            this.cb_P_ID.TabIndex = 1;
            this.cb_P_ID.SelectedIndexChanged += new System.EventHandler(this.cb_P_ID_SelectedIndexChanged);
            // 
            // tblReceivePaymentTableAdapter
            // 
            this.tblReceivePaymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tblCategoryTableAdapter = null;
            this.tableAdapterManager1.tblClientTableAdapter = null;
            this.tableAdapterManager1.tblCompanySetupTableAdapter = null;
            this.tableAdapterManager1.tblFoldingTableAdapter = null;
            this.tableAdapterManager1.tblPaymentModeTableAdapter = null;
            this.tableAdapterManager1.tblPaymentStatusTableAdapter = null;
            this.tableAdapterManager1.tblPersonalExpTableAdapter = null;
            this.tableAdapterManager1.tblUserRoleTableAdapter = null;
            this.tableAdapterManager1.tblUserTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = FazalConstructions.FCProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.label1.Location = new System.Drawing.Point(101, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact for Complete Software\r\nmuhammadwaqas_ali@outlook.com";
            // 
            // rptViewRcvPmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(756, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_P_ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rptViewRcvPmt";
            this.Text = "rptViewRcvPmt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptViewRcvPmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblReceivePaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanySetupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblReceivePaymentBindingSource;
        private FCProjectDataSet FCProjectDataSet;
        private FCProjectDataSetTableAdapters.tblReceivePaymentTableAdapter tblReceivePaymentTableAdapter;
        private System.Windows.Forms.ComboBox cb_P_ID;
        private FCProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource tblCompanySetupBindingSource;
        private FCProjectDataSetTableAdapters.tblCompanySetupTableAdapter tblCompanySetupTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
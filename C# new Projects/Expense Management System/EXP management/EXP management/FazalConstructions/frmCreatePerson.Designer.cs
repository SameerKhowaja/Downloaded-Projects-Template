namespace FazalConstructions
{
    partial class frmCreatePerson
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
            this.tbPersonName = new System.Windows.Forms.TextBox();
            this.DateTimee = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person Name:";
            // 
            // tbPersonName
            // 
            this.tbPersonName.Location = new System.Drawing.Point(137, 39);
            this.tbPersonName.Name = "tbPersonName";
            this.tbPersonName.Size = new System.Drawing.Size(230, 22);
            this.tbPersonName.TabIndex = 1;
            // 
            // DateTimee
            // 
            this.DateTimee.CustomFormat = "dd/MM/yyyy  hh:mm";
            this.DateTimee.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimee.Location = new System.Drawing.Point(137, 4);
            this.DateTimee.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimee.Name = "DateTimee";
            this.DateTimee.Size = new System.Drawing.Size(229, 20);
            this.DateTimee.TabIndex = 35;
            this.DateTimee.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 30);
            this.button1.TabIndex = 36;
            this.button1.Text = "Create New Person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCreatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(371, 137);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTimee);
            this.Controls.Add(this.tbPersonName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCreatePerson";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Person";
            this.Load += new System.EventHandler(this.frmCreatePerson_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCreatePerson_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPersonName;
        private System.Windows.Forms.DateTimePicker DateTimee;
        private System.Windows.Forms.Button button1;
    }
}
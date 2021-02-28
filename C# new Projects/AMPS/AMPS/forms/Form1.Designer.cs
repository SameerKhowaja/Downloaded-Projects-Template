namespace AMPS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(104, 129);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(86, 13);
            this.linkLabelForgotPassword.TabIndex = 55;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot Password";
            this.linkLabelForgotPassword.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(166, 158);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 40);
            this.buttonExit.TabIndex = 52;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.Location = new System.Drawing.Point(104, 101);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(157, 21);
            this.textboxPassword.TabIndex = 50;
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Password";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogIn.Image")));
            this.buttonLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogIn.Location = new System.Drawing.Point(24, 158);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(95, 40);
            this.buttonLogIn.TabIndex = 51;
            this.buttonLogIn.Text = "   Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            // 
            // textboxUserName
            // 
            this.textboxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxUserName.Location = new System.Drawing.Point(104, 63);
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(157, 21);
            this.textboxUserName.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "UserName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textboxUserName;
        private System.Windows.Forms.Label label1;
    }
}


namespace ScreenShot
{
    partial class ScreenShot_image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenShot_image));
            this.Pic_Box = new System.Windows.Forms.PictureBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Box
            // 
            this.Pic_Box.Location = new System.Drawing.Point(12, 31);
            this.Pic_Box.Name = "Pic_Box";
            this.Pic_Box.Size = new System.Drawing.Size(883, 480);
            this.Pic_Box.TabIndex = 0;
            this.Pic_Box.TabStop = false;
            // 
            // Save_Button
            // 
            this.Save_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_Button.BackgroundImage")));
            this.Save_Button.Location = new System.Drawing.Point(12, 517);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(49, 51);
            this.Save_Button.TabIndex = 1;
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel_Button.BackgroundImage")));
            this.Cancel_Button.Location = new System.Drawing.Point(846, 517);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(49, 51);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ScreenShot_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(907, 572);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Pic_Box);
            this.MaximizeBox = false;
            this.Name = "ScreenShot_image";
            this.Text = "ScreenShot - Image";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Box;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}
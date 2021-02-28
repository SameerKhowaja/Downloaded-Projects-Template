namespace StopWatch
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
            this.HH = new System.Windows.Forms.Label();
            this.hms = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.MM = new System.Windows.Forms.Label();
            this.SS = new System.Windows.Forms.Label();
            this.MS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HH
            // 
            this.HH.AutoSize = true;
            this.HH.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HH.Location = new System.Drawing.Point(96, 70);
            this.HH.Name = "HH";
            this.HH.Size = new System.Drawing.Size(175, 135);
            this.HH.TabIndex = 0;
            this.HH.Text = "00";
            // 
            // hms
            // 
            this.hms.AutoSize = true;
            this.hms.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hms.ForeColor = System.Drawing.Color.Red;
            this.hms.Location = new System.Drawing.Point(162, 50);
            this.hms.Name = "hms";
            this.hms.Size = new System.Drawing.Size(779, 35);
            this.hms.TabIndex = 1;
            this.hms.Text = "H                       M                      S                     M.S";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Firebrick;
            this.Start.Font = new System.Drawing.Font("Lucida Console", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.MintCream;
            this.Start.Location = new System.Drawing.Point(119, 292);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(143, 94);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Tomato;
            this.Reset.Font = new System.Drawing.Font("Lucida Console", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.MintCream;
            this.Reset.Location = new System.Drawing.Point(847, 292);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(143, 94);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.YellowGreen;
            this.About.Font = new System.Drawing.Font("Lucida Console", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.MintCream;
            this.About.Location = new System.Drawing.Point(487, 292);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(143, 94);
            this.About.TabIndex = 4;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // MM
            // 
            this.MM.AutoSize = true;
            this.MM.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MM.Location = new System.Drawing.Point(343, 70);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(175, 135);
            this.MM.TabIndex = 5;
            this.MM.Text = "00";
            // 
            // SS
            // 
            this.SS.AutoSize = true;
            this.SS.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SS.Location = new System.Drawing.Point(582, 70);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(175, 135);
            this.SS.TabIndex = 6;
            this.SS.Text = "00";
            // 
            // MS
            // 
            this.MS.AutoSize = true;
            this.MS.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MS.Location = new System.Drawing.Point(824, 70);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(175, 135);
            this.MS.TabIndex = 7;
            this.MS.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(256, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 135);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(500, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 135);
            this.label3.TabIndex = 9;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(741, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 135);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1078, 538);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hms);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.HH);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIGITAL STOPWATCH";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HH;
        private System.Windows.Forms.Label hms;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label MM;
        private System.Windows.Forms.Label SS;
        private System.Windows.Forms.Label MS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


namespace LudoGameBoard
{
    partial class LudoGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LudoGameForm));
            this.GreenCircule1 = new System.Windows.Forms.PictureBox();
            this.GreenRollar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GreenCircule2 = new System.Windows.Forms.PictureBox();
            this.GreenCircule3 = new System.Windows.Forms.PictureBox();
            this.GreenCircule4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCircule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCircule2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCircule3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCircule4)).BeginInit();
            this.SuspendLayout();
            // 
            // GreenCircule1
            // 
            this.GreenCircule1.BackColor = System.Drawing.Color.Transparent;
            this.GreenCircule1.Image = ((System.Drawing.Image)(resources.GetObject("GreenCircule1.Image")));
            this.GreenCircule1.Location = new System.Drawing.Point(227, 464);
            this.GreenCircule1.Name = "GreenCircule1";
            this.GreenCircule1.Size = new System.Drawing.Size(37, 34);
            this.GreenCircule1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenCircule1.TabIndex = 0;
            this.GreenCircule1.TabStop = false;
            this.GreenCircule1.Click += new System.EventHandler(this.GreenCircule1_Click);
            // 
            // GreenRollar
            // 
            this.GreenRollar.Location = new System.Drawing.Point(607, 724);
            this.GreenRollar.Name = "GreenRollar";
            this.GreenRollar.Size = new System.Drawing.Size(79, 83);
            this.GreenRollar.TabIndex = 1;
            this.GreenRollar.Text = "GreenRollar";
            this.GreenRollar.UseVisualStyleBackColor = true;
            this.GreenRollar.Click += new System.EventHandler(this.GreenRollar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 724);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GreenCircule2
            // 
            this.GreenCircule2.BackColor = System.Drawing.Color.Transparent;
            this.GreenCircule2.Image = ((System.Drawing.Image)(resources.GetObject("GreenCircule2.Image")));
            this.GreenCircule2.Location = new System.Drawing.Point(371, 464);
            this.GreenCircule2.Name = "GreenCircule2";
            this.GreenCircule2.Size = new System.Drawing.Size(37, 34);
            this.GreenCircule2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenCircule2.TabIndex = 3;
            this.GreenCircule2.TabStop = false;
            this.GreenCircule2.Click += new System.EventHandler(this.GreenCircule2_Click);
            // 
            // GreenCircule3
            // 
            this.GreenCircule3.BackColor = System.Drawing.Color.Transparent;
            this.GreenCircule3.Image = ((System.Drawing.Image)(resources.GetObject("GreenCircule3.Image")));
            this.GreenCircule3.Location = new System.Drawing.Point(227, 540);
            this.GreenCircule3.Name = "GreenCircule3";
            this.GreenCircule3.Size = new System.Drawing.Size(37, 34);
            this.GreenCircule3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenCircule3.TabIndex = 4;
            this.GreenCircule3.TabStop = false;
            this.GreenCircule3.Click += new System.EventHandler(this.GreenCircule3_Click);
            // 
            // GreenCircule4
            // 
            this.GreenCircule4.BackColor = System.Drawing.Color.Transparent;
            this.GreenCircule4.Image = ((System.Drawing.Image)(resources.GetObject("GreenCircule4.Image")));
            this.GreenCircule4.Location = new System.Drawing.Point(371, 540);
            this.GreenCircule4.Name = "GreenCircule4";
            this.GreenCircule4.Size = new System.Drawing.Size(37, 34);
            this.GreenCircule4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenCircule4.TabIndex = 5;
            this.GreenCircule4.TabStop = false;
            this.GreenCircule4.Click += new System.EventHandler(this.GreenCircule4_Click);
            // 
            // LudoGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 861);
            this.Controls.Add(this.GreenCircule4);
            this.Controls.Add(this.GreenCircule3);
            this.Controls.Add(this.GreenCircule2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GreenRollar);
            this.Controls.Add(this.GreenCircule1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LudoGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ludo Game";
            ((System.ComponentModel.ISupportInitialize)(this.GreenCircule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCircule2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCircule3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCircule4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GreenCircule1;
        private System.Windows.Forms.Button GreenRollar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox GreenCircule2;
        private System.Windows.Forms.PictureBox GreenCircule3;
        private System.Windows.Forms.PictureBox GreenCircule4;
    }
}


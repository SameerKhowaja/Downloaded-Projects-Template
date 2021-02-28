namespace Tictactoe
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
            this.cell1 = new System.Windows.Forms.Button();
            this.cell2 = new System.Windows.Forms.Button();
            this.cell3 = new System.Windows.Forms.Button();
            this.cell6 = new System.Windows.Forms.Button();
            this.cell5 = new System.Windows.Forms.Button();
            this.cell4 = new System.Windows.Forms.Button();
            this.cell9 = new System.Windows.Forms.Button();
            this.cell8 = new System.Windows.Forms.Button();
            this.cell7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtO = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTurn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cell1
            // 
            this.cell1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell1.Location = new System.Drawing.Point(12, 25);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(81, 72);
            this.cell1.TabIndex = 0;
            this.cell1.UseVisualStyleBackColor = true;
            this.cell1.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell2
            // 
            this.cell2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell2.Location = new System.Drawing.Point(99, 25);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(81, 72);
            this.cell2.TabIndex = 1;
            this.cell2.UseVisualStyleBackColor = true;
            this.cell2.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell3
            // 
            this.cell3.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell3.Location = new System.Drawing.Point(186, 25);
            this.cell3.Name = "cell3";
            this.cell3.Size = new System.Drawing.Size(81, 72);
            this.cell3.TabIndex = 2;
            this.cell3.UseVisualStyleBackColor = true;
            this.cell3.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell6
            // 
            this.cell6.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell6.Location = new System.Drawing.Point(186, 103);
            this.cell6.Name = "cell6";
            this.cell6.Size = new System.Drawing.Size(81, 72);
            this.cell6.TabIndex = 5;
            this.cell6.UseVisualStyleBackColor = true;
            this.cell6.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell5
            // 
            this.cell5.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell5.Location = new System.Drawing.Point(99, 103);
            this.cell5.Name = "cell5";
            this.cell5.Size = new System.Drawing.Size(81, 72);
            this.cell5.TabIndex = 4;
            this.cell5.UseVisualStyleBackColor = true;
            this.cell5.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell4
            // 
            this.cell4.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell4.Location = new System.Drawing.Point(12, 103);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(81, 72);
            this.cell4.TabIndex = 3;
            this.cell4.UseVisualStyleBackColor = true;
            this.cell4.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell9
            // 
            this.cell9.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell9.Location = new System.Drawing.Point(186, 181);
            this.cell9.Name = "cell9";
            this.cell9.Size = new System.Drawing.Size(81, 72);
            this.cell9.TabIndex = 8;
            this.cell9.UseVisualStyleBackColor = true;
            this.cell9.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell8
            // 
            this.cell8.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell8.Location = new System.Drawing.Point(99, 181);
            this.cell8.Name = "cell8";
            this.cell8.Size = new System.Drawing.Size(81, 72);
            this.cell8.TabIndex = 7;
            this.cell8.UseVisualStyleBackColor = true;
            this.cell8.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell7
            // 
            this.cell7.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell7.Location = new System.Drawing.Point(12, 181);
            this.cell7.Name = "cell7";
            this.cell7.Size = new System.Drawing.Size(81, 72);
            this.cell7.TabIndex = 6;
            this.cell7.UseVisualStyleBackColor = true;
            this.cell7.Click += new System.EventHandler(this.cell1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtO);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 58);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score Board";
            // 
            // txtO
            // 
            this.txtO.AutoSize = true;
            this.txtO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtO.ForeColor = System.Drawing.Color.Maroon;
            this.txtO.Location = new System.Drawing.Point(68, 37);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(16, 16);
            this.txtO.TabIndex = 16;
            this.txtO.Text = "0";
            // 
            // txtX
            // 
            this.txtX.AutoSize = true;
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtX.Location = new System.Drawing.Point(68, 13);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(16, 16);
            this.txtX.TabIndex = 15;
            this.txtX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "O:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "X:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(154, 286);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 31);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTurn
            // 
            this.txtTurn.AutoSize = true;
            this.txtTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurn.ForeColor = System.Drawing.Color.Coral;
            this.txtTurn.Location = new System.Drawing.Point(177, 265);
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.Size = new System.Drawing.Size(58, 16);
            this.txtTurn.TabIndex = 15;
            this.txtTurn.Text = "O Turn!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 321);
            this.Controls.Add(this.txtTurn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cell9);
            this.Controls.Add(this.cell8);
            this.Controls.Add(this.cell7);
            this.Controls.Add(this.cell6);
            this.Controls.Add(this.cell5);
            this.Controls.Add(this.cell4);
            this.Controls.Add(this.cell3);
            this.Controls.Add(this.cell2);
            this.Controls.Add(this.cell1);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cell1;
        private System.Windows.Forms.Button cell2;
        private System.Windows.Forms.Button cell3;
        private System.Windows.Forms.Button cell6;
        private System.Windows.Forms.Button cell5;
        private System.Windows.Forms.Button cell4;
        private System.Windows.Forms.Button cell9;
        private System.Windows.Forms.Button cell8;
        private System.Windows.Forms.Button cell7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtO;
        private System.Windows.Forms.Label txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label txtTurn;
    }
}


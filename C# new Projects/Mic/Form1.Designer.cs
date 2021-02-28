// VBConversions Note: VB project level imports
using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
// End of VB project level imports


namespace Microphone
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Form1 : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(49, 54);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(211, 36);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Record";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(51, 114);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(209, 31);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Save/Stop";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(51, 177);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(209, 35);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "Play";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 251);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Record Audio";
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		
	}
	
}

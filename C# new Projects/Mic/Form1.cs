
using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;


using System.Runtime.InteropServices;


namespace Microphone
{
	public partial class Form1
	{
		public Form1()
		{
			InitializeComponent();

		}
		
#region Default Instance
		
		private static Form1 defaultInstance;
		
	
		public static Form1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Form1();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		[DllImport("winmm.dll",EntryPoint="mciSendStringA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
		
        public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			record("open new Type waveaudio Alias recsound", "", 0, 0);
			
			record("record recsound", "", 0, 0);
		}
		
		public void Button2_Click(System.Object sender, System.EventArgs e)
		{
			record("save recsound c:\\mic.wav", "", 0, 0);
			
			record("close recsound", "", 0, 0);
		}
		
		public void Button3_Click(System.Object sender, System.EventArgs e)
		{
			(new Microsoft.VisualBasic.Devices.Audio()).Play("c:\\mic.wav");
		}
	}
	
}

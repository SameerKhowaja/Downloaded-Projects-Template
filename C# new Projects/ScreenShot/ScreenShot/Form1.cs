using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ScreenShot
{
    public partial class Form1 : Form
    {
        public static Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); // to use this var in the ScreenShot Form 
        public Form1()
        {
            InitializeComponent();
            this.Text = "Screen Shot   v1.0.0  developed by: Ahmed Ramadan ";  // to make a Title for your Application 
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
            Graphics GH = Graphics.FromImage(BM as Image);
            GH.CopyFromScreen(0, 0, 0, 0, BM.Size);

            ScreenShot_image SI = new ScreenShot_image(); // to create a new object from ScreenShot form 

            SI.ShowDialog(); // to show the ScreenShot form  when the user Clike the Button 
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.label1.Text = "Capture a Image";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.label1.Text = "About";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.label1.Text = "Exit";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.fb.com/A7medGeek");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Simple Programm For Learning not for use \n  Created by : Ahmed Ramadan ","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

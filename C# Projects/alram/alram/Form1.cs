using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alram
{
    public partial class Form1 : Form
    {
        String formatt = "AM";
        int hh;
        int mm;
        int ss;
        int hou;
        int min;
        int sec;
        String value;
        String value2;
        String value3;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                value = textBox1.Text;

                hou = Convert.ToInt32(value);

                value2 = textBox2.Text;

                min = Convert.ToInt32(value2);
                
                value3 = textBox3.Text;

                sec = Convert.ToInt32(value3);
            }
            catch (Exception ee) { MessageBox.Show("Enter the values"); }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            
             hh = DateTime.Now.Hour;
             mm = DateTime.Now.Minute;
             ss = DateTime.Now.Second;
            Clock.Text = ("" + hh+":"+mm+":"+ss);

            

            
            

            
            


                if (hh == hou)
                {
                    if (mm == min)
                    {

                        if (ss == sec)
                        {
                            Console.Beep(700,3000);

                        }
                    }
                
            }
            
        }

        

        

        
    }
}

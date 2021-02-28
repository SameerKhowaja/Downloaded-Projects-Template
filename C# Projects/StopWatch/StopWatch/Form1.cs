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
namespace StopWatch
{
    public partial class Form1 : Form
    {
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        int microsec = 0;
        int store = 0;
        int store2 = 0;
        int store3 = 0;
        System.Windows.Forms.Timer MIRCROSEC= new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer SECONDS = new System.Windows.Forms.Timer();
        
        
        public Form1()
        {
            InitializeComponent();

            MIRCROSEC.Interval = 1;
            
            MIRCROSEC.Tick += new EventHandler(MS_Tick);
        }

        private void Start_Click(object sender, EventArgs e)
        {
           
            


            if (Start.Text == "Start")
            {
                MIRCROSEC.Start();
                Start.Text = ("Stop");

            }

            else if (Start.Text == "Stop")
            {
                MIRCROSEC.Stop();
                Start.Text = ("Start");

            }

        }

        void MS_Tick(object sender, EventArgs e)
        {
            
            
                MS.Text = ("" + (++microsec));
                if (microsec == 100)
                {
                    microsec = 0;
                    store = ++seconds;
                    
                }
                if (seconds > 0 && seconds < 10)
                {


                    SS.Text = ("0" + store);

                }
                else if (seconds == 60)
                {

                    seconds = 0;
                    store2 = ++minutes;



                }

                else
                {
                    SS.Text = ("" + store);
                }


                //////////////////////
                if (minutes >= 0 && minutes < 10)
                {


                    MM.Text = ("0" + store2);

                }
                else if (minutes == 60)
                {
                    minutes = 0;
                    store3 = ++hours;

                }

                else
                {
                    MM.Text = ("" + store2);
                }

                /////////////////////hhhhhhhourrrrrrrrrrr

                if (hours >= 0 && hours < 10)
                {


                    HH.Text = ("0" + store3);

                }

                else
                {
                    HH.Text = ("" + store3);
                }
            
                

                

            ///////////////////////////////////////////////////////////////////
                





                
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            MIRCROSEC.Stop();
            Start.Text = "Start";
            MS.Text = "00";
            SS.Text = "00";
            MM.Text = "00";
            HH.Text = "00";
            hours = 0;
            minutes = 0;
            seconds = 0;
            microsec = 0;
            store = 0;
            store2 = 0;
            store3 = 0;
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Sameer Khowaja");
        }

        

        

        

           


            
         
            
            

            
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }
       
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            try{
            String value1 = textBox1.Text;

            int sub1 = Convert.ToInt32(value1);


           



            String value2 = textBox2.Text;

            int sub2 = Convert.ToInt32(value2);



            


            String value3 = textBox3.Text;

            int sub3 = Convert.ToInt32(value3);



         


            String value4 = textBox4.Text;

            int sub4 = Convert.ToInt32(value4);

         
           


            String value5 = textBox5.Text;

            int sub5 = Convert.ToInt32(value5);


            String value6 = textBox5.Text;

            int grade = Convert.ToInt32(value6);

            double totalmarks = 500;

            int obtained = sub1 + sub2 + sub3 + sub4 + sub5;


            double per = (obtained * 100) / totalmarks;

            


            if(per>=80){

                textBox9.Text = "            A+";
            
            }

            else  if (per>= 70)
            {

                textBox9.Text = "            A";

            }

            else if (per >=60)
            {

                textBox9.Text = "            B";

            }

            else if (per >= 50)
            {

                textBox9.Text = "            C";

            }

            else if (per>=40)
            {

                textBox9.Text = "            D";

            }

            else 
            {

                textBox9.Text = "         Fail";

            }

                if(sub1>0 && sub1>=101 ||sub2>0 && sub2>=101 ||sub3>0 && sub3>=101 ||sub4>0 && sub4>=101 ||
                    sub5>0 && sub5>=101 ){

                    textBox6.Text="";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";   


                    MessageBox.Show("100 above number is not allowed in english math science physics and biology");


                }

                

                
                else {
                    textBox7.Text = ("          " + obtained.ToString());
                    textBox8.Text = ("          " + per.ToString() + " %");

                    textBox6.Text = ("          " + totalmarks.ToString());
                }

            }
            catch (Exception ere) {


                if (textBox1.Text == "")
                {
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    MessageBox.Show("Please Enter English Marks");
                    

                }
                else if (textBox2.Text == "")
                {
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    MessageBox.Show("Please Enter Math Marks");
                    

                }
                else if (textBox3.Text == "")
                {
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    MessageBox.Show("Please Enter Science Marks");
                    

                }

                else if (textBox4.Text == "")
                {
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    MessageBox.Show("Please Enter Physics Marks");
                    

                }

                else if (textBox5.Text == "")
                {
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    MessageBox.Show("Please Enter Biology Marks");
                    

                }


                else
                {
                    MessageBox.Show("This correctors is not allowed\nClick ok button and try again");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Sameer Khowaja");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}

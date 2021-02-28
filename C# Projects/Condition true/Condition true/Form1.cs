using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condition_true
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if(label1.Text==textBox1.Text){
                textBox1.Enabled=false;
                textBox2.Enabled = true;
                textBox1.BackColor = Color.LightGreen;
                textBox2.Focus();



            }


        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if (label2.Text == textBox2.Text)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                textBox2.BackColor = Color.LightGreen;
                textBox3.Focus();



            }

        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {

            if (label3.Text == textBox3.Text)
            {
                textBox3.Enabled = false;
                textBox4.Enabled = true;
                textBox3.BackColor = Color.LightGreen;
                textBox4.Focus();



            }

        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (label4.Text == textBox4.Text)
            {
                textBox4.Enabled = false;
                textBox5.Enabled = true;
                textBox4.BackColor = Color.LightGreen;
                textBox5.Focus();



            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (label5.Text == textBox5.Text)
            {
                textBox5.Enabled = false;
                textBox5.BackColor = Color.LightGreen;

                MessageBox.Show("Are you sure you want to reapet again press ok button thanks :)");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                textBox1.BackColor = Color.Yellow;
                textBox2.BackColor = Color.Yellow;
                textBox3.BackColor = Color.Yellow;
                textBox4.BackColor = Color.Yellow;
                textBox5.BackColor = Color.Yellow;

                textBox1.Enabled = true;
                


                textBox1.Focus();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.Yellow;
            textBox5.BackColor = Color.Yellow;

            textBox1.Enabled = true;
         

            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Sameer Khowaja");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

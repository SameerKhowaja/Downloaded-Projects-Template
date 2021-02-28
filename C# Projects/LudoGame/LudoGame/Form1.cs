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
namespace LudoGame
{
    public partial class ABOUT : Form
    {
        public ABOUT()
        {
            InitializeComponent();

            FirstPlayerTextField.MaxLength=7;
            SecondPlayerTextField.MaxLength = 7;
            ThirdPlayerTextField.MaxLength = 7;
            FourthPlayerTextField.MaxLength = 7;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if(FirstPlayerTextField.Text=="")
            {

                MessageBox.Show("Please Enter The First Player Name");
                FirstPlayerTextField.Focus();
            }
            else{
                
                for (int i = 1; i <= 315; i++)
                {

                    
                    FirPlayNameLabel.Location = new Point(297, 134+i);
                    FirstPlayerTextField.Location = new Point(395, 224+i);
                    Done.Location = new Point(419, 328+i);
                    Thread.Sleep(4);
                    if (i == 315)
                    {
                        FirPlayNameLabel.Visible = false;
                        FirstPlayerTextField.Visible = false;
                        Done.Visible = false;
                    }
                   
                    
                }

            //SecPlayNameLabel.Visible = true;
            //SecondPlayerTextField.Visible = true;
            //Done2.Visible = true;

            //FirPlayNameLabel.Visible = false;
            //ThirdPlayNameLabel.Visible = false;

            //SecPlayNameLabel.BringToFront();
            //SecondPlayerTextField.BringToFront();
            //Done2.BringToFront();

            //SecondPlayerTextField.Focus();
        }
        }

        private void Done2_Click(object sender, EventArgs e)
        {
            if (SecondPlayerTextField.Text == "")
            {

                MessageBox.Show("Please Enter The Second Player Name");
                SecondPlayerTextField.Focus();
            }
            else
            {

                ThirdPlayNameLabel.Visible = true;
                ThirdPlayerTextField.Visible = true;
                Done3.Visible = true;

                FirPlayNameLabel.Visible = false;
                SecPlayNameLabel.Visible = false;

                ThirdPlayNameLabel.BringToFront();
                ThirdPlayerTextField.BringToFront();
                Done3.BringToFront();

                ThirdPlayerTextField.Focus();
            }
        }

        private void Done3_Click(object sender, EventArgs e)
        {
            if (ThirdPlayerTextField.Text == "")
            {

                MessageBox.Show("Please Enter The Third Player Name");
                ThirdPlayerTextField.Focus();
            }
            else
            {

                FourthPlayNameLabel.Visible = true;
                FourthPlayerTextField.Visible = true;
                Done4.Visible = true;

                FirPlayNameLabel.Visible = false;
                SecPlayNameLabel.Visible = false;
                ThirdPlayNameLabel.Visible = false;

                FourthPlayNameLabel.BringToFront();
                FourthPlayerTextField.BringToFront();
                Done4.BringToFront();

                FourthPlayerTextField.Focus();
            }
        }

        private void Done4_Click(object sender, EventArgs e)
        {
            if (FourthPlayerTextField.Text == "")
            {

                MessageBox.Show("Please Enter The Fourth Player Name");
                FourthPlayerTextField.Focus();
            }
        }

       

        

    }
}

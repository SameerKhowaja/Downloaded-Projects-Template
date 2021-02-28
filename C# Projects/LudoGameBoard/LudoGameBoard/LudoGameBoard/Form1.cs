using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoGameBoard
{
    public partial class LudoGameForm : Form
    {
        int GreenCountOne = 0;

        int Dice = 0;

        int GreenPointX1 = 508;

        int GreenPointY1 = 553;

        int num2;

        Random Rn = new Random();

        public LudoGameForm()
        {
            
            InitializeComponent();

            
            
        }

      ///////////////////  greeeeeemmmmm
        private void GreenRollar_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            GreenCircule1.Location=new Point(607,553);

            GreenCountOne = 0;

            GreenPointX1 = 508;

            GreenPointY1 = 553;

            textBox2.Focus();

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            textBox1.Text = textBox2.Text;


            String value2 = textBox2.Text;

            num2 = Convert.ToInt32(value2);

            Dice = Rn.Next(num2, num2);

            GreenRollar.Text = ("" + Dice + "     " + GreenCountOne);

            GreenCountOne = GreenCountOne + Dice;


            if (GreenCountOne == 1)
            {
                for (int Value = GreenPointY1; Value >= 513; Value--)
                {
                    GreenCircule1.Location = new Point(607, Value);

                    GreenCircule1.Refresh();

                    GreenPointY1 = Value;

                    Thread.Sleep(1);
                }

            }
            //22222222
            else if (GreenCountOne == 2)
            {
                for (int Value = GreenPointY1; Value >= 474; Value--)
                {
                    GreenCircule1.Location = new Point(607, Value);

                    GreenCircule1.Refresh();

                    GreenPointY1 = Value;

                    Thread.Sleep(1);
                }

            }

                //////3333333333
            else if (GreenCountOne == 3)
            {
                for (int Value = GreenPointY1; Value >= 434; Value--)
                {
                    GreenCircule1.Location = new Point(607, Value);

                    GreenCircule1.Refresh();

                    GreenPointY1 = Value;

                    Thread.Sleep(1);
                }

            }
            ///////4444444444
            else if (GreenCountOne == 4)
            {
                for (int Value = GreenPointY1; Value >= 396; Value--)
                {
                    GreenCircule1.Location = new Point(607, Value);

                    GreenCircule1.Refresh();

                    GreenPointY1 = Value;

                    Thread.Sleep(1);
                }

            }

                ///////////5555555
            else if (GreenCountOne == 5)
            {
                for (int Value = GreenPointY1; Value >= 396; Value--)
                {
                    GreenCircule1.Location = new Point(607, Value);

                    GreenCircule1.Refresh();

                    GreenPointY1 = Value;

                    Thread.Sleep(1);
                }


                for (int i = 1; i <= 39; i++)
                {
                    GreenCircule1.Location = new Point(607 - i, 396 - i);

                    GreenCircule1.Refresh();

                    Thread.Sleep(1);
                }


                for (int i = 1; i <= 60; i++)
                {
                    GreenCircule1.Location = new Point(568 - i, 357);

                    GreenCircule1.Refresh();

                    Thread.Sleep(1);
                }

            }

            ////////6666

            else if (GreenCountOne == 6)
            {
                if (GreenCircule1.Location.X == 607)
                {
                    for (int Value = GreenPointY1; Value >= 396; Value--)
                    {
                        GreenCircule1.Location = new Point(607, Value);

                        GreenCircule1.Refresh();

                        GreenPointY1 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule1.Location = new Point(607 - i, 396 - i);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule1.Location = new Point(568 - i, 357);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }

                    for (int Value = GreenPointX1; Value >= 438; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }

                else if (GreenCircule1.Location.Y == 357)
                {
                    for (int Value = GreenPointX1; Value >= 438; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }
            }

            ///////77777777

            else if (GreenCountOne == 7)
            {
                if (GreenCircule1.Location.X == 607)
                {
                    for (int Value = GreenPointY1; Value >= 396; Value--)
                    {
                        GreenCircule1.Location = new Point(607, Value);

                        GreenCircule1.Refresh();

                        GreenPointY1 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule1.Location = new Point(607 - i, 396 - i);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule1.Location = new Point(568 - i, 357);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }

                    for (int Value = GreenPointX1; Value >= 352; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }

                else if (GreenCircule1.Location.Y == 357)
                {
                    for (int Value = GreenPointX1; Value >= 352; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }
            }

            //////////8888888888

            else if (GreenCountOne == 8)
            {
                if (GreenCircule1.Location.X == 607)
                {
                    for (int Value = GreenPointY1; Value >= 396; Value--)
                    {
                        GreenCircule1.Location = new Point(607, Value);

                        GreenCircule1.Refresh();

                        GreenPointY1 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule1.Location = new Point(607 - i, 396 - i);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule1.Location = new Point(568 - i, 357);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }

                    for (int Value = GreenPointX1; Value >= 269; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }

                else if (GreenCircule1.Location.Y == 357)
                {
                    for (int Value = GreenPointX1; Value >= 269; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }
            }

            ////////9999999


            else if (GreenCountOne == 9)
            {
                if (GreenCircule1.Location.X == 607)
                {
                    for (int Value = GreenPointY1; Value >= 396; Value--)
                    {
                        GreenCircule1.Location = new Point(607, Value);

                        GreenCircule1.Refresh();

                        GreenPointY1 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule1.Location = new Point(607 - i, 396 - i);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule1.Location = new Point(568 - i, 357);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }

                    for (int Value = GreenPointX1; Value >= 184; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }

                else if (GreenCircule1.Location.Y == 357)
                {
                    for (int Value = GreenPointX1; Value >= 184; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }
            }

            //////////1000000000

            else if (GreenCountOne == 10)
            {
                if (GreenCircule1.Location.X == 607)
                {
                    for (int Value = GreenPointY1; Value >= 396; Value--)
                    {
                        GreenCircule1.Location = new Point(607, Value);

                        GreenCircule1.Refresh();

                        GreenPointY1 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule1.Location = new Point(607 - i, 396 - i);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule1.Location = new Point(568 - i, 357);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }

                    for (int Value = GreenPointX1; Value >= 100; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }

                else if (GreenCircule1.Location.Y == 357)
                {
                    for (int Value = GreenPointX1; Value >= 100; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }

                }
            }

            ////////11111111

            else if (GreenCountOne == 11)
            {
                if (GreenCircule1.Location.X == 607)
                {
                    for (int Value = GreenPointY1; Value >= 396; Value--)
                    {
                        GreenCircule1.Location = new Point(607, Value);

                        GreenCircule1.Refresh();

                        GreenPointY1 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule1.Location = new Point(607 - i, 396 - i);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule1.Location = new Point(568 - i, 357);

                        GreenCircule1.Refresh();

                        Thread.Sleep(1);
                    }

                    for (int Value = GreenPointX1; Value >= 100; Value--)
                    {
                        GreenCircule1.Location = new Point(Value, 357);

                        GreenCircule1.Refresh();

                        GreenPointX1 = Value;

                        Thread.Sleep(1);
                    }


                    for (int Value = GreenPointY1=357; Value >= 318; Value--)
                    {
                        GreenCircule1.Location = new Point(100, Value);

                        GreenCircule1.Refresh();

                        GreenPointY1 = Value;

                        Thread.Sleep(1);
                    }

                }

                else if (GreenCircule1.Location.Y == 357)
                {
                    for (int Value = GreenPointY1 = 357; Value >= 318; Value--)
                    {
                        GreenCircule1.Location = new Point(100, Value);

                        GreenCircule1.Refresh();

                        GreenPointY1 = Value;

                        Thread.Sleep(1);
                    }

                }
            }




            textBox1.Text = "";
            textBox2.Text = "";

        }

        
        }

    }


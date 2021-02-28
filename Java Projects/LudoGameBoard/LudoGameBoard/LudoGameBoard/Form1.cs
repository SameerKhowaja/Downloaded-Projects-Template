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



        int GreenCountTwo = 0;

        int GreenPointX2 = 508;

        int GreenPointY2 = 553;



        int GreenCountThird = 0;

        int GreenPointX3 = 508;

        int GreenPointY3 = 553;


        int GreenCountFour = 0;

        int GreenPointX4 = 508;

        int GreenPointY4 = 553;


        Random Rn = new Random();

        public LudoGameForm()
        {
            InitializeComponent();
        }

        private void GreenRollar_Click(object sender, EventArgs e)
        {

            Dice = Rn.Next(1, 7);

            GreenRollar.Text = ("" + Dice + "     " + GreenCountFour);
        }



        private void GreenCircule1_Click(object sender, EventArgs e)
        {

            GreenCountOne = Dice + GreenCountOne;

            if (GreenCircule1.Location.Y == 552 && GreenCountOne >= 57)
            {
                GreenCountOne = 51;
            }

            else if (GreenCircule1.Location.Y == 513 && GreenCountOne >= 57)
            {
                GreenCountOne = 52;
            }

            else if (GreenCircule1.Location.Y == 474 && GreenCountOne >= 57)
            {
                GreenCountOne = 53;
            }

            else if (GreenCircule1.Location.Y == 434 && GreenCountOne >= 57)
            {
                GreenCountOne = 54;
            }

            else if (GreenCircule1.Location.Y == 394 && GreenCountOne >= 57)
            {
                GreenCountOne = 55;
            }


            else
            {

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

                //////66666666

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

                ////////77777777

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

                ////////8888888888

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

                /////////9999999

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

                ///////////100000000

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

                ////1111111111

                else if (GreenCountOne == 11)
                {
                    if (GreenCircule1.Location.Y == 357)
                    {

                        for (int Value = GreenPointX1; Value >= 100; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 357);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 357; Value >= 318; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }


                /////////////122222222

                else if (GreenCountOne == 12)
                {
                    if (GreenCircule1.Location.Y == 357)
                    {

                        for (int Value = GreenPointX1; Value >= 100; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 357);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 357; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.Y == 318)
                    {

                        for (int Value = GreenPointY1 = 318; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////133333333333


                else if (GreenCountOne == 13)
                {
                    if (GreenCircule1.Location.Y == 357)
                    {

                        for (int Value = GreenPointX1; Value >= 100; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 357);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 357; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 100; Value <= 178; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 318)
                    {
                        for (int Value = GreenPointY1 = 318; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 100; Value <= 178; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 178; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////144444444

                else if (GreenCountOne == 14)
                {
                    if (GreenCircule1.Location.Y == 357)
                    {

                        for (int Value = GreenPointX1; Value >= 100; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 357);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 357; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 100; Value <= 266; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 318)
                    {
                        for (int Value = GreenPointY1 = 318; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 100; Value <= 266; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 266; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////15555555555

                else if (GreenCountOne == 15)
                {
                    if (GreenCircule1.Location.Y == 357)
                    {

                        for (int Value = GreenPointX1; Value >= 100; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 357);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 357; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 100; Value <= 351; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 318)
                    {
                        for (int Value = GreenPointY1 = 318; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 100; Value <= 351; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 351; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////////16666666666

                else if (GreenCountOne == 16)
                {
                    if (GreenCircule1.Location.Y == 357)
                    {

                        for (int Value = GreenPointX1; Value >= 100; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 357);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 357; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 100; Value <= 436; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 318)
                    {
                        for (int Value = GreenPointY1 = 318; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 100; Value <= 436; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 436; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////1777777777

                else if (GreenCountOne == 17)
                {
                    if (GreenCircule1.Location.Y == 357)
                    {

                        for (int Value = GreenPointX1; Value >= 100; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 357);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 357; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 100; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 318)
                    {
                        for (int Value = GreenPointY1 = 318; Value >= 277; Value--)
                        {
                            GreenCircule1.Location = new Point(100, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 100; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////1888888

                else if (GreenCountOne == 18)
                {

                    if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(518 + i, 277 - i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule1.Location = new Point(558 + i, 237);

                            GreenCircule1.Refresh();

                            GreenPointY1 = 237;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////199999

                else if (GreenCountOne == 19)
                {

                    if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(518 + i, 277 - i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule1.Location = new Point(558 + i, 237);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 237; Value >= 198; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 198; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////2000000

                else if (GreenCountOne == 20)
                {

                    if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(518 + i, 277 - i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule1.Location = new Point(558 + i, 237);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 237; Value >= 158; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 158; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////////2111111111

                else if (GreenCountOne == 21)
                {

                    if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(518 + i, 277 - i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule1.Location = new Point(558 + i, 237);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 237; Value >= 118; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 118; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////2222222

                else if (GreenCountOne == 22)
                {

                    if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(518 + i, 277 - i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule1.Location = new Point(558 + i, 237);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 237; Value >= 79; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 79; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                    /////23333333

                else if (GreenCountOne == 23)
                {

                    if (GreenCircule1.Location.Y == 277)
                    {

                        for (int Value = GreenPointX1; Value <= 518; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 277);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(518 + i, 277 - i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule1.Location = new Point(558 + i, 237);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 237; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //24444444444

                else if (GreenCountOne == 24)
                {
                    if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 602; Value <= 688; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //255555555555

                else if (GreenCountOne == 25)
                {
                    if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 602; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 688)
                    {
                        for (int Value = GreenPointX1 = 688; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////266666666

                else if (GreenCountOne == 26)
                {
                    if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 602; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 41; Value <= 77; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule1.Location.X == 688)
                    {
                        for (int Value = GreenPointX1 = 688; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 41; Value <= 77; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 77; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////27777777

                else if (GreenCountOne == 27)
                {
                    if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 602; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 41; Value <= 117; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule1.Location.X == 688)
                    {
                        for (int Value = GreenPointX1 = 688; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 41; Value <= 117; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 117; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////////288888888

                else if (GreenCountOne == 28)
                {
                    if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 602; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 41; Value <= 157; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule1.Location.X == 688)
                    {
                        for (int Value = GreenPointX1 = 688; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 41; Value <= 157; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 157; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////299999

                else if (GreenCountOne == 29)
                {
                    if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 602; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 41; Value <= 198; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule1.Location.X == 688)
                    {
                        for (int Value = GreenPointX1 = 688; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 41; Value <= 198; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 198; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////300000000000

                else if (GreenCountOne == 30)
                {
                    if (GreenCircule1.Location.X == 602)
                    {

                        for (int Value = GreenPointY1; Value >= 41; Value--)
                        {
                            GreenCircule1.Location = new Point(602, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 602; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 41; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule1.Location.X == 688)
                    {
                        for (int Value = GreenPointX1 = 688; Value <= 769; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 41);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1 = 41; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////3111111

                else if (GreenCountOne == 31)
                {
                    if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule1.Location = new Point(769 + i, 237 + i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule1.Location = new Point(807 + i, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = 867;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////322222222

                else if (GreenCountOne == 32)
                {
                    if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule1.Location = new Point(769 + i, 237 + i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule1.Location = new Point(807 + i, 275);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 867; Value <= 942; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 942; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                /////////3333333

                else if (GreenCountOne == 33)
                {
                    if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule1.Location = new Point(769 + i, 237 + i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule1.Location = new Point(807 + i, 275);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 867; Value <= 1028; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1028; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                ///////344444444

                else if (GreenCountOne == 34)
                {
                    if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule1.Location = new Point(769 + i, 237 + i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule1.Location = new Point(807 + i, 275);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 867; Value <= 1116; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1116; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                ///////////35555555

                else if (GreenCountOne == 35)
                {
                    if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule1.Location = new Point(769 + i, 237 + i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule1.Location = new Point(807 + i, 275);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 867; Value <= 1197; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1197; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                /////366666666666

                else if (GreenCountOne == 36)
                {
                    if (GreenCircule1.Location.X == 769)
                    {

                        for (int Value = GreenPointY1; Value <= 237; Value++)
                        {
                            GreenCircule1.Location = new Point(769, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule1.Location = new Point(769 + i, 237 + i);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule1.Location = new Point(807 + i, 275);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 867; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////////3777777

                else if (GreenCountOne == 37)
                {
                    if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 275; Value <= 314; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////388888888888

                else if (GreenCountOne == 38)
                {
                    if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 275; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }
                    }



                    else if (GreenCircule1.Location.Y == 314)
                    {
                        for (int Value = GreenPointY1 = 314; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }
                    }
                }

                /////////39999999

                else if (GreenCountOne == 39)
                {
                    if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 275; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 1199; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule1.Location.Y == 314)
                    {
                        for (int Value = GreenPointY1 = 314; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 1199; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 1199; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ////4000000

                else if (GreenCountOne == 40)
                {
                    if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 275; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 1113; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule1.Location.Y == 314)
                    {
                        for (int Value = GreenPointY1 = 314; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 1113; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 1113; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///////4111111

                else if (GreenCountOne == 41)
                {
                    if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 275; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 1029; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule1.Location.Y == 314)
                    {
                        for (int Value = GreenPointY1 = 314; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 1029; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 1029; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////////42222222

                else if (GreenCountOne == 42)
                {
                    if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 275; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 942; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule1.Location.Y == 314)
                    {
                        for (int Value = GreenPointY1 = 314; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 942; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 942; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ////////4333333

                else if (GreenCountOne == 43)
                {
                    if (GreenCircule1.Location.Y == 275)
                    {
                        for (int Value = GreenPointX1; Value <= 1283; Value++)
                        {
                            GreenCircule1.Location = new Point(Value, 275);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 275; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule1.Location.Y == 314)
                    {
                        for (int Value = GreenPointY1 = 314; Value <= 355; Value++)
                        {
                            GreenCircule1.Location = new Point(1283, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX1 = 1283; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////4444444

                else if (GreenCountOne == 44)
                {
                    if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule1.Location = new Point(856 - i, 355);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(777, 355 + i);

                            GreenCircule1.Refresh();

                            GreenPointY1 = 395;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////45555


                else if (GreenCountOne == 45)
                {
                    if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule1.Location = new Point(856 - i, 355);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(777, 355 + i);

                            GreenCircule1.Refresh();

                            GreenPointY1 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1; Value <= 433; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 777)
                    {

                        for (int Value = GreenPointY1; Value <= 433; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////466666

                else if (GreenCountOne == 46)
                {
                    if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule1.Location = new Point(856 - i, 355);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(777, 355 + i);

                            GreenCircule1.Refresh();

                            GreenPointY1 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1; Value <= 474; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 777)
                    {

                        for (int Value = GreenPointY1; Value <= 474; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //////47777777

                else if (GreenCountOne == 47)
                {
                    if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule1.Location = new Point(856 - i, 355);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(777, 355 + i);

                            GreenCircule1.Refresh();

                            GreenPointY1 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1; Value <= 513; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 777)
                    {

                        for (int Value = GreenPointY1; Value <= 513; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //48888

                else if (GreenCountOne == 48)
                {
                    if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule1.Location = new Point(856 - i, 355);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(777, 355 + i);

                            GreenCircule1.Refresh();

                            GreenPointY1 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1; Value <= 551; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 777)
                    {

                        for (int Value = GreenPointY1; Value <= 551; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///////499999

                else if (GreenCountOne == 49)
                {
                    if (GreenCircule1.Location.Y == 355)
                    {
                        for (int Value = GreenPointX1; Value >= 856; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 355);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule1.Location = new Point(856 - i, 355);

                            GreenCircule1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule1.Location = new Point(777, 355 + i);

                            GreenCircule1.Refresh();

                            GreenPointY1 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule1.Location.X == 777)
                    {

                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////////50000000000


                else if (GreenCountOne == 50)
                {
                    if (GreenCircule1.Location.X == 777)
                    {
                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 777; Value >= 690; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 592);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                /////5111111111


                else if (GreenCountOne == 51)
                {
                    if (GreenCircule1.Location.X == 777)
                    {
                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 777; Value >= 690; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 592);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 592; Value >= 552; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.X == 690)
                    {
                        for (int Value = GreenPointY1; Value >= 552; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //////52222222

                else if (GreenCountOne == 52)
                {
                    if (GreenCircule1.Location.X == 777)
                    {
                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 777; Value >= 690; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 592);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 592; Value >= 513; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.X == 690)
                    {
                        for (int Value = GreenPointY1; Value >= 513; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////53333333

                else if (GreenCountOne == 53)
                {
                    if (GreenCircule1.Location.X == 777)
                    {
                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 777; Value >= 690; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 592);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 592; Value >= 474; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.X == 690)
                    {
                        for (int Value = GreenPointY1; Value >= 474; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                    ////54444444444

                else if (GreenCountOne == 54)
                {
                    if (GreenCircule1.Location.X == 777)
                    {
                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 777; Value >= 690; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 592);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 592; Value >= 434; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.X == 690)
                    {
                        for (int Value = GreenPointY1; Value >= 434; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                ///555555
                ///

                else if (GreenCountOne == 55)
                {
                    if (GreenCircule1.Location.X == 777)
                    {
                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 777; Value >= 690; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 592);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 592; Value >= 394; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule1.Location.X == 690)
                    {
                        for (int Value = GreenPointY1; Value >= 394; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///566666
                ///
                else if (GreenCountOne == 56)
                {
                    if (GreenCircule1.Location.X == 777)
                    {
                        for (int Value = GreenPointY1; Value <= 592; Value++)
                        {
                            GreenCircule1.Location = new Point(777, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX1 = 777; Value >= 690; Value--)
                        {
                            GreenCircule1.Location = new Point(Value, 592);

                            GreenCircule1.Refresh();

                            GreenPointX1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY1 = 592; Value >= 315; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int complete = 1; complete <= 34; complete++)
                        {

                            GreenCircule1.SetBounds(690, 315, 37 - complete, 34 - complete);

                            GreenCircule1.Refresh();

                            Thread.Sleep(4);
                        }


                    }

                    else if (GreenCircule1.Location.X == 690)
                    {
                        for (int Value = GreenPointY1; Value >= 315; Value--)
                        {
                            GreenCircule1.Location = new Point(690, Value);

                            GreenCircule1.Refresh();

                            GreenPointY1 = Value;

                            Thread.Sleep(1);
                        }

                        for (int complete = 1; complete <= 34; complete++)
                        {

                            GreenCircule1.SetBounds(690, 315, 37 - complete, 34 - complete);

                            GreenCircule1.Refresh();

                            Thread.Sleep(4);
                        }

                    }
                }
            }

        }


        private void GreenCircule2_Click(object sender, EventArgs e)
        {

            GreenCountTwo = Dice + GreenCountTwo;

            if (GreenCircule2.Location.Y == 552 && GreenCountTwo >= 57)
            {
                GreenCountTwo = 51;
            }

            else if (GreenCircule2.Location.Y == 513 && GreenCountTwo >= 57)
            {
                GreenCountTwo = 52;
            }

            else if (GreenCircule2.Location.Y == 474 && GreenCountTwo >= 57)
            {
                GreenCountTwo = 53;
            }

            else if (GreenCircule2.Location.Y == 434 && GreenCountTwo >= 57)
            {
                GreenCountTwo = 54;
            }

            else if (GreenCircule2.Location.Y == 394 && GreenCountTwo >= 57)
            {
                GreenCountTwo = 55;
            }


            else
            {

                if (GreenCountTwo == 1)
                {
                    for (int Value = GreenPointY2; Value >= 513; Value--)
                    {
                        GreenCircule2.Location = new Point(607, Value);

                        GreenCircule2.Refresh();

                        GreenPointY2 = Value;

                        Thread.Sleep(1);
                    }

                }
                //22222222
                else if (GreenCountTwo == 2)
                {
                    for (int Value = GreenPointY2; Value >= 474; Value--)
                    {
                        GreenCircule2.Location = new Point(607, Value);

                        GreenCircule2.Refresh();

                        GreenPointY2 = Value;

                        Thread.Sleep(1);
                    }

                }

                    //////3333333333
                else if (GreenCountTwo == 3)
                {
                    for (int Value = GreenPointY2; Value >= 434; Value--)
                    {
                        GreenCircule2.Location = new Point(607, Value);

                        GreenCircule2.Refresh();

                        GreenPointY2 = Value;

                        Thread.Sleep(1);
                    }

                }
                ///////4444444444
                else if (GreenCountTwo == 4)
                {
                    for (int Value = GreenPointY2; Value >= 396; Value--)
                    {
                        GreenCircule2.Location = new Point(607, Value);

                        GreenCircule2.Refresh();

                        GreenPointY2 = Value;

                        Thread.Sleep(1);
                    }

                }

                    ///////////5555555
                else if (GreenCountTwo == 5)
                {
                    for (int Value = GreenPointY2; Value >= 396; Value--)
                    {
                        GreenCircule2.Location = new Point(607, Value);

                        GreenCircule2.Refresh();

                        GreenPointY2 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule2.Location = new Point(607 - i, 396 - i);

                        GreenCircule2.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule2.Location = new Point(568 - i, 357);

                        GreenCircule2.Refresh();

                        Thread.Sleep(1);
                    }

                }

                //////66666666

                else if (GreenCountTwo == 6)
                {
                    if (GreenCircule2.Location.X == 607)
                    {

                        for (int Value = GreenPointY2; Value >= 396; Value--)
                        {
                            GreenCircule2.Location = new Point(607, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule2.Location = new Point(607 - i, 396 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(568 - i, 357);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2; Value >= 438; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 357)
                    {
                        for (int Value = GreenPointX2; Value >= 438; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////77777777

                else if (GreenCountTwo == 7)
                {
                    if (GreenCircule2.Location.X == 607)
                    {

                        for (int Value = GreenPointY2; Value >= 396; Value--)
                        {
                            GreenCircule2.Location = new Point(607, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule2.Location = new Point(607 - i, 396 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(568 - i, 357);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2; Value >= 352; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 357)
                    {
                        for (int Value = GreenPointX2; Value >= 352; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////8888888888

                else if (GreenCountTwo == 8)
                {
                    if (GreenCircule2.Location.X == 607)
                    {

                        for (int Value = GreenPointY2; Value >= 396; Value--)
                        {
                            GreenCircule2.Location = new Point(607, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule2.Location = new Point(607 - i, 396 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(568 - i, 357);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2; Value >= 269; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 357)
                    {
                        for (int Value = GreenPointX2; Value >= 269; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////9999999

                else if (GreenCountTwo == 9)
                {
                    if (GreenCircule2.Location.X == 607)
                    {

                        for (int Value = GreenPointY2; Value >= 396; Value--)
                        {
                            GreenCircule2.Location = new Point(607, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule2.Location = new Point(607 - i, 396 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(568 - i, 357);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2; Value >= 184; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 357)
                    {
                        for (int Value = GreenPointX2; Value >= 184; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////100000000

                else if (GreenCountTwo == 10)
                {
                    if (GreenCircule2.Location.X == 607)
                    {

                        for (int Value = GreenPointY2; Value >= 396; Value--)
                        {
                            GreenCircule2.Location = new Point(607, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule2.Location = new Point(607 - i, 396 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(568 - i, 357);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 357)
                    {
                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////1111111111

                else if (GreenCountTwo == 11)
                {
                    if (GreenCircule2.Location.Y == 357)
                    {

                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 357; Value >= 318; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }


                /////////////122222222

                else if (GreenCountTwo == 12)
                {
                    if (GreenCircule2.Location.Y == 357)
                    {

                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 357; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.Y == 318)
                    {

                        for (int Value = GreenPointY2 = 318; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////133333333333


                else if (GreenCountTwo == 13)
                {
                    if (GreenCircule2.Location.Y == 357)
                    {

                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 357; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 100; Value <= 178; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 318)
                    {
                        for (int Value = GreenPointY2 = 318; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 100; Value <= 178; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 178; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////144444444

                else if (GreenCountTwo == 14)
                {
                    if (GreenCircule2.Location.Y == 357)
                    {

                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 357; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 100; Value <= 266; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 318)
                    {
                        for (int Value = GreenPointY2 = 318; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 100; Value <= 266; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 266; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////15555555555

                else if (GreenCountTwo == 15)
                {
                    if (GreenCircule2.Location.Y == 357)
                    {

                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 357; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 100; Value <= 351; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 318)
                    {
                        for (int Value = GreenPointY2 = 318; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 100; Value <= 351; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 351; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////////16666666666

                else if (GreenCountTwo == 16)
                {
                    if (GreenCircule2.Location.Y == 357)
                    {

                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 357; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 100; Value <= 436; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 318)
                    {
                        for (int Value = GreenPointY2 = 318; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 100; Value <= 436; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 436; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////1777777777

                else if (GreenCountTwo == 17)
                {
                    if (GreenCircule2.Location.Y == 357)
                    {

                        for (int Value = GreenPointX2; Value >= 100; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 357);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 357; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 100; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 318)
                    {
                        for (int Value = GreenPointY2 = 318; Value >= 277; Value--)
                        {
                            GreenCircule2.Location = new Point(100, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 100; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////1888888

                else if (GreenCountTwo == 18)
                {

                    if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(518 + i, 277 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule2.Location = new Point(558 + i, 237);

                            GreenCircule2.Refresh();

                            GreenPointY2 = 237;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////199999

                else if (GreenCountTwo == 19)
                {

                    if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(518 + i, 277 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule2.Location = new Point(558 + i, 237);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 237; Value >= 198; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 198; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////2000000

                else if (GreenCountTwo == 20)
                {

                    if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(518 + i, 277 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule2.Location = new Point(558 + i, 237);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 237; Value >= 158; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 158; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////////2111111111

                else if (GreenCountTwo == 21)
                {

                    if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(518 + i, 277 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule2.Location = new Point(558 + i, 237);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 237; Value >= 118; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 118; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////2222222

                else if (GreenCountTwo == 22)
                {

                    if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(518 + i, 277 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule2.Location = new Point(558 + i, 237);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 237; Value >= 79; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 79; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                    /////23333333

                else if (GreenCountTwo == 23)
                {

                    if (GreenCircule2.Location.Y == 277)
                    {

                        for (int Value = GreenPointX2; Value <= 518; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 277);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(518 + i, 277 - i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule2.Location = new Point(558 + i, 237);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 237; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //24444444444

                else if (GreenCountTwo == 24)
                {
                    if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 602; Value <= 688; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //255555555555

                else if (GreenCountTwo == 25)
                {
                    if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 602; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 688)
                    {
                        for (int Value = GreenPointX2 = 688; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////266666666

                else if (GreenCountTwo == 26)
                {
                    if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 602; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 41; Value <= 77; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule2.Location.X == 688)
                    {
                        for (int Value = GreenPointX2 = 688; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 41; Value <= 77; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 77; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////27777777

                else if (GreenCountTwo == 27)
                {
                    if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 602; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 41; Value <= 117; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule2.Location.X == 688)
                    {
                        for (int Value = GreenPointX2 = 688; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 41; Value <= 117; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 117; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////////288888888

                else if (GreenCountTwo == 28)
                {
                    if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 602; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 41; Value <= 157; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule2.Location.X == 688)
                    {
                        for (int Value = GreenPointX2 = 688; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 41; Value <= 157; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 157; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////299999

                else if (GreenCountTwo == 29)
                {
                    if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 602; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 41; Value <= 198; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule2.Location.X == 688)
                    {
                        for (int Value = GreenPointX2 = 688; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 41; Value <= 198; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 198; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////300000000000

                else if (GreenCountTwo == 30)
                {
                    if (GreenCircule2.Location.X == 602)
                    {

                        for (int Value = GreenPointY2; Value >= 41; Value--)
                        {
                            GreenCircule2.Location = new Point(602, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 602; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 41; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule2.Location.X == 688)
                    {
                        for (int Value = GreenPointX2 = 688; Value <= 769; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 41);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2 = 41; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////3111111

                else if (GreenCountTwo == 31)
                {
                    if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule2.Location = new Point(769 + i, 237 + i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(807 + i, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = 867;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////322222222

                else if (GreenCountTwo == 32)
                {
                    if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule2.Location = new Point(769 + i, 237 + i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(807 + i, 275);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 867; Value <= 942; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 942; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                /////////3333333

                else if (GreenCountTwo == 33)
                {
                    if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule2.Location = new Point(769 + i, 237 + i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(807 + i, 275);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 867; Value <= 1028; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1028; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                ///////344444444

                else if (GreenCountTwo == 34)
                {
                    if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule2.Location = new Point(769 + i, 237 + i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(807 + i, 275);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 867; Value <= 1116; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1116; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                ///////////35555555

                else if (GreenCountTwo == 35)
                {
                    if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule2.Location = new Point(769 + i, 237 + i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(807 + i, 275);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 867; Value <= 1197; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1197; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                /////366666666666

                else if (GreenCountTwo == 36)
                {
                    if (GreenCircule2.Location.X == 769)
                    {

                        for (int Value = GreenPointY2; Value <= 237; Value++)
                        {
                            GreenCircule2.Location = new Point(769, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule2.Location = new Point(769 + i, 237 + i);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule2.Location = new Point(807 + i, 275);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 867; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////////3777777

                else if (GreenCountTwo == 37)
                {
                    if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 275; Value <= 314; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////388888888888

                else if (GreenCountTwo == 38)
                {
                    if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 275; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }
                    }



                    else if (GreenCircule2.Location.Y == 314)
                    {
                        for (int Value = GreenPointY2 = 314; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }
                    }
                }

                /////////39999999

                else if (GreenCountTwo == 39)
                {
                    if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 275; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 1199; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule2.Location.Y == 314)
                    {
                        for (int Value = GreenPointY2 = 314; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 1199; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 1199; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ////4000000

                else if (GreenCountTwo == 40)
                {
                    if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 275; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 1113; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule2.Location.Y == 314)
                    {
                        for (int Value = GreenPointY2 = 314; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 1113; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 1113; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///////4111111

                else if (GreenCountTwo == 41)
                {
                    if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 275; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 1029; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule2.Location.Y == 314)
                    {
                        for (int Value = GreenPointY2 = 314; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 1029; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 1029; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////////42222222

                else if (GreenCountTwo == 42)
                {
                    if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 275; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 942; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule2.Location.Y == 314)
                    {
                        for (int Value = GreenPointY2 = 314; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 942; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 942; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ////////4333333

                else if (GreenCountTwo == 43)
                {
                    if (GreenCircule2.Location.Y == 275)
                    {
                        for (int Value = GreenPointX2; Value <= 1283; Value++)
                        {
                            GreenCircule2.Location = new Point(Value, 275);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 275; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule2.Location.Y == 314)
                    {
                        for (int Value = GreenPointY2 = 314; Value <= 355; Value++)
                        {
                            GreenCircule2.Location = new Point(1283, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX2 = 1283; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////4444444

                else if (GreenCountTwo == 44)
                {
                    if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule2.Location = new Point(856 - i, 355);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(777, 355 + i);

                            GreenCircule2.Refresh();

                            GreenPointY2 = 395;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////45555


                else if (GreenCountTwo == 45)
                {
                    if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule2.Location = new Point(856 - i, 355);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(777, 355 + i);

                            GreenCircule2.Refresh();

                            GreenPointY2 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2; Value <= 433; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 777)
                    {

                        for (int Value = GreenPointY2; Value <= 433; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////466666

                else if (GreenCountTwo == 46)
                {
                    if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule2.Location = new Point(856 - i, 355);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(777, 355 + i);

                            GreenCircule2.Refresh();

                            GreenPointY2 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2; Value <= 474; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 777)
                    {

                        for (int Value = GreenPointY2; Value <= 474; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //////47777777

                else if (GreenCountTwo == 47)
                {
                    if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule2.Location = new Point(856 - i, 355);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(777, 355 + i);

                            GreenCircule2.Refresh();

                            GreenPointY2 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2; Value <= 513; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 777)
                    {

                        for (int Value = GreenPointY2; Value <= 513; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //48888

                else if (GreenCountTwo == 48)
                {
                    if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule2.Location = new Point(856 - i, 355);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(777, 355 + i);

                            GreenCircule2.Refresh();

                            GreenPointY2 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2; Value <= 551; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 777)
                    {

                        for (int Value = GreenPointY2; Value <= 551; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///////499999

                else if (GreenCountTwo == 49)
                {
                    if (GreenCircule2.Location.Y == 355)
                    {
                        for (int Value = GreenPointX2; Value >= 856; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 355);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule2.Location = new Point(856 - i, 355);

                            GreenCircule2.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule2.Location = new Point(777, 355 + i);

                            GreenCircule2.Refresh();

                            GreenPointY2 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule2.Location.X == 777)
                    {

                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////////50000000000


                else if (GreenCountTwo == 50)
                {
                    if (GreenCircule2.Location.X == 777)
                    {
                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 777; Value >= 690; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 592);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                /////5111111111


                else if (GreenCountTwo == 51)
                {
                    if (GreenCircule2.Location.X == 777)
                    {
                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 777; Value >= 690; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 592);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 592; Value >= 552; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.X == 690)
                    {
                        for (int Value = GreenPointY2; Value >= 552; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //////52222222

                else if (GreenCountTwo == 52)
                {
                    if (GreenCircule2.Location.X == 777)
                    {
                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 777; Value >= 690; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 592);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 592; Value >= 513; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.X == 690)
                    {
                        for (int Value = GreenPointY2; Value >= 513; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////53333333

                else if (GreenCountTwo == 53)
                {
                    if (GreenCircule2.Location.X == 777)
                    {
                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 777; Value >= 690; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 592);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 592; Value >= 474; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.X == 690)
                    {
                        for (int Value = GreenPointY2; Value >= 474; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                    ////54444444444

                else if (GreenCountTwo == 54)
                {
                    if (GreenCircule2.Location.X == 777)
                    {
                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 777; Value >= 690; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 592);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 592; Value >= 434; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.X == 690)
                    {
                        for (int Value = GreenPointY2; Value >= 434; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                ///555555
                ///

                else if (GreenCountTwo == 55)
                {
                    if (GreenCircule2.Location.X == 777)
                    {
                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 777; Value >= 690; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 592);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 592; Value >= 394; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule2.Location.X == 690)
                    {
                        for (int Value = GreenPointY2; Value >= 394; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///566666
                ///
                else if (GreenCountTwo == 56)
                {
                    if (GreenCircule2.Location.X == 777)
                    {
                        for (int Value = GreenPointY2; Value <= 592; Value++)
                        {
                            GreenCircule2.Location = new Point(777, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX2 = 777; Value >= 690; Value--)
                        {
                            GreenCircule2.Location = new Point(Value, 592);

                            GreenCircule2.Refresh();

                            GreenPointX2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY2 = 592; Value >= 315; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int complete = 1; complete <= 34; complete++)
                        {

                            GreenCircule2.SetBounds(690, 315, 37 - complete, 34 - complete);

                            GreenCircule2.Refresh();

                            Thread.Sleep(4);
                        }


                    }

                    else if (GreenCircule2.Location.X == 690)
                    {
                        for (int Value = GreenPointY2; Value >= 315; Value--)
                        {
                            GreenCircule2.Location = new Point(690, Value);

                            GreenCircule2.Refresh();

                            GreenPointY2 = Value;

                            Thread.Sleep(1);
                        }

                        for (int complete = 1; complete <= 34; complete++)
                        {

                            GreenCircule2.SetBounds(690, 315, 37 - complete, 34 - complete);

                            GreenCircule2.Refresh();

                            Thread.Sleep(4);
                        }

                    }
                }
            }

        }


        private void GreenCircule3_Click(object sender, EventArgs e)
        {

            GreenCountThird = Dice + GreenCountThird;

            if (GreenCircule3.Location.Y == 552 && GreenCountThird >= 57)
            {
                GreenCountThird = 51;
            }

            else if (GreenCircule3.Location.Y == 513 && GreenCountThird >= 57)
            {
                GreenCountThird = 52;
            }

            else if (GreenCircule3.Location.Y == 474 && GreenCountThird >= 57)
            {
                GreenCountThird = 53;
            }

            else if (GreenCircule3.Location.Y == 434 && GreenCountThird >= 57)
            {
                GreenCountThird = 54;
            }

            else if (GreenCircule3.Location.Y == 394 && GreenCountThird >= 57)
            {
                GreenCountThird = 55;
            }


            else
            {

                if (GreenCountThird == 1)
                {
                    for (int Value = GreenPointY3; Value >= 513; Value--)
                    {
                        GreenCircule3.Location = new Point(607, Value);

                        GreenCircule3.Refresh();

                        GreenPointY3 = Value;

                        Thread.Sleep(1);
                    }

                }
                //22222222
                else if (GreenCountThird == 2)
                {
                    for (int Value = GreenPointY3; Value >= 474; Value--)
                    {
                        GreenCircule3.Location = new Point(607, Value);

                        GreenCircule3.Refresh();

                        GreenPointY3 = Value;

                        Thread.Sleep(1);
                    }

                }

                    //////3333333333
                else if (GreenCountThird == 3)
                {
                    for (int Value = GreenPointY3; Value >= 434; Value--)
                    {
                        GreenCircule3.Location = new Point(607, Value);

                        GreenCircule3.Refresh();

                        GreenPointY3 = Value;

                        Thread.Sleep(1);
                    }

                }
                ///////4444444444
                else if (GreenCountThird == 4)
                {
                    for (int Value = GreenPointY3; Value >= 396; Value--)
                    {
                        GreenCircule3.Location = new Point(607, Value);

                        GreenCircule3.Refresh();

                        GreenPointY3 = Value;

                        Thread.Sleep(1);
                    }

                }

                    ///////////5555555
                else if (GreenCountThird == 5)
                {
                    for (int Value = GreenPointY3; Value >= 396; Value--)
                    {
                        GreenCircule3.Location = new Point(607, Value);

                        GreenCircule3.Refresh();

                        GreenPointY3 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule3.Location = new Point(607 - i, 396 - i);

                        GreenCircule3.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule3.Location = new Point(568 - i, 357);

                        GreenCircule3.Refresh();

                        Thread.Sleep(1);
                    }

                }

                //////66666666

                else if (GreenCountThird == 6)
                {
                    if (GreenCircule3.Location.X == 607)
                    {

                        for (int Value = GreenPointY3; Value >= 396; Value--)
                        {
                            GreenCircule3.Location = new Point(607, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule3.Location = new Point(607 - i, 396 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(568 - i, 357);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3; Value >= 438; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 357)
                    {
                        for (int Value = GreenPointX3; Value >= 438; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////77777777

                else if (GreenCountThird == 7)
                {
                    if (GreenCircule3.Location.X == 607)
                    {

                        for (int Value = GreenPointY3; Value >= 396; Value--)
                        {
                            GreenCircule3.Location = new Point(607, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule3.Location = new Point(607 - i, 396 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(568 - i, 357);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3; Value >= 352; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 357)
                    {
                        for (int Value = GreenPointX3; Value >= 352; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////8888888888

                else if (GreenCountThird == 8)
                {
                    if (GreenCircule3.Location.X == 607)
                    {

                        for (int Value = GreenPointY3; Value >= 396; Value--)
                        {
                            GreenCircule3.Location = new Point(607, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule3.Location = new Point(607 - i, 396 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(568 - i, 357);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3; Value >= 269; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 357)
                    {
                        for (int Value = GreenPointX3; Value >= 269; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////9999999

                else if (GreenCountThird == 9)
                {
                    if (GreenCircule3.Location.X == 607)
                    {

                        for (int Value = GreenPointY3; Value >= 396; Value--)
                        {
                            GreenCircule3.Location = new Point(607, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule3.Location = new Point(607 - i, 396 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(568 - i, 357);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3; Value >= 184; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 357)
                    {
                        for (int Value = GreenPointX3; Value >= 184; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////100000000

                else if (GreenCountThird == 10)
                {
                    if (GreenCircule3.Location.X == 607)
                    {

                        for (int Value = GreenPointY3; Value >= 396; Value--)
                        {
                            GreenCircule3.Location = new Point(607, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule3.Location = new Point(607 - i, 396 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(568 - i, 357);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 357)
                    {
                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////1111111111

                else if (GreenCountThird == 11)
                {
                    if (GreenCircule3.Location.Y == 357)
                    {

                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 357; Value >= 318; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }


                /////////////122222222

                else if (GreenCountThird == 12)
                {
                    if (GreenCircule3.Location.Y == 357)
                    {

                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 357; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.Y == 318)
                    {

                        for (int Value = GreenPointY3 = 318; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////133333333333


                else if (GreenCountThird == 13)
                {
                    if (GreenCircule3.Location.Y == 357)
                    {

                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 357; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 100; Value <= 178; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 318)
                    {
                        for (int Value = GreenPointY3 = 318; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 100; Value <= 178; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 178; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////144444444

                else if (GreenCountThird == 14)
                {
                    if (GreenCircule3.Location.Y == 357)
                    {

                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 357; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 100; Value <= 266; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 318)
                    {
                        for (int Value = GreenPointY3 = 318; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 100; Value <= 266; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 266; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////15555555555

                else if (GreenCountThird == 15)
                {
                    if (GreenCircule3.Location.Y == 357)
                    {

                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 357; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 100; Value <= 351; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 318)
                    {
                        for (int Value = GreenPointY3 = 318; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 100; Value <= 351; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 351; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////////16666666666

                else if (GreenCountThird == 16)
                {
                    if (GreenCircule3.Location.Y == 357)
                    {

                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 357; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 100; Value <= 436; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 318)
                    {
                        for (int Value = GreenPointY3 = 318; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 100; Value <= 436; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 436; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////1777777777

                else if (GreenCountThird == 17)
                {
                    if (GreenCircule3.Location.Y == 357)
                    {

                        for (int Value = GreenPointX3; Value >= 100; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 357);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 357; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 100; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 318)
                    {
                        for (int Value = GreenPointY3 = 318; Value >= 277; Value--)
                        {
                            GreenCircule3.Location = new Point(100, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 100; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////1888888

                else if (GreenCountThird == 18)
                {

                    if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(518 + i, 277 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule3.Location = new Point(558 + i, 237);

                            GreenCircule3.Refresh();

                            GreenPointY3 = 237;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////199999

                else if (GreenCountThird == 19)
                {

                    if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(518 + i, 277 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule3.Location = new Point(558 + i, 237);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 237; Value >= 198; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 198; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////2000000

                else if (GreenCountThird == 20)
                {

                    if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(518 + i, 277 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule3.Location = new Point(558 + i, 237);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 237; Value >= 158; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 158; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////////2111111111

                else if (GreenCountThird == 21)
                {

                    if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(518 + i, 277 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule3.Location = new Point(558 + i, 237);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 237; Value >= 118; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 118; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////2222222

                else if (GreenCountThird == 22)
                {

                    if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(518 + i, 277 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule3.Location = new Point(558 + i, 237);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 237; Value >= 79; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 79; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                    /////23333333

                else if (GreenCountThird == 23)
                {

                    if (GreenCircule3.Location.Y == 277)
                    {

                        for (int Value = GreenPointX3; Value <= 518; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 277);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(518 + i, 277 - i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule3.Location = new Point(558 + i, 237);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 237; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //24444444444

                else if (GreenCountThird == 24)
                {
                    if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 602; Value <= 688; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //255555555555

                else if (GreenCountThird == 25)
                {
                    if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 602; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 688)
                    {
                        for (int Value = GreenPointX3 = 688; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////266666666

                else if (GreenCountThird == 26)
                {
                    if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 602; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 41; Value <= 77; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule3.Location.X == 688)
                    {
                        for (int Value = GreenPointX3 = 688; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 41; Value <= 77; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 77; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////27777777

                else if (GreenCountThird == 27)
                {
                    if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 602; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 41; Value <= 117; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule3.Location.X == 688)
                    {
                        for (int Value = GreenPointX3 = 688; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 41; Value <= 117; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 117; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////////288888888

                else if (GreenCountThird == 28)
                {
                    if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 602; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 41; Value <= 157; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule3.Location.X == 688)
                    {
                        for (int Value = GreenPointX3 = 688; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 41; Value <= 157; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 157; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////299999

                else if (GreenCountThird == 29)
                {
                    if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 602; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 41; Value <= 198; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule3.Location.X == 688)
                    {
                        for (int Value = GreenPointX3 = 688; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 41; Value <= 198; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 198; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////300000000000

                else if (GreenCountThird == 30)
                {
                    if (GreenCircule3.Location.X == 602)
                    {

                        for (int Value = GreenPointY3; Value >= 41; Value--)
                        {
                            GreenCircule3.Location = new Point(602, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 602; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 41; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule3.Location.X == 688)
                    {
                        for (int Value = GreenPointX3 = 688; Value <= 769; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 41);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3 = 41; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////3111111

                else if (GreenCountThird == 31)
                {
                    if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule3.Location = new Point(769 + i, 237 + i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(807 + i, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = 867;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////322222222

                else if (GreenCountThird == 32)
                {
                    if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule3.Location = new Point(769 + i, 237 + i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(807 + i, 275);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 867; Value <= 942; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 942; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                /////////3333333

                else if (GreenCountThird == 33)
                {
                    if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule3.Location = new Point(769 + i, 237 + i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(807 + i, 275);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 867; Value <= 1028; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1028; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                ///////344444444

                else if (GreenCountThird == 34)
                {
                    if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule3.Location = new Point(769 + i, 237 + i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(807 + i, 275);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 867; Value <= 1116; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1116; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                ///////////35555555

                else if (GreenCountThird == 35)
                {
                    if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule3.Location = new Point(769 + i, 237 + i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(807 + i, 275);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 867; Value <= 1197; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1197; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                /////366666666666

                else if (GreenCountThird == 36)
                {
                    if (GreenCircule3.Location.X == 769)
                    {

                        for (int Value = GreenPointY3; Value <= 237; Value++)
                        {
                            GreenCircule3.Location = new Point(769, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule3.Location = new Point(769 + i, 237 + i);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule3.Location = new Point(807 + i, 275);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 867; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////////3777777

                else if (GreenCountThird == 37)
                {
                    if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 275; Value <= 314; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////388888888888

                else if (GreenCountThird == 38)
                {
                    if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 275; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }
                    }



                    else if (GreenCircule3.Location.Y == 314)
                    {
                        for (int Value = GreenPointY3 = 314; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }
                    }
                }

                /////////39999999

                else if (GreenCountThird == 39)
                {
                    if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 275; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 1199; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule3.Location.Y == 314)
                    {
                        for (int Value = GreenPointY3 = 314; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 1199; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 1199; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ////4000000

                else if (GreenCountThird == 40)
                {
                    if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 275; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 1113; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule3.Location.Y == 314)
                    {
                        for (int Value = GreenPointY3 = 314; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 1113; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 1113; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///////4111111

                else if (GreenCountThird == 41)
                {
                    if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 275; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 1029; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule3.Location.Y == 314)
                    {
                        for (int Value = GreenPointY3 = 314; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 1029; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 1029; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////////42222222

                else if (GreenCountThird == 42)
                {
                    if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 275; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 942; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule3.Location.Y == 314)
                    {
                        for (int Value = GreenPointY3 = 314; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 942; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 942; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ////////4333333

                else if (GreenCountThird == 43)
                {
                    if (GreenCircule3.Location.Y == 275)
                    {
                        for (int Value = GreenPointX3; Value <= 1283; Value++)
                        {
                            GreenCircule3.Location = new Point(Value, 275);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 275; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule3.Location.Y == 314)
                    {
                        for (int Value = GreenPointY3 = 314; Value <= 355; Value++)
                        {
                            GreenCircule3.Location = new Point(1283, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX3 = 1283; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////4444444

                else if (GreenCountThird == 44)
                {
                    if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule3.Location = new Point(856 - i, 355);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(777, 355 + i);

                            GreenCircule3.Refresh();

                            GreenPointY3 = 395;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////45555


                else if (GreenCountThird == 45)
                {
                    if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule3.Location = new Point(856 - i, 355);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(777, 355 + i);

                            GreenCircule3.Refresh();

                            GreenPointY3 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3; Value <= 433; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 777)
                    {

                        for (int Value = GreenPointY3; Value <= 433; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////466666

                else if (GreenCountThird == 46)
                {
                    if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule3.Location = new Point(856 - i, 355);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(777, 355 + i);

                            GreenCircule3.Refresh();

                            GreenPointY3 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3; Value <= 474; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 777)
                    {

                        for (int Value = GreenPointY3; Value <= 474; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //////47777777

                else if (GreenCountThird == 47)
                {
                    if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule3.Location = new Point(856 - i, 355);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(777, 355 + i);

                            GreenCircule3.Refresh();

                            GreenPointY3 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3; Value <= 513; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 777)
                    {

                        for (int Value = GreenPointY3; Value <= 513; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //48888

                else if (GreenCountThird == 48)
                {
                    if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule3.Location = new Point(856 - i, 355);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(777, 355 + i);

                            GreenCircule3.Refresh();

                            GreenPointY3 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3; Value <= 551; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 777)
                    {

                        for (int Value = GreenPointY3; Value <= 551; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///////499999

                else if (GreenCountThird == 49)
                {
                    if (GreenCircule3.Location.Y == 355)
                    {
                        for (int Value = GreenPointX3; Value >= 856; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 355);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule3.Location = new Point(856 - i, 355);

                            GreenCircule3.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule3.Location = new Point(777, 355 + i);

                            GreenCircule3.Refresh();

                            GreenPointY3 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule3.Location.X == 777)
                    {

                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////////50000000000


                else if (GreenCountThird == 50)
                {
                    if (GreenCircule3.Location.X == 777)
                    {
                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 777; Value >= 690; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 592);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                /////5111111111


                else if (GreenCountThird == 51)
                {
                    if (GreenCircule3.Location.X == 777)
                    {
                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 777; Value >= 690; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 592);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 592; Value >= 552; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.X == 690)
                    {
                        for (int Value = GreenPointY3; Value >= 552; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //////52222222

                else if (GreenCountThird == 52)
                {
                    if (GreenCircule3.Location.X == 777)
                    {
                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 777; Value >= 690; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 592);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 592; Value >= 513; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.X == 690)
                    {
                        for (int Value = GreenPointY3; Value >= 513; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////53333333

                else if (GreenCountThird == 53)
                {
                    if (GreenCircule3.Location.X == 777)
                    {
                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 777; Value >= 690; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 592);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 592; Value >= 474; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.X == 690)
                    {
                        for (int Value = GreenPointY3; Value >= 474; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                    ////54444444444

                else if (GreenCountThird == 54)
                {
                    if (GreenCircule3.Location.X == 777)
                    {
                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 777; Value >= 690; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 592);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 592; Value >= 434; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.X == 690)
                    {
                        for (int Value = GreenPointY3; Value >= 434; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                ///555555
                ///

                else if (GreenCountThird == 55)
                {
                    if (GreenCircule3.Location.X == 777)
                    {
                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 777; Value >= 690; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 592);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 592; Value >= 394; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule3.Location.X == 690)
                    {
                        for (int Value = GreenPointY3; Value >= 394; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///566666
                ///
                else if (GreenCountThird == 56)
                {
                    if (GreenCircule3.Location.X == 777)
                    {
                        for (int Value = GreenPointY3; Value <= 592; Value++)
                        {
                            GreenCircule3.Location = new Point(777, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX3 = 777; Value >= 690; Value--)
                        {
                            GreenCircule3.Location = new Point(Value, 592);

                            GreenCircule3.Refresh();

                            GreenPointX3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY3 = 592; Value >= 315; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int complete = 1; complete <= 34; complete++)
                        {

                            GreenCircule3.SetBounds(690, 315, 37 - complete, 34 - complete);

                            GreenCircule3.Refresh();

                            Thread.Sleep(4);
                        }


                    }

                    else if (GreenCircule3.Location.X == 690)
                    {
                        for (int Value = GreenPointY3; Value >= 315; Value--)
                        {
                            GreenCircule3.Location = new Point(690, Value);

                            GreenCircule3.Refresh();

                            GreenPointY3 = Value;

                            Thread.Sleep(1);
                        }

                        for (int complete = 1; complete <= 34; complete++)
                        {

                            GreenCircule3.SetBounds(690, 315, 37 - complete, 34 - complete);

                            GreenCircule3.Refresh();

                            Thread.Sleep(4);
                        }

                    }
                }
            }

        }


        private void GreenCircule4_Click(object sender, EventArgs e)
        {

            GreenCountFour = Dice + GreenCountFour;

            if (GreenCircule4.Location.Y == 552 && GreenCountFour >= 57)
            {
                GreenCountFour = 51;
            }

            else if (GreenCircule4.Location.Y == 513 && GreenCountFour >= 57)
            {
                GreenCountFour = 52;
            }

            else if (GreenCircule4.Location.Y == 474 && GreenCountFour >= 57)
            {
                GreenCountFour = 53;
            }

            else if (GreenCircule4.Location.Y == 434 && GreenCountFour >= 57)
            {
                GreenCountFour = 54;
            }

            else if (GreenCircule4.Location.Y == 394 && GreenCountFour >= 57)
            {
                GreenCountFour = 55;
            }


            else
            {

                if (GreenCountFour == 1)
                {
                    for (int Value = GreenPointY4; Value >= 513; Value--)
                    {
                        GreenCircule4.Location = new Point(607, Value);

                        GreenCircule4.Refresh();

                        GreenPointY4 = Value;

                        Thread.Sleep(1);
                    }

                }
                //22222222
                else if (GreenCountFour == 2)
                {
                    for (int Value = GreenPointY4; Value >= 474; Value--)
                    {
                        GreenCircule4.Location = new Point(607, Value);

                        GreenCircule4.Refresh();

                        GreenPointY4 = Value;

                        Thread.Sleep(1);
                    }

                }

                    //////3333333333
                else if (GreenCountFour == 3)
                {
                    for (int Value = GreenPointY4; Value >= 434; Value--)
                    {
                        GreenCircule4.Location = new Point(607, Value);

                        GreenCircule4.Refresh();

                        GreenPointY4 = Value;

                        Thread.Sleep(1);
                    }

                }
                ///////4444444444
                else if (GreenCountFour == 4)
                {
                    for (int Value = GreenPointY4; Value >= 396; Value--)
                    {
                        GreenCircule4.Location = new Point(607, Value);

                        GreenCircule4.Refresh();

                        GreenPointY4 = Value;

                        Thread.Sleep(1);
                    }

                }

                    ///////////5555555
                else if (GreenCountFour == 5)
                {
                    for (int Value = GreenPointY4; Value >= 396; Value--)
                    {
                        GreenCircule4.Location = new Point(607, Value);

                        GreenCircule4.Refresh();

                        GreenPointY4 = Value;

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 39; i++)
                    {
                        GreenCircule4.Location = new Point(607 - i, 396 - i);

                        GreenCircule4.Refresh();

                        Thread.Sleep(1);
                    }


                    for (int i = 1; i <= 60; i++)
                    {
                        GreenCircule4.Location = new Point(568 - i, 357);

                        GreenCircule4.Refresh();

                        Thread.Sleep(1);
                    }

                }

                //////66666666

                else if (GreenCountFour == 6)
                {
                    if (GreenCircule4.Location.X == 607)
                    {

                        for (int Value = GreenPointY4; Value >= 396; Value--)
                        {
                            GreenCircule4.Location = new Point(607, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule4.Location = new Point(607 - i, 396 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(568 - i, 357);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4; Value >= 438; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 357)
                    {
                        for (int Value = GreenPointX4; Value >= 438; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////77777777

                else if (GreenCountFour == 7)
                {
                    if (GreenCircule4.Location.X == 607)
                    {

                        for (int Value = GreenPointY4; Value >= 396; Value--)
                        {
                            GreenCircule4.Location = new Point(607, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule4.Location = new Point(607 - i, 396 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(568 - i, 357);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4; Value >= 352; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 357)
                    {
                        for (int Value = GreenPointX4; Value >= 352; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////8888888888

                else if (GreenCountFour == 8)
                {
                    if (GreenCircule4.Location.X == 607)
                    {

                        for (int Value = GreenPointY4; Value >= 396; Value--)
                        {
                            GreenCircule4.Location = new Point(607, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule4.Location = new Point(607 - i, 396 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(568 - i, 357);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4; Value >= 269; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 357)
                    {
                        for (int Value = GreenPointX4; Value >= 269; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////9999999

                else if (GreenCountFour == 9)
                {
                    if (GreenCircule4.Location.X == 607)
                    {

                        for (int Value = GreenPointY4; Value >= 396; Value--)
                        {
                            GreenCircule4.Location = new Point(607, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule4.Location = new Point(607 - i, 396 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(568 - i, 357);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4; Value >= 184; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 357)
                    {
                        for (int Value = GreenPointX4; Value >= 184; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////100000000

                else if (GreenCountFour == 10)
                {
                    if (GreenCircule4.Location.X == 607)
                    {

                        for (int Value = GreenPointY4; Value >= 396; Value--)
                        {
                            GreenCircule4.Location = new Point(607, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 39; i++)
                        {
                            GreenCircule4.Location = new Point(607 - i, 396 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(568 - i, 357);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 357)
                    {
                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////1111111111

                else if (GreenCountFour == 11)
                {
                    if (GreenCircule4.Location.Y == 357)
                    {

                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 357; Value >= 318; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }


                /////////////122222222

                else if (GreenCountFour == 12)
                {
                    if (GreenCircule4.Location.Y == 357)
                    {

                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 357; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.Y == 318)
                    {

                        for (int Value = GreenPointY4 = 318; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////133333333333


                else if (GreenCountFour == 13)
                {
                    if (GreenCircule4.Location.Y == 357)
                    {

                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 357; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 100; Value <= 178; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 318)
                    {
                        for (int Value = GreenPointY4 = 318; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 100; Value <= 178; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 178; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////144444444

                else if (GreenCountFour == 14)
                {
                    if (GreenCircule4.Location.Y == 357)
                    {

                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 357; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 100; Value <= 266; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 318)
                    {
                        for (int Value = GreenPointY4 = 318; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 100; Value <= 266; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 266; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////15555555555

                else if (GreenCountFour == 15)
                {
                    if (GreenCircule4.Location.Y == 357)
                    {

                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 357; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 100; Value <= 351; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 318)
                    {
                        for (int Value = GreenPointY4 = 318; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 100; Value <= 351; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 351; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////////16666666666

                else if (GreenCountFour == 16)
                {
                    if (GreenCircule4.Location.Y == 357)
                    {

                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 357; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 100; Value <= 436; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 318)
                    {
                        for (int Value = GreenPointY4 = 318; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 100; Value <= 436; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 436; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////1777777777

                else if (GreenCountFour == 17)
                {
                    if (GreenCircule4.Location.Y == 357)
                    {

                        for (int Value = GreenPointX4; Value >= 100; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 357);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 357; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 100; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 318)
                    {
                        for (int Value = GreenPointY4 = 318; Value >= 277; Value--)
                        {
                            GreenCircule4.Location = new Point(100, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 100; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }


                    else if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////1888888

                else if (GreenCountFour == 18)
                {

                    if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(518 + i, 277 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule4.Location = new Point(558 + i, 237);

                            GreenCircule4.Refresh();

                            GreenPointY4 = 237;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////199999

                else if (GreenCountFour == 19)
                {

                    if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(518 + i, 277 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule4.Location = new Point(558 + i, 237);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 237; Value >= 198; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 198; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////////2000000

                else if (GreenCountFour == 20)
                {

                    if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(518 + i, 277 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule4.Location = new Point(558 + i, 237);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 237; Value >= 158; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 158; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////////2111111111

                else if (GreenCountFour == 21)
                {

                    if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(518 + i, 277 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule4.Location = new Point(558 + i, 237);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 237; Value >= 118; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 118; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////2222222

                else if (GreenCountFour == 22)
                {

                    if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(518 + i, 277 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule4.Location = new Point(558 + i, 237);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 237; Value >= 79; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 79; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                    /////23333333

                else if (GreenCountFour == 23)
                {

                    if (GreenCircule4.Location.Y == 277)
                    {

                        for (int Value = GreenPointX4; Value <= 518; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 277);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(518 + i, 277 - i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 44; i++)
                        {
                            GreenCircule4.Location = new Point(558 + i, 237);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 237; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //24444444444

                else if (GreenCountFour == 24)
                {
                    if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 602; Value <= 688; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //255555555555

                else if (GreenCountFour == 25)
                {
                    if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 602; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 688)
                    {
                        for (int Value = GreenPointX4 = 688; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////266666666

                else if (GreenCountFour == 26)
                {
                    if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 602; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 41; Value <= 77; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule4.Location.X == 688)
                    {
                        for (int Value = GreenPointX4 = 688; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 41; Value <= 77; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 77; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                /////////27777777

                else if (GreenCountFour == 27)
                {
                    if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 602; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 41; Value <= 117; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule4.Location.X == 688)
                    {
                        for (int Value = GreenPointX4 = 688; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 41; Value <= 117; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 117; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////////288888888

                else if (GreenCountFour == 28)
                {
                    if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 602; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 41; Value <= 157; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule4.Location.X == 688)
                    {
                        for (int Value = GreenPointX4 = 688; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 41; Value <= 157; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 157; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////////299999

                else if (GreenCountFour == 29)
                {
                    if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 602; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 41; Value <= 198; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule4.Location.X == 688)
                    {
                        for (int Value = GreenPointX4 = 688; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 41; Value <= 198; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 198; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////300000000000

                else if (GreenCountFour == 30)
                {
                    if (GreenCircule4.Location.X == 602)
                    {

                        for (int Value = GreenPointY4; Value >= 41; Value--)
                        {
                            GreenCircule4.Location = new Point(602, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 602; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 41; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }



                    }

                    else if (GreenCircule4.Location.X == 688)
                    {
                        for (int Value = GreenPointX4 = 688; Value <= 769; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 41);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4 = 41; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ////3111111

                else if (GreenCountFour == 31)
                {
                    if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule4.Location = new Point(769 + i, 237 + i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(807 + i, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = 867;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////322222222

                else if (GreenCountFour == 32)
                {
                    if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule4.Location = new Point(769 + i, 237 + i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(807 + i, 275);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 867; Value <= 942; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 942; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                /////////3333333

                else if (GreenCountFour == 33)
                {
                    if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule4.Location = new Point(769 + i, 237 + i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(807 + i, 275);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 867; Value <= 1028; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1028; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                ///////344444444

                else if (GreenCountFour == 34)
                {
                    if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule4.Location = new Point(769 + i, 237 + i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(807 + i, 275);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 867; Value <= 1116; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1116; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                ///////////35555555

                else if (GreenCountFour == 35)
                {
                    if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule4.Location = new Point(769 + i, 237 + i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(807 + i, 275);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 867; Value <= 1197; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1197; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                }

                /////366666666666

                else if (GreenCountFour == 36)
                {
                    if (GreenCircule4.Location.X == 769)
                    {

                        for (int Value = GreenPointY4; Value <= 237; Value++)
                        {
                            GreenCircule4.Location = new Point(769, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 38; i++)
                        {
                            GreenCircule4.Location = new Point(769 + i, 237 + i);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 60; i++)
                        {
                            GreenCircule4.Location = new Point(807 + i, 275);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 867; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                //////////3777777

                else if (GreenCountFour == 37)
                {
                    if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 275; Value <= 314; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                }

                ///////388888888888

                else if (GreenCountFour == 38)
                {
                    if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 275; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }
                    }



                    else if (GreenCircule4.Location.Y == 314)
                    {
                        for (int Value = GreenPointY4 = 314; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }
                    }
                }

                /////////39999999

                else if (GreenCountFour == 39)
                {
                    if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 275; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 1199; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule4.Location.Y == 314)
                    {
                        for (int Value = GreenPointY4 = 314; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 1199; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 1199; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ////4000000

                else if (GreenCountFour == 40)
                {
                    if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 275; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 1113; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule4.Location.Y == 314)
                    {
                        for (int Value = GreenPointY4 = 314; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 1113; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 1113; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///////4111111

                else if (GreenCountFour == 41)
                {
                    if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 275; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 1029; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule4.Location.Y == 314)
                    {
                        for (int Value = GreenPointY4 = 314; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 1029; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 1029; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////////42222222

                else if (GreenCountFour == 42)
                {
                    if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 275; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 942; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule4.Location.Y == 314)
                    {
                        for (int Value = GreenPointY4 = 314; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 942; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 942; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ////////4333333

                else if (GreenCountFour == 43)
                {
                    if (GreenCircule4.Location.Y == 275)
                    {
                        for (int Value = GreenPointX4; Value <= 1283; Value++)
                        {
                            GreenCircule4.Location = new Point(Value, 275);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 275; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }


                    }


                    else if (GreenCircule4.Location.Y == 314)
                    {
                        for (int Value = GreenPointY4 = 314; Value <= 355; Value++)
                        {
                            GreenCircule4.Location = new Point(1283, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointX4 = 1283; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////4444444

                else if (GreenCountFour == 44)
                {
                    if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule4.Location = new Point(856 - i, 355);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(777, 355 + i);

                            GreenCircule4.Refresh();

                            GreenPointY4 = 395;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////45555


                else if (GreenCountFour == 45)
                {
                    if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule4.Location = new Point(856 - i, 355);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(777, 355 + i);

                            GreenCircule4.Refresh();

                            GreenPointY4 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4; Value <= 433; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 777)
                    {

                        for (int Value = GreenPointY4; Value <= 433; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////466666

                else if (GreenCountFour == 46)
                {
                    if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule4.Location = new Point(856 - i, 355);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(777, 355 + i);

                            GreenCircule4.Refresh();

                            GreenPointY4 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4; Value <= 474; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 777)
                    {

                        for (int Value = GreenPointY4; Value <= 474; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //////47777777

                else if (GreenCountFour == 47)
                {
                    if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule4.Location = new Point(856 - i, 355);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(777, 355 + i);

                            GreenCircule4.Refresh();

                            GreenPointY4 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4; Value <= 513; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 777)
                    {

                        for (int Value = GreenPointY4; Value <= 513; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //48888

                else if (GreenCountFour == 48)
                {
                    if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule4.Location = new Point(856 - i, 355);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(777, 355 + i);

                            GreenCircule4.Refresh();

                            GreenPointY4 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4; Value <= 551; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 777)
                    {

                        for (int Value = GreenPointY4; Value <= 551; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///////499999

                else if (GreenCountFour == 49)
                {
                    if (GreenCircule4.Location.Y == 355)
                    {
                        for (int Value = GreenPointX4; Value >= 856; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 355);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int i = 1; i <= 79; i++)
                        {
                            GreenCircule4.Location = new Point(856 - i, 355);

                            GreenCircule4.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int i = 1; i <= 40; i++)
                        {
                            GreenCircule4.Location = new Point(777, 355 + i);

                            GreenCircule4.Refresh();

                            GreenPointY4 = 395;

                            Thread.Sleep(1);
                        }


                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }

                    else if (GreenCircule4.Location.X == 777)
                    {

                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////////50000000000


                else if (GreenCountFour == 50)
                {
                    if (GreenCircule4.Location.X == 777)
                    {
                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 777; Value >= 690; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 592);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                /////5111111111


                else if (GreenCountFour == 51)
                {
                    if (GreenCircule4.Location.X == 777)
                    {
                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 777; Value >= 690; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 592);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 592; Value >= 552; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.X == 690)
                    {
                        for (int Value = GreenPointY4; Value >= 552; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                //////52222222

                else if (GreenCountFour == 52)
                {
                    if (GreenCircule4.Location.X == 777)
                    {
                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 777; Value >= 690; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 592);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 592; Value >= 513; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.X == 690)
                    {
                        for (int Value = GreenPointY4; Value >= 513; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                /////53333333

                else if (GreenCountFour == 53)
                {
                    if (GreenCircule4.Location.X == 777)
                    {
                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 777; Value >= 690; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 592);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 592; Value >= 474; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.X == 690)
                    {
                        for (int Value = GreenPointY4; Value >= 474; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                    ////54444444444

                else if (GreenCountFour == 54)
                {
                    if (GreenCircule4.Location.X == 777)
                    {
                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 777; Value >= 690; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 592);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 592; Value >= 434; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.X == 690)
                    {
                        for (int Value = GreenPointY4; Value >= 434; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }


                ///555555
                ///

                else if (GreenCountFour == 55)
                {
                    if (GreenCircule4.Location.X == 777)
                    {
                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 777; Value >= 690; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 592);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 592; Value >= 394; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }


                    }

                    else if (GreenCircule4.Location.X == 690)
                    {
                        for (int Value = GreenPointY4; Value >= 394; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                    }
                }

                ///566666
                ///
                else if (GreenCountFour == 56)
                {
                    if (GreenCircule4.Location.X == 777)
                    {
                        for (int Value = GreenPointY4; Value <= 592; Value++)
                        {
                            GreenCircule4.Location = new Point(777, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointX4 = 777; Value >= 690; Value--)
                        {
                            GreenCircule4.Location = new Point(Value, 592);

                            GreenCircule4.Refresh();

                            GreenPointX4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int Value = GreenPointY4 = 592; Value >= 315; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int complete = 1; complete <= 34; complete++)
                        {

                            GreenCircule4.SetBounds(690, 315, 37 - complete, 34 - complete);

                            GreenCircule4.Refresh();

                            Thread.Sleep(4);
                        }


                    }

                    else if (GreenCircule4.Location.X == 690)
                    {
                        for (int Value = GreenPointY4; Value >= 315; Value--)
                        {
                            GreenCircule4.Location = new Point(690, Value);

                            GreenCircule4.Refresh();

                            GreenPointY4 = Value;

                            Thread.Sleep(1);
                        }

                        for (int complete = 1; complete <= 34; complete++)
                        {

                            GreenCircule4.SetBounds(690, 315, 37 - complete, 34 - complete);

                            GreenCircule4.Refresh();

                            Thread.Sleep(4);
                        }

                    }
                }
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {

            GreenCircule4.Location = new Point(777, 395);

            GreenCountFour = 44;

            GreenPointX4 = 777;

            GreenPointY4 = 395;
        }
    }
}

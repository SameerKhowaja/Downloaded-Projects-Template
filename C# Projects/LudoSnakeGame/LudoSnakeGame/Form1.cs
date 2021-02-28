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
namespace LudoSnakeGame
{
    public partial class Form1 : Form
    {
        
        Random rn = new Random();
        int store1;
        int dice;
        int count1=1;
        int y=530;
        int firstrowcount=83;
        int secondrowcount;
        int thirdrowcount=83;
        int fourrowcount;
        int fivthrowcount=83;
        int sixthrowcount;
        int seventhrowcount = 83;
        int eigthrowcount;
        int ninethrowcount=83;
        int tenthrowcount;
        int change=0;


        /// <summary>
        /// ///////////////////////
        /// </summary>
        Random rn2 = new Random();
        int store2;
        int Secdice2;
        int count2=1;
        int y2 = 530;
        int firstrowcount2 = 83;
        int secondrowcount2;
        int thirdrowcount2 = 83;
        int fourrowcount2;
        int fivthrowcount2 = 83;
        int sixthrowcount2;
        int seventhrowcount2 = 83;
        int eigthrowcount2;
        int ninethrowcount2 = 83;
        int tenthrowcount2;




       // System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"D:\Assignment\C# Assignment\LudoSnakeGame\LudoSnakeGame\1song_001.wav");
    
        public Form1()
        {
            
            InitializeComponent();
            //startSoundPlayer.PlayLooping();

        }


        private void FirstPlayerPlayButton_Click(object sender, EventArgs e)
        {

            



            dice = rn.Next(1,7);

            count1 = count1 + dice;



            if (count1 >= count2)
            {
                picturePlayer1.BringToFront();
                picturePlayer2.SendToBack();
            }



            if (change == 0)
            {

                FirstPlayerPlayButton.Visible = false;
                SecPlayerPlayButton.Visible = true;
                Head.Text = ("Player 2 Turn");
                Head.ForeColor = Color.Yellow;
                Head.BackColor = Color.FromArgb(0, 192, 0);
                change = 1;
            }



            if (dice == 1)
            {




                dice1.Visible = true;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
                for (int th = 1; th <= 88; th++)
                {

                    dice1.Size = new System.Drawing.Size(102, th);
                    dice1.Refresh();
                    Thread.Sleep(1);

                }



            }

            else if (dice == 2)
            {

                dice2.Visible = true;
                dice1.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
                for (int th = 1; th <= 102; th++)
                {

                    dice2.Size = new System.Drawing.Size(th, 88);
                    dice2.Refresh();
                    Thread.Sleep(1);

                }




            }
            else if (dice == 3)
            {

                dice3.Visible = true;
                dice1.Visible = false;
                dice2.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;

                for (int th = 1; th <= 88; th++)
                {

                    dice3.Size = new System.Drawing.Size(102, th);
                    dice3.Refresh();
                    Thread.Sleep(1);

                }
            }
            else if (dice == 4)
            {

                dice4.Visible = true;
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
                for (int th = 1; th <= 102; th++)
                {

                    dice4.Size = new System.Drawing.Size(th, 88);
                    dice4.Refresh();
                    Thread.Sleep(1);

                }
            }
            else if (dice == 5)
            {

                dice5.Visible = true;
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice6.Visible = false;
                for (int th = 1; th <= 88; th++)
                {

                    dice5.Size = new System.Drawing.Size(102, th);
                    dice5.Refresh();
                    Thread.Sleep(1);

                }
            }
            else if (dice == 6)
            {

                dice6.Visible = true;
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                
                for (int th = 1; th <= 102; th++)
                {

                    dice6.Size = new System.Drawing.Size(th, 88);
                    dice6.Refresh();
                    Thread.Sleep(1);

                }
            }



            Thread FirstPlayerThread = new Thread(Go);

            FirstPlayerThread.Start();

        }



        public delegate void moveBd(PictureBox FirstPlayerPlayButton);
        void moveButton(PictureBox FirstPlayerPlayButton)
        {


            if (store1 == 95 && count1 >= 101)
            {
                count1 = 95;

            }
            else if (store1 == 96 && count1 >= 101)
            {
                count1 = 96;

            }
            else if (store1 == 97 && count1 >= 101)
            {
                count1 = 97;

            }
            else if (store1 == 98 && count1 >= 101)
            {
                count1 = 98;

            }
            else if (store1 == 99 && count1 >= 101)
            {
                count1 = 99;

            }

            else
            {
                if (count1 == 1)
                {
                    for (int first = firstrowcount; first <= 176; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                }
                else if (count1 == 2)
                {
                    for (int first = firstrowcount; first <= 176; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                }
                else if (count1 == 3)
                {
                    for (int first = firstrowcount; first <= 270; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                }
                else if (count1 == 4)
                {
                    for (int first = firstrowcount; first <= 364; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                }
                else if (count1 == 5)
                {
                    for (int first = firstrowcount; first <= 457; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                }
                else if (count1 == 6)
                {
                    for (int first = firstrowcount; first <= 553; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                    for (int loop = 1; loop <= 56; loop++)
                    {




                        picturePlayer1.Location = new Point(553 - loop, 530 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 35; loop++)
                    {




                        picturePlayer1.Location = new Point(497 - loop, 474);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }
                    count1 = 16;
                    secondrowcount = 462;
                    y = 474;
                    firstrowcount = 83;
                    thirdrowcount = 83;
                    fourrowcount = 0;
                    fivthrowcount = 83;
                    sixthrowcount = 0;
                    seventhrowcount = 83;
                    eigthrowcount = 0;
                    ninethrowcount = 83;
                    tenthrowcount = 0;


                }
                else if (count1 == 7)
                {
                    for (int first = firstrowcount; first <= 642; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                }
                else if (count1 == 8)
                {
                    for (int first = firstrowcount; first <= 736; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                }
                else if (count1 == 9)
                {
                    for (int first = firstrowcount; first <= 825; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer1.Location = new Point(825 + loop, 530 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer1.Location = new Point(855, 500 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer1.Location = new Point(855 + loop, 470 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer1.Location = new Point(885, 440 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 44; loop++)
                    {




                        picturePlayer1.Location = new Point(885 + loop, 410 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 9; loop++)
                    {




                        picturePlayer1.Location = new Point(929 - loop, 366);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }
                    firstrowcount = 83;
                    secondrowcount = 0;
                    thirdrowcount = 83;
                    fourrowcount = 0;
                    fivthrowcount = 83;
                    sixthrowcount = 0;
                    seventhrowcount = 83;
                    eigthrowcount = 0;
                    ninethrowcount = 83;
                    tenthrowcount = 0;

                    y = 366;
                    count1 = 31;

                }
                else if (count1 == 10)
                {
                    for (int first = firstrowcount; first <= 920; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }
                }

                else if (count1 == 11)
                {
                    for (int first = firstrowcount; first <= 920; first++)
                    {
                        picturePlayer1.Location = new Point(first, y);
                        picturePlayer1.Refresh();
                        firstrowcount = first;
                        Thread.Sleep(1);
                    }

                    for (int first = 1; first <= 56; first++)
                    {
                        picturePlayer1.Location = new Point(920, 530 - first);
                        picturePlayer1.Refresh();
                        y = 474;
                        Thread.Sleep(1);
                    }
                }

                else if (count1 == 12)
                {
                    if (y == 474)
                    {
                        for (int first = 1; first <= 94; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 94; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////////////////////1333333333333333
                else if (count1 == 13)
                {
                    if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 187; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 187; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ////////////14444444444444444
                else if (count1 == 14)
                {
                    if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 280; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();
                            firstrowcount = first;
                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 280; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                /////////////1555555555555
                else if (count1 == 15)
                {
                    if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 372; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 372; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////////16666666666666666666
                else if (count1 == 16)
                {
                    if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 462; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 458; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////1777777777777777
                else if (count1 == 17)
                {
                    if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 559; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 559; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////18888888888
                else if (count1 == 18)
                {


                    if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 650; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }


                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer1.Location = new Point(272 + loop, 474);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 28; loop++)
                        {




                            picturePlayer1.Location = new Point(290 + loop, 474 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(318 + loop, 502 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        ///////////////////////plus
                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(333 + loop, 487);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        ////////////////////////plusminus


                        for (int loop = 1; loop <= 45; loop++)
                        {




                            picturePlayer1.Location = new Point(348 + loop, 487 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }




                        ///////////////

                        for (int loop = 1; loop <= 17; loop++)
                        {




                            picturePlayer1.Location = new Point(393 + loop, 532);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        ///uppppppppppppppp

                        for (int loop = 1; loop <= 19; loop++)
                        {




                            picturePlayer1.Location = new Point(410, 532 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        //////////////////
                        for (int loop = 1; loop <= 47; loop++)
                        {




                            picturePlayer1.Location = new Point(410 + loop, 513);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///downnnnnnnnnnnnnnnnnnnnnnnnn
                        for (int loop = 1; loop <= 17; loop++)
                        {




                            picturePlayer1.Location = new Point(457, 513 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);




                        }





                        firstrowcount = 457;
                        count1 = 5;
                        y = 530;

                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;


                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);
                        }


                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 650; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////////199999999999999999
                else if (count1 == 19)
                {
                    if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 732; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 108; loop++)
                        {




                            picturePlayer1.Location = new Point(188 + loop, 474 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 29; loop++)
                        {




                            picturePlayer1.Location = new Point(298 - loop, 366);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;
                        count1 = 38;
                        fourrowcount = 651;
                        y = 366;

                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 732; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                /////////////2000000000000
                else if (count1 == 20)
                {
                    if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 530)
                    {
                        for (int first = firstrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, y);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer1.Location = new Point(920, 530 - first);
                            picturePlayer1.Refresh();

                            y = 474;
                            Thread.Sleep(1);
                        }
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();
                            secondrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }

                //21111111111111111111
                else if (count1 == 21)
                {
                    for (int first = secondrowcount; first <= 837; first++)
                    {
                        picturePlayer1.Location = new Point(920 - first, 474);
                        picturePlayer1.Refresh();
                        secondrowcount = first;

                        Thread.Sleep(1);
                    }

                    for (int first = 1; first <= 53; first++)
                    {
                        picturePlayer1.Location = new Point(83, 474 - first);
                        picturePlayer1.Refresh();

                        y = 421;
                        Thread.Sleep(1);

                    }
                    for (int loop = 1; loop <= 40; loop++)
                    {




                        picturePlayer1.Location = new Point(83, 421 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 40; loop++)
                    {




                        picturePlayer1.Location = new Point(83 + loop, 381 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }


                    for (int loop = 1; loop <= 40; loop++)
                    {




                        picturePlayer1.Location = new Point(123, 341 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }


                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer1.Location = new Point(123 + loop, 301 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }



                    for (int loop = 1; loop <= 50; loop++)
                    {




                        picturePlayer1.Location = new Point(153, 271 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 50; loop++)
                    {




                        picturePlayer1.Location = new Point(153 + loop, 221 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }


                    for (int loop = 1; loop <= 28; loop++)
                    {




                        picturePlayer1.Location = new Point(203 - loop, 171);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }


                    for (int loop = 1; loop <= 20; loop++)
                    {




                        picturePlayer1.Location = new Point(175, 171 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }
                    count1 = 79;
                    eigthrowcount = 745;
                    y = 151;
                    firstrowcount = 83;
                    secondrowcount = 0;
                    thirdrowcount = 83;
                    fourrowcount = 0;
                    fivthrowcount = 83;
                    sixthrowcount = 0;
                    seventhrowcount = 83;

                    ninethrowcount = 83;
                    tenthrowcount = 0;

                }
                ///////////////////22222222222222222
                else if (count1 == 22)
                {
                    if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 179; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();


                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 474 - first);
                            picturePlayer1.Refresh();

                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int first = thirdrowcount; first <= 179; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }

                    }


                }

                ////////////////2333333333333333333

                else if (count1 == 23)
                {
                    if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 271; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();


                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 474 - first);
                            picturePlayer1.Refresh();

                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int first = thirdrowcount; first <= 271; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }

                    }


                }
                ////////////////24444444444444444
                else if (count1 == 24)
                {
                    if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 362; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();


                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 474 - first);
                            picturePlayer1.Refresh();

                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int first = thirdrowcount; first <= 362; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }

                    }


                }

                ///////////////////2555555555555555
                else if (count1 == 25)
                {
                    if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 456; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();


                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 474 - first);
                            picturePlayer1.Refresh();

                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int first = thirdrowcount; first <= 456; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }

                    }


                }
                ////////////////26666666666666
                else if (count1 == 26)
                {
                    if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 547; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();


                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 474 - first);
                            picturePlayer1.Refresh();

                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int first = thirdrowcount; first <= 547; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }

                    }


                }

                ///////////////277777777777
                else if (count1 == 27)
                {
                    if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 642; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();


                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 474 - first);
                            picturePlayer1.Refresh();

                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int first = thirdrowcount; first <= 642; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }

                    }


                }
                ///////////////////////288888888888888888888888888888888
                else if (count1 == 28)
                {
                    if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 734; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 100; loop++)
                        {




                            picturePlayer1.Location = new Point(734 - loop, 421 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(634 - loop, 321);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 100; loop++)
                        {




                            picturePlayer1.Location = new Point(614 - loop, 321 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(514 - loop, 221);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 122; loop++)
                        {




                            picturePlayer1.Location = new Point(494 - loop, 221 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(372 - loop, 99);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 84;
                        ninethrowcount = 362;
                        y = 99;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;

                        tenthrowcount = 0;
                    }
                    else if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();


                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 474 - first);
                            picturePlayer1.Refresh();

                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int first = thirdrowcount; first <= 734; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }

                    }


                }
                //////////////29999999999999999999999
                else if (count1 == 29)
                {
                    if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 827; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 474)
                    {
                        for (int first = secondrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 474);
                            picturePlayer1.Refresh();


                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 474 - first);
                            picturePlayer1.Refresh();

                            y = 421;
                            Thread.Sleep(1);
                        }
                        for (int first = thirdrowcount; first <= 827; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();
                            thirdrowcount = first;
                            y = 421;
                            Thread.Sleep(1);
                        }

                    }


                }
                //////////////30000000000000000000
                else if (count1 == 30)
                {

                    for (int first = thirdrowcount; first <= 920; first++)
                    {
                        picturePlayer1.Location = new Point(first, 421);
                        picturePlayer1.Refresh();
                        thirdrowcount = first;
                        y = 421;
                        Thread.Sleep(1);
                    }
                }


                //////////////////////////////31111111111111


                else if (count1 == 31)
                {



                    for (int first = thirdrowcount; first <= 920; first++)
                    {
                        picturePlayer1.Location = new Point(first, 421);
                        picturePlayer1.Refresh();

                        y = 366;
                        Thread.Sleep(1);
                    }
                    for (int first = 1; first <= 55; first++)
                    {
                        picturePlayer1.Location = new Point(920, 421 - first);
                        picturePlayer1.Refresh();
                        y = 366;
                        Thread.Sleep(1);
                    }

                }

                 ////////////////////////32222222222222222222222222222222

                else if (count1 == 32)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 92; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 92; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                /////////////////////////////////33333333333333333333333333333333333333333333
                else if (count1 == 33)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 185; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 185; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                //////////////////////344444444444444444444444
                else if (count1 == 34)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 279; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 279; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////////////////355555555555555555
                else if (count1 == 35)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 372; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 372; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////////////////////366666666666666
                else if (count1 == 36)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 465; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 465; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////////////3777777777777

                else if (count1 == 37)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 559; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 559; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////////3888888888888

                else if (count1 == 38)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 651; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 651; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                /////////399999999
                else if (count1 == 39)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 744; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 744; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }

                 /////////////////40000000000000
                else if (count1 == 40)
                {
                    if (y == 366)
                    {

                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                    else if (y == 421)
                    {
                        for (int first = thirdrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 421);
                            picturePlayer1.Refresh();

                            y = 366;
                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 421 - first);
                            picturePlayer1.Refresh();
                            y = 366;
                            Thread.Sleep(1);
                        }

                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 366;
                            fourrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                /////////////////////////////////////411111111111111111111111111111111111111

                else if (count1 == 41)
                {

                    for (int first = fourrowcount; first <= 837; first++)
                    {
                        picturePlayer1.Location = new Point(920 - first, 366);
                        picturePlayer1.Refresh();
                        y = 313;

                        Thread.Sleep(1);
                    }

                    for (int first = 1; first <= 53; first++)
                    {
                        picturePlayer1.Location = new Point(83, 366 - first);
                        picturePlayer1.Refresh();
                        y = 313;
                        Thread.Sleep(1);
                    }

                }

                 /////////////////////////////////////////422222222222222222222222

                else if (count1 == 42)
                {
                    if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 177; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 366)
                    {
                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 313;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 366 - first);
                            picturePlayer1.Refresh();
                            y = 313;
                            Thread.Sleep(1);
                        }

                        for (int first = fivthrowcount; first <= 177; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                }

                //////////////////////////43333333333333333333333
                else if (count1 == 43)
                {
                    if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 269; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }
                        ///////////mtttttttttt
                        for (int loop = 1; loop <= 3; loop++)
                        {




                            picturePlayer1.Location = new Point(269 + loop, 313);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 16; loop++)
                        {




                            picturePlayer1.Location = new Point(272, 313 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer1.Location = new Point(272 - loop, 329);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer1.Location = new Point(202, 329 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        ////////////////////////////
                        for (int loop = 1; loop <= 135; loop++)
                        {




                            picturePlayer1.Location = new Point(202 - loop, 347);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///////////////////////////////down
                        for (int loop = 1; loop <= 23; loop++)
                        {




                            picturePlayer1.Location = new Point(67, 347 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///////////////////////////////////in side plus
                        for (int loop = 1; loop <= 135; loop++)
                        {




                            picturePlayer1.Location = new Point(67 + loop, 370);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(202, 370 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }





                        //////////////////////////////////////////////////////////////////////////////////////////
                        for (int loop = 1; loop <= 130; loop++)
                        {




                            picturePlayer1.Location = new Point(202 - loop, 410);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        /////////////////////////////////////////////////////new
                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(72, 410 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        /////////////////////////////////////////////////
                        for (int loop = 1; loop <= 90; loop++)
                        {




                            picturePlayer1.Location = new Point(72 + loop, 390);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }





                        /////////////////////down

                        for (int loop = 1; loop <= 31; loop++)
                        {




                            picturePlayer1.Location = new Point(162, 390 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///////////////////////////////last


                        for (int loop = 1; loop <= 109; loop++)
                        {




                            picturePlayer1.Location = new Point(162 + loop, 421);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 23;
                        thirdrowcount = 271;
                        y = 421;
                        firstrowcount = 83;
                        secondrowcount = 0;

                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;


                    }
                    else if (y == 366)
                    {
                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 313;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 366 - first);
                            picturePlayer1.Refresh();
                            y = 313;
                            Thread.Sleep(1);
                        }

                        for (int first = fivthrowcount; first <= 269; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }
                        ///////////mtttttttttt
                        for (int loop = 1; loop <= 3; loop++)
                        {




                            picturePlayer1.Location = new Point(269 + loop, 313);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 16; loop++)
                        {




                            picturePlayer1.Location = new Point(272, 313 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer1.Location = new Point(272 - loop, 329);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer1.Location = new Point(202, 329 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        ////////////////////////////
                        for (int loop = 1; loop <= 135; loop++)
                        {




                            picturePlayer1.Location = new Point(202 - loop, 347);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///////////////////////////////down
                        for (int loop = 1; loop <= 23; loop++)
                        {




                            picturePlayer1.Location = new Point(67, 347 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///////////////////////////////////in side plus
                        for (int loop = 1; loop <= 135; loop++)
                        {




                            picturePlayer1.Location = new Point(67 + loop, 370);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(202, 370 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }





                        //////////////////////////////////////////////////////////////////////////////////////////
                        for (int loop = 1; loop <= 130; loop++)
                        {




                            picturePlayer1.Location = new Point(202 - loop, 410);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        /////////////////////////////////////////////////////new
                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(72, 410 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        /////////////////////////////////////////////////
                        for (int loop = 1; loop <= 90; loop++)
                        {




                            picturePlayer1.Location = new Point(72 + loop, 390);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }





                        /////////////////////down

                        for (int loop = 1; loop <= 31; loop++)
                        {




                            picturePlayer1.Location = new Point(162, 390 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///////////////////////////////last


                        for (int loop = 1; loop <= 109; loop++)
                        {




                            picturePlayer1.Location = new Point(162 + loop, 421);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 23;
                        thirdrowcount = 271;
                        y = 421;
                        firstrowcount = 83;
                        secondrowcount = 0;

                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;


                    }

                }
                //////////////////////44444444

                else if (count1 == 44)
                {
                    if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 363; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 366)
                    {
                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 313;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 366 - first);
                            picturePlayer1.Refresh();
                            y = 313;
                            Thread.Sleep(1);
                        }

                        for (int first = fivthrowcount; first <= 363; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                }

                 ///////////////455555555555555
                else if (count1 == 45)
                {
                    if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 456; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 366)
                    {
                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 313;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 366 - first);
                            picturePlayer1.Refresh();
                            y = 313;
                            Thread.Sleep(1);
                        }

                        for (int first = fivthrowcount; first <= 456; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                }

                 ///////////46666666666666666
                else if (count1 == 46)
                {
                    if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 548; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 366)
                    {
                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 313;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 366 - first);
                            picturePlayer1.Refresh();
                            y = 313;
                            Thread.Sleep(1);
                        }

                        for (int first = fivthrowcount; first <= 548; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                }
                ////////////////47777777777777
                else if (count1 == 47)
                {
                    if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 642; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 366)
                    {
                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 313;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 366 - first);
                            picturePlayer1.Refresh();
                            y = 313;
                            Thread.Sleep(1);
                        }

                        for (int first = fivthrowcount; first <= 642; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                }
                /////////////////488888888888888
                else if (count1 == 48)
                {
                    if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 735; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 366)
                    {
                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 313;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 366 - first);
                            picturePlayer1.Refresh();
                            y = 313;
                            Thread.Sleep(1);
                        }

                        for (int first = fivthrowcount; first <= 735; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                }

                 /////////////////49999999999
                else if (count1 == 49)
                {
                    if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 826; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }
                        ///////meeeeeeeee
                        for (int loop = 1; loop <= 26; loop++)
                        {




                            picturePlayer1.Location = new Point(826 + loop, 313);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 5; loop++)
                        {




                            picturePlayer1.Location = new Point(852, 313 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 13; loop++)
                        {




                            picturePlayer1.Location = new Point(852 + loop, 318 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer1.Location = new Point(865 + loop, 305);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        ////////////////////////////////////////////////////////////////////
                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer1.Location = new Point(900, 305 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        //////////////////////////////////////////////////////turn



                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(900 - loop, 340 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        ////////////////////////////////
                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer1.Location = new Point(885 - loop, 355);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        /////////////////////////////////uppppppppppppppppppppp


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(830, 355 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        //////////////////plusssssssssssssssssss

                        for (int loop = 1; loop <= 60; loop++)
                        {




                            picturePlayer1.Location = new Point(830 + loop, 335);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///////////////////////////////////////////////////down
                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(890, 335 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        ///////////againturnwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
                        for (int loop = 1; loop <= 155; loop++)
                        {




                            picturePlayer1.Location = new Point(890 - loop, 350);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        ///////////lastdownnnnnnnnnnnnnnnnnnnn
                        for (int loop = 1; loop <= 16; loop++)
                        {




                            picturePlayer1.Location = new Point(735, 350 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 33;
                        fourrowcount = 185;
                        y = 366;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;

                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;

                    }
                    else if (y == 366)
                    {
                        for (int first = fourrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 366);
                            picturePlayer1.Refresh();
                            y = 313;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 366 - first);
                            picturePlayer1.Refresh();
                            y = 313;
                            Thread.Sleep(1);
                        }

                        for (int first = fivthrowcount; first <= 826; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 313;
                            fivthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }

                }

                 //////////////////////50000000000000000000
                else if (count1 == 50)
                {

                    for (int first = fivthrowcount; first <= 920; first++)
                    {
                        picturePlayer1.Location = new Point(first, 313);
                        picturePlayer1.Refresh();
                        y = 313;
                        fivthrowcount = first;
                        Thread.Sleep(1);


                    }

                }
                //////////////////5111111111111111111111
                else if (count1 == 51)
                {
                    for (int first = fivthrowcount; first <= 920; first++)
                    {
                        picturePlayer1.Location = new Point(first, 313);
                        picturePlayer1.Refresh();
                        y = 261;
                        fivthrowcount = first;
                        Thread.Sleep(1);


                    }
                    for (int first = 1; first <= 48; first++)
                    {
                        picturePlayer1.Location = new Point(920, 313 - first);
                        picturePlayer1.Refresh();
                        y = 261;
                        Thread.Sleep(1);
                    }

                    for (int loop = 1; loop <= 6; loop++)
                    {




                        picturePlayer1.Location = new Point(920, 265 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }




                    for (int loop = 1; loop <= 70; loop++)
                    {




                        picturePlayer1.Location = new Point(920 - loop, 259);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 15; loop++)
                    {




                        picturePlayer1.Location = new Point(850 - loop, 259 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }



                    for (int loop = 1; loop <= 70; loop++)
                    {




                        picturePlayer1.Location = new Point(835 - loop, 244);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }


                    for (int loop = 1; loop <= 20; loop++)
                    {




                        picturePlayer1.Location = new Point(765 - loop, 244 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 70; loop++)
                    {




                        picturePlayer1.Location = new Point(745 - loop, 224);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 16; loop++)
                    {




                        picturePlayer1.Location = new Point(675 - loop, 224 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 15; loop++)
                    {




                        picturePlayer1.Location = new Point(659 - loop, 208);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 4; loop++)
                    {




                        picturePlayer1.Location = new Point(644, 208 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    for (int loop = 1; loop <= 5; loop++)
                    {




                        picturePlayer1.Location = new Point(644 - loop, 204);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }

                    count1 = 67;
                    seventhrowcount = 639;
                    y = 204;
                    firstrowcount = 83;
                    secondrowcount = 0;
                    thirdrowcount = 83;
                    fourrowcount = 0;
                    fivthrowcount = 83;
                    sixthrowcount = 0;

                    eigthrowcount = 0;
                    ninethrowcount = 83;
                    tenthrowcount = 0;


                }
                ////////////////////52222222222222222
                else if (count1 == 52)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 92; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 92; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////////////53333333333333
                else if (count1 == 53)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 186; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 186; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ///////////////////////////////////544444444444
                else if (count1 == 54)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 274; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 274; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ///////////////////555555555555555555555555555555555555555555555555555
                else if (count1 == 55)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 372; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 372; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }

                 //////////////5666666666666666666666666
                else if (count1 == 56)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 464; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer1.Location = new Point(456 + loop, 261);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 5; loop++)
                        {




                            picturePlayer1.Location = new Point(474, 261 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer1.Location = new Point(474 + loop, 266 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer1.Location = new Point(509 + loop, 231);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(579, 231 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 23; loop++)
                        {




                            picturePlayer1.Location = new Point(579 - loop, 251 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 27; loop++)
                        {




                            picturePlayer1.Location = new Point(556, 274 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(556 + loop, 301);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(596 + loop, 301 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }




                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(606 + loop, 291);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(636 + loop, 291 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(676 - loop, 251 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }




                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(666 - loop, 241);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 60; loop++)
                        {




                            picturePlayer1.Location = new Point(626, 241 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 44; loop++)
                        {




                            picturePlayer1.Location = new Point(626 + loop, 301 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 7; loop++)
                        {




                            picturePlayer1.Location = new Point(670 - loop, 345 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(663, 352 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 17; loop++)
                        {




                            picturePlayer1.Location = new Point(663 + loop, 382 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(680, 399 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(680 - loop, 449);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 28; loop++)
                        {




                            picturePlayer1.Location = new Point(630 - loop, 449 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer1.Location = new Point(602 - loop, 421);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 26;

                        thirdrowcount = 547;
                        y = 421;

                        firstrowcount = 83;
                        secondrowcount = 0;

                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;

                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 464; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer1.Location = new Point(456 + loop, 261);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 5; loop++)
                        {




                            picturePlayer1.Location = new Point(474, 261 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer1.Location = new Point(474 + loop, 266 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer1.Location = new Point(509 + loop, 231);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(579, 231 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 23; loop++)
                        {




                            picturePlayer1.Location = new Point(579 - loop, 251 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 27; loop++)
                        {




                            picturePlayer1.Location = new Point(556, 274 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(556 + loop, 301);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(596 + loop, 301 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }




                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(606 + loop, 291);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(636 + loop, 291 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(676 - loop, 251 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }




                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(666 - loop, 241);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 60; loop++)
                        {




                            picturePlayer1.Location = new Point(626, 241 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 44; loop++)
                        {




                            picturePlayer1.Location = new Point(626 + loop, 301 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 7; loop++)
                        {




                            picturePlayer1.Location = new Point(670 - loop, 345 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(663, 352 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 17; loop++)
                        {




                            picturePlayer1.Location = new Point(663 + loop, 382 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(680, 399 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(680 - loop, 449);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 28; loop++)
                        {




                            picturePlayer1.Location = new Point(630 - loop, 449 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer1.Location = new Point(602 - loop, 421);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 26;

                        thirdrowcount = 547;
                        y = 421;
                        firstrowcount = 83;
                        secondrowcount = 0;

                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;
                    }
                }
                /////////////////577777777777
                else if (count1 == 57)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 555; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 555; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                //////////////////////////58888888888888888
                else if (count1 == 58)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 651; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 651; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }

                 //////////////////59999999999999999999

                else if (count1 == 59)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 743; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 743; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }

                 ////////////////60000000000000000
                else if (count1 == 60)
                {
                    if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 313)
                    {
                        for (int first = fivthrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 313);
                            picturePlayer1.Refresh();
                            y = 261;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 313 - first);
                            picturePlayer1.Refresh();
                            y = 261;
                            Thread.Sleep(1);
                        }
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 261;
                            sixthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }

                 ///////////////////////////61111111111111111
                else if (count1 == 61)
                {
                    for (int first = sixthrowcount; first <= 837; first++)
                    {
                        picturePlayer1.Location = new Point(920 - first, 261);
                        picturePlayer1.Refresh();
                        y = 204;

                        Thread.Sleep(1);


                    }
                    for (int first = 1; first <= 57; first++)
                    {
                        picturePlayer1.Location = new Point(83, 261 - first);
                        picturePlayer1.Refresh();
                        y = 204;
                        Thread.Sleep(1);
                    }
                }
                /////////////////////////////622222222222222222222222
                else if (count1 == 62)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 176; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 176; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ////////////////////////63333333333333333
                else if (count1 == 63)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 268; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 268; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                //////////////////6444444444444
                else if (count1 == 64)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 363; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 363; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ///////////////////65555555
                else if (count1 == 65)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 455; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer1.Location = new Point(455 - loop, 204);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 2; loop++)
                        {




                            picturePlayer1.Location = new Point(420, loop + 204);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(420 - loop, 206 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }




                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer1.Location = new Point(405 - loop, 221);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(370 - loop, 221 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(360 - loop, 209);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(310 + loop, 209 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(350 - loop, 249 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(330 - loop, 269);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(310 - loop, 269 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 25; loop++)
                        {




                            picturePlayer1.Location = new Point(280 - loop, 239);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer1.Location = new Point(255 - loop, 239 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer1.Location = new Point(200 + loop, 294);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(280 + loop, 294 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(300 + loop, 314);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(340, 314 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(340 + loop, 294);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 33; loop++)
                        {




                            picturePlayer1.Location = new Point(380, 294 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(380 - loop, 261);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 57;
                        sixthrowcount = 555;
                        y = 261;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;

                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 455; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer1.Location = new Point(455 - loop, 204);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 2; loop++)
                        {




                            picturePlayer1.Location = new Point(420, loop + 204);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(420 - loop, 206 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }




                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer1.Location = new Point(405 - loop, 221);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(370 - loop, 221 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(360 - loop, 209);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(310 + loop, 209 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(350 - loop, 249 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(330 - loop, 269);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(310 - loop, 269 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 25; loop++)
                        {




                            picturePlayer1.Location = new Point(280 - loop, 239);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer1.Location = new Point(255 - loop, 239 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer1.Location = new Point(200 + loop, 294);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(280 + loop, 294 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(300 + loop, 314);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(340, 314 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(340 + loop, 294);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 33; loop++)
                        {




                            picturePlayer1.Location = new Point(380, 294 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(380 - loop, 261);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 57;
                        sixthrowcount = 555;
                        y = 261;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;

                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;
                    }
                }
                /////////666666666666

                else if (count1 == 66)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 550; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 550; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ////////////////67777777777777777
                else if (count1 == 67)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 639; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 639; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ///////////////////////////6888888888
                else if (count1 == 68)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 736; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 736; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ///////////699999999999
                else if (count1 == 69)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 827; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 827; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                //////////////70000000000
                else if (count1 == 70)
                {
                    if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 261)
                    {
                        for (int first = sixthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 261);
                            picturePlayer1.Refresh();
                            y = 204;

                            Thread.Sleep(1);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer1.Location = new Point(83, 261 - first);
                            picturePlayer1.Refresh();
                            y = 204;
                            Thread.Sleep(1);
                        }

                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 204;
                            seventhrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ////////////////711111111111111111111

                else if (count1 == 71)
                {
                    for (int first = seventhrowcount; first <= 920; first++)
                    {
                        picturePlayer1.Location = new Point(first, 204);
                        picturePlayer1.Refresh();
                        y = 151;
                        seventhrowcount = first;
                        Thread.Sleep(1);
                    }

                    for (int first = 1; first <= 53; first++)
                    {
                        picturePlayer1.Location = new Point(920, 204 - first);
                        picturePlayer1.Refresh();
                        y = 151;
                        Thread.Sleep(1);
                    }

                }
                ////////////72222222222
                else if (count1 == 72)
                {
                    if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 92; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                        for (int loop = 1; loop <= 107; loop++)
                        {




                            picturePlayer1.Location = new Point(828 - loop, 151 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        count1 = 93;
                        tenthrowcount = 195;
                        y = 44;

                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;


                    }
                    else if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 151;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 204 - first);
                            picturePlayer1.Refresh();
                            y = 151;
                            Thread.Sleep(1);
                        }

                        for (int first = eigthrowcount; first <= 92; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 107; loop++)
                        {




                            picturePlayer1.Location = new Point(828 - loop, 151 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        count1 = 93;
                        tenthrowcount = 195;
                        y = 44;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;


                    }
                }
                //////////////////////////733333333333333
                else if (count1 == 73)
                {
                    if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 186; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 151;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 204 - first);
                            picturePlayer1.Refresh();
                            y = 151;
                            Thread.Sleep(1);
                        }

                        for (int first = eigthrowcount; first <= 186; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                }
                ///////////////7444444444
                else if (count1 == 74)
                {
                    if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 274; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 151;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 204 - first);
                            picturePlayer1.Refresh();
                            y = 151;
                            Thread.Sleep(1);
                        }

                        for (int first = eigthrowcount; first <= 274; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                }
                ///////////7555555555555555
                else if (count1 == 75)
                {
                    if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 370; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 151;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 204 - first);
                            picturePlayer1.Refresh();
                            y = 151;
                            Thread.Sleep(1);
                        }

                        for (int first = eigthrowcount; first <= 370; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                }
                ///////////76666666666666
                else if (count1 == 76)
                {
                    if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 464; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 151;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 204 - first);
                            picturePlayer1.Refresh();
                            y = 151;
                            Thread.Sleep(1);
                        }

                        for (int first = eigthrowcount; first <= 464; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                }
                //////////77777777
                else if (count1 == 77)
                {
                    if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 559; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 151;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 204 - first);
                            picturePlayer1.Refresh();
                            y = 151;
                            Thread.Sleep(1);
                        }

                        for (int first = eigthrowcount; first <= 559; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                }
                ////////7888888888
                else if (count1 == 78)
                {
                    if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 651; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 151;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 204 - first);
                            picturePlayer1.Refresh();
                            y = 151;
                            Thread.Sleep(1);
                        }

                        for (int first = eigthrowcount; first <= 651; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                }
                /////////799999999
                else if (count1 == 79)
                {
                    if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 745; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                    else if (y == 204)
                    {
                        for (int first = seventhrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 204);
                            picturePlayer1.Refresh();
                            y = 151;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(920, 204 - first);
                            picturePlayer1.Refresh();
                            y = 151;
                            Thread.Sleep(1);
                        }

                        for (int first = eigthrowcount; first <= 745; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 151;
                            eigthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                }
                //////////////////////800000000000

                else if (count1 == 80)
                {
                    for (int first = eigthrowcount; first <= 837; first++)
                    {
                        picturePlayer1.Location = new Point(920 - first, 151);
                        picturePlayer1.Refresh();
                        y = 151;
                        eigthrowcount = first;
                        Thread.Sleep(1);
                    }
                    for (int loop = 1; loop <= 107; loop++)
                    {




                        picturePlayer1.Location = new Point(83, 151 - loop);
                        picturePlayer1.Refresh();

                        Thread.Sleep(1);


                    }
                    count1 = 100;
                    y = 44;
                    tenthrowcount = 837;
                    firstrowcount = 83;
                    secondrowcount = 0;
                    thirdrowcount = 83;
                    fourrowcount = 0;
                    fivthrowcount = 83;
                    sixthrowcount = 0;
                    seventhrowcount = 83;
                    eigthrowcount = 0;
                    ninethrowcount = 83;
                 //   startSoundPlayer.Stop();
                    
                    MessageBox.Show("Player 1 won the match\nClick ok button and play again :D");

                    count1 = 1;
                    firstrowcount = 83;
                    secondrowcount = 0;
                    thirdrowcount = 83;
                    fourrowcount = 0;
                    fivthrowcount = 83;
                    sixthrowcount = 0;
                    seventhrowcount = 83;
                    eigthrowcount = 0;
                    ninethrowcount = 83;
                    tenthrowcount = 0;
                    y = 530;
                    picturePlayer1.Location = new Point(83, 530);





                    count2 = 1;
                    firstrowcount2 = 83;
                    secondrowcount2 = 0;
                    thirdrowcount2 = 83;
                    fourrowcount2 = 0;
                    fivthrowcount2 = 83;
                    sixthrowcount2 = 0;
                    seventhrowcount2 = 83;
                    eigthrowcount2 = 0;
                    ninethrowcount2 = 83;
                    tenthrowcount2 = 0;
                    y2 = 530;
                    picturePlayer2.Location = new Point(83, 530);

                    Head.Text = ("Player 1 Turn");
                    Head.ForeColor = Color.Red;
                    Head.BackColor = Color.Maroon;

                    change = 0;
                    FirstPlayerPlayButton.Visible = true;
                    SecPlayerPlayButton.Visible = false;

                    picturePlayer1.BringToFront();


                    //startSoundPlayer.PlayLooping();

                }
                /////////////////////////////8111111

                else if (count1 == 81)
                {
                    for (int first = eigthrowcount; first <= 837; first++)
                    {
                        picturePlayer1.Location = new Point(920 - first, 151);
                        picturePlayer1.Refresh();
                        y = 99;

                        Thread.Sleep(1);
                    }

                    for (int first = 1; first <= 52; first++)
                    {
                        picturePlayer1.Location = new Point(83, 151 - first);
                        picturePlayer1.Refresh();
                        y = 99;
                        Thread.Sleep(1);
                    }

                }

                ///////////////////////////8222222222222222

                else if (count1 == 82)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 179; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 179; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////833333333333333
                else if (count1 == 83)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 270; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 270; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////////844444444
                else if (count1 == 84)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 362; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 362; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                /////////////////////855555
                else if (count1 == 85)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 456; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 456; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ////////////8666666666

                else if (count1 == 86)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 549; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 549; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////8777777777
                else if (count1 == 87)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 642; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 642; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ///////888888

                else if (count1 == 88)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 733; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 29; loop++)
                        {




                            picturePlayer1.Location = new Point(733 - loop, 99);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(704 - loop, 99);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(674, 99 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 25; loop++)
                        {




                            picturePlayer1.Location = new Point(674 + loop, 129 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 85; loop++)
                        {




                            picturePlayer1.Location = new Point(699 - loop, 154);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(614 + loop, 154 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(644, 124 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer1.Location = new Point(644 - loop, 84);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(564 + loop, 84 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 25; loop++)
                        {




                            picturePlayer1.Location = new Point(604 - loop, 124 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }


                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer1.Location = new Point(579 - loop, 149);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(499 - loop, 149 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(469 + loop, 179 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer1.Location = new Point(499 + loop, 209);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(579 + loop, 209 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(589 + loop, 199);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(619 + loop, 199 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer1.Location = new Point(634 + loop, 184);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(704 + loop, 184 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 47; loop++)
                        {




                            picturePlayer1.Location = new Point(734, 214 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 53;
                        sixthrowcount = 186;
                        y = 261;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;

                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;


                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 733; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }

                 ////////8999999999999999999
                else if (count1 == 89)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 827; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 827; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ////////////90000000000000
                else if (count1 == 90)
                {
                    if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 151)
                    {
                        for (int first = eigthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 151);
                            picturePlayer1.Refresh();
                            y = 99;

                            Thread.Sleep(1);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer1.Location = new Point(83, 151 - first);
                            picturePlayer1.Refresh();
                            y = 99;
                            Thread.Sleep(1);
                        }

                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 99;
                            ninethrowcount = first;

                            Thread.Sleep(1);
                        }
                    }

                }
                ////////9111111111

                else if (count1 == 91)
                {

                    for (int first = ninethrowcount; first <= 920; first++)
                    {
                        picturePlayer1.Location = new Point(first, 99);
                        picturePlayer1.Refresh();
                        y = 44;
                        ninethrowcount = first;

                        Thread.Sleep(1);
                    }
                    for (int first = 1; first <= 55; first++)
                    {
                        picturePlayer1.Location = new Point(920, 99 - first);
                        picturePlayer1.Refresh();
                        y = 44;
                        Thread.Sleep(1);
                    }
                }
                //////////9222222222
                else if (count1 == 92)
                {
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 93; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 41; loop++)
                        {




                            picturePlayer1.Location = new Point(827 + loop, 44);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(868 + loop, 44);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(918 - loop, 44 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(888 + loop, 74);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(938, 74 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(938 - loop, 59);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 33; loop++)
                        {




                            picturePlayer1.Location = new Point(898 - loop, 59 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(865 + loop, 92);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 59; loop++)
                        {




                            picturePlayer1.Location = new Point(905, 92 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(905 + loop, 151);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 71;

                        y = 151;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;
                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 93; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 41; loop++)
                        {




                            picturePlayer1.Location = new Point(827 + loop, 44);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }



                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(868 + loop, 44);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(918 - loop, 44 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(888 + loop, 74);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(938, 74 - loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(938 - loop, 59);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 33; loop++)
                        {




                            picturePlayer1.Location = new Point(898 - loop, 59 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(865 + loop, 92);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 59; loop++)
                        {




                            picturePlayer1.Location = new Point(905, 92 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer1.Location = new Point(905 + loop, 151);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 71;

                        y = 151;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;
                    }
                }
                //////93333333333
                else if (count1 == 93)
                {
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 195; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 195; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }

                 //////94444444
                else if (count1 == 94)
                {
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 279; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 279; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ////955555
                else if (count1 == 95)
                {
                    store1 = count1;
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 372; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 372; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                //////966666
                else if (count1 == 96)
                {
                    store1 = count1;
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 465; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 465; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ///////9777777777777777777

                else if (count1 == 97)
                {
                    store1 = count1;
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 557; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 557; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                ////////98888888888
                else if (count1 == 98)
                {
                    store1 = count1;
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 651; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 651; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }

                 ///99999999999
                else if (count1 == 99)
                {
                    store1 = count1;
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 744; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(181 + loop, 44 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(221 - loop, 84);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(181 - loop, 84 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 100; loop++)
                        {




                            picturePlayer1.Location = new Point(171 + loop, 94 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(271 + loop, 194 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(291 + loop, 214);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer1.Location = new Point(311 + loop, 214 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(361 + loop, 264);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer1.Location = new Point(371 + loop, 264 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(381 + loop, 274);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(411, 274 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer1.Location = new Point(411 + loop, 304 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer1.Location = new Point(431 + loop, 324);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer1.Location = new Point(471, 324 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 77; loop++)
                        {




                            picturePlayer1.Location = new Point(471 + loop, 354);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }

                        for (int loop = 1; loop <= 12; loop++)
                        {




                            picturePlayer1.Location = new Point(548, 354 + loop);
                            picturePlayer1.Refresh();

                            Thread.Sleep(1);


                        }
                        count1 = 35;
                        y = 366;
                        fourrowcount = 372;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;

                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;

                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 744; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }
                    }
                }
                //100000000000000000000000000000
                else if (count1 == 100)
                {
                    if (y == 44)
                    {
                        for (int first = tenthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }

                       // startSoundPlayer.Stop();
                        MessageBox.Show("Player 1 won the match\nClick ok button and play again :D");

                        count1 = 1;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;
                        y = 530;
                        picturePlayer1.Location = new Point(83, 530);
                        




                        count2 = 1;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                        y2 = 530;
                        picturePlayer2.Location = new Point(83, 530);

                        Head.Text = ("Player 1 Turn");
                        Head.ForeColor = Color.Red;
                        Head.BackColor = Color.Maroon;

                        picturePlayer1.BringToFront();

                        change = 0;
                        FirstPlayerPlayButton.Visible = true;
                        SecPlayerPlayButton.Visible = false;
                       // startSoundPlayer.PlayLooping();
                    }
                    else if (y == 99)
                    {
                        for (int first = ninethrowcount; first <= 920; first++)
                        {
                            picturePlayer1.Location = new Point(first, 99);
                            picturePlayer1.Refresh();
                            y = 44;

                            Thread.Sleep(1);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer1.Location = new Point(920, 99 - first);
                            picturePlayer1.Refresh();
                            y = 44;
                            Thread.Sleep(1);
                        }

                        for (int first = tenthrowcount; first <= 837; first++)
                        {
                            picturePlayer1.Location = new Point(920 - first, 44);
                            picturePlayer1.Refresh();
                            y = 44;
                            tenthrowcount = first;
                            Thread.Sleep(1);
                        }

                    }
                }
            }

        }



        public void Go()
        {
            Invoke(new moveBd(moveButton), FirstPlayerPlayButton);

        }
        /// <summary>
        /// ////////////////////////////////secccccccccccccccccccccccccccplllllllly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecPlayerPlayButton_Click(object sender, EventArgs e)
        {
            Secdice2 = rn.Next(1,7);

            count2 = count2 + Secdice2;
            if (count2 >= count1)
            {
                picturePlayer2.BringToFront();
                picturePlayer1.SendToBack();
            }
            if (change == 1)
            {
                SecPlayerPlayButton.Visible = false;
                FirstPlayerPlayButton.Visible = true;
                Head.Text = ("Player 1 Turn");
                Head.ForeColor = Color.Red;
                Head.BackColor = Color.Maroon;
                change = 0;
            }


            if (Secdice2 == 1)
            {

                dice1.Visible = true;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
                for (int th = 1; th <= 88; th++)
                {

                    dice1.Size = new System.Drawing.Size(102, th);
                    dice1.Refresh();
                    Thread.Sleep(1);//(2);//(1);

                }



            }

            else if (Secdice2 == 2)
            {

                dice2.Visible = true;
                dice1.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
                for (int th = 1; th <= 102; th++)
                {

                    dice2.Size = new System.Drawing.Size(th, 88);
                    dice2.Refresh();
                    Thread.Sleep(1);//(2);//(1);

                }




            }
            else if (Secdice2 == 3)
            {

                dice3.Visible = true;
                dice1.Visible = false;
                dice2.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;

                for (int th = 1; th <= 88; th++)
                {

                    dice3.Size = new System.Drawing.Size(102, th);
                    dice3.Refresh();
                    Thread.Sleep(1);//(2);//(1);

                }
            }
            else if (Secdice2 == 4)
            {

                dice4.Visible = true;
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice5.Visible = false;
                dice6.Visible = false;
                for (int th = 1; th <= 102; th++)
                {

                    dice4.Size = new System.Drawing.Size(th, 88);
                    dice4.Refresh();
                    Thread.Sleep(1);//(2);//(1);

                }
            }
            else if (Secdice2 == 5)
            {

                dice5.Visible = true;
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice6.Visible = false;
                for (int th = 1; th <= 88; th++)
                {

                    dice5.Size = new System.Drawing.Size(102, th);
                    dice5.Refresh();
                    Thread.Sleep(1);//(2);//(1);

                }
            }
            else if (Secdice2 == 6)
            {

                dice6.Visible = true;
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                
                for (int th = 1; th <= 102; th++)
                {

                    dice6.Size = new System.Drawing.Size(th, 88);
                    dice6.Refresh();
                    Thread.Sleep(1);//(2);//(1);

                }
            }

            
            Thread SecPlayerThread = new Thread(Go2);

            SecPlayerThread.Start();
        }

        public delegate void moveBd2(PictureBox SecPlayerPlayButton);
        void moveButton2(PictureBox SecPlayerPlayButton)
         {
             if (store2 == 95 && count2 >= 101)
            {
                count2 = 95;
                
            }
            else if (store2 == 96 && count2 >= 101)
            {
                count2 = 96;

            }
            else if (store2 == 97 && count2 >= 101)
            {
                count2 = 97;

            }
            else if (store2 == 98 && count2 >= 101)
            {
                count2 = 98;

            }
            else if (store2 == 99 && count2 >= 101)
            {
                count2 = 99;

            }

            else
            {
                if (count2 == 1)
                {
                    for (int first = firstrowcount2; first <= 176; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                else if (count2 == 2)
                {
                    for (int first = firstrowcount2; first <= 176; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                else if (count2 == 3)
                {
                    for (int first = firstrowcount2; first <= 270; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                else if (count2 == 4)
                {
                    for (int first = firstrowcount2; first <= 364; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                else if (count2 == 5)
                {
                    for (int first = firstrowcount2; first <= 457; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                else if (count2 == 6)
                {
                    for (int first = firstrowcount2; first <= 553; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                    for (int loop = 1; loop <= 56; loop++)
                    {




                        picturePlayer2.Location = new Point(553 - loop, 530 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 35; loop++)
                    {




                        picturePlayer2.Location = new Point(497 - loop, 474);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }
                    count2 = 16;
                    secondrowcount2 = 462;
                    y2 = 474;
                    firstrowcount2 = 83;
                    thirdrowcount2 = 83;
                    fourrowcount2=0;
                    fivthrowcount2 = 83;
                    sixthrowcount2=0;
                    seventhrowcount2 = 83;
                    eigthrowcount2=0;
                    ninethrowcount2 = 83;
                    tenthrowcount2=0;


                }
                else if (count2 == 7)
                {
                    for (int first = firstrowcount2; first <= 642; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                else if (count2 == 8)
                {
                    for (int first = firstrowcount2; first <= 736; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                else if (count2 == 9)
                {
                    for (int first = firstrowcount2; first <= 825; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer2.Location = new Point(825 + loop, 530 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer2.Location = new Point(855, 500 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer2.Location = new Point(855 + loop, 470 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer2.Location = new Point(885, 440 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 44; loop++)
                    {




                        picturePlayer2.Location = new Point(885 + loop, 410 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 9; loop++)
                    {




                        picturePlayer2.Location = new Point(929 - loop, 366);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }
                    firstrowcount2 = 83;
                    secondrowcount2 = 0;
                    thirdrowcount2 = 83;
                    fourrowcount2 = 0;
                    fivthrowcount2 = 83;
                    sixthrowcount2 = 0;
                    seventhrowcount2 = 83;
                    eigthrowcount2 = 0;
                    ninethrowcount2 = 83;
                    tenthrowcount2 = 0;

                    y2 = 366;
                    count2 = 31;

                }
                else if (count2 == 10)
                {
                    for (int first = firstrowcount2; first <= 920; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }

                else if (count2 == 11)
                {
                    for (int first = firstrowcount2; first <= 920; first++)
                    {
                        picturePlayer2.Location = new Point(first, y2);
                        picturePlayer2.Refresh();
                        firstrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }

                    for (int first = 1; first <= 56; first++)
                    {
                        picturePlayer2.Location = new Point(920, 530 - first);
                        picturePlayer2.Refresh();
                        y2 = 474;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }

                else if (count2 == 12)
                {
                    if (y2 == 474)
                    {
                        for (int first = 1; first <= 94; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y2);
                            picturePlayer2.Refresh();
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 94; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////////////////////1333333333333333
                else if (count2 == 13)
                {
                    if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 187; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y2);
                            picturePlayer2.Refresh();
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 187; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ////////////14444444444444444
                else if (count2 == 14)
                {
                    if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 280; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y);
                            picturePlayer2.Refresh();
                            firstrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 280; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                /////////////1555555555555
                else if (count2 == 15)
                {
                    if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 372; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y2);
                            picturePlayer2.Refresh();
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 372; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////////16666666666666666666
                else if (count2 == 16)
                {
                    if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 462; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y2);
                            picturePlayer2.Refresh();
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 458; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////1777777777777777
                else if (count2 == 17)
                {
                    if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 559; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y);
                            picturePlayer2.Refresh();
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 559; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////18888888888
                else if (count2 == 18)
                {
                    if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 650; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer2.Location = new Point(272 + loop, 474);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 28; loop++)
                        {




                            picturePlayer2.Location = new Point(290 + loop, 474 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(318 + loop, 502 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        ///////////////////////plus
                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(333 + loop, 487);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        ////////////////////////plusminus


                        for (int loop = 1; loop <= 45; loop++)
                        {




                            picturePlayer2.Location = new Point(348 + loop, 487 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }




                        ///////////////

                        for (int loop = 1; loop <= 17; loop++)
                        {




                            picturePlayer2.Location = new Point(393 + loop, 532);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        ///uppppppppppppppp

                        for (int loop = 1; loop <= 19; loop++)
                        {




                            picturePlayer2.Location = new Point(410, 532 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        //////////////////
                        for (int loop = 1; loop <= 47; loop++)
                        {




                            picturePlayer2.Location = new Point(410 + loop, 513);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///downnnnnnnnnnnnnnnnnnnnnnnnn
                        for (int loop = 1; loop <= 17; loop++)
                        {




                            picturePlayer2.Location = new Point(457, 513 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        firstrowcount2 = 457;
                        count2 = 5;
                        y2 = 530;
                        
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                        

                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y2);
                            picturePlayer2.Refresh();
                           
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 650; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////////199999999999999999
                else if (count2 == 19)
                {
                    if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 732; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 108; loop++)
                        {




                            picturePlayer2.Location = new Point(188 + loop, 474 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 29; loop++)
                        {




                            picturePlayer2.Location = new Point(298 - loop, 366);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                        count2 = 38;
                        fourrowcount2 = 651;
                        y2 = 366;

                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y2);
                            picturePlayer2.Refresh();
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 732; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                /////////////2000000000000
                else if (count2 == 20)
                {
                    if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 530)
                    {
                        for (int first = firstrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, y2);
                            picturePlayer2.Refresh();
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 56; first++)
                        {
                            picturePlayer2.Location = new Point(920, 530 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 474;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            secondrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }

                //21111111111111111111
                else if (count2 == 21)
                {
                    for (int first = secondrowcount2; first <= 837; first++)
                    {
                        picturePlayer2.Location = new Point(920 - first, 474);
                        picturePlayer2.Refresh();
                        secondrowcount2 = first;

                        Thread.Sleep(1);//(2);//(4);
                    }

                    for (int first = 1; first <= 53; first++)
                    {
                        picturePlayer2.Location = new Point(83, 474 - first);
                        picturePlayer2.Refresh();
                        
                        y2 = 421;
                        Thread.Sleep(1);//(2);//(4);
                        
                    }
                    for (int loop = 1; loop <= 40; loop++)
                    {




                        picturePlayer2.Location = new Point(83, 421 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 40; loop++)
                    {




                        picturePlayer2.Location = new Point(83 + loop, 381 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }


                    for (int loop = 1; loop <= 40; loop++)
                    {




                        picturePlayer2.Location = new Point(123, 341 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }


                    for (int loop = 1; loop <= 30; loop++)
                    {




                        picturePlayer2.Location = new Point(123 + loop, 301 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }



                    for (int loop = 1; loop <= 50; loop++)
                    {




                        picturePlayer2.Location = new Point(153, 271 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 50; loop++)
                    {




                        picturePlayer2.Location = new Point(153 + loop, 221 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }


                    for (int loop = 1; loop <= 28; loop++)
                    {




                        picturePlayer2.Location = new Point(203 - loop, 171);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }


                    for (int loop = 1; loop <= 20; loop++)
                    {




                        picturePlayer2.Location = new Point(175, 171 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }
                    count2 = 79;
                    eigthrowcount2 = 745;
                    y2 = 151;
                    firstrowcount2 = 83;
                    secondrowcount2 = 0;
                    thirdrowcount2 = 83;
                    fourrowcount2 = 0;
                    fivthrowcount2 = 83;
                    sixthrowcount2 = 0;
                    seventhrowcount2 = 83;
                    
                    ninethrowcount2 = 83;
                    tenthrowcount2 = 0;

                }
                ///////////////////22222222222222222
                else if (count2 == 22)
                {
                    if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 179; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 474 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = thirdrowcount2; first <= 179; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }


                }

                ////////////////2333333333333333333

                else if (count2 == 23)
                {
                    if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 271; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 474 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = thirdrowcount2; first <= 271; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }


                }
                ////////////////24444444444444444
                else if (count2 == 24)
                {
                    if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 362; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 474 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = thirdrowcount2; first <= 362; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }


                }

                ///////////////////2555555555555555
                else if (count2 == 25)
                {
                    if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 456; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                           

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 474 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = thirdrowcount2; first <= 456; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }


                }
                ////////////////26666666666666
                else if (count2 == 26)
                {
                    if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 547; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 474 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = thirdrowcount2; first <= 547; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }


                }

                ///////////////277777777777
                else if (count2 == 27)
                {
                    if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 642; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 474 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = thirdrowcount2; first <= 642; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }


                }
                ///////////////////////288888888888888888888888888888888
                else if (count2 == 28)
                {
                    if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 734; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 100; loop++)
                        {




                            picturePlayer2.Location = new Point(734 - loop, 421 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(634 - loop, 321);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 100; loop++)
                        {




                            picturePlayer2.Location = new Point(614 - loop, 321 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(514 - loop, 221);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 122; loop++)
                        {




                            picturePlayer2.Location = new Point(494 - loop, 221 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(372 - loop, 99);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 84;
                        ninethrowcount2 = 362;
                        y2 = 99;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        
                        tenthrowcount2 = 0;
                    }
                    else if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 474 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = thirdrowcount2; first <= 734; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }


                }
                //////////////29999999999999999999999
                else if (count2 == 29)
                {
                    if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 827; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 474)
                    {
                        for (int first = secondrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 474);
                            picturePlayer2.Refresh();
                            

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 474 - first);
                            picturePlayer2.Refresh();
                            
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = thirdrowcount2; first <= 827; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            thirdrowcount2 = first;
                            y2 = 421;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }


                }
                //////////////30000000000000000000
                else if (count2 == 30)
                {

                    for (int first = thirdrowcount2; first <= 920; first++)
                    {
                        picturePlayer2.Location = new Point(first, 421);
                        picturePlayer2.Refresh();
                        thirdrowcount2 = first;
                        y2 = 421;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }


                //////////////////////////////31111111111111


                else if (count2 == 31)
                {
                    
                    
                   
                         for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    
                }

                 ////////////////////////32222222222222222222222222222222

                else if (count2 == 32)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 92; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 92; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                /////////////////////////////////33333333333333333333333333333333333333333333
                else if (count2 == 33)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 185; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 185; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                //////////////////////344444444444444444444444
                else if (count2 == 34)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 279; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 279; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////////////////355555555555555555
                else if (count2 == 35)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 372; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 372; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////////////////////366666666666666
                else if (count2 == 36)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 465; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 465; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////////////3777777777777

                else if (count2 == 37)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 559; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 559; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////////3888888888888

                else if (count2 == 38)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 651; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 651; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                /////////399999999
                else if (count2 == 39)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 744; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 744; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }

                 /////////////////40000000000000
                else if (count2 == 40)
                {
                    if (y2 == 366)
                    {

                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                    else if (y2 == 421)
                    {
                        for (int first = thirdrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 421);
                            picturePlayer2.Refresh();
                            
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 421 - first);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 366;
                            fourrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                /////////////////////////////////////411111111111111111111111111111111111111

                else if (count2 == 41)
                {

                    for (int first = fourrowcount2; first <= 837; first++)
                    {
                        picturePlayer2.Location = new Point(920 - first, 366);
                        picturePlayer2.Refresh();
                        y2 = 313;

                        Thread.Sleep(1);//(2);//(4);
                    }

                    for (int first = 1; first <= 53; first++)
                    {
                        picturePlayer2.Location = new Point(83, 366 - first);
                        picturePlayer2.Refresh();
                        y2 = 313;
                        Thread.Sleep(1);//(2);//(4);
                    }

                }

                 /////////////////////////////////////////422222222222222222222222

                else if (count2 == 42)
                {
                    if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 177; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 366)
                    {
                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 313;

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 366 - first);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fivthrowcount2; first <= 177; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                }

                //////////////////////////43333333333333333333333
                else if (count2 == 43)
                {
                    if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 269; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        ///////////mtttttttttt
                        for (int loop = 1; loop <= 3; loop++)
                        {




                            picturePlayer2.Location = new Point(269 + loop, 313);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 16; loop++)
                        {




                            picturePlayer2.Location = new Point(272, 313 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer2.Location = new Point(272 - loop, 329);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer2.Location = new Point(202, 329 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        ////////////////////////////
                        for (int loop = 1; loop <= 135; loop++)
                        {




                            picturePlayer2.Location = new Point(202 - loop, 347);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///////////////////////////////down
                        for (int loop = 1; loop <= 23; loop++)
                        {




                            picturePlayer2.Location = new Point(67, 347 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///////////////////////////////////in side plus
                        for (int loop = 1; loop <= 135; loop++)
                        {




                            picturePlayer2.Location = new Point(67 + loop, 370);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(202, 370 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }





                        //////////////////////////////////////////////////////////////////////////////////////////
                        for (int loop = 1; loop <= 130; loop++)
                        {




                            picturePlayer2.Location = new Point(202 - loop, 410);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        /////////////////////////////////////////////////////new
                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(72, 410 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        /////////////////////////////////////////////////
                        for (int loop = 1; loop <= 90; loop++)
                        {




                            picturePlayer2.Location = new Point(72 + loop, 390);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }





                        /////////////////////down

                        for (int loop = 1; loop <= 31; loop++)
                        {




                            picturePlayer2.Location = new Point(162, 390 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///////////////////////////////last


                        for (int loop = 1; loop <= 109; loop++)
                        {




                            picturePlayer2.Location = new Point(162 + loop, 421);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 23;
                        thirdrowcount2 = 271;
                        y2 = 421;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                       

                    }
                    else if (y2 == 366)
                    {
                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 313;

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 366 - first);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fivthrowcount2; first <= 269; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        ///////////mtttttttttt
                        for (int loop = 1; loop <= 3; loop++)
                        {




                            picturePlayer2.Location = new Point(269 + loop, 313);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 16; loop++)
                        {




                            picturePlayer2.Location = new Point(272, 313 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer2.Location = new Point(272 - loop, 329);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer2.Location = new Point(202, 329 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        ////////////////////////////
                        for (int loop = 1; loop <= 135; loop++)
                        {




                            picturePlayer2.Location = new Point(202 - loop, 347);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///////////////////////////////down
                        for (int loop = 1; loop <= 23; loop++)
                        {




                            picturePlayer2.Location = new Point(67, 347 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///////////////////////////////////in side plus
                        for (int loop = 1; loop <= 135; loop++)
                        {




                            picturePlayer2.Location = new Point(67 + loop, 370);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(202, 370 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }





                        //////////////////////////////////////////////////////////////////////////////////////////
                        for (int loop = 1; loop <= 130; loop++)
                        {




                            picturePlayer2.Location = new Point(202 - loop, 410);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        /////////////////////////////////////////////////////new
                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(72, 410 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        /////////////////////////////////////////////////
                        for (int loop = 1; loop <= 90; loop++)
                        {




                            picturePlayer2.Location = new Point(72 + loop, 390);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }





                        /////////////////////down

                        for (int loop = 1; loop <= 31; loop++)
                        {




                            picturePlayer2.Location = new Point(162, 390 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///////////////////////////////last


                        for (int loop = 1; loop <= 109; loop++)
                        {




                            picturePlayer2.Location = new Point(162 + loop, 421);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 23;
                        thirdrowcount2 = 271;
                        y2 = 421;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                        

                    }

                }
                //////////////////////44444444

                else if (count2 == 44)
                {
                    if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 363; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 366)
                    {
                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 313;

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 366 - first);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fivthrowcount2; first <= 363; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                }

                 ///////////////455555555555555
                else if (count2 == 45)
                {
                    if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 456; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 366)
                    {
                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 313;

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 366 - first);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fivthrowcount2; first <= 456; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                }

                 ///////////46666666666666666
                else if (count2 == 46)
                {
                    if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 548; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 366)
                    {
                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 313;

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 366 - first);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fivthrowcount2; first <= 548; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                }
                ////////////////47777777777777
                else if (count2 == 47)
                {
                    if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 642; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 366)
                    {
                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 313;

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 366 - first);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fivthrowcount2; first <= 642; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                }
                /////////////////488888888888888
                else if (count2 == 48)
                {
                    if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 735; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 366)
                    {
                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 313;

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 366 - first);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fivthrowcount2; first <= 735; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                }

                 /////////////////49999999999
                else if (count2 == 49)
                {
                    if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 826; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        ///////meeeeeeeee
                        for (int loop = 1; loop <= 26; loop++)
                        {




                            picturePlayer2.Location = new Point(826 + loop, 313);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 5; loop++)
                        {




                            picturePlayer2.Location = new Point(852, 313 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 13; loop++)
                        {




                            picturePlayer2.Location = new Point(852 + loop, 318 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer2.Location = new Point(865 + loop, 305);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        ////////////////////////////////////////////////////////////////////
                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer2.Location = new Point(900, 305 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        //////////////////////////////////////////////////////turn



                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(900 - loop, 340 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        ////////////////////////////////
                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer2.Location = new Point(885 - loop, 355);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        /////////////////////////////////uppppppppppppppppppppp


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(830, 355 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        //////////////////plusssssssssssssssssss

                        for (int loop = 1; loop <= 60; loop++)
                        {




                            picturePlayer2.Location = new Point(830 + loop, 335);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///////////////////////////////////////////////////down
                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(890, 335 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        ///////////againturnwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
                        for (int loop = 1; loop <= 155; loop++)
                        {




                            picturePlayer2.Location = new Point(890 - loop, 350);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        ///////////lastdownnnnnnnnnnnnnnnnnnnn
                        for (int loop = 1; loop <= 16; loop++)
                        {




                            picturePlayer2.Location = new Point(735, 350 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 33;
                        fourrowcount2 = 185;
                        y2 = 366;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;

                    }
                    else if (y2 == 366)
                    {
                        for (int first = fourrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 366);
                            picturePlayer2.Refresh();
                            y2 = 313;

                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 366 - first);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = fivthrowcount2; first <= 826; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 313;
                            fivthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }

                }

                 //////////////////////50000000000000000000
                else if (count2 == 50)
                {

                    for (int first = fivthrowcount2; first <= 920; first++)
                    {
                        picturePlayer2.Location = new Point(first, 313);
                        picturePlayer2.Refresh();
                        y2 = 313;
                        fivthrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);


                    }

                }
                //////////////////5111111111111111111111
                else if (count2 == 51)
                {
                    for (int first = fivthrowcount2; first <= 920; first++)
                    {
                        picturePlayer2.Location = new Point(first, 313);
                        picturePlayer2.Refresh();
                        y2 = 261;
                        fivthrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);


                    }
                    for (int first = 1; first <= 48; first++)
                    {
                        picturePlayer2.Location = new Point(920, 313 - first);
                        picturePlayer2.Refresh();
                        y2 = 261;
                        Thread.Sleep(1);//(2);//(4);
                    }

                    for (int loop = 1; loop <= 6; loop++)
                    {




                        picturePlayer2.Location = new Point(920, 265 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }




                    for (int loop = 1; loop <= 70; loop++)
                    {




                        picturePlayer2.Location = new Point(920 - loop, 259);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 15; loop++)
                    {




                        picturePlayer2.Location = new Point(850 - loop, 259 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }



                    for (int loop = 1; loop <= 70; loop++)
                    {




                        picturePlayer2.Location = new Point(835 - loop, 244);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }


                    for (int loop = 1; loop <= 20; loop++)
                    {




                        picturePlayer2.Location = new Point(765 - loop, 244 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 70; loop++)
                    {




                        picturePlayer2.Location = new Point(745 - loop, 224);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 16; loop++)
                    {




                        picturePlayer2.Location = new Point(675 - loop, 224 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 15; loop++)
                    {




                        picturePlayer2.Location = new Point(659 - loop, 208);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 4; loop++)
                    {




                        picturePlayer2.Location = new Point(644, 208 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    for (int loop = 1; loop <= 5; loop++)
                    {




                        picturePlayer2.Location = new Point(644 - loop, 204);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }

                    count2 = 67;
                    seventhrowcount2 = 639;
                    y2 = 204;
                    firstrowcount2 = 83;
                    secondrowcount2 = 0;
                    thirdrowcount2 = 83;
                    fourrowcount2 = 0;
                    fivthrowcount2 = 83;
                    sixthrowcount2 = 0;
                    
                    eigthrowcount2 = 0;
                    ninethrowcount2 = 83;
                    tenthrowcount2 = 0;


                }
                ////////////////////52222222222222222
                else if (count2 == 52)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 92; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 92; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    
                }
                ///////////////////53333333333333
                else if (count2 == 53)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 186; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 186; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ///////////////////////////////////544444444444
                else if (count2 == 54)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 274; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 274; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ///////////////////555555555555555555555555555555555555555555555555555
                else if (count2 == 55)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 372; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 372; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }

                 //////////////5666666666666666666666666
                else if (count2 == 56)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 464; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer2.Location = new Point(456 + loop, 261);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 5; loop++)
                        {




                            picturePlayer2.Location = new Point(474, 261 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer2.Location = new Point(474 + loop, 266 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer2.Location = new Point(509 + loop, 231);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(579, 231 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 23; loop++)
                        {




                            picturePlayer2.Location = new Point(579 - loop, 251 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 27; loop++)
                        {




                            picturePlayer2.Location = new Point(556, 274 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(556 + loop, 301);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(596 + loop, 301 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }




                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(606 + loop, 291);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(636 + loop, 291 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(676 - loop, 251 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }




                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(666 - loop, 241);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 60; loop++)
                        {




                            picturePlayer2.Location = new Point(626, 241 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 44; loop++)
                        {




                            picturePlayer2.Location = new Point(626 + loop, 301 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 7; loop++)
                        {




                            picturePlayer2.Location = new Point(670 - loop, 345 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(663, 352 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 17; loop++)
                        {




                            picturePlayer2.Location = new Point(663 + loop, 382 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(680, 399 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(680 - loop, 449);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 28; loop++)
                        {




                            picturePlayer2.Location = new Point(630 - loop, 449 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer2.Location = new Point(602 - loop, 421);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 26;
                        
                        thirdrowcount2 = 547;
                        y2 = 421;

                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                        
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 464; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 18; loop++)
                        {




                            picturePlayer2.Location = new Point(456 + loop, 261);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 5; loop++)
                        {




                            picturePlayer2.Location = new Point(474, 261 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer2.Location = new Point(474 + loop, 266 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer2.Location = new Point(509 + loop, 231);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(579, 231 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 23; loop++)
                        {




                            picturePlayer2.Location = new Point(579 - loop, 251 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 27; loop++)
                        {




                            picturePlayer2.Location = new Point(556, 274 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(556 + loop, 301);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(596 + loop, 301 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }




                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(606 + loop, 291);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(636 + loop, 291 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(676 - loop, 251 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }




                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(666 - loop, 241);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 60; loop++)
                        {




                            picturePlayer2.Location = new Point(626, 241 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 44; loop++)
                        {




                            picturePlayer2.Location = new Point(626 + loop, 301 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 7; loop++)
                        {




                            picturePlayer2.Location = new Point(670 - loop, 345 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(663, 352 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 17; loop++)
                        {




                            picturePlayer2.Location = new Point(663 + loop, 382 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(680, 399 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(680 - loop, 449);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 28; loop++)
                        {




                            picturePlayer2.Location = new Point(630 - loop, 449 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer2.Location = new Point(602 - loop, 421);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 26;
                        
                        thirdrowcount2 = 547;
                        y2 = 421;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                    }
                }
                /////////////////577777777777
                else if (count2 == 57)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 555; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 555; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                //////////////////////////58888888888888888
                else if (count2 == 58)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 651; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 651; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }

                 //////////////////59999999999999999999

                else if (count2 == 59)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 743; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 743; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }

                 ////////////////60000000000000000
                else if (count2 == 60)
                {
                    if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 313)
                    {
                        for (int first = fivthrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 313);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            
                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 313 - first);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 261;
                            sixthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }

                 ///////////////////////////61111111111111111
                else if (count2 == 61)
                {
                    for (int first = sixthrowcount2; first <= 837; first++)
                    {
                        picturePlayer2.Location = new Point(920 - first, 261);
                        picturePlayer2.Refresh();
                        y2 = 204;

                        Thread.Sleep(1);//(2);//(4);


                    }
                    for (int first = 1; first <= 57; first++)
                    {
                        picturePlayer2.Location = new Point(83, 261 - first);
                        picturePlayer2.Refresh();
                        y2 = 204;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                /////////////////////////////622222222222222222222222
                else if (count2 == 62)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 176; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 176; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ////////////////////////63333333333333333
                else if (count2 == 63)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 268; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 268; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                //////////////////6444444444444
                else if (count2 == 64)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 363; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 363; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ///////////////////65555555
                else if (count2 == 65)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 455; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer2.Location = new Point(455 - loop, 204);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 2; loop++)
                        {




                            picturePlayer2.Location = new Point(420, loop + 204);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(420 - loop, 206 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }




                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer2.Location = new Point(405 - loop, 221);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(370 - loop, 221 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(360 - loop, 209);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(310 + loop, 209 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(350 - loop, 249 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(330 - loop, 269);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(310 - loop, 269 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 25; loop++)
                        {




                            picturePlayer2.Location = new Point(280 - loop, 239);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer2.Location = new Point(255 - loop, 239 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer2.Location = new Point(200 + loop, 294);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(280 + loop, 294 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(300 + loop, 314);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(340, 314 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(340 + loop, 294);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 33; loop++)
                        {




                            picturePlayer2.Location = new Point(380, 294 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(380 - loop, 261);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 57;
                        sixthrowcount2 = 555;
                        y2 = 261;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 455; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer2.Location = new Point(455 - loop, 204);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 2; loop++)
                        {




                            picturePlayer2.Location = new Point(420, loop + 204);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(420 - loop, 206 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }




                        for (int loop = 1; loop <= 35; loop++)
                        {




                            picturePlayer2.Location = new Point(405 - loop, 221);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(370 - loop, 221 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(360 - loop, 209);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(310 + loop, 209 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(350 - loop, 249 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(330 - loop, 269);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(310 - loop, 269 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 25; loop++)
                        {




                            picturePlayer2.Location = new Point(280 - loop, 239);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 55; loop++)
                        {




                            picturePlayer2.Location = new Point(255 - loop, 239 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer2.Location = new Point(200 + loop, 294);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(280 + loop, 294 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(300 + loop, 314);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(340, 314 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(340 + loop, 294);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 33; loop++)
                        {




                            picturePlayer2.Location = new Point(380, 294 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(380 - loop, 261);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 57;
                        sixthrowcount2 = 555;
                        y2 = 261;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                       
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                    }
                }
                /////////666666666666

                else if (count2 == 66)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 550; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 550; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ////////////////67777777777777777
                else if (count2 == 67)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 639; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 639; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ///////////////////////////6888888888
                else if (count2 == 68)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 736; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 736; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ///////////699999999999
                else if (count2 == 69)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 827; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 827; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                //////////////70000000000
                else if (count2 == 70)
                {
                    if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 261)
                    {
                        for (int first = sixthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 261);
                            picturePlayer2.Refresh();
                            y2 = 204;

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int first = 1; first <= 57; first++)
                        {
                            picturePlayer2.Location = new Point(83, 261 - first);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 204;
                            seventhrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ////////////////711111111111111111111

                else if (count2 == 71)
                {
                    for (int first = seventhrowcount2; first <= 920; first++)
                    {
                        picturePlayer2.Location = new Point(first, 204);
                        picturePlayer2.Refresh();
                        y2 = 151;
                        seventhrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }

                    for (int first = 1; first <= 53; first++)
                    {
                        picturePlayer2.Location = new Point(920, 204 - first);
                        picturePlayer2.Refresh();
                        y2 = 151;
                        Thread.Sleep(1);//(2);//(4);
                    }

                }
                ////////////72222222222
                else if (count2 == 72)
                {
                    if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 92; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int loop = 1; loop <= 107; loop++)
                        {




                            picturePlayer2.Location = new Point(828 - loop, 151 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        count2 = 93;
                        tenthrowcount2 = 195;
                        y2 = 44;

                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        

                    }
                    else if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 204 - first);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = eigthrowcount2; first <= 92; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 107; loop++)
                        {




                            picturePlayer2.Location = new Point(828 - loop, 151 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        count2 = 93;
                        tenthrowcount2 = 195;
                        y2 = 44;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        

                    }
                }
                //////////////////////////733333333333333
                else if (count2 == 73)
                {
                    if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 186; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 204 - first);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = eigthrowcount2; first <= 186; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                }
                ///////////////7444444444
                else if (count2 == 74)
                {
                    if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 274; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 204 - first);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = eigthrowcount2; first <= 274; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                }
                ///////////7555555555555555
                else if (count2 == 75)
                {
                    if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 370; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 204 - first);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = eigthrowcount2; first <= 370; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                }
                ///////////76666666666666
                else if (count2 == 76)
                {
                    if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 464; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 204 - first);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = eigthrowcount2; first <= 464; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                }
                //////////77777777
                else if (count2 == 77)
                {
                    if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 559; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 204 - first);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = eigthrowcount2; first <= 559; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                }
                ////////7888888888
                else if (count2 == 78)
                {
                    if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 651; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 204 - first);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = eigthrowcount2; first <= 651; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                }
                /////////799999999
                else if (count2 == 79)
                {
                    if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 745; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                    else if (y2 == 204)
                    {
                        for (int first = seventhrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 204);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(920, 204 - first);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = eigthrowcount2; first <= 745; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 151;
                            eigthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                    }
                }
                //////////////////////800000000000

                else if (count2 == 80)
                {
                    for (int first = eigthrowcount2; first <= 837; first++)
                    {
                        picturePlayer2.Location = new Point(920 - first, 151);
                        picturePlayer2.Refresh();
                        y2 = 151;
                        eigthrowcount2 = first;
                        Thread.Sleep(1);//(2);//(4);
                    }
                    for (int loop = 1; loop <= 107; loop++)
                    {




                        picturePlayer2.Location = new Point(83, 151 - loop);
                        picturePlayer2.Refresh();

                        Thread.Sleep(1);//(2);//(4);


                    }
                    count1 = 100;
                    y = 44;
                    tenthrowcount = 837;
                    firstrowcount = 83;
                    secondrowcount = 0;
                    thirdrowcount = 83;
                    fourrowcount = 0;
                    fivthrowcount = 83;
                    sixthrowcount = 0;
                    seventhrowcount = 83;
                    eigthrowcount = 0;
                    ninethrowcount = 83;
                    //startSoundPlayer.Stop();

                    MessageBox.Show("Player 2 won the match\nClick ok button and play again :D");

                    count1 = 1;
                    firstrowcount = 83;
                    secondrowcount = 0;
                    thirdrowcount = 83;
                    fourrowcount = 0;
                    fivthrowcount = 83;
                    sixthrowcount = 0;
                    seventhrowcount = 83;
                    eigthrowcount = 0;
                    ninethrowcount = 83;
                    tenthrowcount = 0;
                    y = 530;
                    picturePlayer1.Location = new Point(83, 530);





                    count2 = 1;
                    firstrowcount2 = 83;
                    secondrowcount2 = 0;
                    thirdrowcount2 = 83;
                    fourrowcount2 = 0;
                    fivthrowcount2 = 83;
                    sixthrowcount2 = 0;
                    seventhrowcount2 = 83;
                    eigthrowcount2 = 0;
                    ninethrowcount2 = 83;
                    tenthrowcount2 = 0;
                    y2 = 530;
                    picturePlayer2.Location = new Point(83, 530);
                    Head.Text = ("Player 1 Turn");
                    Head.ForeColor = Color.Red;
                    Head.BackColor = Color.Maroon;

                    change = 0;
                    SecPlayerPlayButton.Visible = false;
                    FirstPlayerPlayButton.Visible = true;
                    picturePlayer1.BringToFront();


                   // startSoundPlayer.PlayLooping();
                    

                }
                /////////////////////////////8111111

                else if (count2 == 81)
                {
                    for (int first = eigthrowcount2; first <= 837; first++)
                    {
                        picturePlayer2.Location = new Point(920 - first, 151);
                        picturePlayer2.Refresh();
                        y2 = 99;

                        Thread.Sleep(1);//(2);//(4);
                    }

                    for (int first = 1; first <= 52; first++)
                    {
                        picturePlayer2.Location = new Point(83, 151 - first);
                        picturePlayer2.Refresh();
                        y2 = 99;
                        Thread.Sleep(1);//(2);//(4);
                    }

                }

                ///////////////////////////8222222222222222

                else if (count2 == 82)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 179; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 179; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////833333333333333
                else if (count2 == 83)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 270; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 270; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////////844444444
                else if (count2 == 84)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 362; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 362; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                /////////////////////855555
                else if (count2 == 85)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 456; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 456; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ////////////8666666666

                else if (count2 == 86)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 549; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 549; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////8777777777
                else if (count2 == 87)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 642; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 642; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ///////888888

                else if (count2 == 88)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 733; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 29; loop++)
                        {




                            picturePlayer2.Location = new Point(733 - loop, 99);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(704 - loop, 99);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(674, 99 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 25; loop++)
                        {




                            picturePlayer2.Location = new Point(674 + loop, 129 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 85; loop++)
                        {




                            picturePlayer2.Location = new Point(699 - loop, 154);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(614 + loop, 154 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(644, 124 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer2.Location = new Point(644 - loop, 84);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(564 + loop, 84 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 25; loop++)
                        {




                            picturePlayer2.Location = new Point(604 - loop, 124 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }


                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer2.Location = new Point(579 - loop, 149);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(499 - loop, 149 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(469 + loop, 179 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 80; loop++)
                        {




                            picturePlayer2.Location = new Point(499 + loop, 209);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(579 + loop, 209 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(589 + loop, 199);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(619 + loop, 199 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 70; loop++)
                        {




                            picturePlayer2.Location = new Point(634 + loop, 184);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(704 + loop, 184 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 47; loop++)
                        {




                            picturePlayer2.Location = new Point(734, 214 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 53;
                        sixthrowcount2 = 186;
                        y2 = 261;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;


                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 733; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }

                 ////////8999999999999999999
                else if (count2 == 89)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 827; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 827; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ////////////90000000000000
                else if (count2 == 90)
                {
                    if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 151)
                    {
                        for (int first = eigthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 151);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = 1; first <= 53; first++)
                        {
                            picturePlayer2.Location = new Point(83, 151 - first);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 99;
                            ninethrowcount2 = first;

                            Thread.Sleep(1);//(2);//(4);
                        }
                    }

                }
                ////////9111111111

                else if (count2 == 91)
                {

                    for (int first = ninethrowcount2; first <= 920; first++)
                    {
                        picturePlayer2.Location = new Point(first, 99);
                        picturePlayer2.Refresh();
                        y2 = 44;
                        ninethrowcount2 = first;

                        Thread.Sleep(1);//(2);//(4);
                    }
                    for (int first = 1; first <= 55; first++)
                    {
                        picturePlayer2.Location = new Point(920, 99 - first);
                        picturePlayer2.Refresh();
                        y2 = 44;
                        Thread.Sleep(1);//(2);//(4);
                    }
                }
                //////////9222222222
                else if (count2 == 92)
                {
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 93; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 41; loop++)
                        {




                            picturePlayer2.Location = new Point(827 + loop, 44);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(868 + loop, 44);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(918 - loop, 44 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(888 + loop, 74);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(938, 74 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(938 - loop, 59);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 33; loop++)
                        {




                            picturePlayer2.Location = new Point(898 - loop, 59 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(865 + loop, 92);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 59; loop++)
                        {




                            picturePlayer2.Location = new Point(905, 92 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(905 + loop, 151);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 71;
                        
                        y2 = 151;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 93; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 41; loop++)
                        {




                            picturePlayer2.Location = new Point(827 + loop, 44);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }



                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(868 + loop, 44);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(918 - loop, 44 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(888 + loop, 74);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(938, 74 - loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(938 - loop, 59);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 33; loop++)
                        {




                            picturePlayer2.Location = new Point(898 - loop, 59 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(865 + loop, 92);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 59; loop++)
                        {




                            picturePlayer2.Location = new Point(905, 92 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 15; loop++)
                        {




                            picturePlayer2.Location = new Point(905 + loop, 151);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 71;
                        
                        y2 = 151;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                    }
                }
                //////93333333333
                else if (count2 == 93)
                {
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 195; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 195; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }

                 //////94444444
                else if (count2 == 94)
                {
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 279; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 279; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ////955555
                else if (count2 == 95)
                {
                    store2 = count2;
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 372; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 372; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                //////966666
                else if (count2 == 96)
                {
                    store2 = count2;
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 465; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 465; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ///////9777777777777777777

                else if (count2 == 97)
                {
                    store2 = count2;
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 557; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 557; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                ////////98888888888
                else if (count2 == 98)
                {
                    store2 = count2;
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 651; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 651; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }

                 ///99999999999
                else if (count2 == 99)
                {
                    store2 = count2;
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 744; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(181 + loop, 44 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(221 - loop, 84);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(181 - loop, 84 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 100; loop++)
                        {




                            picturePlayer2.Location = new Point(171 + loop, 94 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(271 + loop, 194 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(291 + loop, 214);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 50; loop++)
                        {




                            picturePlayer2.Location = new Point(311 + loop, 214 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(361 + loop, 264);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 10; loop++)
                        {




                            picturePlayer2.Location = new Point(371 + loop, 264 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(381 + loop, 274);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(411, 274 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 20; loop++)
                        {




                            picturePlayer2.Location = new Point(411 + loop, 304 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 40; loop++)
                        {




                            picturePlayer2.Location = new Point(431 + loop, 324);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        for (int loop = 1; loop <= 30; loop++)
                        {




                            picturePlayer2.Location = new Point(471, 324 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 77; loop++)
                        {




                            picturePlayer2.Location = new Point(471 + loop, 354);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }

                        for (int loop = 1; loop <= 12; loop++)
                        {




                            picturePlayer2.Location = new Point(548, 354 + loop);
                            picturePlayer2.Refresh();

                            Thread.Sleep(1);//(2);//(4);


                        }
                        count2 = 35;
                        y2 = 366;
                        fourrowcount2 = 372;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;

                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 744; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
                //100000000000000000000000000000
                else if (count2 == 100)
                {
                    if (y2 == 44)
                    {
                        for (int first = tenthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        

                        MessageBox.Show("Player 2 won the match\nClick ok button and play again :D");

                        count1 = 1;
                        firstrowcount = 83;
                        secondrowcount = 0;
                        thirdrowcount = 83;
                        fourrowcount = 0;
                        fivthrowcount = 83;
                        sixthrowcount = 0;
                        seventhrowcount = 83;
                        eigthrowcount = 0;
                        ninethrowcount = 83;
                        tenthrowcount = 0;
                        y = 530;
                        picturePlayer1.Location = new Point(83, 530);





                        count2 = 1;
                        firstrowcount2 = 83;
                        secondrowcount2 = 0;
                        thirdrowcount2 = 83;
                        fourrowcount2 = 0;
                        fivthrowcount2 = 83;
                        sixthrowcount2 = 0;
                        seventhrowcount2 = 83;
                        eigthrowcount2 = 0;
                        ninethrowcount2 = 83;
                        tenthrowcount2 = 0;
                        y2 = 530;
                        picturePlayer2.Location = new Point(83, 530);

                        picturePlayer1.BringToFront();

                        Head.Text = ("Player 1 Turn");
                        Head.ForeColor = Color.Red;
                        Head.BackColor = Color.Maroon;

                        change = 0;
                        SecPlayerPlayButton.Visible = false;
                        FirstPlayerPlayButton.Visible = true;
                        

                      //  startSoundPlayer.PlayLooping();


                    }
                    else if (y2 == 99)
                    {
                        for (int first = ninethrowcount2; first <= 920; first++)
                        {
                            picturePlayer2.Location = new Point(first, 99);
                            picturePlayer2.Refresh();
                            y2 = 44;

                            Thread.Sleep(1);//(2);//(4);
                        }
                        for (int first = 1; first <= 55; first++)
                        {
                            picturePlayer2.Location = new Point(920, 99 - first);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            Thread.Sleep(1);//(2);//(4);
                        }

                        for (int first = tenthrowcount2; first <= 837; first++)
                        {
                            picturePlayer2.Location = new Point(920 - first, 44);
                            picturePlayer2.Refresh();
                            y2 = 44;
                            tenthrowcount2 = first;
                            Thread.Sleep(1);//(2);//(4);
                        }
                    }
                }
            }

        


         }



        public void Go2()
        {
            Invoke(new moveBd2(moveButton2), SecPlayerPlayButton);

        }

       

        
        
    }
}

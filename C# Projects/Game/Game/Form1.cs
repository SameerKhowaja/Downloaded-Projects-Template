using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if(btn2.BackColor==Color.Red && btn1.BackColor==Color.White && btn3.BackColor==Color.White && btn4.BackColor==Color.White && 
                btn5.BackColor==Color.White && btn6.BackColor==Color.White &&btn7.BackColor==Color.White && btn8.BackColor==Color.White &&
                btn9.BackColor==Color.White)
            {

                btn1.BackColor = Color.Green;

            }


           else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn4.BackColor == Color.White &&
            btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
            btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;

            }



            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                    btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                    btn9.BackColor == Color.White)
            {

                    btn1.BackColor = Color.Green;

            }


            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn4.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;

            }



            else if (btn6.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                            btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                            btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;

            }


            else if (btn7.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;

            }



            else if (btn8.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;

            }


            else if (btn9.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                                    btn8.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;

            }


                //////////////////////////


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                 && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
                 && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;
            }




                ////////////////////






                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;
            }





                //////////////////////////////////////downnnnnnnnnnnnn






            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                                 && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                 && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Green;
            }




            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                 && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                 && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }



            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                             && btn2.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                             && btn9.BackColor == Color.White)
            {

                btn1.BackColor = Color.Red;
            }






            else if(btn1.BackColor==Color.White && btn2.BackColor==Color.White && btn3.BackColor==Color.White && btn4.BackColor==Color.White && 
                btn5.BackColor==Color.White && btn6.BackColor==Color.White &&btn7.BackColor==Color.White && btn8.BackColor==Color.White &&
                btn9.BackColor==Color.White)
            {

                btn1.BackColor = Color.Red;

            }




        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;

            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn4.BackColor == Color.White &&
                        btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;

            }

            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;

            }

            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
            btn4.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
            btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;

            }

            else if (btn6.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                                        btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;

            }




            else if (btn7.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;

            }




            else if (btn8.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;

            }



            else if (btn9.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                                    btn8.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;

            }


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }

                ///////////////////////

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;
            }




                ////////////////////




                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;
            }





                //////////////////////////////////////downnnnnnnnnnnnn


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                  && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                  && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }



            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                             && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Green;
            }




            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.Green
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn1.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;
            }





            else if (btn7.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn2.BackColor = Color.Red;

            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {


            if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;

            }




            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
            btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
            btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;

            }


            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                                btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;

            }


            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
            btn4.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
            btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;

            }

            else if (btn6.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;

            }



            else if (btn7.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;

            }




            else if (btn8.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;

            }





            else if (btn9.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                                    btn8.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;

            }



//////////////////
            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }

 ////////





            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;
            }




                ////////////////////





                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;
            }





                //////////////////////////////////////downnnnnnnnnnnnn

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
              && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
              && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                             && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Green;
            }


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn1.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }




            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }



            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                             && btn2.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                             && btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;
            }



            else if (btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn3.BackColor = Color.Red;

            }
        }

        private  void btn4_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }
            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                    btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                    btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }

            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn4.BackColor == Color.White &&
                                    btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                                    btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }

            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }

            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
            btn4.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
            btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }

            else if (btn6.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }



            else if (btn7.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }





            else if (btn8.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }




            else if (btn9.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                                    btn8.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;

            }

                ////////////////
            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }
                /////////////







            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;
            }




                ////////////////////
            


                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;
            }


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }


                //////////////////////////////////////downnnnnnnnnnnnn
            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                             && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Green;
            }




            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }



            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                             && btn2.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                             && btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }









            else if (btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn4.BackColor = Color.Red;
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;

            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;

            }

            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn4.BackColor == Color.White &&
                                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                                btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;

            }

            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;

            }




            else if (btn6.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;

            }




            else if (btn7.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;

            }





            else if (btn8.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;

            }





            else if (btn9.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                                    btn8.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;

            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }




            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;
            }




                ////////////////////





                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;
            }





                //////////////////////////////////////downnnnnnnnnnnnn


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
            && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
            && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                             && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Green;
            }



            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn1.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }






            else if (btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn5.BackColor = Color.Red;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;

            }


            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;

            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn4.BackColor == Color.White &&
                                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                                btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;

            }

            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;

            }

            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                    btn4.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                    btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;

            }



            else if (btn7.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;

            }




            else if (btn8.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;

            }



            else if (btn9.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                                    btn8.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;

            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }




            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;
            }




                ////////////////////






                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;
            }





                //////////////////////////////////////downnnnnnnnnnnnn


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                             && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn1.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }



            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                             && btn2.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                             && btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }








            else if (btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn6.BackColor = Color.Red;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;

            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;

            }

            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn4.BackColor == Color.White &&
                                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                                btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;

            }


            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;

            }


            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn4.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;

            }


            else if (btn6.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                    btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;

            }




            else if (btn8.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;

            }




            else if (btn9.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                                    btn8.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;

            }



            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;
            }





                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;
            }





                //////////////////////////////////////downnnnnnnnnnnnn



            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
            && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
            && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                             && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Green;
            }


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                         && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn1.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }



            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                             && btn2.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                             && btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }

                ////////////////////
            else if (btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn7.BackColor = Color.Red;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;

            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;

            }

            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn4.BackColor == Color.White &&
                                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                                btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;

            }

            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;

            }

            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn4.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;

            }

            else if (btn6.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                    btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;

            }




            else if (btn7.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;

            }


            else if (btn9.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                                    btn8.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;

            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;
            }





                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;
            }





                //////////////////////////////////////downnnnnnnnnnnnn





            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
            && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
            && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }

                ////////////////////
            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                             && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;
            }



            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                     && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                 && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn7.BackColor == Color.Red && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.Green
                                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn1.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }





            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }



            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                             && btn2.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                             && btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }




            else if (btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn8.BackColor = Color.Red;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;

            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;

            }

            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn4.BackColor == Color.White &&
                                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                                btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;

            }

            else if (btn4.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;

            }



            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                btn4.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;

            }


            else if (btn6.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                    btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                    btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;

            }


            else if (btn7.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn8.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;

            }




            else if (btn8.BackColor == Color.Red && btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White &&
                        btn4.BackColor == Color.White && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White &&
                        btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;

            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }

            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.Green && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }


            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn2.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }





            else if (btn1.BackColor == Color.Red && btn3.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }


            else if (btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn2.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Green && btn4.BackColor == Color.White
             && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;
            }

            else if (btn2.BackColor == Color.Red && btn3.BackColor == Color.Red && btn1.BackColor == Color.Green && btn4.BackColor == Color.White
                         && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;
            }






                ///////////////////////////////////////////downnnnnnnnnnnnn

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White
             && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn1.BackColor == Color.White && btn2.BackColor == Color.White
             && btn3.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }

            else if (btn5.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                             && btn3.BackColor == Color.White && btn8.BackColor == Color.White && btn9.BackColor == Color.White && btn6.BackColor == Color.White
                             && btn7.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White && btn2.BackColor == Color.White
                         && btn3.BackColor == Color.White && btn5.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn5.BackColor == Color.Green && btn1.BackColor == Color.White && btn4.BackColor == Color.White
                     && btn3.BackColor == Color.White && btn2.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }





            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn4.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }


            else if (btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn2.BackColor == Color.White && btn1.BackColor == Color.White
                     && btn5.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }


                ////////////


                ////////redgreen
            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Green && btn6.BackColor == Color.Red && btn1.BackColor == Color.White
                 && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                 && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;
            }

            else if (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn1.BackColor == Color.White
             && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;
            }

            else if (btn5.BackColor == Color.Red && btn6.BackColor == Color.Red && btn4.BackColor == Color.Green && btn1.BackColor == Color.White
                         && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                         && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;
            }





                //////////////////////////////////////downnnnnnnnnnnnn


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
            && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
            && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                             && btn5.BackColor == Color.Red && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;
            }



            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                     && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
             && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn7.BackColor == Color.Red && btn8.BackColor == Color.White
             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Green;
            }


            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.Green && btn3.BackColor == Color.Red && btn4.BackColor == Color.Green
                         && btn5.BackColor == Color.Red && btn6.BackColor == Color.Green && btn7.BackColor == Color.Red && btn8.BackColor == Color.Green
                         && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }

            else if (btn1.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }


            else if (btn4.BackColor == Color.Red && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn1.BackColor == Color.Green
                     && btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                     && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }



            else if (btn2.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                             && btn5.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }



            else if (btn5.BackColor == Color.Red && btn1.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White
                                             && btn2.BackColor == Color.Green && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White
                                             && btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }




            else if (btn1.BackColor == Color.White && btn2.BackColor == Color.White && btn3.BackColor == Color.White && btn4.BackColor == Color.White &&
                btn5.BackColor == Color.White && btn6.BackColor == Color.White && btn7.BackColor == Color.White && btn8.BackColor == Color.White &&
                btn9.BackColor == Color.White)
            {

                btn9.BackColor = Color.Red;
            }
        }

       







       

        
            
    }
}
            
        

        
      
    


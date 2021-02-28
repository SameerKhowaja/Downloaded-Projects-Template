using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCall
{
    class Program
    {
        static void Main(string[] args)
        {

            calculator t = new calculator();

            //t.cal();






            table ty = new table();

          // ty.tb();


            tableult yy = new tableult();

        //yy.tablee();



            largest L = new largest();

         //  L.large();


            smallest sm = new smallest();

           //sm.small();

            
            middle m = new middle();

            //m.mid();


            alphbate al = new alphbate();

       // al.abc();






            marks tt = new marks();

            //tt.marksshe();





            space s = new space();

         //  s.spa();





            count cn = new count();

           // cn.cou();





            worde ww= new worde();

          //ww.word();




            power op = new power();

            //op.po();




            Addition lo = new Addition();

           // lo.add();

            Multiplication you = new Multiplication();

            //you.mul();
            Console.ReadLine();
        }


        class calculator {

            public void cal() {

                Console.WriteLine("Enter First Number");

                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Enter Second Number");

                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Enter Operator Number");

                string op= Console.ReadLine();
                Console.Clear();


                if(op=="+"){

                Console.WriteLine("Add  {0}",num1+num2);
                }



                if (op == "-")
                {
                    Console.WriteLine("SUB  {0}   ", num1 - num2);
                }
                if (op == "*")
                {
                    Console.WriteLine("MUL  {0}   ", num1 * num2);
                }
                if (op == "/")
                {
                    Console.WriteLine("DIV  {0}   ", num1 / num2);
                }
                if (op == "%")
                {
                    Console.WriteLine("REM  {0}   ", num1 % num2);
                }

                if(op!="+" &&op!="-" &&op!="*" &&op!="/" &&op!="%"){

                    Console.WriteLine("Invaild");
                
                }





            }
        
        }


        class table {



            public void tb() {


                Console.WriteLine("Enter Your Choice Any Number You want table print");

                int ta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You Put finish table number");

                int taa = Convert.ToInt32(Console.ReadLine());





                for (int a = 1; a <= taa; a++) {



                    Console.WriteLine("{0} X {1} = {2}",ta,a,a*ta);
                
                
                }



            
            
            }
        
        }



        class tableult {


            public void tablee() {


                Console.WriteLine("Enter Your Choice Any Number Your want table print but table is reverse");


                int s = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("You Put finish table number but table is reverse");



                int tq = Convert.ToInt32(Console.ReadLine());







                for (int b = tq; b >= 1; b--) {



                    Console.WriteLine("{0} X {1} = {2}",s,b,s*b);
                
                
                
                }






            
            }
        
        }



        class largest {

            public void large() {




                Console.WriteLine("Enter First Number");

                int num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Second Number");

                int num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Third Number");

                int num3 = Convert.ToInt32(Console.ReadLine());





                if(num1>num2 && num1>num3){

                    Console.WriteLine("The Largest Number ==> {0}",num1);
                
                
                }


                else if(num2>num1 && num2>num3){
                
                    Console.WriteLine("The Largest Number ==> {0}",num2);
                
                
                
                
                }



                else if (num3 > num1 && num3 > num2)
                {


                    Console.WriteLine("The Largest Number ==> {0}", num3);


                }



                else {


                    Console.WriteLine("The Values is same");
                
                
                }





            
            }
        
        }

        class smallest {

            public void small() {



                Console.WriteLine("Enter First Number");

                int num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Second Number");

                int num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Third Number");

                int num3 = Convert.ToInt32(Console.ReadLine());





                if (num1 < num2 && num1 < num3)
                {

                    Console.WriteLine("The Smallest Number ==> {0}", num1);


                }


                else if (num2 < num1 && num2 < num3)
                {

                    Console.WriteLine("The Smallest Number ==> {0}", num2);




                }



                else if (num3 < num1 && num3 < num2)
                {


                    Console.WriteLine("The Smallest Number ==> {0}", num3);


                }



                else
                {


                    Console.WriteLine("The Values is same");


                }
        
            
            
            
            }
        
        
        }




        class middle {


            public void mid() {



                Console.WriteLine("Enter First Number");

                int num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Second Number");

                int num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Third Number");

                int num3 = Convert.ToInt32(Console.ReadLine());





                if ((num1 < num2 || num1 < num3) && (num1 >num2 || num1 > num3))
                {

                    Console.WriteLine("The Middle Number ==> {0}", num1);


                }


                else if ((num2 < num1 || num2 <num3) && (num2 > num1 || num2> num3))
                {

                    Console.WriteLine("The Middle Number ==> {0}", num2);




                }



                else if ((num3 < num1 || num3 < num2) && (num3 >num1 || num3 > num2))
                {


                    Console.WriteLine("The Middle Number ==> {0}", num3);


                }



                else
                {


                    Console.WriteLine("The Values is same");


                }
            
            
            
            
            
            }
        
        }




        class alphbate {


            public void abc() {


                Console.WriteLine("Enter Charector");


                char ch = Convert.ToChar(Console.ReadLine());


                int  a = Convert.ToChar(ch);





                if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z')
                {

                    Console.WriteLine("The Assci Code ===> {0}", a);

                }

                else {


                    Console.WriteLine("Please Put in Only Charector");
                
                }
                
               
            }
        
        }




        class marks {
            public void marksshe() {



                Console.WriteLine("Enter Marks");

               Single marks = Convert.ToSingle(Console.ReadLine());




                if(marks>=80 && marks<=100){

                    Console.WriteLine("A");
                
                }

                else if(marks>=60 && marks<80){

                    Console.WriteLine("B");
                
                
                }

                else if (marks >= 50 && marks < 60)
                {

                    Console.WriteLine("C");


                }

                else {

                    Console.WriteLine("Fail");
                   
                
                }
                

            }
           
        
        }




        class space {


            public void spa() {


                
                Console.WriteLine("Enter Your Name");


                String str = Console.ReadLine();

                int space = 0;

                for (int a = 0; a < str.Length; a++) {

                   
                
                
                if(str[a]==' '){
                    
                    space++;

                    
                
                   
                
                }
                
               
                }
                Console.WriteLine("The Spaces is ===> {0}",space);


                



            
            
            }






         





        
        
        }


        class count
        {



            public void cou()
            {

                Console.WriteLine("Enter start the Nummber");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Enter the Finish Number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();



                for (int count = num1; count <= num2; count++) {

                   
                    Console.WriteLine(count);
                
                
                }





            }








        }




        class worde{




            public void word() {



                Console.WriteLine("Enter Your Name");


                String str = Console.ReadLine();

                Console.Clear();

                for (int a = 0; a < str.Length; a++)
                {




                    if (str[a] == 's')
                    {



                        Console.Write(" m ");

                    }
                    else {


                        Console.Write(" {0} ",str[a]);
                    
                    
                    
                    }

                    
                }
                

            
            
            
            
            
            }
        
        
        }




        class power {

            public void po() {

                

                Console.WriteLine("Enter the number");

                int num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter The Power");

                int power = Convert.ToInt32(Console.ReadLine());



                int p=1;


                for (int count = 1; count <=power; count++) {


                    p =p *num1;

                    
                }
                Console.WriteLine("{0}", p);
                
                
















            
            }
        
        
        }



        class Addition {
            public void add() {

                int count=0;

                for (int a = 1; a <= 5; a++)
                {

                    Console.WriteLine("Enter the number");

                    int num1 = Convert.ToInt32(Console.ReadLine());


                    count = num1 + count;
                
                
                }

                Console.WriteLine("\n\n\nThe Addition is ===> {0}",count);

            
            }
        
        
        }


        class Multiplication
        {
            public void mul()
            {

                int count = 1;

                for (int a = 1; a <= 5; a++)
                {

                    Console.WriteLine("Enter the number");

                    int num1 = Convert.ToInt32(Console.ReadLine());


                    count = num1 * count;


                }

                Console.WriteLine("\n\n\nThe Mutiplication is ===> {0}", count);


            }


        }










    }
}

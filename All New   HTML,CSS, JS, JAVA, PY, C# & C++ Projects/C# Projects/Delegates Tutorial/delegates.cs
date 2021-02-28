using System;

namespace IntroductionToDelegates
{
    public delegate int ReturnDel(int _value);  // Declaring a delegate with a return type of an int with one argument/paramenter of type int
    public delegate void WriteDel();    // Declaring a delegate without a return type that takes no arguments

    class Program
    {
        static void Main(string[] args)
        {
            ReturnDel returnDel = new ReturnDel(Return);    // Instantiating the delegate and subscribing the method Return to it

            Console.WriteLine(returnDel(10));       // Now use the instance of the delegate to call the method
            Console.WriteLine("This has been writen from a delegate");      // Just clearning up what happened

            Console.WriteLine();    // Since for some reason I can't use Console.ReadKey and Console.Clear, I have just made a line of spacing

            WriteDel write = new WriteDel(WriteA);  // Instantiating the delegate WriteDel, and subscribing WriteA to it
            write += WriteB;    /* Here comes the main reason you would use delegates. You can subscribe 
			                    as many methods as you want to it, and then call them all at the same time. Here I also subscribe WriteB to it */

            write();        // Call ALL of the methods that are subscribed to the "write" variable
            Console.WriteLine("Both came from a delegate.");

            Console.WriteLine("\nThis was only a brief introduction to delegates,");
            Console.WriteLine("Since for some reason there wasn't a tutorial about them in the course here...");
            Console.WriteLine("You can find a lot more about them on YouTube, or the internet in general. Make sure to do so.");
            Console.WriteLine("\nOh, and BTW, you can also use them to have methods with parameters that ask for a different method as the argument.");
            Console.WriteLine("I won't show any example for that here, but it is pretty awesome. This is one of my favorite uses for them.");
        }

        #region Used For Examples
        static int Return(int _value)
        {
            return _value;
        }

        static void WriteA()
        {
            Console.WriteLine("This comes from method A");
        }

        static void WriteB()
        {
            Console.WriteLine("This comes from method B");
        }
        #endregion
    }
}
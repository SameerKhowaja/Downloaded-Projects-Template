using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
        {

            Console.WriteLine("Enter a text");

            string txt;

            txt = Console.ReadLine();

            var encode = new List<string>(); //initalising encode list

            int count = -1, key = 3;

            try
            {

                /////////////////////////////EncodingText////////////////////////////////////////

                foreach (char c in txt) //for each loop on no of string
                {

                    encode.Add((c + key).ToString());

                }//end of for each

                Console.WriteLine("\n\n\t\t\t***********Encoded*********");

                ////////////////////////////////Print the encode text////////////////////////////

                foreach (char c in txt)
                {

                    count += 1;

                    //////////////////////////Condition Check Mod26 for small alphabet///////////////

                    if (Convert.ToInt32(encode[count]) >= 123 && Convert.ToInt32(encode[count]) <= 126)
                    {

                        var temp = Convert.ToInt32(encode[count]);

                        temp -= 26;

                        encode[count] = temp.ToString();

                    }

                    //////////////////////////Condition check mod26 for capital alphabet/////////////

                    if (Convert.ToInt32(encode[count]) >= 91 && Convert.ToInt32(encode[count]) <= 93)
                    {

                        var temp = Convert.ToInt32(encode[count]);

                        temp -= 26;

                        encode[count] = temp.ToString();

                    }

                    Console.Write(Convert.ToChar(Convert.ToInt32(encode[count])));

                }//end of foreach loop

            }//end of try block

            catch (Exception e)
            {

                Console.WriteLine(e);

            }

            //////////////////////////////////////Decoding Text////////////////////////////

            Console.WriteLine("\n\n\t\t\t***********Decoded*********");

            count = -1;

            foreach (char c in txt)
            {

                count += 1;

                ////////////////////////Condition Check Mod26 for small alphabet////////////////

                if (Convert.ToInt32(encode[count]) >= 97 && Convert.ToInt32(encode[count]) <= 100)
                {

                    var temp = Convert.ToInt32(encode[count]);

                    temp += 26;
                    if (temp>=126)
                    {
                        temp -= 26;
                    }

                    encode[count] = temp.ToString();

                }

                ////////////////////Condition check mod26 for capital alphabet//////////////////

                if (Convert.ToInt32(encode[count]) >= 65 && Convert.ToInt32(encode[count]) <= 67)
                {

                    var temp = Convert.ToInt32(encode[count]);

                    temp += 26;

                    encode[count] = temp.ToString();

                }

                Console.Write(Convert.ToChar(Convert.ToInt32(encode[count]) - 3));

            }//end of foreach loop
            Console.Read();
        }

	}
}

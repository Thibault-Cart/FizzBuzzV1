/*
 Author: Thibault Cart
 Date:29.12.2021
 Version: 2.0
 Basic description: Count to the number define by the variable "number", ect...
 */

using System;


namespace Console_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing all constants and variabes that we will use in the program
            const int number = 100;
            const int divider1 = 3;
            const int divider2 = 5;
            const string textDivider1 = "Fizz";
            const string textDivider2 = "Buzz";
            string OutPutText = "";


            

            for (int i = 1; i <= number; i++)
            {
                //can be divide by divider1
                if (i%divider1==0)
                {
                    OutPutText += textDivider1;
                }
                //can be divide by divider2
                if (i % divider2 == 0)
                {
                    OutPutText += textDivider2;
                }
                //cannot be divide by divider1 and divider2
                if (i % divider1 != 0&& i % divider2 != 0)
                {
                    OutPutText = i.ToString();
                }

                Console.WriteLine(OutPutText);
                OutPutText = "";
            }
            Console.ReadLine();
        }
    }
}

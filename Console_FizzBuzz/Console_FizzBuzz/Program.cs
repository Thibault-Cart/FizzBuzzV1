/*
 Author: Thibault Cart
 Date:29.12.2021
 Version: 1.1
 Basic description: Count to the numer define by the variable "number", ect...
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Put the number typed by the user in the variable "number"
            Console.Write("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                //can be devide by 3
                if (i % 3 == 0)
                {
                    //can be devide by 5
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Fizz Buzz ");
                    }
                    else
                    {
                        Console.WriteLine("Fizz ");
                    }

                }
                //cannot be devide by 3
                else
                {
                    //can be devide by 5
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz ");
                    }
                    //cannot be devide by 5
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

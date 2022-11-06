using System;
using System.Collections.Generic;
using System.Text;

namespace VisualProgramming
{
    class NumberManip
    {
        internal static void Palindrome()
        {
            int number, remainder, reverse = 0;
            Console.WriteLine("Enter any number");
            number = int.Parse(Console.ReadLine());
            int temp = number;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            if (reverse == temp)
                Console.WriteLine("Number is palindrome");
            else
                Console.WriteLine("Number isnot palindrome");
        }

        internal static void Armstrong()
        {

        }

        internal static void Factorial()
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The Factorial is " + fact);
        }
    }
}

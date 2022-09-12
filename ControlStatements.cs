using System;
using System.Windows;

namespace VisualProgramming
{
    class ControlStatements
    {
        internal static void Func()
        {
            int num1 = 20, num2 = 50, num3 = 10;

            //Simple If
            if (num1 > num2)
            {
                Console.WriteLine("Num1 is greater");
            }

            //if else 
            if (num1 > num2)
            {
                Console.WriteLine("Num1 is greater");
            }
            else
            {
                Console.WriteLine("Num2 is greater");
            }

            //if else ladder
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Num1 is greater");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Num2 is greater");
            }
            else
            {
                Console.WriteLine("Num3 is greater");
            }
        }
    }
}

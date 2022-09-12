using System;
using System.Collections.Generic;
using System.Text;

namespace VisualProgramming
{
    class Patterns
    {
        internal static void Pattern1()
        {
            //      Pattern
            //      **************
            //      *            *   
            //      *            *   
            //      *            *   
            //      *            *   
            //      *            *   
            //      *            *   
            //      **************

            int num = 10;
            Console.WriteLine("\nPattern 1\n");
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (i == 1 || i == num || j == 1 || j == num)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }


        internal static void Pattern2()
        {
            //      Pattern
            //      *
            //      **
            //      * *
            //      *  *
            //      *   *
            //      *    *
            //      *     *
            //      *      *
            //      *       *
            //      **********

            Console.WriteLine("\nPattern 2\n");
            int num = 10;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == j || i == num)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        internal static void Pattern3()
        {
            //                *
            //               ***
            //              *****
            //             *******
            //            *********
            //           ***********
            //          *************
            //         ***************
            //        *****************
            //       *******************

            Console.WriteLine("\nPattern 3\n");
            int n = 10, m = n;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                m--;
                Console.Write("\n");
            }
        }
    }
}

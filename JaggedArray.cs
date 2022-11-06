using System;
using System.Collections.Generic;
using System.Text;

namespace VisualProgramming
{
    class JaggedArray
    {
        internal static void Function()
        {
            string[][] arr = new string[][]
            {
                new string[] { "*" },
                new string[] { "* *" },
                new string[] { "* * *" },
                new string[] { "* * * *" },
                new string[] { "* * * * *" }
            };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VisualProgramming
{
    class NepalFlag
    {
        public static void DrawFlag()
        {
            int size = 10;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k <= j; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}

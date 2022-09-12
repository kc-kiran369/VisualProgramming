using System;

namespace VisualProgramming
{
    class LoopingStatements
    {
        //1) for loop
        //2) while loop
        //3) do while loop
        //4) foreach loop

        internal static void Func()
        {
            //1) for loop
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(a);
            }

            //2) while loop
            int i = 1;
            while (i < 20)
            {
                Console.WriteLine(i);
                i++;
            }

            //3) do while loop
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 30);

            //4) foreach
            int[] array = new int[10];
            Array.Fill<int>(array, 20);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace VisualProgramming
{
    public class Program
    {
        internal void Function()
        {
            var numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sumOfSquares = numberList.Select(number => number * number)
            .Aggregate((int first, int second) => { return first + second; });
            Console.WriteLine(sumOfSquares);
        }
    }
}
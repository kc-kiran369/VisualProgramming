using System;
using System.Collections.Generic;
using System.Text;

namespace VisualProgramming
{
    class CelToFahren
    {
        public static void ConvertCintoF()
        {
            float celsius;
            Console.WriteLine("Enter Celsius");
            celsius = float.Parse(Console.ReadLine());
            float fahrenheit = ((9.0f / 5.0f) * celsius) + 32.0f;
            Console.WriteLine(celsius + " is " + fahrenheit + " in fahrenheit");
        }
    }
}

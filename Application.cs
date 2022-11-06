﻿using System;

namespace VisualProgramming
{
    class Application
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            OperatingSystem os = Environment.OSVersion;
            Console.WriteLine("Platform: {0:G}\n\n", os.Platform);

            //Variables.Func();
            //ControlStatements.Func();
            //LoopingStatements.Func();
            //Patterns.Pattern1();
            //Patterns.Pattern2();
            //Patterns.Pattern3();
            //CelToFahren.ConvertCintoF();
            //NepalFlag.DrawFlag();
            //String.StringPalindrome();
            //NumberManip.Palindrome();
            //NumberManip.Factorial();
            //Test.Function();
            //JaggedArray.Function();

            Console.ReadKey();
        }
    }
}
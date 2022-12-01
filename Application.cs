using System;

namespace VisualProgramming
{
    class Application
    {
        public static void Main()
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
            //JaggedArray.Function();
            //StructStudent.Function();

            //Event
            //Event.Singelton.ExampleEvent += () =>
            //{
            //    Console.WriteLine("Event Executed");
            //};
            //Event.Singelton.FireEvent();

            Console.ReadKey();
        }
    }
}
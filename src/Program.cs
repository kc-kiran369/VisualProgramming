using System;

namespace VisualProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatingSystem os = Environment.OSVersion;
            Console.WriteLine("Current OS Information:\n");
            Console.WriteLine("Platform: {0:G}", os.Platform);
            Console.WriteLine("Version String: {0}", os.VersionString);
            Console.WriteLine("Version: {0}", os.Version);
        }
    }
}

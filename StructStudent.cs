using System;

namespace VisualProgramming
{
    internal struct Student
    {
        private readonly string name;
        private readonly string address;
        private readonly int rollno;
        private readonly string[] hobbies;
        public Student(string _name, string _address, int _rollno, params string[] _hobbies)
        {
            name = _name;
            address = _address;
            rollno = _rollno;
            hobbies = new string[_hobbies.Length];
            hobbies = _hobbies;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("Address : " + this.address);
            Console.WriteLine("rollno : " + this.rollno);
            Console.WriteLine("Hobbies : ");
            foreach (var hobby in hobbies)
            {
                Console.WriteLine(" - " + hobby);
            }
            Console.WriteLine();
        }
    }

    class StructStudent
    {
        public static void Function()
        {
            Student student1 = new Student("Nischal Pariyar", "Khudi Khola", 10, "VolleyBall", "Singing", "Bunking");
            Student student2 = new Student("Prashant Gautam", "Begnas Tal", 10, "programming", "sleeping", "lazy");
            Student student3 = new Student("Anish Majhi", "dherai tada", 3, "anime", "lazy", "shouting");
            student1.DisplayDetails();
            student2.DisplayDetails();
            student3.DisplayDetails();
        }
    }
}

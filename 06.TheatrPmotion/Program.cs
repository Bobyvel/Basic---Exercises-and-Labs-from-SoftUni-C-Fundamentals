using System;

namespace _06.TheatrPmotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            

            if ((day == "Weekday" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122))) || (day == "Holiday" && (age >18 && age <= 64)))
            {
                Console.WriteLine("12$");
                
            }
            else if (day == "Weekday" && (age >18 && age <= 64))
            {
                Console.WriteLine("18$");
            }
            else if (day == "Weekend" && ((age >= 0 && age <= 18) || (age > 64 && age <= 122)))
            {
                Console.WriteLine("15$");
            }
            else if (day == "Weekend" && (age >18 && age <= 64))
            {
                Console.WriteLine("20$");
            }
            else if (day == "Holiday" && (age >= 0 && age <= 18))
            {
                Console.WriteLine("5$");
            }
            else if (day == "Holiday" && (age > 64 && age <= 122))
            {
                Console.WriteLine("10$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

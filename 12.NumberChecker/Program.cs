using System;

namespace _12.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var number = 0;

            

            if (int.TryParse(n, out number))
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}

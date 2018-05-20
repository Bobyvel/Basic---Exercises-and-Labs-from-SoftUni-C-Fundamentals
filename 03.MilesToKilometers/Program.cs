using System;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            var oneMileInKilometres = 1.60934;
            var kilometres = miles * oneMileInKilometres;

            Console.WriteLine($"{kilometres:F2}");
        }
    }
}

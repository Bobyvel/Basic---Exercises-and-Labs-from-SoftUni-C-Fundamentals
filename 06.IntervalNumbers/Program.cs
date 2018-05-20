using System;

namespace _06.IntervalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                for (int i = numberTwo; i <= numberOne; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = numberOne; i <= numberTwo; i++)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}

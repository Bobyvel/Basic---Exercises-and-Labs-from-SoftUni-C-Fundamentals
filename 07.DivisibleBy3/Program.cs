using System;

namespace _07.DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //second way
            for (int i = 3; i < 100; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}

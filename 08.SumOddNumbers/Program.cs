using System;

namespace _08.SumOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            //even

            for (int i = 0; i < n*2 ; i+=2)
            {
                Console.WriteLine(i);
            }

            //odd
            for (int i = 1; i <= n * 2; i++)
            {
                
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            Console.WriteLine($"Sum: {sum}");


            //odd second way
            for (int i = 1; i <= n * 2; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

using System;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); //decreases n to 1
            var m = int.Parse(Console.ReadLine()); //increases 1 to M
            var maxSum = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = 0;

            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    counter++;
                    sum += 3 * (i * j);
                    
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                    
                }
            }

            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

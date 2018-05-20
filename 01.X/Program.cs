using System;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); //only odd number
            

            for (int i = 0; i < n/2; i++)
            {
                var outSpace = n - (n - i);
                var innerSpace = n - (outSpace * 2 + 2);

                Console.WriteLine($"{new string(' ', outSpace)}{new string('x', 1)}{new string(' ', innerSpace)}{new string('x', 1)}"); 
            }

            Console.WriteLine($"{new string(' ', n/2)}x");

            for (int i = n/2; i > 0; i--)
            {
                var outSpace = n - (n - i + 1);
                var innerSpace = n - (outSpace * 2 + 2);

                Console.WriteLine($"{new string(' ', outSpace)}{new string('x', 1)}{new string(' ', innerSpace)}{new string('x', 1)}"); 
            }
            
        }
    }
}

using System;

namespace _10.TriangleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) //change number
            {
                for (int j = 0; j < i; j++) //counter
                {
                    Console.Write(i + " "); // print number
                }

                Console.WriteLine();
            }
        }
    }
}

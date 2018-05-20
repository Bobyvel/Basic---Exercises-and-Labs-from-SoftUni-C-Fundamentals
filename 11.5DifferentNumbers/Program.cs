using System;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b - a < 5)
            {
                Console.WriteLine("No");
            }

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                //a ≤ n1 < n2 < n3 < n4 < n5 ≤ b
                                if (a <= i && i < j && j < k && k < l && l < m && m <= b)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    
                                }
                            }
                        }
                    }
                }
            }

           
        }
    }
}

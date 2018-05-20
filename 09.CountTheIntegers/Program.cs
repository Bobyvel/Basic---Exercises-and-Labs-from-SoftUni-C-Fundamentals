using System;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var number = 0;
            var counter = 0;

            for (int i = 0; i < 100; i++)
            {
                if (int.TryParse(input, out number))
                {
                    counter++;
                }
                else
                {
                    break;
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine(counter);
            
        }
    }
}

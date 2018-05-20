using System;
using System.Collections.Generic;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, int>()
            {
                {"cheese", 500},
                {"tomato sauce", 150},
                {"salami", 600},
                {"pepper", 50}
            };

           var caloriesAmount = 0;

           var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().ToLower();

                if (products.ContainsKey(input))
                {
                    caloriesAmount += products[input];
                }
            }

            Console.WriteLine($"Total calories: {caloriesAmount}");
        }
    }
}

using System;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = string.Empty;
            var counter = 0;

            while ((input = Console.ReadLine()) != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                counter++;
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}

using System;

namespace _01.ChooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var lowerString = profession.ToLower();

            var waterPrice = 0.70;
            var coffeePrice = 1.00;
            var beerPrice = 1.70;
            var teaPrice = 1.20;

            switch (lowerString)
            {
                case "athlete":
                    Console.WriteLine($"The {profession} has to pay {(quantity * waterPrice):F2}.");
                    break;
                case "businessman":
                case "businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(quantity * coffeePrice):F2}.");
                    break;
                case "softuni student":
                    Console.WriteLine($"The {profession} has to pay {(quantity * beerPrice):F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {(quantity * teaPrice):F2}.");
                    break;
            }

        }
    }
}

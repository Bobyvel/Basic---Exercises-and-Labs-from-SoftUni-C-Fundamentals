using System;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());
            var subtotal = 0d;

            for (int i = 0; i < numberOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    itemName += "s";
                }

                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");

                subtotal += itemPrice * itemCount;
            }

            Console.WriteLine($"Subtotal: ${subtotal:F2}");

            if (subtotal > budget)
            {
                subtotal -= budget;
                Console.WriteLine($"Not enough. We need ${subtotal:F2} more.");
            }
            else
            {
                budget -= subtotal;
                Console.WriteLine($"Money left: ${budget:F2}");
            }
        }
    }
}

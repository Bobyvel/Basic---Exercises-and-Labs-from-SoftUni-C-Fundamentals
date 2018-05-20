using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hallCapacity = new Dictionary<string, int>()
            {
                {"Small Hall", 50},
                {"Terrace", 100},
                {"Great Hall", 120}

            };

            var hallPrice = new Dictionary<string, int>()
            {
                {"Small Hall", 2500},
                {"Terrace", 5000},
                {"Great Hall", 7500}
            };

            var pakagePrice = new Dictionary<string, int>()
            {
                {"Normal", 500},
                {"Gold", 750},
                {"Platinum", 1000}

            };

            var pakageDiscount = new Dictionary<string, double>()
            {
                {"Normal", 0.05},
                {"Gold", 0.1},
                {"Platinum", 0.15}

            };

            try
            {
                var hall = hallCapacity.First(s => s.Value >= groupSize).Key;
                Console.WriteLine($"We can offer you the {hall}");

                var price = hallPrice[hall] + pakagePrice[package];
                var dickountPrice = price - (price * pakageDiscount[package]);
                var pricePerPerson = dickountPrice / groupSize;

                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            catch (Exception)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameList = new Dictionary<string, double>()
            {
                {"OutFall 4", 39.99},
                {"CS: OG", 15.99},
                {"Zplinter Zell", 19.99},
                {"Honored 2", 59.99},
                {"RoverWatch", 29.99},
                {"RoverWatch Origins Edition", 39.99}

            };

            var spendMoney = 0D;
            var budget = double.Parse(Console.ReadLine());
            var game = string.Empty;

            while ((game = Console.ReadLine()) != "Game Time")
            {
                if (gameList.ContainsKey(game))
                {
                    if (budget < gameList[game])
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {game}");
                        budget -= gameList[game];
                        spendMoney += gameList[game];

                        if (budget <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                   
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }

            
                Console.WriteLine($"Total spent: ${spendMoney:F2}. Remaining: ${budget:F2}"); 
            
            
        }
    }
}

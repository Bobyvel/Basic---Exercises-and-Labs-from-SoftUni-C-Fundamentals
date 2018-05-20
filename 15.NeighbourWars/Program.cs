using System;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var roundhouseKick = int.Parse(Console.ReadLine()); //Pesho odd turn
            var thunderousFist = int.Parse(Console.ReadLine()); //Gosho even turn 

            var peshoHealthPoints = 100;
            var goshoHealthPoints = 100;

            var attacker = string.Empty;
            var player = string.Empty;
            var attackerMove = string.Empty;
            var points = 0;

            var thirdTurnPoint = 10;
            var counter = 0;

            while (true)
            {
                counter++;

                if (counter % 2 == 1)
                {
                    goshoHealthPoints -= roundhouseKick;

                    attacker = "Pesho";
                    player = "Gosho";
                    attackerMove = "Roundhouse kick";
                    points = goshoHealthPoints;

                    if (goshoHealthPoints <= 0)
                    {
                        break;
                    }
                }
                else if (counter % 2 == 0)
                {
                    peshoHealthPoints -= thunderousFist;

                    attacker = "Gosho";
                    player = "Pesho";
                    attackerMove = "Thunderous fist";
                    points = peshoHealthPoints;

                    if (peshoHealthPoints <= 0)
                    {
                        break;
                    }
                }

                Console.WriteLine($"{attacker} used {attackerMove} and reduced {player} to {points} health.");

                if (counter % 3 == 0)
                {
                    peshoHealthPoints += 10;
                    goshoHealthPoints += 10;
                }

            }

            Console.WriteLine($"{attacker} won in {counter}th round.");

        }
    }
}

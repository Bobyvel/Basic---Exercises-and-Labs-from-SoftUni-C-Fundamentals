using System;

namespace _05.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var currentHealthBar = new string('|', currentHealth);
            var emptyHealthBar = new string('.', maxHealth - currentHealth);
            var currentEnergyBar = new string('|', currentEnergy);
            var emptyEnergyBar = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currentHealthBar}{emptyHealthBar}|");
            Console.WriteLine($"Energy: |{currentEnergyBar}{emptyEnergyBar}|");
            
        }
    }
}

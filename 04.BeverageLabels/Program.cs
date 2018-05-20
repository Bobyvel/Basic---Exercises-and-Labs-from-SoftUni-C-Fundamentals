using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyPer100 = int.Parse(Console.ReadLine());
            var sugarPer100 = int.Parse(Console.ReadLine());

            var energyInProduct = (double)(volume * energyPer100) / 100;
            var sugarInProduct = (double)(volume * sugarPer100) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyInProduct}kcal, {sugarInProduct}g sugars");
        }
    }
}

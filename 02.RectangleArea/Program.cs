using System;
using System.ComponentModel.DataAnnotations;

namespace _02.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());

            var area = sideA * sideB;

            Console.WriteLine($"{area:F2}");
        }
    }
}

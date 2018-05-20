using System;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var megaPixel = (double)(width * height) / 1000000;

           // Console.WriteLine($"{width}x{height} => {megaPixel:F1}MP"); //other way to do it
            Console.WriteLine($"{width}x{height} => {Math.Round(megaPixel, 1)}MP");
        }
    }
}

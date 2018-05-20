using System;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var mounth = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var bytes = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var heigth = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{name:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{mounth:D2}/{year} {hour:D2}:{minutes:D2}");

            var sizeFormat = string.Empty;
            if (bytes > 1000000)
            {
                bytes /= 1000000;
                sizeFormat = "MB";
            }
            else if(bytes > 1000)
            {
                bytes /= 1000;
                sizeFormat = "KB";
            }
            else
            {
                sizeFormat = "B";
            }
            Console.WriteLine($"Size: {bytes}{sizeFormat}");

            var orientation = string.Empty;
            if (width == heigth)
            {
                orientation = "square";
            }else if (width > heigth)
            {
                orientation = "landscape";
            }
            else
            {
                orientation = "portrait";
            }
            Console.WriteLine($"Resolution: {width}x{heigth} ({orientation})");
        }
    }
}

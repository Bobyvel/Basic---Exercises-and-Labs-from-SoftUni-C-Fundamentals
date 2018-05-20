using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var mounth = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());

            var studio = 0.0;
            var doubleRoom = 0.0;
            var suite = 0.0;



            if (mounth == "may"|| mounth == "october")
            {

                studio = 50;
                doubleRoom = 65;
                suite = 75;

                if(nights > 7)
                {
                    studio = 50 - (50*0.05);

                }
            }
            else if (mounth == "june" || mounth == "september")
            {
                studio = 60;
                doubleRoom = 72;
                suite = 82;

                if (nights > 14)
                {
                    doubleRoom = 72 - (72 * 0.1);
                }
            }
            else if (mounth == "july" || mounth == "august" || mounth == "december")
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;

                if (nights > 14)
                {
                    suite = 89 - (89 * 0.15);
                }
            }

            var priceStudio = studio * nights;
            var priceDouble = doubleRoom * nights;
            var priceSuite = suite * nights;


            if ((mounth == "october" && nights > 7) || (mounth == "september" && nights > 7))
            {
                priceStudio = priceStudio - studio;
            }
            

            
            Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.", priceStudio, priceDouble, priceSuite);
        }
    }
}

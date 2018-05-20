using System;

namespace _04.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthOfTheYear = int.Parse(Console.ReadLine());

            var months = new []
            {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            if (monthOfTheYear > 12 || monthOfTheYear < 1)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                monthOfTheYear--;
                Console.WriteLine(months[monthOfTheYear]);
            }
        }
    }
}

using System;

namespace _03.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());

            var afterHalfAnHour = minute + 30;

            if (afterHalfAnHour > 59)
            {
                minute = afterHalfAnHour - 60; 
                hour++;
                if (hour > 23)
                {
                    hour = 0;
                }

                Console.WriteLine($"{hour}:{minute:D2}");
            }
            else
            {
                Console.WriteLine($"{hour}:{afterHalfAnHour:D2}"); 
            }

           
        }
    }
}

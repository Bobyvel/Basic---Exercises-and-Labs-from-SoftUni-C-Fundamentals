using System;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var beatsPerMinute = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());

            var bar = 4; //1 bar = 4 beats

            var bars = numberOfBeats / bar;
            var minutes = 0d;
            var seconds = 0d;

            if (beatsPerMinute > numberOfBeats)
            {
                seconds = (numberOfBeats / beatsPerMinute) * 60; //same
            }
            else if (beatsPerMinute < numberOfBeats)
            {
                seconds = numberOfBeats * (60 / beatsPerMinute); //same
             
                if (seconds > 59)
                {
                    minutes = seconds / 60;
                    seconds = seconds % 60;
                }
            }
            else
            {
                minutes = numberOfBeats / beatsPerMinute;
            }
               
                
            
            
            Console.WriteLine($"{Math.Round(bars,1)} bars - {(int)minutes}m {(int)seconds}s");
        }
    }
}

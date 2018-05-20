using System;

namespace _14._MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var letterFrom = char.Parse(Console.ReadLine());
            var letterTo = char.Parse(Console.ReadLine());
            var letterWithout = char.Parse(Console.ReadLine());


            for (char i = letterFrom; i <= letterTo; i++)
            {
                for (char j = letterFrom; j <= letterTo; j++)
                {
                    for (char k = letterFrom; k <= letterTo; k++)
                    {
                        if (i != letterWithout && j != letterWithout && k != letterWithout)
                        {
                            Console.Write($"{i}{j}{k} ");
                            
                        }
                        
                    }
                } 
            }
        }
    }
}

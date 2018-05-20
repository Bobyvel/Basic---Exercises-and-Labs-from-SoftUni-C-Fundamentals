using System;

namespace _06.DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = new []
            {
                "A", "C", "G", "T"
            };

            var sum = int.Parse(Console.ReadLine());
            var lettersSum = 0;


            for (int i = 0; i <= letters.Length-1 ; i++)
            {
                for (int j = 0; j <= letters.Length-1; j++)
                {
                    for (int k = 0; k <= letters.Length-1; k++)
                    {
                        lettersSum += (i + 1) + (j + 1) + (k + 1);

                        if (lettersSum >= sum)
                        {
                            Console.Write($"O{letters[i]}{letters[j]}{letters[k]}O ");
                        }
                        else
                        {
                            Console.Write($"X{letters[i]}{letters[j]}{letters[k]}X "); 
                        }

                        lettersSum = 0;
                    }

                    Console.WriteLine();
                }
            }
            
        }
    }
}

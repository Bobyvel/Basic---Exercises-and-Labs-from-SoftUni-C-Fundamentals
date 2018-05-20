using System;

namespace _13.GameNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var lastNum = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var number1 = 0;
            var number2 = 0;
            var hasMagicNum = false;

            var counter = 0;

            for (int i = firstNum; i <= lastNum; i++)
            {
                for (int j = firstNum; j <= lastNum; j++)
                {
                    if (i+ j == magicNum)
                    {
                        number1 = i;
                        number2 = j;
                        hasMagicNum = true;

                    }

                    counter++;
                }
            }

            if (hasMagicNum)
            {
                Console.WriteLine($"Number found! {number1} + {number2} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
            
        }
    }
}

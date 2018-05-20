using System;

namespace _02.AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());

            var sum = numOne + numTwo;

            Console.WriteLine($"{numOne} + {numTwo} = {sum}");
        }
    }
}

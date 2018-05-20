using System;

namespace _05.WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var newWord = string.Empty;

            if (word.EndsWith("y"))
            {
                newWord = word.Remove(word.Length - 1, 1);
                newWord += "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                newWord = word + "es"; 
            }
            else
            {
                newWord = word + "s"; 
            }

            Console.WriteLine(newWord);
        }
    }
}

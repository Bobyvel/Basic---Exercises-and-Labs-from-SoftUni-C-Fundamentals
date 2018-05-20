using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _08.SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sms = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var digits = Console.ReadLine();
                var character = ' ';

                if (digits != "0")
                {
                   
                    var mainDigit = int.Parse(digits.Substring(0, 1));
                    var offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }

                    var numberOfDigits = digits.Length;
                    var letterIndex = offset + numberOfDigits - 1;
                    character = (char) (97 + letterIndex);  
                }
                
                sms.Append(character);

            }

            Console.WriteLine(sms);
        }
    }
}

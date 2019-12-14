using System;
using System.Collections.Generic;

namespace _13._Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> Letters = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }

            };
            string roman = "LVIII";
            int result = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if ( i+1< roman.Length && roman[i] == 'I' && (roman[i + 1] == 'V' || roman[i + 1] == 'X'))
                {
                    result += Letters[roman[i + 1]] - Letters[roman[i]];
                    i++;
                }
                else if (i + 1 < roman.Length && roman[i] == 'X' && (roman[i + 1] == 'L' || roman[i + 1] == 'C'))
                {
                    result += Letters[roman[i + 1]] - Letters[roman[i]];
                    i++;
                }
                else if (i + 1 < roman.Length && roman[i] == 'C' && (roman[i + 1] == 'D' || roman[i + 1] == 'M'))
                {
                    result += Letters[roman[i + 1]] - Letters[roman[i]];
                    i++;
                }
                else
                {
                    result += Letters[roman[i]];
                }
            }
            Console.WriteLine("{0}", result);
        }
    }
}

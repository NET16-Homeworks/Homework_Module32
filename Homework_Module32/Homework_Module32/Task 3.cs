using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task_3
    {
        public void StringChecker(string text)
        {
            char[] chars = text.ToCharArray();
            Dictionary<char, int> dictionaryChars = new Dictionary<char, int>();
            foreach (var character in chars)
            {
                if (dictionaryChars.ContainsKey(character))
                {
                    dictionaryChars[character]++;
                }
                else
                {
                    dictionaryChars.Add(character, 1);
                }
            }
            foreach (var character in dictionaryChars)
            {
                Console.WriteLine($"\"{character.Key}\" символ содержится в строке {character.Value} раз(a).");
            }
        }
    }
}

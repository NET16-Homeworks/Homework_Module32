using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task3
    {
        public void OriginSymbols(string s)
        {            
            Dictionary<char, int> symbols = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (symbols.ContainsKey(s[i]))
                {
                    symbols[s[i]]++;
                }
                else
                {
                    symbols.Add(s[i], 1);
                }
            }
            foreach (var symbol in symbols)
            {
                Console.WriteLine($"Уникальный символ:'{symbol.Key}', количество повторений: {symbol.Value}");
            }
        }
    }
}


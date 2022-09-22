using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32.ThirdTask
{
    internal class ThirdTask
    {
        public void NumbersOfUniqueSymbols(string line)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();
            for (int i = 0; i < line.Length; i++)
            {
                if (symbols.ContainsKey(line[i]))
                {
                    symbols[line[i]]++;
                }
                else
                {
                    symbols.Add(line[i], 1);
                }
            }
            foreach (var symbol in symbols)
            {
                Console.WriteLine($"Value: {symbol.Key}, Iteration: {symbol.Value}");
            }
        }
    }
}

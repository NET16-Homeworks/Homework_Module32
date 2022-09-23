using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    public class Third
    {
        public void GetSymbolsCountInString(string howMuchInStrings)
        {
            Dictionary<char, int> symbols = new();

            foreach (char currentChar in howMuchInStrings)
            {
                if (symbols.TryGetValue(currentChar, out int count))
                {
                    symbols[currentChar] += 1;
                }
                else
                {
                    symbols.Add(currentChar, 1);
                }
            }

            foreach (var item in symbols)
            {
                Console.WriteLine($@"Символ(ключ)'{item.Key}': {item.Value} Кол-во раз (Значение)");
            }
        }
    }
}

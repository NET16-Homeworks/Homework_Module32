using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class NumberExtractor
    {
        public NumberExtractor(List<int> numbers)
        {
            Numbers = numbers;
        }
        public List<int> Numbers { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = Numbers.Count-1; i >= 0; i--)
            {
                if (Numbers[i] % 2 == 0 || Numbers[i] % 3 == 0)
                {
                    yield return Numbers[i];
                }
            }       
        }
    }
}

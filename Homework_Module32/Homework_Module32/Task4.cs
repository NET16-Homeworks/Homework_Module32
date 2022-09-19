using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class Task4
    {
        public int[] _intNumbers { get; set; }
        public Task4(int[] intNumbers)
        {
            _intNumbers = intNumbers;
        }
        public IEnumerable<int> ReturnNumbers()
        {
            var enumerator = _intNumbers.Reverse();
            foreach (var number in enumerator)
            {
                if (!(number % 2 == 0 || number % 3 == 0))
                {
                    yield return number;
                }
            }
        }
    }
}

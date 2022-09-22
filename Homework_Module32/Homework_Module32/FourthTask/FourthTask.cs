using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32.FourthTask
{
    internal class FourthTask
    {
        private int[] _numbers;

        public FourthTask(int[] numbers)
        {
            _numbers = numbers;
        }

        public IEnumerable<int> GetEnumerable()
        {
            for (int i = _numbers.Length - 1; i >= 0; i--)
            {
                if(_numbers[i] % 3 == 0 || _numbers[i] % 2 == 0)
                {
                    yield return _numbers[i];
                }
            }
        }
    }
}

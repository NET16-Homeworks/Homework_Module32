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

        public void Process()
        {
            
        } 

        public IEnumerator<int> GetNumbers()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                if(_numbers[i] % 3 == 0 || _numbers[i] % 2 == 0)
                {
                    yield return _numbers[i];
                }
            }
        }
    }
}

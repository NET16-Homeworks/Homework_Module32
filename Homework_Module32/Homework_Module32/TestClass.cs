using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module32
{
    internal class TestClass
    {
        private List<int> numberList;

        public TestClass(List<int> listOfNumb)
        {
            this.numberList = listOfNumb;
        }

        public IEnumerable GetEnumerable()
        {
            for (var i = numberList.Count - 1; i >= 0; i--)
            {
                if (((numberList[i] % 2) != 0) && ((numberList[i] % 3) != 0))
                {
                    yield return numberList[i];
                }
            }
        }
    }
}

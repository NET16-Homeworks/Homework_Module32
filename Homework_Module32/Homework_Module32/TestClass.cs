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
        private List<int> listOfNumbers;

        public TestClass(List<int> listOfNumbers)
        {
            this.listOfNumbers = listOfNumbers;
        }

        public IEnumerable GetEnum()
        {
            for (var i = listOfNumbers.Count - 1; i >= 0; i--) ///S KONCA!!!
            {
                if (((listOfNumbers[i] % 2) != 0) && ((listOfNumbers[i] % 3) != 0)) //
                {
                    yield return listOfNumbers[i]; //определяем возвращаемый элемент
                }
            }       
        }
    }
}

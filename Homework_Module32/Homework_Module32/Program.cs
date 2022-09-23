using System;
using System.Collections.Generic;
using Homework_Module32;


namespace Homework_Module32 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var firstpart = new First();

            // #1
            List<string> firstListNames = new()
{
                "Dmitriy",
                "Dasha",
                "Sasha",
                "Aleksandr",
                "Masha"
};
            List<string> secondListNames = new()
{
                 "Petya",
                "Dima",
                "Sokrat",
                "Dbrinya", 
};

            firstpart.GetListUniqueNames(new List<List<string>> { firstListNames, secondListNames });
            var secondPart = new Second();
            LinkedList<int> numberLinkedList = secondPart.CreateIntLinkedListWithValues(100_000, 0, 100);
            secondPart.SwapEvenOdd(numberLinkedList);
            var thirdPart = new Third();
            thirdPart.GetSymbolsCountInString("dsldlsdlsdlsdlsldlsslsdlsdldl");
            List<int> numberList = new()
                {
                     1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
                };
            var testClass = new TestClass(numberList);

            foreach (int number in testClass.GetEnumerable())
            {

                Console.WriteLine(number);
            }
        }
    }
  }


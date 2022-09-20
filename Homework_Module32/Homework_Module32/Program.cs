using System;
using System.Collections.Generic;


namespace Homework_Module32 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            #region[1st Task Normal]
            List<string> namesInList1 = new List<string>()
{
    "Dima",
    "Dasha",
    "Vasya"
};

            List<string> namesInList2 = new List<string>()
{
    "Kolya",
    "Mikle",
    "Dobrinya"
};

            List<string> namesInList3 = new List<string>()
{
    "Dima",
    "Olya",
    "Evgeniy",
    "Petr",
    "Anna",
    "Dima"
};

            void GetHashNames(List<string> list)
            {
                var uniqueNamesOfHashSet = new HashSet<string>(list);

                Console.WriteLine("Unique Names of HashSet: ");

                foreach (var name in uniqueNamesOfHashSet)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine($"Unique Numbers of Unique Names is:{uniqueNamesOfHashSet.Count} ");
            }
            GetHashNames(namesInList1);
            GetHashNames(namesInList2);
            GetHashNames(namesInList3);

            HashSet<List<string>> hashSetTest = new HashSet<List<string>>()
            {
                namesInList1,
                namesInList2,
                namesInList3
            };
            foreach (var item in hashSetTest)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Количество уникальных листов в Хешсете2:{hashSetTest.Count}");
            #endregion
            #region[2nd Task LinkedList]
            //LinkedList<int> numberLinkedList = LinkedListNumbersCreate(100000, 0, 100); 
            LinkedList<int> numberLinkedList = LinkedListNumbersCreate(20, 0, 100);// ДЛЯ ПРОВЕРКИ
            ZamenaEvenOdd(numberLinkedList);
            //numbers.AddLast(1);
            //numbers.AddFirst(2);
            //numbers.AddAfter(numbers.Last, 3);

            foreach (var item in numberLinkedList)
            {
                Console.WriteLine($"PROVERKA 2nd Taska=) {item}");
            }

            void ZamenaEvenOdd(LinkedList<int> list)
            {
                var TekuscheeZnach = list.First;

                for (int i = 1; i < list.Count; i++)
                {
                    var prediduscheeValue = TekuscheeZnach?.Previous?.Value;
                    var sleduyuscheeValue = TekuscheeZnach?.Next?.Value;
                    bool sledValueEven = (sleduyuscheeValue != null && (sleduyuscheeValue % 2) == 0);
                    bool predValueOdd = (prediduscheeValue != null && (prediduscheeValue % 2) != 0);

                    if (sledValueEven && predValueOdd)
                    {
                        int? tempPredidusch = prediduscheeValue;
                        int? tempSleduyusch = sleduyuscheeValue;

                        sleduyuscheeValue = tempPredidusch;
                        prediduscheeValue = tempSleduyusch;

                        Console.WriteLine($"Текущий индекс: {i}, Текущее значение: {TekuscheeZnach?.Value}");
                    }

                    TekuscheeZnach = TekuscheeZnach?.Next;
                }
            }

            LinkedList<int> LinkedListNumbersCreate(int CountOfNumbers, int Min, int Max)
            {
                LinkedList<int> list = new LinkedList<int>();

                for (int i = 1; i < CountOfNumbers; i++)
                {
                    var NumberRND = rnd.Next(Min, Max);
                    list.AddLast(NumberRND);
                }

                return list;
            }
            #endregion
            #region[3rd Task]
            GetCountOfSymbolsInString("arggarrgaarrgarggaragaarrga");
            void GetCountOfSymbolsInString(string test)
            {
                Dictionary<char, int> symbolsInString = new Dictionary<char, int>();

                foreach (char currentZn in test)
                {
                    if (symbolsInString.TryGetValue(currentZn, out int count)) //true, если Dictionary<TKey,TValue> содержит элемент с указанным ключом, в противном случае — false.
                    {
                        symbolsInString[currentZn] += 1;
                    }
                    else
                    {
                        symbolsInString.Add(currentZn, 1);
                    }
                }

                foreach (var item in symbolsInString)
                {
                    Console.WriteLine($@"symbol '{item.Key}': {item.Value} times");
                }
                #endregion
            #region[Task 4]
                // List<int> numberList = ListNumbersCreate(25, 1, 5);
                List<int> listOfNumbers = new List<int>() {4,5,6,7,8,9,10,11,12,13,14,15,16,17,18};
                var TestClass = new TestClass(listOfNumbers);

                foreach (int number in TestClass.GetEnum())
                {
                    Console.WriteLine(number);
                }

                //List<int> ListNumbersCreate(int CountOfNumbers, int Min, int Max)
                //{
                //    List<int> numlist = new List<int>();

                //    for (int i = 1; i < CountOfNumbers; i++)
                //    {
                //        var NumberRND = rnd.Next(Min, Max);
                //        numlist.Add(NumberRND);
                //    }
                //    foreach (int number in numlist)
                //    {
                //        Console.WriteLine(number);
                //    }

                //    return numlist;
                //}
                #endregion
        }
    }
  }
}

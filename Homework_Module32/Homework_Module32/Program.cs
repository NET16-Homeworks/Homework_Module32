using Homework_Module32;

#region Task 1
//List<string>[] names = new List<string>[]
//{
//    new List<string> {"Alice", "Bob", "Mike", "Anya", "Bob"},
//    new List<string> {"Mike", "Anya", "Alice", "Bob", "Alice"},
//    new List<string> {"Kira", "Lex", "Bob", "Jera", "Isaac"}
//};

//ShowUsUniqueNames(names);


//#region Classes for Task 1
//void ShowUsUniqueNames(List<string>[] listNames)
//{
//    int counter = 0;
//    foreach (var listName in listNames)
//    {
//        counter++;
//        _listProcessionUniqueNames(listName, counter);
//    }
//}

//void _listProcessionUniqueNames(List<string> names, int listNum)
//{
//    HashSet<string> uniqueNames = new HashSet<string>();
//    HashSet<string> ununiqueNames = new HashSet<string>();
//    foreach (var name in names)
//    {
//        if (!uniqueNames.Add(name))
//        {
//            ununiqueNames.Add(name);
//        }
//    }
//    foreach (var name in ununiqueNames)
//    {
//        uniqueNames.Remove(name);
//    }
//    if (uniqueNames.Count != 0)
//    {
//        Tabs();
//        Console.WriteLine($"List №{listNum} unique names:");
//        Tabs();
//        foreach (var name in uniqueNames)
//        {
//            Console.Write($"| {name}\t");
//        }
//        Console.WriteLine();
//        Tabs();
//        Console.WriteLine($"Total names: {uniqueNames.Count}");
//        Tabs();
//    }
//    else
//    {
//        Console.WriteLine("Unique names is not exist in this list!");
//    }
//}

//void Tabs()
//{
//    Console.WriteLine("-----------------------------");
//}
#endregion 

#region Task 2

//LinkedListSwap(100_000);

//void LinkedListSwap(int howMuchNumbers)
//{
//    Random random = new Random();
//    LinkedList<int> numbers = new LinkedList<int>();
//    for (int i = 0; i < howMuchNumbers; i++)
//    {
//        numbers.AddLast(random.Next(0, 100));
//    }

//    LinkedListNode<int> node;

//    int index = 0;
//    for (node = numbers.First; node != null; node = node.Next)
//    {
//        if (node.Next != null && node.Previous != null)
//        {
//            //Console.WriteLine($"{node.Previous.Value} | {node.Value} | {node.Next.Value}");

//            if (node.Previous.Value % 2 == 1 && node.Next.Value % 2 == 0)
//            {
//                var temp = node.Previous.Value;
//                node.Previous.Value = node.Next.Value;
//                node.Next.Value = temp;
//                Console.WriteLine($"Индекс иттерации - {index}, значение - {node.Value}");
//                //Console.WriteLine($"{node.Previous.Value} | {node.Value} | {node.Next.Value}");

//            }

//        }
//        index++;
//    }
//}
#endregion

#region Task 3
//StringChecker("Эта строка проверит правильность выполнения кода");


//void StringChecker(string text)
//{
//    char[] chars = text.ToCharArray();
//    Dictionary<char, int> dictionaryChars = new Dictionary<char, int>();
//    foreach (var character in chars)
//    {
//        if (dictionaryChars.ContainsKey(character))
//        {
//            dictionaryChars[character]++; 
//        }
//        else
//        {
//            dictionaryChars.Add(character, 1);
//        }  
//    }
//    foreach (var character in dictionaryChars)
//    {
//        Console.WriteLine($"\"{character.Key}\" символ содержится в строке {character.Value} раз(a).");
//    }
//}
#endregion

#region Task 4
Stack<int> numbers = new Stack<int>();
numbers.Push(0);
numbers.Push(1);
numbers.Push(2);
numbers.Push(3);
numbers.Push(4);
numbers.Push(5);
numbers.Push(6);
numbers.Push(8);
numbers.Push(12);
NumberExtractor numberExtractor = new NumberExtractor(numbers);
foreach (var number in numberExtractor)
{
    Console.WriteLine(number);
}
#endregion
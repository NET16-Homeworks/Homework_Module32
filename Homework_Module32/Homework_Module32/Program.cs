using Homework_Module32.Classes;

List<int> numberList = new()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
};
var yieldClass = new YieldClass(numberList);

foreach (int number in yieldClass.GetEnumerable())
{

    Console.WriteLine(number);
}

List<string> namesList = new()
{
    "Сеня", "Саня", "Александр", "Антон", "Саня", "Тоха", "Александр", "Сергей"
};
LinkedList<int> numberLinkedList = CreateIntLinkedListWithValues(100_000, 0, 100);
GetListUniqueNames(namesList);
SwapEvenOdd(numberLinkedList);
GetSymbolsCountInString("asdasagasfasdasdasdasf");
void GetListUniqueNames(List<string> list)
{
    var uniqueNames = new HashSet<string>(list);

    Console.WriteLine("List of unique names: ");

    foreach (var name in uniqueNames)
    {
        Console.WriteLine(name);
    }
}
LinkedList<int> CreateIntLinkedListWithValues(int numberOfValues, int minValue, int maxValue)
{
    LinkedList<int> list = new();

    var random = new Random();
    for (int i = 1; i < numberOfValues; i++)
    {
        var randomNumber = random.Next(minValue, maxValue);
        list.AddLast(randomNumber);
    }

    return list;
}
void SwapEvenOdd(LinkedList<int> list)
{
    var currentValue = list.First;

    for (int i = 1; i < list.Count; i++)
    {
        var prevValue = currentValue?.Previous?.Value;
        var nextValue = currentValue?.Next?.Value;
        bool isNextValueEven = (nextValue != null && (nextValue % 2) == 0);
        bool isPrevValueOdd = (prevValue != null && (prevValue % 2) != 0);

        if (isNextValueEven && isPrevValueOdd)
        {
            int? tempPrev = prevValue;
            int? tempNext = nextValue;

            nextValue = tempPrev;
            prevValue = tempNext;

            Console.WriteLine($"current index: {i}, current value: {currentValue?.Value}");
        }

        currentValue = currentValue?.Next;
    }
}
void GetSymbolsCountInString(string @string)
{
    Dictionary<char, int> symbols = new();

    foreach (char currentSymbol in @string)
    {
        if (symbols.TryGetValue(currentSymbol, out int count))
        {   
            symbols[currentSymbol] += 1;
        } else
        {
            symbols.Add(currentSymbol, 1);
        }
    }

    foreach (var item in symbols)
    {
        Console.WriteLine($@"symbol '{item.Key}': {item.Value} times");
    }
}
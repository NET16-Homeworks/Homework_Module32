using Homework_Module32.Classes;
using Homework_Module32.Tasks;

var tasks = new HomeTask();

// #1
List<string> namesList1 = new()
{
    "Сеня", "Саня", "Александр", "Антон", "Саня", "Тоха", "Александр", "Сергей"
};
List<string> namesList2 = new()
{
    "Вася", "Петя", "Гриша", "Вася", "Саня", "Петя", "Александр", "Веня"
};

tasks.GetListUniqueNames(new List<List<string>> { namesList1, namesList2 });

// #2
LinkedList<int> numberLinkedList = tasks.CreateIntLinkedListWithValues(100_000, 0, 100);
tasks.SwapEvenOdd(numberLinkedList);

// #3
tasks.GetSymbolsCountInString("asdasagasfasdasdasdasf");

// #4 

List<int> numberList = new()
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    10,
    11,
    12,
    13,
    14,
    15,
    16,
    17,
    18,
    19,
    20,
    21,
    22,
    23,
    24,
    25,
};
var yieldClass = new YieldClass(numberList);

foreach (int number in yieldClass.GetEnumerable())
{

    Console.WriteLine(number);
}
using Homework_Module32;

#region Task 1
Task_1 task_1 = new Task_1();

List<string>[] names = new List<string>[]
{
    new List<string> {"Alice", "Bob", "Mike", "Anya", "Bob"},
    new List<string> {"Mike", "Anya", "Alice", "Bob", "Alice"},
    new List<string> {"Kira", "Lex", "Bob", "Jera", "Isaac"}
};

task_1.ShowUsUniqueNames(names);
#endregion 

#region Task 2
Task_2 task_2 = new Task_2();

task_2.LinkedListSwap(100);
#endregion

#region Task 3
Task_3 task_3 = new Task_3();

task_3.StringChecker("Эта строка проверит правильность выполнения кода");
#endregion

#region Task 4
List<int> numbers = new List<int>() { 2, 4, 5, 7, 9, 12, 16, 20 };

NumberExtractor numberExtractor = new NumberExtractor(numbers);
foreach (var number in numberExtractor)
{
    Console.WriteLine(number);
}
#endregion
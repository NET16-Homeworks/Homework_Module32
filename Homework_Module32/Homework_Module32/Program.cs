// See https://aka.ms/new-console-template for more information

using Homework_Module32;
using System;
using System.Collections.Generic;
Console.WriteLine("================ Task 1 =======================");
Task1 task1 = new Task1();
task1.ListsWithUsernames(task1.arrayWithListsOfUsernames);
Console.WriteLine("================ Task 2 =======================");
Task2 task2 = new Task2();
task2.SwapNumbers(task2.numbers);
Console.WriteLine("================ Task 3 =======================");
Task3 task3 = new Task3();
task3.SearchUniqueChars(task3.str);
Console.WriteLine("================ Task 4 =======================");
Task4 task4 = new Task4(new int[]
{
    1,2, 3, 4, 5, 6, 7,
}); 
foreach(var number in task4.ReturnNumbers())
{
    Console.WriteLine(number);
}

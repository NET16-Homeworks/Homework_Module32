using Homework_Module32;
using System;
using System.Collections.Generic;
using System.Collections;

var task1 = new Task1();

List<string>[] ListofNames = new List<string>[]
{
    new List<string> {"Павел", "Кирилл", "Света", "Таня", "Саша", "Сергей", "Света", "Павел", "Антон", "Антон"},
    new List<string> {"Павел", "Женя", "Оля", "Таня", "Кеша", "Сергей", "Света", "Павел", "Дима", "Антон", "Дима", "Павел"}
};
task1.UniqueNames(ListofNames);

var task2 = new Task2();
LinkedList<int> LinkedList = task2.RandomNumbers();
task2.ChangePosition(LinkedList);

var task3 = new Task3();
string s = "Для ссылочных типов допускается значение null";
Console.WriteLine(s);
task3.OriginSymbols(s);

Console.WriteLine("Task 4");
Random random = new Random();
int[] Arr = new int[100];
for (int i = 0; i < 100; i++)  
{
    Arr[i] = random.Next(0, 100);    
}
var task4 = new Task4(Arr);
Console.WriteLine("Числа в обратном порядке из массива, которые не делятся на 2 или 3:");
foreach (var integer in task4)
{
    Console.WriteLine(integer);
}









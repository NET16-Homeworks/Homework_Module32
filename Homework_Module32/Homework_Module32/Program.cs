// See https://aka.ms/new-console-template for more information

using Homework_Module32;
using System;
using System.Collections.Generic;
using System.Collections;

Console.WriteLine("-----------Task 1-----------");
var task1 = new Task1();
List<string> [] listOfNames = new List<string>[]
{
new List<string> {"Hanna", "Neon", "Gloria" },
new List<string> {"Helen", "Solmah", "Manik"},
new List<string> {"Kostya", "Gleb", "Igar"},
};

task1.GetNames(listOfNames);

Console.WriteLine("-----------Task 2-----------");
var task2 = new Task2();

//task2.GetRandomNumbers(0, 100);
var rn = task2.GetRandomNumbers(0, 100);
task2.GetIndexAndValueOfIteration(rn);

Console.WriteLine("-----------Task 3 with LINQ-----------");
var task3 = new Task3();

task3.GetSymbolsAndCount("GesPacchhoolinnika");

Console.WriteLine("-----------Task 3-----------");
var task3b = new Task3();

task3b.GetSymbolsAndCountArray("GesPacchhoolinnika");

Console.WriteLine("-----------Task 4-----------");
int[] array = new int[] {1,2,3,5,7,11,15};
var task4 = new Task4(array);

foreach (var integer in task4)
{
    Console.WriteLine(integer);
}

task4.GetElementsOfTheArray();
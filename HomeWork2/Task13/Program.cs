﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6


using static System.Console;

Clear();
Write("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a>99) 
{
    int a1 = a/100;
    int a2 = a1%10;
    WriteLine(a2);
}
else 
{
    WriteLine("Третьей цифры нет");
}


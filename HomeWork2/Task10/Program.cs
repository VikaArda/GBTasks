﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using static System.Console;

Clear();
int number = new Random().Next(100,1000);
WriteLine(number);
int a1 = number/10;
int a2 = a1%10;
WriteLine(a2);




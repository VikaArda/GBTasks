﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

using static System.Console;

int max = 0;

Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(ReadLine());

Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(ReadLine());

Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(ReadLine());

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

WriteLine("max = " + max);
﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

using static System.Console;

Write("Введите число: ");
int day = Convert.ToInt32(ReadLine());

if (day <=7 && day>=1)
{
    WriteLine(day==6|day==7?"Выходной":"Рабочий день");
}
else 
{
    WriteLine("Этого дня недели не существует");
}

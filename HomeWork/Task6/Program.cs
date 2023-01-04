//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

using static System.Console;

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

int a = number % 2;

if(a % 2 == 0)
{
    WriteLine("Четное");
}
else
{
    WriteLine("Нечетное");
}

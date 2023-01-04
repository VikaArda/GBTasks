//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using static System.Console;

int max = 0;
int min = 0;

Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(ReadLine());

Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(ReadLine());

if(firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber; 
}
WriteLine("max =" + max  + " " + "min =" + min);

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

using static System.Console;

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

int a = 2;

if(number > 1)
{
    while(a <= number)
    {
        Write(a + " ");
        a = a + 2;
    }
}

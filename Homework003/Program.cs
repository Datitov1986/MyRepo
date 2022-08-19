using System;

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if(x % 2 == 1)
{
    Console.WriteLine("Ваше число нечетное ");
}
else
{
    Console.WriteLine("Ваше число четное ");
}
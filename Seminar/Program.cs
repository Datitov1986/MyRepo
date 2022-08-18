using System;

Console.WriteLine("Введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());

if(x*x==y)
{
    Console.Write("Является квадратом второго числа");
}
else
{
    Console.Write("Не является квадратом первого числа");
}
using System;

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.Write("Первое число больше ");
}
else if(x==y)
{
    Console.Write("Да числа-то одинаковые! ");
}
else if(x < y)
{
    Console.Write("Второе число больше ");
}
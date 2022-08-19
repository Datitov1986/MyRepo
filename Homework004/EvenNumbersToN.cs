using System;

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = 0;

while(x < N - 1)
{
    x = x + 2;
    Console.Write(x);
    Console.Write(", ");
}
Console.WriteLine(" как-то так");
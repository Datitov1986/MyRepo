using System;
Console.Write("Ведите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = -N;
while(x <= N)
{
    Console.Write(x);
    Console.Write(", ");
    x++;
}
Console.WriteLine("Something Like That");
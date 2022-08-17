using System;

int numberA = new Random().Next(1,10); //new Random().Next() добавляет случайное 
//число из заданного диапазона включая первое число и второе число -1. В данном примере числа 1,2,3,4....9
Console.Write("Первое число: ");
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.Write("Второе число: ");
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.Write("Результат сложения двух чисел: ");
Console.WriteLine(result);

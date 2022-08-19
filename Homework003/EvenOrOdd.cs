using System;

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if(x % 2 == 0) // %2 == 0 показывает остаток от деления на 2, если он равен 0, значит число четное. 
//Также можно вместо 2 поставить любое число и вывести остаток от него 
{
    Console.WriteLine("Ваше число четное ");
}
else
{
    Console.WriteLine("Ваше число нечетное ");
}
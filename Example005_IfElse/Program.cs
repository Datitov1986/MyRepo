using System;

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //Команда ToLower() позволяет игнорировать регистр букв
    {
        Console.WriteLine("Ура! Это же Маша!");
    }
else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }


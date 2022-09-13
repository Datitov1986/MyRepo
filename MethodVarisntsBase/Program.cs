//Вид 1 (функция, которая ничего не принимает и не возвращает)

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
//Method1();

//Вид 2 (ничего не возвращают, но принимают значения)

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
//Method2("Текст сообщения"); //неименованные аргументы

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //Инкремент
//     }
// }
//Method21("Текст", 4);
//Method21(msg: "Текст",count: 4); //именованные аргументы, не обязательно писать их по порядку Method21(count: 4, msg: "Текст");

//Вид 3 (функция что-то возвращает)

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
//Console.WriteLine(year);


//Вид 4 (Что-то принимают и что-то возвращают)

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "adsf");
Console.WriteLine(res);
//Цикл while и цикл for (цикл со счетчиком) собирает в себе все данные
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }


// string Method4(int count, string text)
// {
//     //int i = 0;
//     string result = String.Empty; //пустая строка
//     for (int i = 0; i < count; i++)
//     //while (i < count)
//     {
//         result = result + text;
//         //i++;
//     }
//     return result;
// }
// string res = Method4(10, "adsf");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}"); //интерполяция строк
//     }
//     Console.WriteLine();
// }

//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

//Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
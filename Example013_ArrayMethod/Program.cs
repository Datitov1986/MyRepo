using System.Reflection.Emit;
using System.Data;
using System.Collections;
using System.Collections.ObjectModel;
using System;

void FillArray(int[] collection) // void метод, который не возвращает значения -> не нужно использовать оператор return
{

    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {

        Console.Write(col[position] + ", ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // ставлю значение -1 чтобы, в случае если нет элемента удовлетворяющего условию
    //появлялось значение -1, что будет означать что такой элемент не найден
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}
int[] array = new int[10];// new int[10] - Создай новый массив, в котром будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine("Ваша позиция: " + pos);

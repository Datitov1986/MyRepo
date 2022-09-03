// string[,] table = new string[2, 5];          // new int[5 - количество строк, 8 - количество столбцов];
// table[1, 2] = "Слово";

// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }




void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)        //int[,] matrix = new int[5 - строки matrix.GetLength(0), 8 - столбцы matrix.GetLength(1)];
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10); //  [1;10)
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
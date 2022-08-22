//Дана квадратная матрица.
//Проверить является ли она симметричной отностительно главной диагонали.

using System;
{
    string s = Console.ReadLine();
    int N = int.Parse(s.Split(' ')[0]);
    int M = N;
    int[,] matrix = new int[N, M];
    bool flag = true;

    CreateArray(matrix);
    PrintArray(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != matrix[j, i])
            {
                flag = false;
                break;
            }
        }
    }
    if (flag != false) System.Console.WriteLine("Матрица симметрична");
    else System.Console.WriteLine("Матрица не симметрична");

    void CreateArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            s = Console.ReadLine();
            string[] ss = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(ss[j]);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j],4} ");
            }
            System.Console.WriteLine();
        }
    }

}

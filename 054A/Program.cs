/*Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

7 4 2 1
9 5 3 2
8 4 4 2
*/

using System;
{
    string s = Console.ReadLine();
    int N = int.Parse(s.Split(' ')[0]);
    int M = int.Parse(s.Split(' ')[1]);
    int[,] a = new int[N, M];

    for (int i = 0; i < N; i++)
    {
        s = Console.ReadLine();
        string[] ss = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < ss.Length; j++)
        {
            a[i, j] = int.Parse(ss[j]);
        }
    }

    int temp = 0;
    //PrintArray(a);
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = j + 1; k < a.GetLength(1); k++)
            {
                if (a[i, j] < a[i, k])
                {
                    temp = a[i, j];
                    a[i, j] = a[i, k];
                    a[i, k] = temp;
                }
            }
        }
    }

    PrintArray(a);

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

/*Даны две квадратных таблице чисел. Требуется построить третью, каждый
элемент которой равен сумме элементов, стоящих на том же месте в 1-й и 2-й
таблицах.

Входные данные
Во входном файле записано сначала число N, затем записана первая таблица,
а после нее вторая.Элементы таблиц числа от 0 до 100.
100>=N>=1
*/

using System;
{
    string s = Console.ReadLine();
    int N = int.Parse(s.Split(' ')[0]);
    int M = N;
    int[,] a = new int[N, M];
    int[,] b = new int[N, M];
    int[,] c = new int[N, M];

    CreateArray(a);
    System.Console.WriteLine();
    CreateArray(b);
    System.Console.WriteLine();

    for (int i = 0; i < c.GetLength(0); i++)
    {
        for (int j = 0; j < c.GetLength(1); j++)
        {
            c[i, j] = a[i, j] + b[i, j];
        }
    }

    PrintArray(c);

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

/*Диагональки

В квадратной таблице NxN подсчитать суммы чисел, стоящих на диагоналях.

Входные данные
Во входном файле содержится число N (100>=N>=1), а затем матрица NxN.
Элементы матрицы - числа из диапазона integer.

Выходные данные
В выходной файл выдать сначала сумму чисел на главной,
а затем - на побочной диагонали.

Пример входного файла
3
1 2 3
4 5 6
10 9 8

Пример выходного файла
14 18
*/

using System;
{
    string s = Console.ReadLine();
    int N = int.Parse(s.Split(' ')[0]);
    int M = N;
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

    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        sum1 = sum1 + a[i, i];
        sum2 = sum2 + a[i, a.GetLength(1) - 1 - i];
    }$"{sum1} {sum2}"

    System.Console.WriteLine();
}



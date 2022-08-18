/*Нолики

В матрице найти положение первого нулевого элемента.

Входные данные
Формат входных данных такой же, как в предыдущей задаче.
Хотя бы один нулевой элемент в матрице всегда существует.

Выходные данные
Вывести сначала номер строки, а затем - номер столбца нулевого элемента.
Если в матрице несколько нулей, выдать позицию любого из них.

Пример входного файла
3 4
0 1 2 3
4 5 0 1
2 3 4 5

Пример выходного файла
2 3
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

    int x = 0;
    int y = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] == 0)
            {
                x = i;
                y = j;
            }
            break;
        }
    }
    System.Console.WriteLine($"{x+1} {y+1}");
}





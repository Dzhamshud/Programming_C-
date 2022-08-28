/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/

System.Console.WriteLine(A(3,2));
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (n > 0) return A(m - 1, A(m, n - 1));
    else return A(m - 1, 1);
}


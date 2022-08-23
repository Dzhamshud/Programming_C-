//Написать программу вычисления функции Аккермана - 5*
//методом рекурсий

System.Console.WriteLine(A(3,5));
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (n > 0) return A(m - 1, A(m, n - 1));
    else return A(m - 1, 1);
}

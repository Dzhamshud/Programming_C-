//Найти сумму элементов от M до N, N и M заданы - 1
//методом рекурсий

System.Console.WriteLine(S(1, 10));

int S(int m, int n)
{
    if (m < n) return S(m + 1, n) + m;
    else return m;
}

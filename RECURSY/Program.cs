//Возведение a в степень b методом рекурсии
int P(int a, int b)
{
    if (b==0)return 1;
    if (b%2!=0) return P(a, b-1)*a;
    else return P(a,b/2)*P(a,b/2);
}

System.Console.WriteLine(P(2,8));



// Вывести числа от 1 до N без использования циклов
/*
Loop(1, 10);
void Loop(int i, int N)
{
    System.Console.WriteLine(i);
    if (i < N) Loop(i + 1, N);
    else return;
}


//Вычисление факториала методом рекурсии

System.Console.WriteLine(F(5));
int F(int n)
{
    if (n > 0) return F(n - 1) * n;
    else return 1;
}
*/
//Найти сумму цифр числа - 2
//методом рекурсий

System.Console.WriteLine(S(2578));

int S(int n)
{
    if(n>0) return n%10+S(n/10);
    else return 0;
}

//Написать программу возведения числа А в целую степень B - 3
//методом рекурсии
int P(int a, int b)
{
    if (b==0)return 1;
    else return P(a,b-1)*a;
}

System.Console.WriteLine(P(2,8));
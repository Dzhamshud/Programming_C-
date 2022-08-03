//Выяснить являются ли три числа сторонами треугольника

double a=2, b=3, c=2;
System.Console.WriteLine(IsTriangle(a,b,c));


bool IsTriangle(double a, double b, double c)
{
    return (a+b>c && b+c>a && a+c>b);
}
//С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a, b, c;
System.Console.WriteLine("ВВедите число a ");
string? s1 = Console.ReadLine();
a = Convert.ToInt32(s1);
System.Console.WriteLine("ВВедите число b ");
string? s2 = Console.ReadLine();
b = Convert.ToInt32(s2);
System.Console.WriteLine("ВВедите число c ");
string? s3 = Console.ReadLine();
c = Convert.ToInt32(s3);

if (a > b)
{
    if (a > c)
    {
        System.Console.WriteLine("Число a максимальное");
    }
    else System.Console.WriteLine("Число c максимальное");
}
else if (b > c)
{
    System.Console.WriteLine("Число b максимальное");
}
else System.Console.WriteLine("Число c максимальное");
//С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a, b;
System.Console.WriteLine("ВВедите число a ");
string? s1=Console.ReadLine();
a=Convert.ToInt32(s1);
System.Console.WriteLine("ВВедите число b ");
string? s2=Console.ReadLine();
b=Convert.ToInt32(s2);

if(a>b)
{
    System.Console.WriteLine("Число a максимальное");
}
else System.Console.WriteLine("Число b максимальное");
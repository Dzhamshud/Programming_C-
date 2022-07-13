//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b,
//если нет, вывести остаток от деления a на b.
int a, b, c;
System.Console.WriteLine("ВВедите число a ");
string? s1=Console.ReadLine();
a=Convert.ToInt32(s1);
System.Console.WriteLine("ВВедите число b ");
string? s2=Console.ReadLine();
b=Convert.ToInt32(s2);
bool x;
x=a%b==0;
if(x)
{
    System.Console.WriteLine("a кратно b");
}
else System.Console.WriteLine($"Остаток от деления a на b: {c=a%b}");

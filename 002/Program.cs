//С клавиатуры вводятся два вещественных числа.
//Проверять является ли одно из них квадратом второго

int a,b;
string? s1=Console.ReadLine();
a=Convert.ToInt32(s1);
string? s2=Console.ReadLine();
b=Convert.ToInt32(s2);

if (a*a==b)
{
    System.Console.WriteLine("b является квадратом a");
}
else
{
    if (b*b==a)
    {
       System.Console.WriteLine("a является квадратом b"); 
    }
    else
    {
        System.Console.WriteLine("числа не являются квадратами друг друга");
    }
}
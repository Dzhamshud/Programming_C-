//Выяснить является ли число чётным.
bool x;
int number;
System.Console.WriteLine("Введите число ");
string? s = Console.ReadLine();
number = Convert.ToInt32(s);
x = number % 2 == 0;

if (x)
{
    System.Console.WriteLine("Число четное ");
}
else System.Console.WriteLine("Число не четное ");
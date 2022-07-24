//Программа проверяет пятизначное число на палиндромом.
int number = 12321;
bool x, y;
int a = number % 10, b = number / 10 % 10, c = number / 1000 % 10, d = number / 10000 % 10;
//System.Console.WriteLine($"{a}, {b}, {c}, {d}");
x = a == d;
y = b == c;
if (x & y)
{
    System.Console.WriteLine($"Число {number} является палиандромом");
}
else System.Console.WriteLine($"Число {number} не является палиандромом");
//С клавиатуры вводится целое число из  диапазона  [10, 99].
//Показать наибольшую цифру числа
int number, a, b;
System.Console.WriteLine("Введите целое число в диапазоне [10, 99] ");
string? s = Console.ReadLine();
number = Convert.ToInt32(s);

a = number % 10;
b = number / 10 % 10;

if(a>b)
{
    System.Console.WriteLine($"Наибольшая цифра числа: {a}");
}
else System.Console.WriteLine($"Наибольшая цифра числа: {b}");
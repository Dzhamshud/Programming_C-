//С клавиатуры вводится целое число.
//Вывести третью цифру числа или сообщить, что её нет.
int number, a, b;
System.Console.Write("Введите целое число: ");
string? s = Console.ReadLine();
number = Convert.ToInt32(s);

int CountDigits(int N)
{
    int k = 0;
    while (N != 0)
    {
        k++;
        N = N / 10;
    }
    return k;
}
b = CountDigits(number);

a = number / 100 % 10;

if (b < 3)
{
    System.Console.WriteLine("В числе нет третьей цифры");
}
else System.Console.WriteLine(a);
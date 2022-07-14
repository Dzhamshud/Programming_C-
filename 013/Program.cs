//Удалить вторую цифру целого числа введенного с клавиатуры.
int number, a, b, c;
System.Console.WriteLine("Введите целое число: ");
string? s = Console.ReadLine();
number = Convert.ToInt32(s);

a = number % 10;
b = number / 10 % 10;
c = number / 100;
number = int.Parse(c.ToString()+a.ToString());
System.Console.WriteLine(number);
//Вывести на экран последнюю цифру целого числа введенного с клавиатуры.
int a, b;
System.Console.WriteLine("Введите целое число ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
b = a % 10;
System.Console.Write("Последняя цифра целого числа: ");
System.Console.WriteLine(b);
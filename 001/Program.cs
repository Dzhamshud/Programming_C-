// See https://aka.ms/new-console-template for more information
//комментарии
/*
Console.WriteLine("Hello, World!");
System.Console.WriteLine(11%3);
*/

//С клавиатуры вводится целое число. Вывести квадрат числа
double a;
double b;
string? s=Console.ReadLine();//ввод данных
a=Convert.ToDouble(s);

b=a*a;//обработак данных

//вывод результата
System.Console.WriteLine($"{a}^2={b}");//строка интерполяции


/*string? s;//объявили переменную
s=Console.ReadLine();//присвоили переменную
System.Console.WriteLine(s);
*/
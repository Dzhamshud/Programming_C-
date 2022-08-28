/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 5, 6, 7, 8""
*/

System.Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine());
System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());

for (int i = M; i < N+1; i++)
{
    System.Console.Write($"{i} ");
}
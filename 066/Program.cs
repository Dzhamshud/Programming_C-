/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
System.Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine());
System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = M; i < N+1; i++)
{
    sum = sum + i;
}

System.Console.WriteLine(sum);
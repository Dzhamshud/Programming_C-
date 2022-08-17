/*Вводится сначала число N, а затем N чисел.
Выведите эти N чисел в обратном порядке.

Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

Выходные данные
Выведите N чисел в обратном порядке

Пример входного файла
7
2 4 1 3 5 3 1

Пример выходного файла
1 3 5 3 1 4 2
*/

using System;

int n=int.Parse(Console.ReadLine());//вводим с клавиатуры 1 строку(N)
string s=Console.ReadLine();//вводим с клавиатуры 2 строку(массив)
string[] a=s.Split(' ', StringSplitOptions.RemoveEmptyEntries);//преобразуем строку в массив строк
//int[] a=Array.ConvertAll<string, int>(ss, int.Parse);//преобразуем массив строк в массив int

/*for (int i = 0; i < a.Length/2; i++)
{
    string temp=a[i];
    a[i]=a[a.Length-i-1];
    a[a.Length-i-1]=temp;
}
*/
for (int i = a.Length-1; i >=0; i--)
{
    System.Console.Write(a[i] + " ");
}
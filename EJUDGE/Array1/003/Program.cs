/*Вводится сначала число N, а затем N чисел. Выведите эти N чисел
в следующем порядке: сначала выводятся числа, стоящие на нечетных местах,
а затем - стоящие на четных местах. Нумерация элементов начинается с 1.

Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

Входные данные
7
2 4 1 3 5 3 1

Результат работы
4 3 3 2 1 5 1
*/

using System;//подключаем пространство имен

int n=int.Parse(Console.ReadLine());//вводим с клавиатуры 1 строку(N)
string s=Console.ReadLine();//вводим с клавиатуры 2 строку(массив)
string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries);//преобразуем строку в массив строк
int[] a=Array.ConvertAll<string, int>(ss, int.Parse);//преобразуем массив строк в массив int
int temp = 0;
for (int i = 0; i < a.Length; i=i+2)
{
    System.Console.Write(a[i] + " ");
}

for (int j = 1; j < a.Length; j=j+2)
{
    System.Console.Write(a[j] + " ");
}


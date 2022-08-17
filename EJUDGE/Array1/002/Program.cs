/*Вводится сначала число N, а затем N чисел.
Выведите эти N чисел в следующем порядке:
сначала выводятся все нечетные числа в том порядке,
в каком они встречались во входном файле, а затем - все четные.

Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.

Пример входного файла
7
2 4 1 3 5 3 1

Пример выходного файла
1 3 5 3 1 2 4
*/

using System;//подключаем пространство имен

int n=int.Parse(Console.ReadLine());//вводим с клавиатуры 1 строку(N)
string s=Console.ReadLine();//вводим с клавиатуры 2 строку(массив)
string[] ss=s.Split(' ', StringSplitOptions.RemoveEmptyEntries);//преобразуем строку в массив строк
int[] a=Array.ConvertAll<string, int>(ss, int.Parse);//преобразуем массив строк в массив int
int temp = 0;
for (int i = 0; i < a.Length; i++)
{
    if(a[i]%2!=0)
    System.Console.Write(a[i] + " ");
}

for (int j = 0; j < a.Length; j++)
{
    if(a[j]%2==0)
    System.Console.Write(a[j] + " ");
}

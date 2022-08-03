//Задать массив из 12 элементов, заполненных числами
//из [-9, 9]. Найти сумму положительных/отрицательных
//элементов массива

/*
//Вариант решения 1.
//Инициализация массива
int N=12;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,10);

//вывод массива (до обработки)
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

//решение задачи    
int sumPositive=0;
for(int i=0;i<a.Length;i++)
    if (a[i]>0)
        sumPositive=sumPositive+a[i];
//вывод данных
System.Console.WriteLine(sumPositive);    

int sumNegative=0;
for(int i=0;i<a.Length;i++)
    if (a[i]<0)
        sumNegative+=a[i];
        
System.Console.WriteLine(sumNegative);
*/

//Вариант решения 2.
//инициализация массива
int[] a;
Init(out a,12,-9,9);
//вывод массива (до обработки)
Print(a);
Console.WriteLine();
//решение задачи
int sumPositive;
int sumNegative;
Solve(a,out sumPositive, out sumNegative);
//Вывод результатов
System.Console.WriteLine(sumPositive);
System.Console.WriteLine(sumNegative);

void Init(out int[] t, int Length,int min=0,int max=10)
{
t=new int[Length];
Random random=new Random();
for(int i=0;i<t.Length;i++)
t[i]=random.Next(min,max+1);
}

void Print(int[] t)
{
for(int i=0;i<t.Length;i++)
System.Console.Write($"{t[i],4} ");
}

void Solve(int[] a,out int sumPositive, out int sumNegative)
{
sumPositive=0;
sumNegative=0;
for(int i=0;i<a.Length;i++)
if (a[i]>0)
sumPositive=sumPositive+a[i];
for(int i=0;i<a.Length;i++)
if (a[i]<0)
sumNegative+=a[i];
}
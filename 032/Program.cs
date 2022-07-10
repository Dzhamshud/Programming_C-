//Задать массив из 8 элементов и вывести их на экран

int[] t;//Обявление массива
t=new int[8];
for(int i=0;i<t.Length;i++)
    t[i]=i*10;
for(int i=0;i<t.Length;i++)
    System.Console.Write($"a[{i}]={t[i]} ");

//Максимальная строка

//В матрице найти номер строки, сумма чисел в которой максимальна
using System;
{
    string s=Console.ReadLine();
    int N=int.Parse(s.Split(' ')[0]);
    int M=int.Parse(s.Split(' ')[1]);
    int[,] a=new int[N,M];

    for (int i = 0; i < N; i++)
    {
        s=Console.ReadLine();
        string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < ss.Length; j++)
        {
            a[i,j]=int.Parse(ss[j]);
        }
    }

    //PrintArray(a);
    int max=0;
    int index=0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
            sum=sum+a[i,j];
        }
        if (sum>max)
        {
            max=sum;
            index=i;
        }
    }

    System.Console.WriteLine(index+1);


    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j],4} ");
            }
            System.Console.WriteLine();
        }
    }
}
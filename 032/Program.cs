//Задать массив из 8 элементов и вывести их на экран

//инициализация
int[] t;//Обявление массива
Init(out t, 8, 0, 10);
//решение задачи
//вывод результатов на экран
Print(t, "t");

void Init(out int[] t, int Length, int min, int max)
{
    t=new int[Length];
    Random random= new Random();
    for(int i=0;i<t.Length;i++)
    t[i]=random.Next(min,max+1);
}

void Print(int[] t, string variableName)
{
    for(int i=0;i<t.Length;i++)
    System.Console.Write($"{variableName}[{i}]={t[i]} ");
}
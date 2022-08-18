//В двумерном массиве n×k заменить четные элементы на противоположные
//по значению (a[i,j]=-a[i,j])

int[,] a;//описываем массив

a = Init(3, 4);//Инициализация случайными числами
PrintArray(a);//вывод массива на экран
Solution(a);//Решение задачи
System.Console.WriteLine();//разделение пустой строкой
PrintArray(a);//вывод массива на экран

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

int[,] Init(int N, int M)
{
    a = new int[N, M];//создаем массив
    Random random = new Random();//Создали переменную(объект) типа Random
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(1, 11);
        }
    }
    return a;
}

void Solution(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
                array[i, j] = -array[i, j];
        }
    }
}

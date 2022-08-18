//Показать двумерный массив размером m×n заполненный целыми случайными числами

int N = 5;
int M = 4;

int[,] a;//описываем массив
a = new int[N, M];// создаем массив


//Инициализация случайными числами
Random random = new Random();//Создали переменную(объект) типа Random
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=random.Next(1,11);
    }
}


//вывод массива на экран
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        System.Console.Write($"{a[i,j]} ");
    }
    System.Console.WriteLine();
}


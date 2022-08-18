//Показать двумерный массив размером m×n заполненный вещественными
//случайными числами

int N = 5;
int M = 4;

double[,] a;//описываем массив
a = new double[N, M];// создаем массив


//Инициализация случайными числами
Random random = new Random();//Создали переменную(объект) типа Random
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=random.NextDouble()*10+3;//Конструкция ".NextDouble()" генерирует числа в диапазоне от (0,0 до 1,0]. С помощью математических операторов мы можем менять диапазон
    }
}


//вывод массива на экран
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        System.Console.Write($"{a[i,j]:F2} ");//конструкция ":F2" округляет дробное значение до двух знаков после запятой
    }
    System.Console.WriteLine();
}


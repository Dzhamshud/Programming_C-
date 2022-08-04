//Вывести на экран кубы чисел от 1 до N

int[] array;
int[] result;
Init(out array, 8, 1, 9);
Print(array);
Slave(array, out result);
System.Console.WriteLine();
Print(result);


void Init(out int[] array, int Length, int min, int max)
{
    array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(min, max + 1);
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i],4}");
}

void Slave(int[] array,out int[] result)
{
    result=new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        result[i]=Convert.ToInt32(Math.Pow(array[i], 3));
}


//С клавиатуры вводится число N. Затем вводятся N чисел.
//Определить сколько чисел больше 0 введено с клавиатуры

int N;
System.Console.WriteLine("Введите число N ");
string? s=Console.ReadLine();
N=Convert.ToInt32(s);
int[] array;
int result=0;
Init();
//Print(array);
Slave(array);


void Init()
{
    array=new int[N];
    System.Console.WriteLine($"Введите {N} чисел ");
    for (int i = 0; i < N; i++)
    {
        string? s=Console.ReadLine();
        array[i]=Convert.ToInt32(s);
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i],4}");
}

int Slave(int[] array)
{
        for (int i = 0; i < array.Length; i++)
        if (array[i]>0) result++;
    return(result);
}

System.Console.WriteLine($"Количество чисел больше 0: {result}");
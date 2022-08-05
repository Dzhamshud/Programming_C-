//С клавиатуры вводится число N. Показать первые N чисел Фибоначчи.
//Принять первые числа равными 0 и 1

int N;
System.Console.WriteLine("Введите число N ");
string? s=Console.ReadLine();
N=Convert.ToInt32(s);
int[] F;
Slave();
System.Console.WriteLine($"Последовательность Фибоначчи до числа {N} ");
Print(F);

void Slave()
{
    F = new int[N];
    F[0]=0;
    F[1]=1;
    for (int i = 2; i < N; i++)
    {
        F[i]=F[i-1]+F[i-2];
    }
}

void Print(int[] F)
{
    for (int i = 0; i < F.Length; i++)
        System.Console.Write($"{F[i],4}");
}



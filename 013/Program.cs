//Удалить вторую цифру целого числа введенного с клавиатуры.
/*
int number, a, b, c;
System.Console.WriteLine("Введите целое число: ");
string? s = Console.ReadLine();
number = Convert.ToInt32(s);

a = number % 10;
b = number / 10 % 10;
c = number / 100;
number = int.Parse(c.ToString()+a.ToString());
System.Console.WriteLine(number);
*/

//Вариант 2.Удаление с начала
int n=Convert.ToInt32(Console.ReadLine());
int k=DigitsCount(n);
int n2=n%(int)Math.Pow(10,k-2);
int n3=n/(int)Math.Pow(10,k-1);
int nn=n3*(int)Math.Pow(10,k-2)+n2;
//System.Console.WriteLine($"{n3}{n2}");
System.Console.WriteLine(nn);
//12346%1000=346
//12346/10000=1000+346
int DigitsCount(int N)
{
    if (N==0) return 1;
    int k=0;
    while(N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
}
//Написать программу преобразования десятичного числа в двоичное

int n = 16;//1111

for (int i = 0; i < 20; i++)
    System.Console.WriteLine($"{i} {DecToBin(i)}");


String DecToBin(int n)
{
    if(n==0) return "0";
    string s = "";
    while (n != 0)
    {
        s = (n % 2).ToString() + s;
        n /= 2;//n=n/2
    }
    return s;
}
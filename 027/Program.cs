//Возведите число А в натуральную степень B используя цикл

int a = 3;
int b = 4;
int result = 1;
for (int i = 0; i < b; i++)
{
    result = result * a;
}
System.Console.WriteLine(result);
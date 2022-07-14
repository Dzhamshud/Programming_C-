//Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
bool a, b;
int day = 6;
a = day == 6;
b = day == 7;

if (a || b)
{
    System.Console.WriteLine("Сегодня выходной день");
}
else
{
    System.Console.WriteLine("Сегодня будний день");
}
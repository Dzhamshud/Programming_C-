//По заданному с клавиатуры номеру дня недели вывести его название
int day;
link1:
System.Console.WriteLine("Введите день недели(число от 1 до 7) с пн по вс ");
string? s = Console.ReadLine();
day = Convert.ToInt32(s);

if(day == 1)
{
    System.Console.WriteLine("Сегодня понедельник");
}
if(day == 2)
{
    System.Console.WriteLine("Сегодня вторник");
}
if(day == 3)
{
    System.Console.WriteLine("Сегодня среда");
}
if(day == 4)
{
    System.Console.WriteLine("Сегодня четверг");
}
if(day == 5)
{
    System.Console.WriteLine("Сегодня пятница");
}
if(day == 6)
{
    System.Console.WriteLine("Сегодня суббота");
}
if(day == 7)
{
    System.Console.WriteLine("Сегодня воскресение");
}
if(day <= 0)
{
    System.Console.WriteLine("Дружище, день недели не может быть равен 0 или меньше!");
    goto link1;
}
if(day >= 8)
{
    System.Console.WriteLine("Приятель, в неделе 7 дней. Поставь цифру поменьше!");
    goto link1;
}
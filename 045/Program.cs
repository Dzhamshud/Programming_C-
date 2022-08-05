//Найти точку пересечения двух прямых заданных уравнением
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double  k1 = 2,
        k2 = 1,
        b1 = -5,
        b2 = 3;
Slave(k1, k2, b1, b2);

void Slave(double k1, double k2, double b1, double b2)
{
    double x=(b2-b1)/(k1-k2);
    double y = k1*x+b1;
    System.Console.WriteLine($"Точка пересечения двух прямых M({x};{y})");
}

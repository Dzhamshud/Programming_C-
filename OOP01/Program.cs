//Вводятся координаты двух точек x1, y1 и x2, y2
//Нужно написать подпрограмму Distance, которая находит растояние между точками
class Program
{
    struct Point
    {
        private double x, y;

        //конструктор
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double value)
        {
            if (value>10000) throw new ArgumentOutOfRangeException("Значение не может превышать 10000");
            x = value;
            y = value;
        }

        public Point(double _x, double y)
        {
            x = _x;
            this.y = y;
        }


        //публичные методы(альтернативные варианты)
        public double Getx()
        {
            return x;
        }

        public double Gety()
        {
            return y;
        }

        public void Setx(double value)
        {
            x = value;
        }

        public void Sety(double value)
        {
            y = value;
        }


        //свойства
        public double X
        {
            //акцессоры доступа
            get//чтение значения
            {
                return X;
            }
            set//запись значения
            {
                x = value;
            }
        }

        public double Y
        {
            //акцессоры доступа
            get//чтение значения
            {
                return Y;
            }
            set//запись значения
            {
                y = value;
            }
        }


        static public double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static public double Distance(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }
    }





    static void Main()
    {
        Point A, B;
        A = new Point(0, 0);//инициализация точки А
        B = new Point(1000000);
        //A.Setx(5);
        A.X=5;
        //A.x = 2;
        //A.y = 3;
        //B.x = 8;
        //B.y = 5;
        //double distance = Distance(2, 3, 8, 5);
        double distance = Point.Distance(A, B);
        System.Console.WriteLine(distance);
    }



}
using System.Reflection;

class Program
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - this.X, 2) + Math.Pow(other.Y - this.Y, 2));
        }
    }
    static void Ex1()
    {
        Point p1 = new Point(3, 4);
        Point p2 = new Point(0, 0);
        Console.WriteLine(p1.DistanceTo(p2));
    }

    class Car 
    {
        public string Brand;
        public string Model;
        public int Year;
        public string Color;
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model, int year)
        : this(brand, model)
        {
            Year = year;
        }
        public Car(string brand, string model, int year, string color)
        : this(brand, model, year)
        {
            Color = color;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Марка: " + Brand);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Год: " + (Year != 0 ? Year.ToString() : "Неизвестно"));
            Console.WriteLine("Цвет: " + (!string.IsNullOrEmpty(Color) ? Color : "Неизвестно"));
        }
    }

    static void Ex2()
    {
        Car car1 = new Car("Toyota", "Camry");
        Car car2 = new Car("Honda", "Civic", 2020);
        Car car3 = new Car("Ford", "Mustang", 2021, "Red");

        Console.WriteLine("Информация о первом автомобиле:");
        car1.ShowInfo();
        Console.WriteLine("\nИнформация о втором автомобиле:");
        car2.ShowInfo();
        Console.WriteLine("\nИнформация о третьем автомобиле:");
        car3.ShowInfo();
    }
    static void Main(string[] args)
    {
        Ex1();
        Ex2();
    }
}
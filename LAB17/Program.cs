using static Program;

class Program
{
    public class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            set
            {
                if (value < 0 || value > 120)
                    Console.WriteLine("Возраст должен быть в диапазоне от 0 до 120");
                else
                    age = value;
            }
            get { return age; }
        }
    }
    public static void Ex1()
    {
        Student student = new Student();
        student.Name = "Иван";
        student.Age = 25;
        Console.WriteLine($"Имя: {student.Name},\nВозраст: {student.Age}");
    }

    public class Car
    {
        private int speed;
        public string Speed
        {
            get { return ($"Скорость автомобиля: {speed} км/ч"); }
        }
        public void Accelerate(int increment)
        {
            speed += increment;
        }
        public void Brake(int decrement)
        {
            speed -= decrement;
            if (speed < 0)
            {
                speed = 0;
                Console.WriteLine("Машина стоит на месте...");
            }
        }

    }
    public static void Ex2()
    {
        Car auto = new Car();

        auto.Accelerate(50);
        Console.WriteLine(auto.Speed);

        auto.Brake(20);
        Console.WriteLine(auto.Speed);

        auto.Brake(40);
        Console.WriteLine(auto.Speed);


    }
    static void Main()
    {
        Console.WriteLine("Ex1");
        Ex1();
        Console.WriteLine("Ex2");
        Ex2();
    }

}
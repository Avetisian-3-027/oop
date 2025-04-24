class Program
{   
    class Transport
    {
        public string Name { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("Транспорт перемещается...");
        }
    }
    class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Автомобиль перемещается.");
        }
    }
    class Bicycle : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Велосипед перемещается.");
        }
    }
    class Train : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Поезд перемещается.");
        }
    }
    public static void Ex1()
    {
        Transport[] transports = {
            new Car { Name = "Volkswagen" },
            new Bicycle { Name = "BMW" },
            new Train { Name = "Siemens" }
        };
        Console.WriteLine("Транспорные средства:");
        foreach (Transport i in transports)
        {
            i.Move();
        }
    }    
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Рабочий работает.");
        }
    }
    class Programmer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Программист программирует.");
        }
    }
    class Designer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Дизайнер дизайнит.");
        }
    }
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Менеджер управляет.");
        }
    }
    public static void Ex2()
    { 
        List<Employee> employees = new List<Employee>
        {
            new Programmer(),
            new Designer(),
            new Manager()
        };
        Console.WriteLine("Гастарбайтеры:");
        foreach (Employee e in employees)
        {
            e.Work();
        }
    }
    public static void Main()
    {
        Console.WriteLine("Ex1");
        Ex1();
        Console.WriteLine("\nEx2");
        Ex2();
    }
}
class Program
{
    //EX_1
    public static void Ex1()
    {
        int age = 25;
        double weight = 85.5D;
        char grade = 'A';
        string name = "John Doe";
        bool isEmployed = true;
        Console.WriteLine("Ex1");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Вес: {weight}");
        Console.WriteLine($"Оценка: {grade}");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Трудоустроен?: {isEmployed}\n");
    }

    //EX_2
    public static void Ex2()
    {
        Console.WriteLine($"Ex2");
        while (true)
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            try
            {
                double number = Convert.ToDouble(input);
                Console.WriteLine($"Вы ввели число: {number}");
                int parsedNumber = Convert.ToInt32(number);
                Console.WriteLine($"Его целочисленная форма: {parsedNumber}");
                input = Convert.ToString(parsedNumber);
                Console.WriteLine($"Его строковая форма: '{input}'\n");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Некорректное значение.");
            }
        }
    }

    //EX_3
    public static void Ex3()
    {
        string name;
        int age;
        Console.WriteLine("Ex3");
        Console.WriteLine("Как тебя зовут?:");
        name = Console.ReadLine();
        Console.WriteLine("Сколько тебе лет?:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Привет {name}!\nТебе уже {age}!\n");
    }

    //EX_4
    public static void Ex4()
    {
        double speed, time, distance;
        Console.WriteLine("Ex4");
        Console.WriteLine("Введите расстояние (км):");
        distance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите время (ч):");
        time = Convert.ToDouble(Console.ReadLine());
        speed = distance / time;
        Console.WriteLine($"Скорость: {speed} км/ч.\n");

    }

    //EX_5
    public static void Ex5()
    {
        string str;
        Console.WriteLine("Ex5");
        Console.WriteLine("Введите строку:");
        str = Console.ReadLine();
        Console.WriteLine($"Строка: {str}");
        Console.WriteLine($"Количество символов в строке: {str.Length}");
        Console.WriteLine($"Строка в верхнем регистре: {str.ToUpper()}");
        Console.WriteLine($"Строка без пробелов: {str.Replace(" ", "_")}");
        Console.WriteLine($"Первые 5 символов строки: {str.Substring(0, 5)}");
    }
    static void Main()
    {
        //EX_1
        Ex1();
        //EX_2
        Ex2();
        //EX_3
        Ex3();
        //EX_4
        Ex4();
        //EX_5
        Ex5();
    }
}



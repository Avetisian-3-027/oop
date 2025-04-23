class Program
{
    //EX_1
    public static string IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return "Число парное.";
        }
        else
        {
            return "Число непарное.";
        }
    }
    public static void Ex1()
    {
        Console.WriteLine("Ex1");
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат: {IsEven(number)}");
    }

    //EX_2
    public static string YourGrade(int number)
    {
        if (number < 60)
        {
            return "Ваша оценка: F";
        }
        else if (number < 75)
        {
            return "Ваша оценка: C";
        }
        else if (number < 90)
        {
            return "Ваша оценка: B";
        }
        else
        {
            return "Ваша оценка: A";
        }
    }
    public static void Ex2()
    {
        Console.WriteLine("Ex2");
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(YourGrade(number));
    }
    //EX_3
    public static void Ex3()
    {
        Console.WriteLine("Ex3");
        Console.Write("Введите число (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1: Console.WriteLine("Понедельник"); break;
            case 2: Console.WriteLine("Вторник"); break;
            case 3: Console.WriteLine("Среда"); break;
            case 4: Console.WriteLine("Четверг"); break;
            case 5: Console.WriteLine("Пятница"); break;
            case 6: Console.WriteLine("Суббота"); break;
            case 7: Console.WriteLine("Воскресенье"); break;
            default: Console.WriteLine("Некорректный ввод!"); break;
        }
    }
    //EX_4
    public static void Ex4()
    {
        Console.WriteLine("Ex4");
        Console.Write("Введите марку авто: ");
        string brand = Console.ReadLine();
        switch (brand)
        {
            case "Toyota": Console.WriteLine("Япония"); break;
            case "BMW": Console.WriteLine("Германия"); break;
            case "Tesla": Console.WriteLine("США"); break;
            default: Console.WriteLine("Неизвестная марка авто"); break;
        }
    }
    //EX_5
    public static void Ex5()
    {
        Console.WriteLine("Ex5");
        Console.Write("Введите температуру: ");
        double temp = Convert.ToDouble(Console.ReadLine());
        string result = temp >= 0 ? "Погода тёплая" : "Погода холодная";
        Console.WriteLine("Результат: " + result);
    }
    //EX_6
    public static void Ex6()
    {
        Console.WriteLine("Ex6");
        try
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double div = a / b;
            Console.WriteLine("Результат: " + div);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: некорректный ввод");
        }
    }
    public static void Main()
    {
        Ex1();
        Ex2();
        Ex3();
        Ex4();
        Ex5();
        Ex6();
    }
}
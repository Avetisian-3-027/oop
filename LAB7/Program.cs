class Program
{
    //EX_1
    public static void Ex1()
    {
        Console.WriteLine("Ex1");
        Console.WriteLine("Чётные числа от 2 до 20:");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine('\n');
    }

    //EX_2
    public static void Ex2()
    {
        int sum = 0;
        int input;
        Console.WriteLine("Ex2");
        Console.WriteLine("Введите числа. Введите 0 для завершения:");
        while (true)
        {
            Console.Write("Введите число: ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 0) break;
            sum += input;
        }
        Console.WriteLine("Сумма: " + sum);
    }

    //EX_3
    public static void Ex3()
    {
        string password;
        Console.WriteLine("Ex3");
        do
        {
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();
            if (password != "1234")
            {
                Console.WriteLine("Неправильный пароль!");
            }
        }
        while (password != "1234");

        Console.WriteLine("Доступ разрешён!");
    }
    public static void Main()
    {
        Ex1();
        Ex2();
        Ex3();
    }

}
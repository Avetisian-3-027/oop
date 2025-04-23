class Program
{
    //EX_1
    public static bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Ex1()
    {
        Console.WriteLine("Ex1");
        Console.WriteLine(IsEven(8));
        Console.WriteLine(IsEven(7));
    }
    //EX_2
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public static double Sum(double a, double b)
    {
        return a + b;
    }

    public static void Ex2()
    {
        Console.WriteLine("Ex2");
        Console.WriteLine(Sum(5, 10));
        Console.WriteLine(Sum(2, 3, 4));
        Console.WriteLine(Sum(2.5, 3.1));
    }
    //EX_3
    public static int Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        return 0;
    }
    public static void Ex3()
    {
        int a = 5, b = 10;
        Swap(ref a, ref b);
        Console.WriteLine("Ex3");
        Console.WriteLine($"a = {a}, b = {b}");

    }
    static void Main()
    {
        //EX_1
        Ex1();
        //EX_2
        Ex2();
        //EX_3
        Ex3();
    }
}



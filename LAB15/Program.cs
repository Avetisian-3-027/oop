using System.Diagnostics;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 500; i++)
        {
            Console.Write($"{i} ");
            if (i % 25 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
    static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine($"Факториал {n} = {result}");
        return result;
    }
    static void Ex1()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        Parallel.Invoke(
            () => PrintNumbers(),
            () => CalculateFactorial(10)
        );

        stopwatch.Stop();
        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
    }

    static void Ex2()
    {
        int counter = 0;
        Parallel.For(0, 1000, i =>
        {
            Interlocked.Increment(ref counter); 
        });
        Console.WriteLine($"Результат (by Interlocked): {counter}");
    }

    static void Main()
    {
        Console.WriteLine("EX1:");
        Ex1();
        Console.WriteLine("EX2:");
        Ex2();
    }
}
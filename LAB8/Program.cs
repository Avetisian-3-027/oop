class Program
{
    public static void Ex1()
    {
        int[] numbers = { 12, 15, 7, 20, 33, 50, 8, 11, 90, 45 };
        var divisible = numbers.Where(n => n % 3 == 0 || n % 5 == 0);
        int sum = divisible.Sum();

        Console.WriteLine("Ex1");
        Console.WriteLine(string.Join(", ", divisible));
        Console.WriteLine($"Сумма этих чисел: {sum}");
    }
    public static void Ex2()
    {
        string[] productNames = { "Хлеб", "Молоко", "Яблоки", "Сыр", "Шоколад", "Кофе", "Чай" };
        double[] productPrices = { 25.5, 32.0, 45.3, 120.0, 80.0, 150.0, 75.5 };

        double averagePrice = productPrices.Average();
        Console.WriteLine("Ex2");
        Console.WriteLine($"Средняя цена товаров: {averagePrice:F2}");

        Console.WriteLine("Товары, цена которых выше средней:");
        for (int i = 0; i < productPrices.Length; i++)
        {
            if (productPrices[i] > averagePrice)
            {
                Console.WriteLine($"{productNames[i]} - {productPrices[i]} грн");
            }
        }

        int minIndex = Array.IndexOf(productPrices, productPrices.Min());
        int maxIndex = Array.IndexOf(productPrices, productPrices.Max());

        Console.WriteLine($"Самый дешёвый товар: {productNames[minIndex]} - {productPrices[minIndex]} грн");
        Console.WriteLine($"Самый дорогой товар: {productNames[maxIndex]} - {productPrices[maxIndex]} грн");
    }
    public static void Main()
    {
        Ex1();
        Ex2();
    }
}
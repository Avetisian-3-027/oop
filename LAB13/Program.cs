class Program
{    
    static int[] Filter(int[] numbers, Predicate<int> predicate)
    {
        var result = new List<int>();
        foreach (var number in numbers)
        {
            if (predicate(number))
                result.Add(number);
        }
        return result.ToArray();
    }
    static void Ex1()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Predicate<int> isEven = n => n % 2 == 0;

        var evenNumbers = Filter(numbers, isEven);

        Console.WriteLine("Парные числа:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
    
    static void OrderStatusChangedHandler(object sender, string status)
    {
        Console.WriteLine($"Статус заказа изменён на: {status}");
    }
    class Order
    {
        public event EventHandler<string> OrderStatusChanged;
        private string status;

        public string Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    OnOrderStatusChanged(status);
                }
            }
        }
        protected virtual void OnOrderStatusChanged(string status)
        {
            OrderStatusChanged?.Invoke(this, status);
        }
    }
    static void Ex2()
    {
        Order order = new Order();
        order.OrderStatusChanged += OrderStatusChangedHandler;
        order.Status = "Получено";
        order.Status = "Отправлено";
        order.Status = "Доставлено";
    }

    static void Main()
    {
        Console.WriteLine("Ex1\n");
        Ex1();
        Console.WriteLine("\nEx2\n");
        Ex2();
    }
}

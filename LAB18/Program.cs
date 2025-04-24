class Program
{
    interface IAnimal
    {
        void Speak();
        void Eat();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Гав!");
        }
        public void Eat()
        {
            Console.WriteLine("Собака ест.");
        }
    }
    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Мяу!");
        }
        public void Eat()
        {
            Console.WriteLine("Кот ест.");
        }
    }
    static void Ex1()
    {
        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(new Dog());
        animals.Add(new Cat());
        foreach (IAnimal animal in animals)
        {
            animal.Speak();
            animal.Eat();
        }
    }
    
    interface IPaymentMethod
    {
        void Pay(decimal amount);
    }

    class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата кредитной картой: {amount}");
        }
    }
    class PayPal : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через PayPal: {amount}");
        }
    }

    class ApplePay : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через ApplePay: {amount}");
        }
    }

    class Order
    {
        public IPaymentMethod PaymentMethod { get; set; }

        public Order(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Обработка платежа...");
            PaymentMethod.Pay(amount);
            Console.WriteLine("Платёж завершён.\n");
        }

    }
    static void Ex2()
    {
        Order order1 = new Order(new CreditCard());
        order1.ProcessPayment(150);

        Order order2 = new Order(new PayPal());
        order2.ProcessPayment(15);

        Order order3 = new Order(new ApplePay());
        order3.ProcessPayment(120);

    }
    static void Main()
    {
        Console.WriteLine("EX1");
        Ex1();
        Console.WriteLine("EX2");
        Ex2();
    }
}

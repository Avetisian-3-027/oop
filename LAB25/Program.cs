using System;
using System.Collections.Generic;

class Program
{
    //Ex1
    interface ICalculationStrategy
    {
        int Calculate(int a, int b);
    }
    class AddStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a + b;
    }
    class SubtractStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a - b;
    }
    class MultiplyStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a * b;
    }
    class Calculator
    {
        private ICalculationStrategy _strategy;

        public void SetStrategy(ICalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Calculate(int a, int b)
        {
            if (_strategy == null)
                throw new InvalidOperationException("Strategy not set");
            return _strategy.Calculate(a, b);
        }
    }
    static void Ex1()
    {
        Console.WriteLine("Strategy Pattern Example");
        var calculator = new Calculator();
        Console.WriteLine("Виберіть операцію: add, sub, mul");
        string choice = Console.ReadLine()?.ToLower();
        switch (choice)
        {
            case "add":
                calculator.SetStrategy(new AddStrategy());
                break;
            case "sub":
                calculator.SetStrategy(new SubtractStrategy());
                break;
            case "mul":
                calculator.SetStrategy(new MultiplyStrategy());
                break;
            default:
                Console.WriteLine("Невідома операція");
                return;
        }
        int a = 10, b = 5;
        Console.WriteLine($"Результат для {a} та {b}: {calculator.Calculate(a, b)}");
    }

    //Ex2
    interface ICommand
    {
        void Execute();
    }

    class OpenFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл відкрито.");
    }

    class SaveFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл збережено.");
    }

    class CloseFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл закрито.");
    }

    class Editor
    {
        private List<ICommand> _commands = new();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var cmd in _commands)
            {
                cmd.Execute();
            }
            _commands.Clear();
        }
    }

    static void Ex2()
    {
        Console.WriteLine("Command Pattern Example");

        var editor = new Editor();
        editor.AddCommand(new OpenFileCommand());
        editor.AddCommand(new SaveFileCommand());
        editor.AddCommand(new CloseFileCommand());

        editor.ExecuteCommands();
    }

    //EX3
    interface IUser
    {
        string Name { get; }
        void Receive(string message, IUser from);
    }

    class User : IUser
    {
        private readonly IChatMediator _mediator;
        public string Name { get; }
        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }
        public void Send(string message)
        {
            _mediator.SendMessage(message, this);
        }
        public void Receive(string message, IUser from)
        {
            if (from != this)
                Console.WriteLine($"{Name} отримав від {from.Name}: {message}");
        }
    }

    interface IChatMediator
    {
        void RegisterUser(IUser user);
        void SendMessage(string message, IUser from);
    }
    class ChatMediator : IChatMediator
    {
        private readonly List<IUser> _users = new();

        public void RegisterUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, IUser from)
        {
            foreach (var user in _users)
            {
                user.Receive(message, from);
            }
        }
    }
    static void Ex3()
    {
        Console.WriteLine("Mediator Pattern Example");
        var mediator = new ChatMediator();
        var user1 = new User("Іван", mediator);
        var user2 = new User("Оля", mediator);
        var user3 = new User("Петро", mediator);
        mediator.RegisterUser(user1);
        mediator.RegisterUser(user2);
        mediator.RegisterUser(user3);
        user1.Send("Привіт всім!");
        user2.Send("Доброго дня!");
    }

    //Ex4
    interface IWeatherObserver
    {
        void Update(int temperature);
    }

    class WeatherStation
    {
        private readonly List<IWeatherObserver> _observers = new();
        private int _temperature;

        public int Temperature
        {
            get => _temperature;
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    Notify();
                }
            }
        }

        public void RegisterObserver(IWeatherObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }

    class PhoneApp : IWeatherObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"PhoneApp: Температура оновлена до {temperature}°C");
        }
    }

    class Billboard : IWeatherObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"Billboard: Погода зараз {temperature}°C");
        }
    }

    static void Ex4()
    {
        Console.WriteLine("Observer Pattern Example");

        var station = new WeatherStation();

        var phoneApp = new PhoneApp();
        var billboard = new Billboard();

        station.RegisterObserver(phoneApp);
        station.RegisterObserver(billboard);

        station.Temperature = 25;
        station.Temperature = 28;
    }
    static void Main()
    {
        Console.WriteLine("Ex1:");
        Ex1();
        Console.WriteLine("Ex2:");
        Ex2();
        Console.WriteLine("Ex3:");
        Ex3();
        Console.WriteLine("Ex4:");
        Ex4();
    }
}
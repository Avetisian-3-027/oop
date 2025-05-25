class Program
{
    //Ex1
    interface INewPrinter
    {
        void Print(string message);
    }

    class OldPrinter
    {
        public void OldPrint(string msg)
        {
            Console.WriteLine("OldPrinter: " + msg);
        }
    }

    class PrinterAdapter : INewPrinter
    {
        private OldPrinter _oldPrinter;
        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public void Print(string message)
        {
            _oldPrinter.OldPrint(message);
        }
    }

    static void Ex1()
    {
        Console.WriteLine("=== Adapter ===");
        OldPrinter oldPrinter = new OldPrinter();
        INewPrinter printer = new PrinterAdapter(oldPrinter);
        printer.Print("Hello world!");
        Console.WriteLine();
    }

    //Ex2
    class Engine
    {
        public void Start()
        {
            Console.WriteLine("Двигун заведено.");
        }
    }

    class Battery
    {
        public void Start()
        {
            Console.WriteLine("АКБ ввімкнено.");
        }
    }

    class IgnitionSystem
    {
        public void Start()
        {
            Console.WriteLine("Систему запалювання ввімкнено");
        }
    }

    class CarFacade
    {
        private Engine _engine;
        private Battery _battery;
        private IgnitionSystem _ignition;

        public CarFacade()
        {
            _engine = new Engine();
            _battery = new Battery();
            _ignition = new IgnitionSystem();
        }

        public void StartCar()
        {
            _battery.Start();
            _ignition.Start();
            _engine.Start();
            Console.WriteLine("Автомобіль – успішно запущений.");
        }
    }

    static void Ex2()
    {
        Console.WriteLine("=== Facade ===");
        CarFacade car = new CarFacade();
        car.StartCar();
        Console.WriteLine();
    }

    //Ex3
    interface IWriter
    {
        void Write(string text);
    }

    class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

    class TimestampWriter : IWriter
    {
        private IWriter _innerWriter;
        public TimestampWriter(IWriter innerWriter)
        {
            _innerWriter = innerWriter;
        }

        public void Write(string text)
        {
            string decoratedText = $"[{DateTime.Now}] {text}";
            _innerWriter.Write(decoratedText);
        }
    }

    static void Ex3()
    {
        Console.WriteLine("=== Decorator ===");
        IWriter writer = new ConsoleWriter();
        IWriter timestampWriter = new TimestampWriter(writer);
        timestampWriter.Write("Це прикрашене повідомлення.");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Ex1();
        Ex2();
        Ex3();
    }
}
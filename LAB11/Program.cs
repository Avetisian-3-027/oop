//class Program
//{
//    static Queue<string> mortgageApplications = new Queue<string>();

//    public static void Main()
//    {
//        bool running = true;

//        while (running)
//        {
//            Console.WriteLine("\n=== МЕНЮ ===");
//            Console.WriteLine("1. Оставить заявку");
//            Console.WriteLine("2. Обработать первую заявку");
//            Console.WriteLine("3. Просмотреть приоритетную заявку");
//            Console.WriteLine("4. Просмотреть все заявки");
//            Console.WriteLine("5. Рассчитать ежемесячный платёж по ипотеке");
//            Console.WriteLine("0. Выйти");
//            Console.Write("Выберите действие: ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    AddApplication();
//                    break;
//                case "2":
//                    ProcessApplication();
//                    break;
//                case "3":
//                    PeekApplication();
//                    break;
//                case "4":
//                    ShowAllApplications();
//                    break;
//                case "0":
//                    running = false;
//                    break;
//                default:
//                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз...");
//                    break;
//            }
//        }
//    }

//    static void AddApplication()
//    {
//        Console.Write("Введите имя заявщика: ");
//        string name = Console.ReadLine();
//        mortgageApplications.Enqueue(name);
//        Console.WriteLine("Заявка добавлена.");
//    }

//    static void ProcessApplication()
//    {
//        if (mortgageApplications.Count > 0)
//        {
//            string processed = mortgageApplications.Dequeue();
//            Console.WriteLine($"Обработана заявка: {processed}");
//        }
//        else
//        {
//            Console.WriteLine("Очередь пуста.");
//        }
//    }

//    static void PeekApplication()
//    {
//        if (mortgageApplications.Count > 0)
//        {
//            Console.WriteLine($"Следующая заявка: {mortgageApplications.Peek()}");
//        }
//        else
//        {
//            Console.WriteLine("Очередь пуста.");
//        }
//    }

//    static void ShowAllApplications()
//    {
//        if (mortgageApplications.Count > 0)
//        {
//            Console.WriteLine("Все заявки в очереди:");
//            foreach (string name in mortgageApplications)
//            {
//                Console.WriteLine("* " + name);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Очередь пуста.");
//        }
//    }
//} Я говорил
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст для анализа:");
        string input = Console.ReadLine();

        string cleanedText = Regex.Replace(input.ToLower(), @"[^\w\s]", "");

        string[] words = cleanedText.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
                wordCounts[word]++;
            else
                wordCounts[word] = 1;
        }

        var sortedWords = wordCounts.OrderByDescending(pair => pair.Value);

        Console.WriteLine("\nСтатистика слов:");
        foreach (var pair in sortedWords)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}

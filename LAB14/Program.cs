class Program
{
    static void ProcessFile(string fileName)
    {
        int errorCount = 0;

        try
        {
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    errorCount++;
                }
            }

            Console.WriteLine($"Файл {fileName}: обнаружено {errorCount} ошибок.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при обработке файла {fileName}: {ex.Message}");
        }
    }
    static void Ex1()
    {
        string[] fileNames = { "Something.txt", "Something1.txt", "Something2.txt" };

        Task[] tasks = new Task[fileNames.Length];

        for (int i = 0; i < fileNames.Length; i++)
        {
            int fileIndex = i;
            tasks[i] = Task.Run(() => ProcessFile(fileNames[fileIndex]));
        }

        Task.WhenAll(tasks).Wait();

        Console.WriteLine("Обработка файлов завершена!");
    }
    static void Main()
    { 
        Console.WriteLine("Ex1\n");
        Ex1();
    }
}

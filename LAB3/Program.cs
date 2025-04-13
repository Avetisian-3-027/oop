namespace LAB3
{
    class Program
    {
        // 1)
        private static void Task1()
        {
            int userAge = 20;
            string userName = "Андрій";

            Console.WriteLine("Привіт, " + userName + "! Твій вік: " + userAge);
        }
        // 2) К сожаленнию, не могу выполнить это задание, так как оно не рассписано...
        private static void Task2()
        {
            int userAge = 20;
            string userName = "Андрій";

            Console.WriteLine("Привіт, " + userName + "! Твій вік: " + userAge);
        }
        // 3) 
        private static void Task3() // создаём приватный статический метод Task3
        {
            string name = "Анна"; // создаём строковую переменную name и присваиваем ей значение "Анна"
            int age = 25; // создаём целочисленную переменную age и присваиваем ей значение 25
            Console.WriteLine("Привіт, " + name + "! Твій вік: " + age); // выводим на консоль терминала строку с приветствием и значениями переменных name и age
        }

    }
}
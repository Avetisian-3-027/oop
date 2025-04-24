class Program
{ 
    public class BankAccount
    {
        private decimal balance = 0;
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        public async Task DepositAsync(decimal amount)
        {
            await semaphore.WaitAsync();
            try
            {
                await Task.Delay(100); 
                balance += amount;
                Console.WriteLine($"Пополнение +{amount}");
            }
            finally
            {
                semaphore.Release();
            }
        }

        public async Task WithdrawAsync(decimal amount)
        {
            await semaphore.WaitAsync();
            try
            {
                await Task.Delay(100); 
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Съём -{amount}");
                }
                else
                {
                    Console.WriteLine($"Недостаточно средств для съёма -{amount}");
                }
            }
            finally
            {
                semaphore.Release();
            }
        }

        public void ShowMyBalance()
        {
            Console.WriteLine($"Финальный баланс: {balance}");
        }
    }
    public static async Task Ex1()
    {
        BankAccount account1 = new BankAccount();
        await account1.DepositAsync(200);
        await account1.WithdrawAsync(100);
        await account1.DepositAsync(300);
        await account1.WithdrawAsync(50);
        account1.ShowMyBalance();
    }
    public static async Task Main()
    {
        await Ex1();
    }
}

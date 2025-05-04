namespace частично_практика_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new(Category.Credit, 1000);
            Bank.CreateUser("Сергеев Дмитрий Сергеевич");
            Bank.Account(info, "Сергеев Дмитрий Сергеевич");
            Bank.PrintClients();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_3
{
    public static class Bank
    {
        internal static int _accountIdCounter = 1;
        public static Dictionary<string, List<Account>> Clients { get; internal set; } = new();

        public static void CreateClient(string fullName) //  Создание клиента
        {
            if (!Clients.ContainsKey(fullName))
            {
                Clients[fullName] = new List<Account>();
                Console.WriteLine($"Клиент {fullName} успешно создан.");
            }
            else
            {
                Console.WriteLine($"Клиент {fullName} уже существует.");
            }
        }

        public static void CreateAccountForClient(string fullName, Category category, decimal initialBalance) // Открытие счёта
        {
            if (!Clients.ContainsKey(fullName))
            {
                Console.WriteLine($"Клиент {fullName} не найден. Создайте клиента сначала.");
                return;
            }

            var account = new Account
            {
                Id = _accountIdCounter++,
                Category = category,
                Balance = initialBalance
            };

            Clients[fullName].Add(account);
            Console.WriteLine($"Для клиента {fullName} открыт счёт {account.Id}, тип: {category}, начальный баланс: {initialBalance:F2}");
        }

        public static void PrintAllClientsWithAccounts() //Вывод всех клиентов
        {
            Console.WriteLine("\nВсе клиенты");
            foreach (var client in Clients)
            {
                Console.WriteLine($"\nКлиент: {client.Key}");
                foreach (var account in client.Value)
                {
                    Console.WriteLine($"  {account}");
                }
            }
        }

        public static void PrintAccountsByClient(string fullName) //Вывод счетов конкретного клиента
        {
            if (!Clients.TryGetValue(fullName, out var accounts))
            {
                Console.WriteLine($"Клиент {fullName} не найден.");
                return;
            }

            Console.WriteLine($"\nСчета клиента {fullName}");
            foreach (var account in accounts)
            {
                Console.WriteLine($"  {account}");
            }
        }

        public static void PrintTotalBalanceByClient(string fullName) // Общий баланс клиента
        {
            if (!Clients.TryGetValue(fullName, out var accounts))
            {
                Console.WriteLine($"Клиент {fullName} не найден.");
                return;
            }

            decimal total = accounts.Sum(a => a.Balance);
            Console.WriteLine($"\nОбщий баланс клиента {fullName}: {total:F2}");
        }

        public static void PrintTotalBalanceAllClients() // Общий баланс всех клиентов
        {
            decimal total = Clients.Values.SelectMany(accs => accs).Sum(a => a.Balance);
            Console.WriteLine($"\nОбщий баланс всех клиентов: {total:F2}");
        }

        public static void PrintCreditAccounts() // Вывод только кредитных счетов
        {
            var creditAccounts = Clients.Values.SelectMany(accs => accs).Where(a => a.Category == Category.Credit);
            Console.WriteLine("\nКредитные счета");
            foreach (var acc in creditAccounts)
            {
                Console.WriteLine($"  {acc}");
            }
        }

        public static void PrintDebitAccounts() // Вывод только дебетовых счетов
        {
            var debitAccounts = Clients.Values.SelectMany(accs => accs).Where(a => a.Category == Category.Debit);
            Console.WriteLine("\nДебетовые счета");
            foreach (var acc in debitAccounts)
            {
                Console.WriteLine($"  {acc}");
            }
        }
    }
}

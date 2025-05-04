using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace частично_практика
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public decimal Balance { get; set; }
        public Category Category { get; set; } // Изменен на свойство с заглавной буквы согласно соглашениям

        public string GetAccountInfo()
        {
            return $"{Id:D2}:{Surname} {Name} {Patronymic}. Баланс: {Balance:F2}; Тип счета: {Category}"; // Форматирование баланса
        }

        static void Main(string[] args)
        {
            var accounts = AccountsGenerator(10);

            foreach (var entry in accounts)
            {
                foreach (var account in entry.Value)
                {
                    Console.WriteLine(account.GetAccountInfo());
                }
            }
        }

        static Dictionary<string, List<Users>> AccountsGenerator(int count)
        {
            var accounts = new Dictionary<string, List<Users>>(); // Словарь для хранения ФИО и списка счетов
            Random random = new();

            List<string> names = new List<string> { "Иван", "Петр", "Дмитрий", "Тимофей", "Федор", "Данил", "Сергей", "Валентин" };
            List<string> surnames = new List<string> { "Иванов", "Петров", "Сидоров", "Иванченков", "Рябов", "Коромыслов", "Гагарин", "Циолковский", "Менделеев", "Чехов", "Тимиряшев" };
            List<string> patronymics = new List<string> { "Сергеевич", "Петрович", "Александрович", "Ильич", "Дмитриевич", "Федорович" };
            List<Category> categories = new List<Category> { Category.Credit, Category.Debit }; // типы счетов

            // Запуск цикла по количеству нужных элементов
            for (int i = 0; i < count; i++)
            {
                // Генерация id для объекта через тернарный оператор
                int tempId = accounts.Values.SelectMany(x => x).Count() + 1; // Уникальный Id

                Users account = new() // создается объект банковского счета
                {
                    Name = names[random.Next(names.Count)], // случайное имя из подготовленного списка
                    Surname = surnames[random.Next(surnames.Count)], // случайная фамилия
                    Patronymic = patronymics[random.Next(patronymics.Count)], // случайное отчество
                    Balance = Math.Round((decimal)(random.NextDouble() * 100000), 2), // случайный баланс от 0 до 100000
                    Category = categories[random.Next(categories.Count)], // случайный тип счета
                    Id = tempId
                };

                string fullName = $"{account.Surname} {account.Name} {account.Patronymic}";

                // Добавление счета в словарь по ФИО
                if (!accounts.ContainsKey(fullName))
                {
                    accounts[fullName] = new List<Users>();
                }
                accounts[fullName].Add(account); // Добавление счета в список
            }

            return accounts;
        }
    }
}

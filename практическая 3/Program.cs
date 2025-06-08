namespace практическая_3
{
    internal class Program
    {//Создать перечисление для категорий банковских счетов (дебетовый/кредитный
     //создать класс банковского счета(категория, сумма на счёте, пополнение счета, снятие со счета). создать словарь, где ключом будет ФИО клиента, а значением - список его счетов.
     //Заполнить словарь программно через специальный метод-генератор
     //Создать статичный класс банка со статичными методами для:
     //1. Создания клиента
     //2. Создания счета для уже существующего клиента
     //3. Вывода всех клиентов с данными по их счетам
     //4. Вывода всех счетов для конкретного клиента
     //5. Вывод суммы на всех счетах для конкретного клиента
     //6. Вывод суммы на всех счетах всех клиентов
     //7. Вывод отдельно только кредитных счетов
     //8. Вывод отдельно только дебетовых счетов
     //Продемонстрировать работу методов.

        static void Main(string[] args)
        {
            Console.WriteLine("Банковская система");
            DataStorage.LoadData();
            GenerateTestData(10);
            string input = Console.ReadLine();
            Bank.PrintAccountsByClient(input);
            DataStorage.SaveData();
        }

        static void GenerateTestData(int count)
        {
            var random = new Random();
            var names = new List<string> { "Иван", "Петр", "Алексей", "Иван", "Сергей" };
            var surnames = new List<string> { "Иванов", "Петров", "Смирнов", "Кузнецов", "Сидоров" };
            var patronymics = new List<string> { "Сергеевич", "Иванович", "Петрович", "Алексеевич" };
            var categories = new List<Category> { Category.Debit, Category.Credit };

            for (int i = 0; i < count; i++)
            {
                string name = names[random.Next(names.Count)];
                string surname = surnames[random.Next(surnames.Count)];
                string patronymic = patronymics[random.Next(patronymics.Count)];
                string fullName = $"{surname} {name} {patronymic}";

                Category category = categories[random.Next(categories.Count)];
                decimal balance = (decimal)(random.NextDouble() * 100000);

                Bank.CreateClient(fullName);
                Bank.CreateAccountForClient(fullName, category, balance);
            }
        }
    }
}

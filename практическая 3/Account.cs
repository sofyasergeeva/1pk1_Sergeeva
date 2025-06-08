using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_3
{
    public class Account
    {
        public int Id { get; set; } // уникальный номер счёта
        public Category Category { get; set; } // тип счёта
        public decimal Balance { get; set; } // текущий баланс

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Сумма пополнения должна быть положительной.");
            Balance += amount;
            Console.WriteLine($"Счёт {Id} пополнен на {amount:F2}. Новый баланс: {Balance:F2}");
        }

        public void Withdraw(decimal amount) // метод, который снимает деньги со счёта, проверяет остаток
        {
            if (amount <= 0) throw new ArgumentException("Сумма снятия должна быть положительной.");
            if (Balance < amount)
            {
                Console.WriteLine($"На счёте {Id} недостаточно средств для снятия {amount:F2}");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Со счёта {Id} списано {amount:F2}. Остаток: {Balance:F2}");
        }

        public override string ToString() // метод, который выдаёт информацию о счёте
        {
            return $"Счёт {Id}: {Category}, Баланс: {Balance:F2}";
        }
    }
}

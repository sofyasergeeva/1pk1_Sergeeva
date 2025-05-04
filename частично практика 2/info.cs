using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace частично_практика_2
{
   /// <summary>
   /// счет
   /// </summary>
    internal class Info
    {
        public Category category;
        public decimal summ;
        public void Replenish(decimal add)
        {
            Console.WriteLine($"Баланс до пополнения: {summ}");

            summ += add;
            Console.WriteLine($"Баланс после пополнения: {summ}");
        }
        public void Withdrawal(decimal remove)
        {
            if (summ < remove)
            {
                Console.WriteLine(" На счёте недостаточно средств");
                return;
            }
            Console.WriteLine($"Баланс до списания: {summ}");
            summ -= remove;
            Console.WriteLine($"Баланс после списания: {summ}");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Ваш счет \nБаланс:{summ}\nКатегория:{category}");

        }
        public Info(Category category, decimal summ)
        {
            this.category = category;
            this.summ = summ;
        }


    }
}

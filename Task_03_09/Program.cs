namespace Task_03_09
{
    internal class Program
    {/*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
          отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
          менее y рублей*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            // сумма вклада
            double x= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите проценты в год");
            // проценты в год
             double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ожидаемую сумму");
            // ожидаемая сумма
            double y = Convert.ToDouble(Console.ReadLine());
            
            // количество лет
            int Year = 0; 
            while (true)
            {
                if (x >= y)
                    break;
                x += x * p / 100;
                Year++;
            }
            Console.WriteLine($"Через {Year} лет вклад составит {y}руб.");
        }
    }
}

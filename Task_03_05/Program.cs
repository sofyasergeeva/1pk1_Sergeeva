namespace Task_03_05
{
    internal class Program
    {/*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
       Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
       время работы программы
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг для таблицы изменения температуры");
            // шаг
            double step = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите начальную температуру в градусах (С)");
            // от
            double start = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конечную температуру в градусах (С)");
            // до
            double finish = Convert.ToDouble(Console.ReadLine());

            for (double i = start; i <= finish; i += step)
            {
                // температура в Фарингейтах
                double tempF = i * 1.8 + 32;
                Console.WriteLine($"{i}°C = {tempF}°F");
            }
        }
    }
}


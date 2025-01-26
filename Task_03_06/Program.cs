namespace Task_03_06
{
    internal class Program
    {/* Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5
      */
        static void Main(string[] args)
        {
            // функциz
            double y = 0;

            Console.WriteLine("Таблица значений функции y=|x|:\n y\tx");
            for (double i = -4; i <= 4; i += 0.5)
            {
                y = Math.Abs(i);

                Console.WriteLine($" {y}\t{i}");
            }
        }
    }
}

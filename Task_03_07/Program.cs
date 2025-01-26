namespace Task_03_07
{
    internal class Program
    { /*Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
        где 2 g = 9,8 м/с2 – ускорение свободного падения*/
        static void Main(string[] args)
        {
            // скорость
            double V = 0;

            // ускорение свободного падения
            double g = 9.8;
            Console.WriteLine("Введите время падения тела:");

            // время падения тела
            double t = Convert.ToDouble(Console.ReadLine());
            for (double i = 0; i <= t; i += 0.5)
            {
                V = g * i;
                Console.WriteLine("Скорость тела: {0}m/c", V);
            }
        }
    }
}

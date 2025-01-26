namespace _1pk1_Sergeeva
{
    internal class Program
    { /* Найти значение выражения при a = 8, b = 14, с = π/4
       * */
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            // нахождение знаменателя
            double step1_1 = Math.Abs(a - b);
            double step1_2 = step1_1 * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c));

            // нахождение числителя
            double step2_1 = Math.Pow(a - 1, 1.0 / 3);
            double step2_2 = Math.Pow(b + step2_1, 0.25);

            double itog = step2_2 / step1_2;
            Console.WriteLine("Значение выражения равно:" + itog);
        }
    }
}

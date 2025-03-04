namespace Task_14_03
{
    internal class Program
    { /*Реализуйте статический метод Factorial, который принимает
       * целое число и возвращает его факториал. Сделайте так, чтобы
       * метод работал только для неотрицательных чисел.*/

        
        
            public static void Main(string[] args)
            {
                Console.WriteLine("Введите неотрицательное целое число:");
                int number = int.Parse(Console.ReadLine());

                try
                {
                    long result = Factorial(number);
                    Console.WriteLine($"Факториал числа {number} равен {result}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public static long Factorial(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException("n", "Факториал определён только для неотрицательных чисел.");
                }

                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }



    }


namespace Task_11_04
{
    internal class Program
    { /*Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
        их среднее значение. Используйте ключевое слово params*/

        static void Main(string[] args)
        {
            // Пример использования метода
            double average = Numbers(1, 2, 3, 4, 5);
            Console.WriteLine($"Среднее значение: {average}");
        }

        static double Numbers(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Массив чисел не может быть пустым");
            }

            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;

        }

    }
}

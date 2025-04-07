namespace Task_21_01
{
    internal class Program
    { /*Дан список чисел. Создать новый список, содержащий только чётные числа из исходного списка, умноженныена10.*/
        static void Main(string[] args)
        {
            static void Main()
            {
                // Исходный список чисел
                List<int> originalList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                // Новый список с четными числами из исходного, умноженными на 10
                List<int> evenNumbersMultipliedByTen = originalList
                    .Where(n => n % 2 == 0) // Фильтруем четные числа
                    .Select(n => n * 10)    // Умножаем их на 10
                    .ToList();              // Преобразуем в список

                // Выводим результат
                Console.WriteLine("Четные числа, умноженные на 10:");
                foreach (int number in evenNumbersMultipliedByTen)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}

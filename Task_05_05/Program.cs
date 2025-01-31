namespace Task_05_05
{
    internal class Program
    {/*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
        случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
        по следующему правилу:
        • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
        • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом */
        static void Main(string[] args)
        {
            Random random = new Random();

            // Запрос размеров массива у пользователя
            Console.Write("Введите количество строк (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов (m): ");
            int m = int.Parse(Console.ReadLine());

            // Создание прямоугольного массива
            int[,] array = new int[n, m];

            // Заполнение массива случайными числами от -99 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-99, 100);
                }
            }

            // Обработка и вывод массива
            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Обработка элемента согласно правилу
                    if (array[i, j] < 0)
                    {
                        // Если элемент меньше нуля, отбрасываем знак
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(array[i, j]) + " ");
                    }
                    else if (array[i, j] == 0)
                    {
                        // Если элемент равен нулю, заменяем на единицу
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(1 + " ");
                        array[i, j] = 1; // Обновляем элемент в массиве
                    }
                    else
                    {
                        // Если элемент больше нуля, выводим его как есть
                        Console.ResetColor();
                        Console.Write(array[i, j] + " ");
                    }
                    Console.ResetColor(); // Сбрасываем цвет после каждого вывода
                }
                Console.WriteLine(); // Переход на новую строку после каждой строки массива
            }

            // Сброс цвета консоли
            Console.ResetColor();
        }
    }
}

namespace pk1_01_02
{
    internal class Program
    {
        static void Main(string[] args)
            

        class Program
        {
            static void Main()
            {
                // Запрос количества элементов массива
                Console.Write("Введите количество элементов массива: ");
                int n = int.Parse(Console.ReadLine());

                // Создание массива строк
                string[] arr = new string[n];

                // Ввод данных в массив с обработкой пустых строк
                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        Console.Write($"Введите строку {i + 1}: ");
                        string input = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Ошибка: строка не может быть пустой. Попробуйте снова.");
                        }
                        else
                        {
                            arr[i] = input;
                            break;
                        }
                    }
                }

                // Вывод массива с выделением значений по типу
                Console.WriteLine("\nРезультат:");

                foreach (var item in arr)
                {
                    // Попытка преобразования строки в целое число
                    if (int.TryParse(item, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для целых чисел
                        Console.WriteLine(item);
                    }
                    // Попытка преобразования строки в дробное число
                    else if (double.TryParse(item, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Красный цвет для дробных чисел
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.ResetColor(); // Сброс цвета для других значений
                        Console.WriteLine(item);
                    }
                }

                // Сброс цвета консоли
                Console.ResetColor();
            }
        }
    }
            
        }
    }
}


namespace Task_05_07
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе[n * n]. Заполнение случайными
        числами в диапазоне от 10 до 99 включительно.
        Найти и вывести отдельно минимальный элемент в матрице(LINQ под запретом) Осуществить умножение матрицы на ее
        минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве*/
        static void Main(string[] args)
        {
           // Запрос числа n
        Console.Write("Введите размерность массива n: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Пожалуйста, введите положительное целое число.");
        }

        // Генерация квадратного массива n * n и заполнение случайными числами
        int[,] array = new int[n, n];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.Next(10, 100);
            }
        }

        // Нахождение минимального элемента в матрице
        int minElement = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                }
            }
        }

        // Умножение матрицы на её минимальный элемент
        int[,] resultArray = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                resultArray[i, j] = array[i, j] * minElement;
            }
        }

        // Нахождение максимальных значений в результирующей матрице
        int[] allValues = new int[n * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                allValues[i * n + j] = resultArray[i, j];
            }
        }
        
        Array.Sort(allValues);
        Array.Reverse(allValues);

        // Вывод результирующей матрицы с выделением 5 максимальных значений
        Console.WriteLine("Результирующая матрица (умноженная на минимальный элемент):");
        int maxCount = Math.Min(5, allValues.Length);
        int[] maxValues = new int[maxCount];

        for (int i = 0; i < maxCount; i++)
        {
            maxValues[i] = allValues[i];
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                bool isMax = false;
                for (int k = 0; k < maxCount; k++)
                {
                    if (resultArray[i, j] == maxValues[k])
                    {
                        isMax = true;
                        break;
                    }
                }
                if (isMax)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Выделение цветом
                }
                Console.Write(resultArray[i, j] + "\t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        // Вывод минимального элемента
        Console.WriteLine($"Минимальный элемент в матрице: {minElement}");
        }
    }
}

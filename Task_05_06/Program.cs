namespace Task_05_06
{
    internal class Program
    {/*Осуществить генерация двумерного [10*5] массива по следующему правилу:
        • 1 столбец содержит нули
        • 2 столбце содержит числа кратные 2
        • 3 столбец содержит числа кратные 3
        • 4 столбец содержит числа кратные 4
        • 5 столбец содержит числа кратные 5
        Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив*/
        static void Main(string[] args)
        {
            int[,] array = new int[10, 5];
            Random random = new Random();

            // Заполняем массив 
            for (int i = 0; i < 10; i++)
            {
                array[i, 0] = 0; // 1 столбец содержит нули
                array[i, 1] = random.Next(1, 101) * 2; // 2 столбец содержит числа кратные 2
                array[i, 2] = random.Next(1, 34) * 3; // 3 столбец содержит числа кратные 3
                array[i, 3] = random.Next(1, 26) * 4; // 4 столбец содержит числа кратные 4
                array[i, 4] = random.Next(1, 21) * 5; // 5 столбец содержит числа кратные 5
            }

            // Выводим исходный массив
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Транспонируем массив
            int[,] transposedArray = TransposeArray(array);

            // Выводим транспонированный массив
            Console.WriteLine("\nТранспонированный массив:");
            PrintArray(transposedArray);
        }

        // Метод для вывода массива
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(5)); // Форматируем вывод
                }
                Console.WriteLine();
            }
        }

        // Метод для транспонирования массива
        static int[,] TransposeArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = array[i, j];
                }
            }

            return transposed;
        }
    }
}

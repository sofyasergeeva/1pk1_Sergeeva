namespace Task_05_04
{
    internal class Program
    {/*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
        диагональной (все элементы вне главной диагонали равны нулю)
        Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
        сообщение что матрица не является диагональной. */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n];

            // Заполнение матрицы
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Элемент [{i}, {j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Анализ матрицы на диагональность
            bool isDiagonal = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && array[i, j] != 0)
                    {
                        isDiagonal = false;
                    }
                }
            }

            // Вывод результата
            if (isDiagonal)
            {
                Console.WriteLine("Матрица является диагональной. Вывод с выделением главной диагонали:\n");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // Задаем цвет главной диагонали
                            Console.Write(array[i, j] + "\t");
                            Console.ResetColor(); // Сбрасываем цвет
                        }
                        else
                        {
                            Console.Write(array[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }
        }
    }

}
    


namespace Task_05_09
{
    internal class Program
    {/*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
        (это матрица, где все недиагональные элементы меньше нуля)
        Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
        вывести сообщение что данная матрица не является Z-матрицей*/
        static void Main(string[] args)
        {
            // Ввод размерности матрицы
            Console.Write("Введите размерность матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            // Создание и заполнение матрицы
            int[,] array = new int[n, n];
            Random random = new Random();

            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   array[i, j] = random.Next(-10, 10); // Генерация случайных чисел от -10 до 9
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Проверка на Z-матрицу
            bool isZArray = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && array[i, j] >= 0) // Недиагональные элементы должны быть меньше нуля
                    {
                        isZArray = false;
                        break;
                    }
                }
                if (!isZArray)
                {
                    break;
                }
            }

            // Вывод результата
            if (isZArray)
            {
                Console.WriteLine("Матрица является Z-матрицей:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            // Цвет для главной диагонали (например, зелёный)
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            // Цвет для недиагональных элементов
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                // Сброс цвета
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Данная матрица не является Z-матрицей.");
            }
        }
    }
}

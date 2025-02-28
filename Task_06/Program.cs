namespace Task_10_06
{
    internal class Program
    {/*Создать Метод ArrayGeneration не возвращающий значения,
      *принимает целое число n, выводит на консоль сгенерированный
      *массив размерности n*n.*/
        static void Main()
        {
            Console.Write("Введите размерность массива n: ");
            int n = int.Parse(Console.ReadLine());
            ArrayGeneration(n);
        }

        static void ArrayGeneration(int n)
        {
            // Создаем двумерный массив размерностью n*n
            int[,] array = new int[n, n];

            // Заполняем массив случайными числами (например, от 1 до 100)
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 101); // Генерация случайного числа от 1 до 100
                }
            }
            

            // Выводим массив на консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
    


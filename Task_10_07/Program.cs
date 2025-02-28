namespace Task_10_07
{
    internal class Program
    {/*Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерный массив
      * (состоящий из символов русского алфавита) и выведите на консоль данный массив с помощью
      * другого метода (который принимает данный массив в качестве параметра)*/

        // Метод для генерации двумерного массива символов русского алфавита
        static char[,] RussianArray(int rows, int cols)
        {
            char[,] array = new char[rows, cols];
            Random random = new Random();

            // Генерация случайных символов русского алфавита
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Генерируем случайный индекс для русского алфавита
                    int index = random.Next(0, 33); // Всего 33 буквы (от А до Я)
                    array[i, j] = (char)('А' + index); // 'А' - это 1040 в int
                }
            }
            return array;
        }

        // Метод для вывода двумерного массива
        static void PrintArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(); 
            }
        }

        static void Main(string[] args)
        {
            int rows = 5; // Количество строк
            int cols = 5; // Количество столбцов

            char[,] russianArray = RussianArray(rows, cols);
            PrintArray(russianArray);
        }
    }
}

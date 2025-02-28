namespace Task_10_08
{
    internal class Program
    {/*Создайте метод, который на вход принимает одномерный массив и число для поиска,
      * верните индекс искомого элемента в массиве. Если элемента нет – верните индекс = -1*/

        static void Main(string[] args)
        {
            // Пример использования
            int[] array = { 1, 2, 3, 4, 5 };
            int numberToFind = 3;

            int index = FindIndex(array, numberToFind);

            if (index != -1)
            {
                Console.WriteLine($"Элемент {numberToFind} найден на индексе {index}");
            }
            else
            {
                Console.WriteLine($"Элемент {numberToFind} не найден в массиве");
            }
        }

        static int FindIndex(int[] array, int numberToFind)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numberToFind)
                {
                    return i; // Возвращаем индекс найденного элемента
                }
            }

            return -1; // Если элемент не найден, возвращаем -1

        }
    }
}


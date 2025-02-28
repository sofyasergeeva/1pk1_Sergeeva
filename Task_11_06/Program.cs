namespace Task_11_06
{
    internal class Program
    { /*Передача массива по значению: Напишите метод, который принимает массив целых чисел и
        изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный
        массив вне метода.*/

        static void Main()
        {
            
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("массив перед изменением:");
            PrintArray(array);

            // Вызываем метод, который изменит элементы массива
            Change(array);

            Console.WriteLine("массив после изменения:");
            PrintArray(array);
        }

        // Метод для увеличения каждого элемента массива на 1
        static void Change(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1; // Увеличиваем элемент на 1
            }
        }

        // Метод для вывода массива в консоль
        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));

        }
    }
}

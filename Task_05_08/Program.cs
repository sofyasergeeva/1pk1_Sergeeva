namespace Task_05_08
{
    internal class Program
    {
        /*Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
        произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
        результирующий массив)
        Вывести результирующий массив */
        static void Main(string[] args)
        {
            // Размеры массивов
            int size = 10;

            // Создаем два массива
            int[,] array1 = new int[10, 10];
            int[,] array2 = new int[10, 10];
            int[,] resultArray = new int[10, 10];

            Random rand = new Random();

            // Заполняем массивы случайными числами от 1 до 9
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array1[i, j] = rand.Next(1, 10); // Генерируем число от 1 до 9
                    array2[i, j] = rand.Next(1, 10);

                    // Вычисляем произведение и сохраняем в результирующий массив
                    resultArray[i, j] = array1[i, j] * array2[i, j];
                }
            }

            // Выводим результирующий массив
            Console.WriteLine("Результирующий массив:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(resultArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

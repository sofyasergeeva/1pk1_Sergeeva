namespace Task_04_06
{
    internal class Program
    {/*Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
       модулю были разными. Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
       двух равных по модулю. В полученном массиве найти наибольшее по модулю число.*/

        static void Main(string[] args)
        {
            Random rnd = new Random();
            // результирующий массив 
            int[] numbers = new int[90];

            // массив использованных чисел
            int[] outnumbers = new int[90];

            // рандомное число
            int random = 0;

            // параметр цикла
            int i = 0;
            while (i < numbers.Length)
            {
                random = rnd.Next(-90, 91);
                if (Array.IndexOf(outnumbers, Math.Abs(random)) != -1 || random == 0)
                    continue;
                outnumbers[i] = Math.Abs(random);
                numbers[i] = random;
                i++;
            }


            // нахождение максимального числа по модулю
            int maxnum = 0;
            foreach (int j in numbers)
                if (Math.Abs(maxnum) < Math.Abs(j))
                    maxnum = j;
            Console.WriteLine($"Число: {maxnum} наибольшее по модулю.");
        }
    }
}

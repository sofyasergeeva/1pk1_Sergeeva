namespace Task_04_07
{
    internal class Program
    {/* В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
        отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
        мальчиков и девочек. При выводе избавиться от отрицательных значений.*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] height = new int[30];

            // количества мальчиков, девочек и их суммарный рост
            int countBoy = 0;
            double summHeightBoy = 0;
            int countGirl = 0;
            double summHeightGirl = 0;
            for (int i = 0; i < height.Length; i++)
            {
                height[i] = rnd.Next(150, 190) * (rnd.Next(2) * 2 - 1); 
                
                if (height[i] < 0)
                {
                    summHeightBoy += Math.Abs(height[i]);
                    countBoy++;
                }
                else
                {
                    summHeightGirl += height[i];
                    countGirl++;
                }
            }
            Console.WriteLine($"Количество девочек в классе: {countGirl}\nКоличесвто мальчиков в классе: {countBoy}");
            Console.WriteLine("Средний рост девочек: {0:g6}\nСредний рост мальчиков: {1:g6}", summHeightGirl / countGirl, summHeightBoy / countBoy);
        }
    }
}

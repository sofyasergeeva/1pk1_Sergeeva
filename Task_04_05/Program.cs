namespace Task_04_05
{
    internal class Program
    {/*В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее
       количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
       отдельно вывести дни без осадков. Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
       осадков, до 300 мм выпавших осадков.*/
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] precs = new int[30];

            // первая декада
            int decad1 = 0;

            // вторая декада
            int decad2 = 0;

            // третья декада
            int decad3 = 0;

            // максимальное количество осадков
            int maxOsad = 0;

            // день максимального количества осадков
            int dayMaxOsad = 0;
            for (int i = 0; i < precs.Length; i++)
            {
                precs[i] = random.Next(0, 301);
                if (i < 10)
                    decad1 += precs[i];
                else if (i >= 20)
                    decad3 += precs[i];
                else
                    decad2 += precs[i];
                if (maxOsad < precs[i])
                {
                    maxOsad = precs[i];
                    dayMaxOsad = i;
                }
                if (precs[i] == 0)
                    Console.WriteLine($"{i + 1} день без осадков");
            }
            Console.WriteLine($"За первую декаду месяцев выпало: {decad1}мм осадков\nЗа вторую декаду месяцев выпало: {decad2}мм осадков" +
                $"\nЗа третью декаду месяцев выпало: {decad3}мм осадков");
            Console.WriteLine($"{dayMaxOsad} числа выпало максимальное количество осадков: {maxOsad}мм");
        }
    }
}
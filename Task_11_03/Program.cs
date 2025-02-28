namespace Task_11_03
{
    internal class Program
    { /*Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
        выходной параметр количество гласных и согласных букв в этой строке*/

        static void Main()
        {
            string input = "Строка для подсчета";
            int glasn, sogl;

            CountLetters(input, out glasn, out sogl);

            Console.WriteLine($"Количество гласных: {glasn}");
            Console.WriteLine($"Количество согласных: {sogl}");
        }

        static void CountLetters(string input, out int glasn, out int sogl)
        {
            glasn = 0;
            sogl = 0;

            foreach (char c in input)
            {
                if (char.IsLetter(c)) // Проверяем, является ли символ буквой
                {
                    char lowerC = char.ToLower(c); // Приводим к нижнему регистру для удобства
                    if ("аеёиоуыэюя".Contains(lowerC)) // Гласные буквы
                    {
                        glasn++;
                    }
                    else if ("бвгджзйклмнопрстфхцчшщ".Contains(lowerC)) // Согласные буквы
                    {
                        sogl++;
                    }
                }
            }

        }
    }
}

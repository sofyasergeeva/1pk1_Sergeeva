namespace Task_21_02
{
    internal class Program
    { /*Дан текст. Написать метод, который возвращает словарь, где ключ — слово, а значение —количество его вхождений в тексте*/
        static void Main(string[] args)
        {
            string text = "Это пример текста. Это текст содержит слова. Слова должны быть подсчитаны.";
            var wordCount = CountWords(text);

            // Выводим результаты
            foreach (var kvp in wordCount)
            {
                Console.WriteLine($"Слово: {kvp.Key}, Количество вхождений: {kvp.Value}");
            }
        }

        static Dictionary<string, int> CountWords(string text)
        {
            // Приводим текст к нижнему регистру и разбиваем его на слова
            string[] words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            // Создаем словарь для хранения слов и их количеств
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }
    }
}

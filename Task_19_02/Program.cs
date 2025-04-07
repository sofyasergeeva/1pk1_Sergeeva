namespace Task_19_02
{
    internal class Program
    {/*Напишите программу, которая запрашивает у пользователя произвольный текст, содержащий
        предложения (есть знаки препинания). программу после анализа выводит текст, разделенный на
        части:
        a)
        По пробелам (отдельные слова построчно)
        b)
        По предложениям (отдельные предложения построчно)
        (используйте метод Split())*/
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя ввод текста
            Console.WriteLine("Введите произвольный текст, содержащий предложения:");
            string inputText = Console.ReadLine();

            // Разделение текста по пробелам
            Console.WriteLine("\nСлова:");
            string[] words = inputText.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Разделение текста по предложениям
            Console.WriteLine("\nПредложения:");
            char[] sentenceDelimiters = { '.', '!', '?' };
            string[] sentences = inputText.Split(sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in sentences)
            {
                // Удаляем возможные пробелы в начале и конце предложения
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
    


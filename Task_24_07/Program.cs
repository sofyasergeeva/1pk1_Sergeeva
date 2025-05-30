namespace Task_24_07
{
    class Program
    {
        // Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки, содержащиеэтослово (регистронезависимо)
        static List<string> FindLinesWithWord(string path, string word)
        {
            List<string> result = new List<string>();
            string line;

            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Add(line);
                    }
                }
            }

            return result;
        }

        static void Main()
        {
            string filePath = "TextFile1.txt"; 
            string searchWord = "молоко";    // Слово для поиска

            if (File.Exists(filePath))
            {
                List<string> matchingLines = FindLinesWithWord(filePath, searchWord);

                Console.WriteLine($"Строки с словом \"{searchWord}\":");
                foreach (string line in matchingLines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }

        }
    }
}

namespace Task_24_06
{
    internal class Program
    { //Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. ИспользуйтеStreamReader.//
        static int CountLines(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main()
        {
            string filePath = "strings.txt";
            if (File.Exists(filePath))
            {
                int lines = CountLines(filePath);
                Console.WriteLine("Количество строк: " + lines);
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }
    }
}

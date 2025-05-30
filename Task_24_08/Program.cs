namespace Task_24_08
{
    class Program
    { //реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенныепользователем
        static void Main()
        {
            string filePath = "example.txt"; 

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            // Ввод данных от пользователя
            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string replaceText = Console.ReadLine();

            // Читаем все строки файла
            string[] lines = File.ReadAllLines(filePath);

            // Меняем текст в каждой строке
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(searchText, replaceText);
            }

            // Перезаписываем файл с обновлённым содержимым
            File.WriteAllLines(filePath, lines);

            Console.WriteLine("Замена завершена.");
        }
    }
}

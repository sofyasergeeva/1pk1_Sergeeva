namespace Task_23_06
{
    internal class Program
    { /*Напишите программу со следующими функциями:
        1. Выведите информации о всех дисках в системе
        2. Выведите содержимое каталога C:\Users (названия папок)
        3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
        a) Создание вложенного каталога “temp”
        b) Вывод информации о текущем каталоге (имя, родитель и тд)
        c) Вывод информации о вложенном каталоге
        4. Переместите каталог “temp” по пути “D:\work\newTemp”
        a) Реализуйте вывод информационного сообщения об успешном (или нет)
        перемещении
        5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
        удалении.*/
        static void Main(string[] args)
        {
            // 1. Выведите информацию о всех дисках в системе
            DisplayDrives();

            // 2. Выведите содержимое каталога C:\Users (названия папок)
            DisplayDirectories(@"C:\Users");

            // 3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
            string workDirectory = @"D:\work";
            CreateDirectory(workDirectory);

            // a) Создание вложенного каталога “temp”
            string tempDirectory = Path.Combine(workDirectory, "temp");
            CreateDirectory(tempDirectory);

            // b) Вывод информации о текущем каталоге (имя, родитель и тд)
            DisplayDirectoryInfo(tempDirectory);

            // c) Вывод информации о вложенном каталоге
            DisplayDirectoryInfo(tempDirectory);

            // 4. Переместите каталог “temp” по пути “D:\work\newTemp”
            string newTempDirectory = Path.Combine(workDirectory, "newTemp");
            MoveDirectory(tempDirectory, newTempDirectory);

            // 5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) удалении.
            DeleteDirectory(newTempDirectory);
        }

        static void DisplayDrives()
        {
            Console.WriteLine("Диски в системе:");
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                    Console.WriteLine($"Диск: {drive.Name}, Тип: {drive.DriveType}, Свободное место: {drive.AvailableFreeSpace / (1024 * 1024)} MB, Общий размер: {drive.TotalSize / (1024 * 1024)} MB");
            }
        }

        static void DisplayDirectories(string path)
        {
            Console.WriteLine($"\nСодержимое каталога '{path}':");
            try
            {
                var directories = Directory.GetDirectories(path);
                foreach (var dir in directories)
                {
                    Console.WriteLine(Path.GetFileName(dir));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении папок: {ex.Message}");
            }
        }

        static void CreateDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"Каталог '{path}' успешно создан.");
                }
                else
                {
                    Console.WriteLine($"Каталог '{path}' уже существует.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании каталога: {ex.Message}");
            }
        }

        static void DisplayDirectoryInfo(string path)
        {
            try
            {
                var directoryInfo = new DirectoryInfo(path);
                Console.WriteLine($"\nИнформация о каталоге '{path}':");
                Console.WriteLine($"Имя: {directoryInfo.Name}");
                Console.WriteLine($"Полный путь: {directoryInfo.FullName}");
                Console.WriteLine($"Родитель: {directoryInfo.Parent?.FullName}");
                Console.WriteLine($"Дата создания: {directoryInfo.CreationTime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении информации о каталоге: {ex.Message}");
            }
        }

        static void MoveDirectory(string sourceDir, string destDir)
        {
            try
            {
                if (Directory.Exists(sourceDir))
                {
                    Directory.Move(sourceDir, destDir);
                    Console.WriteLine($"Каталог перемещен из '{sourceDir}' в '{destDir}'.");
                }
                else
                {
                    Console.WriteLine($"Каталог '{sourceDir}' не существует.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при перемещении каталога: {ex.Message}");
            }
        }

        static void DeleteDirectory(string path)
        {
            try
            {
                Directory.Delete(path, true);
                Console.WriteLine($"Каталог '{path}' успешно удален.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении каталога: {ex.Message}");
            }
        }
    }
}

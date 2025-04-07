namespace Task_19_01
{
    internal class Program
    {/*Напиши код для C#:Напишите программу, в которой пользователь вводит произвольный текст в консоли, после чего
        программа запрашивает подстроку для поиска. Если подстрока найдена - то программа запрашивает
        текст для того чтобы заменить на него эту подстроку (столько раз, сколько раз подстрока встречена
        в тексте)*/
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя произвольный текст
            Console.WriteLine("Введите строку:");
            string originalText = Console.ReadLine();

            // Запрашиваем подстроку для поиска
            Console.WriteLine("Введите подстроку для поиска:");
            string stringToFind = Console.ReadLine();

            // Проверяем, найдена ли подстрока
            if (originalText.Contains(stringToFind))
            {
                // Запрашиваем подстроку для замены
                Console.WriteLine("Введите подстроку для замены:");
                string stringToReplace = Console.ReadLine();

                // Заменяем все вхождения подстроки
                string modifiedText = originalText.Replace(stringToFind, stringToReplace);

                // Выводим результат
                Console.WriteLine("Результат: " + modifiedText);
            }
            else
            {
                Console.WriteLine("Подстрока не найдена в тексте.");
            }
        }
    }
}

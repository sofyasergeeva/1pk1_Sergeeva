namespace Task_19_03
{
    internal class Program
    {/*Напишите консольное приложение, в котором осуществляется построчный пользовательский
        ввод (ввод каждой строки подтверждается нажатием на enter). количество введенных строк
        произвольно, ввод завершается при вводе пустой строки.
        После окончания ввода произведите объединение всех ранеее введенных строк в одну с
        использованием разделителя «-»*/
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            string input;

            Console.WriteLine("Введите строки (для завершения ввода введите пустую строку):");

            while (true)
            {
                Console.Write("Введите строку: ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break; // выход из цикла при вводе пустой строки
                }

                lines.Add(input);
            }

            // Объединение всех введенных строк с использованием разделителя "-"
            string result = string.Join("-", lines);
            Console.WriteLine($"Результат: \"{result}\"");
        }
    }
}

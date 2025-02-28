namespace Task_11_02
{
    internal class Program
    { /*Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
        меняет их местами. Проверьте, изменились ли значения переменных вне метода*/

        // Метод, который меняет местами два числа
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 7;

            Console.WriteLine($"Перед изменением: {num1}, {num2}");

            // Вызов метода Swap с передачей переменных по ссылке
            Swap(ref num1, ref num2);

            Console.WriteLine($"После изменения: {num1}, {num2}");

        }
    }
}

namespace Task_11_05
{
    internal class Program
    { /*Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
        возвращает их сумму и произведение через выходные параметры (out).*/

        static void Main()
        {
            int num1 = 5;
            int num2 = 10;

            // Переменные для хранения выходных параметров
            int sum;
            int product;

            // Вызов метода с использованием ref и out
            Proces(ref num1, ref num2, out sum, out product);

            // Вывод результатов
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }

        static void Proces(ref int a, ref int b, out int sum, out int product)
        {
            a += 1; 
            b += 1; 

            sum = a + b;
            product = a * b;

        }
    }
}

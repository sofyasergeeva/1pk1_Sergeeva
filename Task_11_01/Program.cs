namespace Task_11_01
{
    internal class Program
    { /*Передача по значению: Напишите метод, который принимает два целых числа
       *и меняет их местами. Проверьте, изменились ли значения переменных вне метода*/
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Перед вызовом метода: a = {a}, b = {b}");

            // Вызов метода с передачей параметров по ссылке
            Swap(ref a, ref b);

            Console.WriteLine($"После вызова метода: a = {a}, b = {b}");
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
    }
}

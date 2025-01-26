namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;    // сегоднейшая дата
            Console.WriteLine("Введие год вашего рождения");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введие месяц вашего рождения");
            int mouth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введие день вашего рождения");
            int day = Convert.ToInt32(Console.ReadLine());

            // разница годов
            int age = today.Year - year;

            // если введённый день и месяц позже настоящего времени
            if (today.Month < mouth)
            {
                age--;
            }
            else if (today.Month == mouth)
            {
            age -= today.Day <= day ? 1 : 0;
            }
            if (age >= 18)
            {
                Console.WriteLine("Вы совершеннолетний");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний");
            }
        }
    }
}

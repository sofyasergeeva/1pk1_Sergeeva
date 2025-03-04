namespace Task_13_03
{
    internal class Program
    {
        public static void Main()
        {
            // Пример использования класса Car
            Car myCar = new Car("ABC123", "Toyota", "Красный");
            myCar.ShowInfo();

            myCar.Accelerate(50);
            myCar.Accelerate(160); // Превышение максимальной скорости
            myCar.Brake();
            myCar.ShowInfo();
        }
        public class Car
        {
            // Свойства класса
            public string LicensePlate { get; set; }
            public string Brand { get; set; }
            public string Color { get; set; }
            public double CurrentSpeed { get; private set; }
            private const double MaxSpeed = 200.0; // Максимальная допустимая скорость

            // Конструктор по умолчанию
            public Car()
            {
                LicensePlate = "Unknown";
                Brand = "Unknown";
                Color = "Unknown";
                CurrentSpeed = 0.0;
            }

            // Конструктор с параметрами
            public Car(string licensePlate, string brand, string color)
            {
                LicensePlate = licensePlate;
                Brand = brand;
                Color = color;
                CurrentSpeed = 0.0;
            }

            // Метод для ускорения
            public void Accelerate(double acceleration)
            {
                if (CurrentSpeed + acceleration > MaxSpeed)
                {
                    Console.WriteLine($"Скорость превышает допустимую ({MaxSpeed} км/ч). Остановка автомобиля.");
                    CurrentSpeed = 0.0; // Останавливаем автомобиль
                }
                else
                {
                    CurrentSpeed += acceleration;
                    Console.WriteLine($"Автомобиль {Brand} разгоняется. Текущая скорость: {CurrentSpeed} км/ч.");
                }
            }

            // Метод для торможения
            public void Brake()
            {
                if (CurrentSpeed > 0)
                {
                    CurrentSpeed = 0.0; // Останавливаем автомобиль
                    Console.WriteLine($"Автомобиль {Brand} остановился.");
                }
                else
                {
                    Console.WriteLine($"Автомобиль {Brand} уже стоит на месте.");
                }
            }

            // Метод для вывода информации об автомобиле
            public void ShowInfo()
            {
                Console.WriteLine($"Автомобиль: {Brand}, Номер: {LicensePlate}, Цвет: {Color}, Текущая скорость: {CurrentSpeed} км/ч");
            }
        }

       
    }
}

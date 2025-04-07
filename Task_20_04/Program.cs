using static Task_20_04.VehicleTracker;

namespace Task_20_04
{
    internal class Program
    {/*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
        • Car
        • Bike
        • Bus
        • Truck
        • Motorcycle
        Храните список транспортных средств (можно просто List).
        Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
        Реализуйте поиск по типу и вывод информации*/
        static void Main(string[] args)
        {
            // Список транспортных средств
            List<Vehicle> vehicles = new List<Vehicle>();

            // Добавление транспортных средств
            vehicles.Add(new Vehicle(VehicleType.Car));
            vehicles.Add(new Vehicle(VehicleType.Bike));
            vehicles.Add(new Vehicle(VehicleType.Bus));
            vehicles.Add(new Vehicle(VehicleType.Truck));
            vehicles.Add(new Vehicle(VehicleType.Motorcycle));
            vehicles.Add(new Vehicle(VehicleType.Truck));

            // Подсчёт и вывод информации о грузовиках
            int truckCount = CountVehiclesByType(vehicles, VehicleType.Truck);
            Console.WriteLine($"Количество грузовиков: {truckCount}");

            // Поиск и вывод всех транспортных средств определённого типа
            VehicleType searchType = VehicleType.Truck; // Можно изменить на любой другой тип
            var foundVehicles = FindVehiclesByType(vehicles, searchType);

            Console.WriteLine($"Транспортные средства типа {searchType}:");
            foreach (var vehicle in foundVehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        // Метод для подсчёта транспортных средств определённого типа
        static int CountVehiclesByType(List<Vehicle> vehicles, VehicleType type)
        {
            return vehicles.Count(v => v.Type == type);
        }

        // Метод для поиска транспортных средств определённого типа
        static List<Vehicle> FindVehiclesByType(List<Vehicle> vehicles, VehicleType type)
        {
            return vehicles.Where(v => v.Type == type).ToList();
        }
    }
}

namespace Task_13_02
{
    internal class Program
    { /*создать класс питомца
        свойства:
        кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
        методы:
        вывод информации об объекте
        изменение значения веса животного
        изменение отметки о состоянии здоровья
        конструторы:
        предусмотрите разные варианты инициализации объектов*/

        public class Pet
        {
            // Свойства
            public string Name { get; set; }
            public string AnimalType { get; set; } // Вид животного
            public int Age { get; set; }           // Возраст
            public double Weight { get; set; }     // Вес
            public string HealthStatus { get; set; } // Состояние здоровья (здоров/нездоров)

            // Конструктор с параметрами
            public Pet(string name, string animalType, int age, double weight, string healthStatus)
            {
                Name = name;
                AnimalType = animalType;
                Age = age;
                Weight = weight;
                HealthStatus = healthStatus;
            }

            // Конструктор по умолчанию
            public Pet()
            {
                Name = "Unnamed";
                AnimalType = "Unknown";
                Age = 0;
                Weight = 0.0;
                HealthStatus = "Healthy";
            }

            // Метод для вывода информации об объекте
            public void DisplayInfo()
            {
                Console.WriteLine("Имя: " + Name);
                Console.WriteLine("Вид животного: " + AnimalType);
                Console.WriteLine("Возраст: " + Age + " лет");
                Console.WriteLine("Вес: " + Weight + " кг");
                Console.WriteLine("Состояние здоровья: " + HealthStatus);
            }

            // Метод для изменения веса животного
            public void ChangeWeight(double newWeight)
            {
                Weight = newWeight;
                Console.WriteLine($"Вес питомца {Name} изменен на {Weight} кг.");
            }

            // Метод для изменения отметки о состоянии здоровья
            public void ChangeHealthStatus(string newStatus)
            {
                HealthStatus = newStatus;
                Console.WriteLine($"Состояние здоровья питомца {Name} изменено на {HealthStatus}.");
            }
        }

        // Пример использования класса Pet
        
            static void Main(string[] args)
            {
                // Создание объекта питомца с параметрами
                Pet dog = new Pet("Шарик", "Собака", 5, 20.5, "Здоров");

                // Вывод информации о питомце
                dog.DisplayInfo();

                // Изменение веса
                dog.ChangeWeight(22.0);

                // Изменение состояния здоровья
                dog.ChangeHealthStatus("Нездоров");

                // Вывод обновленной информации о питомце
                dog.DisplayInfo();

                // Создание объекта питомца по умолчанию
                Pet defaultPet = new Pet();
                defaultPet.DisplayInfo();
            }
        }

    }


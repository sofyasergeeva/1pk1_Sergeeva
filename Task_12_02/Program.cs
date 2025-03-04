namespace Task_12_02
{
    internal class Program
    { /*создайте проект с классом Cat и Dog, полностью самостоятельно 
       * продумайте данные для объектов класса и их функционал:
       * Cat Свойства:
        Name: имя кошки
        Age: возраст кошки
        Color: цвет шерсти
        Методы:
        Speak(): выводит на консоль, как говорит кошка
        Play(): выводит на консоль, чем занимается кошка

        Dog Свойства:
        Name: имя собаки
        Age: возраст собаки
        Breed: порода собаки
        Методы:
        Speak(): выводит на консоль, как говорит собака
        Play(): выводит на консоль, чем занимается собака*/

        // Класс Cat
        public class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Color { get; set; }

            public Cat(string name, int age, string color)
            {
                Name = name;
                Age = age;
                Color = color;
            }

            public void Speak()
            {
                Console.WriteLine($"{Name} говорит: Мяу!");
            }

            public void Play()
            {
                Console.WriteLine($"{Name} играет с мячиком.");
            }
        }

        // Класс Dog
        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Breed { get; set; }

            public Dog(string name, int age, string breed)
            {
                Name = name;
                Age = age;
                Breed = breed;
            }

            public void Speak()
            {
                Console.WriteLine($"{Name} говорит: Гав!");
            }

            public void Play()
            {
                Console.WriteLine($"{Name} бегает за мячом.");
            }
        }

        
        
            static void Main(string[] args)
            {
                Cat cat = new Cat("Мурка", 3, "Серый");
                Dog dog = new Dog("Шарик", 5, "Лабрадор");

                cat.Speak();
                cat.Play();

                dog.Speak();
                dog.Play();

                Console.WriteLine($"{cat.Name} - {cat.Age} года, цвет: {cat.Color}");
                Console.WriteLine($"{dog.Name} - {dog.Age} года, порода: {dog.Breed}");
            }

        }
    }


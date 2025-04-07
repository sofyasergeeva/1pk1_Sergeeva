namespace Task_20_06
{
    internal class Program
    {/*Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
    • Red
    • Yellow
    • Green
    Реализуйте автоматическое переключение цветов (каждые 3 секунды).
    При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
    Добавьте возможность ручного переключения (например, по нажатию клавиши).*/
    enum TrafficLightColor
        {
            Red,
            Yellow,
            Green
        }
            static TrafficLightColor currentColor = TrafficLightColor.Red;
            static bool isRunning = true;

            static void Main(string[] args)
            {
                Thread trafficLightThread = new Thread(SwitchTrafficLight);
                trafficLightThread.Start();

                Console.WriteLine("Нажмите любую клавишу для ручного переключения светофора. Нажмите 'q' для выхода.");

                while (isRunning)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Q)
                        {
                            isRunning = false;
                        }
                        else
                        {
                            SwitchColor();
                        }
                    }
                }

                trafficLightThread.Join();
                Console.WriteLine("Светофор остановлен. Нажмите любую клавишу для выхода.");
                Console.ReadKey();
            }

            static void SwitchTrafficLight()
            {
                while (isRunning)
                {
                    Thread.Sleep(3000); // Задержка в 3 секунды
                    SwitchColor();
                }
            }

            static void SwitchColor()
            {
                currentColor = (TrafficLightColor)(((int)currentColor + 1) % 3);
                Console.Clear();
                Console.WriteLine($"Текущий цвет светофора: {currentColor}");
            }
        }
    }



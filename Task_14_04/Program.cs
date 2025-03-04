namespace Task_14_04
{
    internal class Program
    { /*Определите класс User, который будет иметь статическое свойство 
       * CurrentUser, представляющее текущего пользователя, и метод для его установки*/

        // Пример использования
        public static void Main(string[] args)
        {
            // Создаем нового пользователя
            var user1 = new User("Alice", "alice@example.com");

            // Устанавливаем текущего пользователя
            User.SetCurrentUser(user1);

            // Проверяем текущего пользователя
            if (User.CurrentUser != null)
            {
                Console.WriteLine($"Current User: {User.CurrentUser.Name}, Email: {User.CurrentUser.Email}");
            }
            else
            {
                Console.WriteLine("No current user.");
            }
        }

        public class User
        {
            // Статическое свойство для хранения текущего пользователя
            public static User CurrentUser { get; private set; }

            // Поля экземпляра для хранения информации о пользователе
            public string Name { get; set; }
            public string Email { get; set; }

            // Конструктор для инициализации пользователя
            public User(string name, string email)
            {
                Name = name;
                Email = email;
            }

            // Метод для установки текущего пользователя
            public static void SetCurrentUser(User user)
            {
                CurrentUser = user;
            }

            // Метод для сброса текущего пользователя (необязательно)
            public static void ClearCurrentUser()
            {
                CurrentUser = null;
            }
        }

       

        }

    }


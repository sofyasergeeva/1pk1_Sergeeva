namespace Task_20_05
{
    internal class Program
    { /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
        • Guest (только чтение)
        • User (чтение + комментарии)
        • Moderator (удаление контента)
        • Admin (полный доступ)
        Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).На основе уровня доступа выводите сообщение (например,
        "Ошибка: Недостаточно прав!").*/
        static void Main(string[] args)
        {
            User user1 = new User("Иван", AccessLevel.Guest);
            User user2 = new User("Мария", AccessLevel.Moderator);
            User user3 = new User("Сергей", AccessLevel.Admin);

            // Проверка прав доступа для удаления поста
            CheckAccess(user1, "удалить пост");
            CheckAccess(user2, "удалить пост");
            CheckAccess(user3, "удалить пост");
        }

        static void CheckAccess(User user, string action)
        {
            if (user.CanPerformAction(action))
            {
                Console.WriteLine($"{user.Name} может выполнить действие: {action}");
            }
            else
            {
                Console.WriteLine($"Ошибка: {user.Name} - недостаточно прав для выполнения действия: {action}");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    
        public enum AccessLevel
        {
            Guest,      // только чтение
            User,       // чтение + комментарии
            Moderator,  // удаление контента
            Admin       // полный доступ
        }

        // Класс User
        public class User
        {
            public string Name { get; set; }
            public AccessLevel Level { get; set; }

            public User(string name, AccessLevel level)
            {
                Name = name;
                Level = level;
            }

            // Метод для проверки прав доступа
            public bool CanPerformAction(string action)
            {
                switch (action.ToLower())
                {
                    case "удалить пост":
                        return Level == AccessLevel.Moderator || Level == AccessLevel.Admin;
                    case "комментировать":
                        return Level == AccessLevel.User || Level == AccessLevel.Moderator || Level == AccessLevel.Admin;
                    default:
                        return false;
                }
            }
        }
    
}

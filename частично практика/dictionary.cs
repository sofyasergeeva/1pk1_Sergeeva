using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace частично_практика
{
    internal static class Bank
    {
        public static Dictionary<string, List<Info>> users = new();
        /// <summary>
        /// создание пользователя
        /// </summary>
        /// <param name="fullname"></param>
        public static void CreateUser(string fullname)
        {
            users[fullname] = new();
            //Console.WriteLine(
        }
        /// <summary>
        /// создание счета
        /// </summary>
        /// <param name="info">счет</param>
        /// <param name="fullname">ФИО</param>
        public static void Account(Info info, string fullname)
        {
            if (users.ContainsKey(fullname))
            {
                users[fullname].Add(info);
            }
            else
            {
                Console.WriteLine("Создайте пользователя");
            }
        }
        /// <summary>
        /// вывод информации о клиентах
        /// </summary>
        public static void PrintClients()
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.Key);
                foreach (Info info1 in user.Value)
                {
                    info1.PrintInfo();
                }
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace практическая_3
{
    public static class DataStorage 
    {
        private const string FilePath = "bank_data.json";

        public static void SaveData()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(Bank.Clients, options);
            File.WriteAllText(FilePath, json);
            Console.WriteLine("Данные успешно сохранены.");
        }

        public static void LoadData()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Файл сохранения не найден. Будут использованы пустые данные.");
                return;
            }

            string json = File.ReadAllText(FilePath);
            var loadedClients = JsonSerializer.Deserialize<Dictionary<string, List<Account>>>(json);

            if (loadedClients != null)
            {
                Bank.Clients = loadedClients;
                int maxId = Bank.Clients.Values.SelectMany(x => x).Max(a => a.Id);
                Bank._accountIdCounter = maxId + 1;
                Console.WriteLine("Данные успешно загружены.");
            }
        }
    }
}

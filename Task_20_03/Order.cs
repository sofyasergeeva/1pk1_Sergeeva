using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    
        // Перечисление для статусов заказа
        public enum OrderStatus
        {
            New,
            Processing,
            Shipped,
            Delivered,
            Cancelled
        }

        // Класс для представления заказа
        class Order
        {
            public int OrderId { get; private set; }
            public OrderStatus Status { get; private set; }

            public Order(int orderId)
            {
                OrderId = orderId;
                Status = OrderStatus.New; // Изначально статус новый
            }

            // Метод для изменения статуса заказа
            public void ChangeStatus(OrderStatus newStatus)
            {
                // Проверка: можно ли изменить статус
                if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
                {
                    Console.WriteLine($"Невозможно изменить статус заказа #{OrderId}, так как он уже в статусе '{Status}'.");
                    return;
                }

                // Изменение статуса и вывод сообщения
                Status = newStatus;
                Console.WriteLine($"Заказ #{OrderId} переведен в статус: {Status}");
            }
        }
    }


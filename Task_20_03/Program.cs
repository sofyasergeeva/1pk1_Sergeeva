namespace Task_20_03
{
    internal class Program
    {/*Создайте программу для управления статусом заказа в интернет-магазине. Используйте перечислениеOrderStatus со значениями:
        • New (новый)
        • Processing (в обработке)
        • Shipped (отправлен)
        • Delivered (доставлен)
        • Cancelled (отменён)
        Напишите метод, который меняет статус заказа. Если заказ уже доставлен или отменён, запретите изменение статуса. Выводите сообщение при каждом изменении статуса (например,
        "Заказ переведён в статус: Отправлен").*/
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                // Создание заказа
                Order order = new Order(1);

                // Изменение статуса заказа
                order.ChangeStatus(OrderStatus.Processing);
                order.ChangeStatus(OrderStatus.Shipped);
                order.ChangeStatus(OrderStatus.Delivered);

                // Попытка изменить статус после доставки
                order.ChangeStatus(OrderStatus.Cancelled);

                // Создание другого заказа и изменение его статуса
                Order order2 = new Order(2);
                order2.ChangeStatus(OrderStatus.Cancelled);
                order2.ChangeStatus(OrderStatus.Processing);
            }
        }
    }
}

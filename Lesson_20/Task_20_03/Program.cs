using System;

namespace OrderManagementSystem
{
    public enum OrderStatus
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderStatus currentStatus = OrderStatus.New;
            Console.WriteLine($"Текущий статус заказа: {GetStatusName(currentStatus)}");

            ChangeOrderStatus(ref currentStatus, OrderStatus.Processing);
            ChangeOrderStatus(ref currentStatus, OrderStatus.Shipped);
            ChangeOrderStatus(ref currentStatus, OrderStatus.Delivered);

            ChangeOrderStatus(ref currentStatus, OrderStatus.Processing);

            OrderStatus cancelledOrder = OrderStatus.New;
            ChangeOrderStatus(ref cancelledOrder, OrderStatus.Cancelled);
            ChangeOrderStatus(ref cancelledOrder, OrderStatus.Processing);
        }

        static void ChangeOrderStatus(ref OrderStatus currentStatus, OrderStatus newStatus)
        {
            if (currentStatus == OrderStatus.Delivered || currentStatus == OrderStatus.Cancelled)
            {
                Console.WriteLine($"Ошибка: Невозможно изменить статус. Заказ уже {GetStatusName(currentStatus)}.");
                return;
            }

            OrderStatus oldStatus = currentStatus;
            currentStatus = newStatus;
            Console.WriteLine($"Заказ переведён в статус: {GetStatusName(newStatus)}");
        }

        static string GetStatusName(OrderStatus status)
        {
            return status switch
            {
                OrderStatus.New => "Новый",
                OrderStatus.Processing => "В обработке",
                OrderStatus.Shipped => "Отправлен",
                OrderStatus.Delivered => "Доставлен",
                OrderStatus.Cancelled => "Отменён",
                _ => "Неизвестный статус"
            };
        }
    }
}
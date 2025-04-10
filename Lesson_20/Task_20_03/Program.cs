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
            Console.WriteLine($"������� ������ ������: {GetStatusName(currentStatus)}");

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
                Console.WriteLine($"������: ���������� �������� ������. ����� ��� {GetStatusName(currentStatus)}.");
                return;
            }

            OrderStatus oldStatus = currentStatus;
            currentStatus = newStatus;
            Console.WriteLine($"����� �������� � ������: {GetStatusName(newStatus)}");
        }

        static string GetStatusName(OrderStatus status)
        {
            return status switch
            {
                OrderStatus.New => "�����",
                OrderStatus.Processing => "� ���������",
                OrderStatus.Shipped => "���������",
                OrderStatus.Delivered => "���������",
                OrderStatus.Cancelled => "������",
                _ => "����������� ������"
            };
        }
    }
}
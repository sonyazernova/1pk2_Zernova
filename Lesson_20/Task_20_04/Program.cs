using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleManagementSystem
{
    public enum VehicleType
    {
        Car,
        Bike,
        Bus,
        Truck,
        Motorcycle
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<VehicleType> vehicles = new List<VehicleType>
            {
                VehicleType.Car,
                VehicleType.Bike,
                VehicleType.Car,
                VehicleType.Truck,
                VehicleType.Bus,
                VehicleType.Motorcycle,
                VehicleType.Car,
                VehicleType.Truck,
                VehicleType.Bike
            };

            Console.WriteLine("��� ������������ ��������:");
            PrintVehicles(vehicles);

            Console.WriteLine("\n���������� ������������ ������� �� �����:");
            foreach (VehicleType type in Enum.GetValues(typeof(VehicleType)))
            {
                int count = CountVehiclesByType(vehicles, type);
                Console.WriteLine($"{type}: {count}");
            }

            Console.WriteLine("\n����� ���������� (Truck):");
            var trucks = FindVehiclesByType(vehicles, VehicleType.Truck);
            PrintVehicles(trucks);
        }

        static int CountVehiclesByType(List<VehicleType> vehicles, VehicleType type)
        {
            return vehicles.Count(v => v == type);
        }

        static List<VehicleType> FindVehiclesByType(List<VehicleType> vehicles, VehicleType type)
        {
            return vehicles.Where(v => v == type).ToList();
        }

        static void PrintVehicles(List<VehicleType> vehicles)
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("������������ �������� �� �������.");
                return;
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
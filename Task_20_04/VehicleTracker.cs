using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    internal class VehicleTracker
    {
        // Перечисление типов транспортных средств
        public enum VehicleType
        {
            Car,
            Bike,
            Bus,
            Truck,
            Motorcycle
        }

        // Класс для представления транспортного средства
        public class Vehicle
        {
            public VehicleType Type { get; set; }

            public Vehicle(VehicleType type)
            {
                Type = type;
            }

            public override string ToString()
            {
                return Type.ToString();
            }
        }
    }
}
